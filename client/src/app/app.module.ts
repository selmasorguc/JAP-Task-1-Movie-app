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
import { TvshowsComponent } from './tvshows/tvshows.component';
@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    MoviesComponent,
    MovieCardComponent,
    TvshowsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    TabsModule.forRoot(),
    HttpClientModule,
    RatingModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
