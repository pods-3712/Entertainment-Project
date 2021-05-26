import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EntquestionandanswersService {
  public API = 'https://localhost:44322';

  constructor(private http:HttpClient) { }

  getPages(): Observable<any[]>
  {
    return this.http.get<any>(this.API +'/getQuestAns');
  }
}
