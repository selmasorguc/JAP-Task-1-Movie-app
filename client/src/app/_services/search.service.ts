import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  baseUrl: string = "https://localhost:5001/";

  constructor(private http: HttpClient) { }

  
}
