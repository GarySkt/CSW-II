import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { datosActividadTabla } from '../interfaces/datosActividadTabla.interface';

@Injectable({
  providedIn: 'root'
})
export class ObtenerListaActividadesService {

  constructor(private http: HttpClient) { }

  url = "https://localhost:5001/api/Actividad/getactividaddetalle";

  obtenerDatosTablaActividades(): Observable<datosActividadTabla[]>{
    return this.http.get<datosActividadTabla[]>(this.url);
    }
}

