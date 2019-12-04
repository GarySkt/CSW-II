import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Entregable } from '../interfaces/entregableActividad';
import { EntregableClass } from '../interfaces/entregableRespuesta';



@Injectable({
  providedIn: 'root'
})
export class AgregarEntregableService {

  constructor(private http: HttpClient) { }

  url = "https://localhost:5001/api/entregable";

  agregarEntregable(
    actividadId: number,
    descripcion: string,
    comentario:string
  ):Observable<Entregable>{
    let entregable: EntregableClass = new EntregableClass;
    entregable.actividadId = actividadId;
    entregable.descripcion = descripcion;
    entregable.comentario = comentario;
    let body: any = JSON.stringify(entregable);
    let headers: HttpHeaders = new HttpHeaders({
      'Content-Type':'application/json'
    });
    return this.http.post<Entregable>(this.url,body,{headers:headers});
  }

}
