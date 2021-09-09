import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Movie } from '../_models/movie';
import { MoviesService } from '../_services/movies.service';

@Component({
  selector: 'app-media',
  templateUrl: './media.component.html',
  styleUrls: ['./media.component.css']
})
export class MediaComponent implements OnInit {
  movies: Movie[] = [];
  tvshows: Movie[] = [];
  searchQuery: string = '';
  search: any = {};
  pageNumber = 1;
  itemsPerPage = 6;
  loadButton: boolean = true;

  constructor(private moviesService: MoviesService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.moviesService.getPagedMovies(this.pageNumber, this.itemsPerPage).subscribe((response) => {
      this.movies = response;
      this.pageNumber++;
    }, error => { console.log(error); });
  }

  loadMoreMovies() {
    this.moviesService.getPagedMovies(this.pageNumber, this.itemsPerPage).subscribe((response) => {
      
      if (response.length === 0) 
      {
        this.loadButton = false;
        this.toastr.warning(
          'We dont have any more movies', '');
      }

      this.movies = this.movies.concat(response);
      this.pageNumber++;
    }, error => { console.log(error); });
  }

}
