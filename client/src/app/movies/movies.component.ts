import { Component, OnInit } from '@angular/core';
import { Movie } from '../_models/movie';
import { MoviesService } from '../_services/movies.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  movies: Movie[] = [];

  constructor(private moviesService: MoviesService) { }

  ngOnInit(): void {
    this.moviesService.getMovies().subscribe((response) => {
      this.movies = response;
      console.log(this.movies[1]);
    }, error => { console.log(error); });
  }

}
