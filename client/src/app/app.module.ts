import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { HttpClientModule } from '@angular/common/http';
import { MoviesComponent } from './movies/movies.component';
import { MovieCardComponent } from './movie-card/movie-card.component';
import { RatingModule } from 'ngx-bootstrap/rating';
import { TvShowsComponent } from './tv-shows/tv-shows.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    MoviesComponent,
    MovieCardComponent,
    TvShowsComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    TabsModule.forRoot(),
    HttpClientModule,
    RatingModule.forRoot(),
    FormsModule,
    RatingModule.forRoot(),
    NgbModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
