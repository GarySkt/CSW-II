import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActividadAlumno } from '../interfaces/actividadAlumno.interface';

@Injectable({
  providedIn: 'root'
})
export class ObtenerActividadesAlumnoService {

  constructor(private http:HttpClient) { }

  url = "https://localhost:5001/api/Actividad/getactividaddetalle/";

  obtenerActividadesDocente(entidadId): Observable<ActividadAlumno[]>{
    return this.http.get<ActividadAlumno[]>(this.url+entidadId);
  }
}
