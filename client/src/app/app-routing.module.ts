import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoviesComponent } from './movies/movies.component';
import { TvShowsComponent } from './tv-shows/tv-shows.component';

const routes: Routes = [
  {path:'' , component: MoviesComponent},
  {path:'movies' , component: MoviesComponent},
  {path:'tvshows' , component: TvShowsComponent},
  {path:'**' , component: MoviesComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
