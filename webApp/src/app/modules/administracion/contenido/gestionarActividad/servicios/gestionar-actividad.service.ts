import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Actividad} from 'src/app/modules/administracion/contenido/gestionarActividad/interfaces/actividad.interface';

@Injectable({
  providedIn: 'root'
})
export class GestionarActividadService {

  constructor(private http: HttpClient) { }

  urlAPI = "https://localhost:5001/api/actividadtipo";
  obtenerTiposActividad():Observable<Actividad[]>{
    return this.http.get<Actividad[]>(this.urlAPI)
  }
}
