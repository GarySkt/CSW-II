import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LineaInvestigacion } from '../interfaces/LineaInvestigacion.interface';

@Injectable({
  providedIn: 'root'
})
export class ObtenerLineaInvestigacionService {

  constructor(private http: HttpClient) { }

  url="http://localhost:5000/api/LineaInvestigacion/"

  obtenerLineasInvestigacion():Observable<LineaInvestigacion[]>{
    return this.http.get<LineaInvestigacion[]>(this.url);

  }
}
