import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SharedserviceService {

  nombreEntidad:string;
  apellidoEntidad: string;
  entidadId: number;

  
  constructor() {  }
  
}
