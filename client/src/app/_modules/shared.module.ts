import { RatingModule } from 'ngx-bootstrap/rating';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { Ng2SearchPipeModule } from 'ng2-search-filter';


import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    TabsModule.forRoot(),
    RatingModule.forRoot(),
    FormsModule,
    RatingModule.forRoot(),
    NgbModule,
    ToastrModule.forRoot(),
    Ng2SearchPipeModule
  ],
  exports: [
    CommonModule,
    TabsModule,
    RatingModule,
    FormsModule,
    RatingModule,
    NgbModule,
    ToastrModule,
    Ng2SearchPipeModule
  ]
})
export class SharedModule { }
