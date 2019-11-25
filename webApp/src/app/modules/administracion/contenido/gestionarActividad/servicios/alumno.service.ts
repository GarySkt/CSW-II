import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable} from 'rxjs';
import { Alumno } from 'src/app/modules/administracion/contenido/gestionarActividad/interfaces/alumno.interface';


@Injectable({
  providedIn: 'root'
})
export class AlumnoService {

  constructor(private http: HttpClient) { }

  url = "http://localhost:5000/api/alumno/getalumnoescuela/";

  obtenerAlumnosEscuela(esculaId):Observable<Alumno[]>{
    return this.http.get<Alumno[]>(this.url+esculaId);
  }
}
