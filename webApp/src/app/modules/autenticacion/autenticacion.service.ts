import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Autenticacion } from './autenticacion.interface';
import { AutenticacionRespuesta } from './autenticacionRespuesta.interface';

@Injectable({
    providedIn: 'root'
})
export class AutenticacionService {

  constructor(private http: HttpClient) { }

  urlAPI ='https://localhost:5001/api/login';
  
  autenticarUsuario( usuario: string,  contrasena:string  ):Observable<AutenticacionRespuesta>{
    
    let autenticacion: Autenticacion = new Autenticacion();    
    autenticacion.usuario  = usuario;
    autenticacion.contrasena = contrasena;
    let body: any = JSON.stringify(autenticacion);
    let headersA: HttpHeaders = new HttpHeaders({
      'Content-Type':'application/json'
    });
    return this.http.post<AutenticacionRespuesta>(this.urlAPI, body, { headers: headersA});
  }
}
