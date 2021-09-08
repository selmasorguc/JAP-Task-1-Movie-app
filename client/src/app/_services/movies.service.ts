import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Movie } from '../_models/movie';
import { Rating } from '../_models/rating';


@Injectable({
  providedIn: 'root'
})
export class MoviesService {
  movies: any;
  baseUrl: string = "https://localhost:5001/";

  constructor(private http: HttpClient) { }

  getMovies() {
    return this.http.get<Movie[]>(this.baseUrl + "movies");
  }

  getTVShows() {
    return this.http.get<Movie[]>(this.baseUrl + "tvshows");
  }

  addRating(rating: Rating) {
    return this.http.post<number>(this.baseUrl + "ratings/add", rating);
  }

  searchMovies(query: string) {
    return this.http.get<Movie[]>(this.baseUrl + "search/movies");
  }
}
