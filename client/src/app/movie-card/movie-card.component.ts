import { Component, Input, OnInit } from '@angular/core';
import { Movie } from '../_models/movie';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.css']
})
export class MovieCardComponent implements OnInit {
  @Input() movie!: Movie;
  rate = 0;
  max = 5; 

  constructor() { }

 

  ngOnInit(): void {
  }

}
