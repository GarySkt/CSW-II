import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Escuela } from './escuela.interface';

@Injectable({
  providedIn: 'root'
})
export class EscuelaService {

  constructor(private http: HttpClient) { }
  url="https://localhost:5001/api/escuela";

  obtenerEscuelas():Observable<Escuela[]>{
    return this.http.get<Escuela[]>(this.url)
  }
}
