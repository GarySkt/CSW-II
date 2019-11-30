import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Actividad } from '../interfaces/actividad.interface';

@Injectable({
  providedIn: 'root'
})
export class EliminarActividadService {

  constructor(private http: HttpClient) { }

  url: "https://localhost:5001/api/Actividad/";

  eliminarActividad(actividadId):Observable<Actividad[]>{
    return this.http.delete<Actividad[]>(this.url+actividadId);

  }

}
