import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Actividad } from 'src/app/modules/administracion/contenido/gestionarActividad/interfaces/actividad';
import { ActividadRespuesta } from 'src/app/modules/administracion/contenido/gestionarActividad/interfaces/actividadRespuesta';

@Injectable({
  providedIn: 'root'
})
export class GuardarActividadService {

  constructor(private http: HttpClient) { }

  urlAPI ='https://localhost:5001/api/Actividad';

  agregarActividad(
      AlumnoId: number,
      Titulo: string,
      Resumen: string,
      Descripcion: string,
      AsesorId: number,
      ActividadTipoId: number,
  ):Observable<ActividadRespuesta>{
        let actividad: Actividad = new Actividad();
        actividad.AlumnoId = AlumnoId;
        actividad.Titulo = Titulo;
        actividad.Resumen = Resumen;
        actividad.Descripcion = Descripcion;
        actividad.AsesorId=AsesorId;
        actividad.ActividadTipoId = ActividadTipoId;
        let body: any = JSON.stringify(actividad);
        let headers: HttpHeaders = new HttpHeaders({
          'Content-Type':'application/json'
        });
        return this.http.post<ActividadRespuesta>(this.urlAPI,body,{headers: headers});
  }

}
