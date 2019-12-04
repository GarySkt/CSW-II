import { Component, OnInit } from '@angular/core';
import { SharedserviceService } from '../../../../sharedservice.service';
import { ActividadDocente } from './interfaces/actividadDocente.interface';
import { ObtenerActividadesDocenteService } from './servicios/obtener-actividades-docente.service';

@Component({
  selector: 'app-actividades',
  templateUrl: './actividades.component.html',
  styleUrls: ['./actividades.component.scss']
})
export class ActividadesComponent implements OnInit {

  actividadesDocente: ActividadDocente[] = new Array<ActividadDocente>();

  constructor(  public shared: SharedserviceService, private obtenerActividadDocente: ObtenerActividadesDocenteService) { 
  }
entidadId: number;
  ngOnInit() {
    this.entidadId= this.shared.entidadId;
    
    this.obtenerActividadDocente.obtenerActividadesDocente(this.entidadId).subscribe(
      activiadadesDocente=>{
        this.actividadesDocente = activiadadesDocente;
      }
    )
  }

  // obtenerActivdidadesDocente(entidadId){
  //   this.obtenerActividadDocente.obtenerActividadesDocente(entidadId).subscribe(
  //     activiadadesDocente=>{
  //       this.actividadesDocente = activiadadesDocente;
  //     }
  //   )
  // }

  

}
