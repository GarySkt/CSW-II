import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Docente } from './docente.interface';

@Injectable({
    providedIn: 'root'
})
export class EspecialidadesService {

  constructor(private http: HttpClient) { }

  //urlAPI ='https://localhost:5001/api/docente';
  url="http://localhost:5000/api/AreaInvestigacion";

  getDocentes():Observable<Docente[]>{
    return this.http.get<Docente[]>(this.url)
  }
}
