import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Docente } from '../interfaces/docente.interface';

@Injectable({
    providedIn: 'root'
})
export class DocenteLineaInvestigacionService {

  constructor(private http: HttpClient) { }

  urlAPI = "http://localhost:5000/api/docente/GetLineaInvestigacionDocente/1";

  getDocentes():Observable<Docente[]>{
    return this.http.get<Docente[]>(this.urlAPI)
  }
}
