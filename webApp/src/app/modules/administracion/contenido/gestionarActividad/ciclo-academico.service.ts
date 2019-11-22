import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CicloAcademico } from './cicloAcademico.interface';

@Injectable({
  providedIn: 'root'
})
export class CicloAcademicoService {

  constructor(private http: HttpClient) { }
  urlAPI="https://localhost:5001/api/ciclo"

  obtenerCiclos():Observable<CicloAcademico[]>{
    return this.http.get<CicloAcademico[]>(this.urlAPI)
  }
}
