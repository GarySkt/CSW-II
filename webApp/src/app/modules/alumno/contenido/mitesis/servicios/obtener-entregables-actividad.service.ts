import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Entregable } from '../interfaces/entregableActividad';

@Injectable({
  providedIn: 'root'
})
export class ObtenerEntregablesActividadService {

  constructor(private http: HttpClient) { }

  url = "https://localhost:5001/api/entregable/GetEntregableDetalle/";

  obtenerEntregablesActividad(actividadId):Observable<Entregable[]>{
    return this.http.get<Entregable[]>(this.url+actividadId);
  }
}
