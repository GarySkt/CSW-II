import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Medallas } from './medallas.interface';

@Injectable({
    providedIn: 'root'
})
export class MislogrosService {

  constructor(private http: HttpClient) { }

  urlAPI ='https://localhost:5001/api/medalla';

  obtenerMedallas():Observable<Medallas[]>{
    return this.http.get<Medallas[]>(this.urlAPI)
  }
}
