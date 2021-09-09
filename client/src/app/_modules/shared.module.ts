import { RatingModule } from 'ngx-bootstrap/rating';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


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
    Ng2SearchPipeModule,
    TabsModule.forRoot(),
    BrowserAnimationsModule
  ],
  exports: [
    CommonModule,
    TabsModule,
    RatingModule,
    FormsModule,
    RatingModule,
    NgbModule,
    ToastrModule,
    Ng2SearchPipeModule,
    TabsModule,
    BrowserAnimationsModule 
  ]
})
export class SharedModule { }
