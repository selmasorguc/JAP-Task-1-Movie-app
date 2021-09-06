import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Movie } from '../_models/movie';

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
}
