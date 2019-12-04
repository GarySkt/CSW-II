import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AreaInvestigacion } from '../interfaces/AreaInvestigacion.interface';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ObtenerAreasInvestigacionService {

  constructor(private  http: HttpClient) { }

  url="http://localhost:5000/api/AreaInvestigacion";

  obtenerAreasInvestigacion():Observable<AreaInvestigacion[]>{
    return this.http.get<AreaInvestigacion[]>(this.url);
  }
}
