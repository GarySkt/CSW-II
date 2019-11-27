import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActividadDocente } from '../interfaces/actividadDocente.interface';

@Injectable({
  providedIn: 'root'
})
export class ObtenerActividadesDocenteService {

  constructor(private http:HttpClient) { }

  url = "https://localhost:5001/api/Actividad/getactividaddetalle/";

  obtenerActividadesDocente(entidadId): Observable<ActividadDocente[]>{
    return this.http.get<ActividadDocente[]>(this.url+entidadId);
  }
}
