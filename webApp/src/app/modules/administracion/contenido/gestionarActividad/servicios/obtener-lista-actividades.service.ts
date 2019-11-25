import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Actividad } from '../interfaces/actividad';

@Injectable({
  providedIn: 'root'
})
export class ObtenerListaActividadesService {

  constructor(private http: HttpClient) { }

  url = "https://localhost:5001/api/Actividad";

  obtenerDatosTablaActividades(): Observable<Actividad[]>{
    return this.http.get<Actividad[]>(this.url);
    }
}

