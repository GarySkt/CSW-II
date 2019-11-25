import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Asesor } from 'src/app/modules/administracion/contenido/gestionarActividad/interfaces/asesor.interface';

@Injectable({
  providedIn: 'root'
})
export class AsesorService {

  constructor(private http: HttpClient) { }
  
  url = "http://localhost:5000/api/asesor/getasesorescuela/";

  obtenerAsesoresPorEscuela(escuelaId): Observable<Asesor[]>{
    return this.http.get<Asesor[]>(this.url+escuelaId);
  }
}
