import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Docente } from './docente.interface';

@Injectable({
    providedIn: 'root'
})
export class EspecialidadesService {

  constructor(private http: HttpClient) { }

  urlAPI ='https://localhost:5001/api/docente';

  getDocentes():Observable<Docente[]>{
    return this.http.get<Docente[]>(this.urlAPI)
  }
}
