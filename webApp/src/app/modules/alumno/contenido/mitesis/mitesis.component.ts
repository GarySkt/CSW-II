import { Component, OnInit } from '@angular/core';
import { ActividadAlumno } from './interfaces/actividadAlumno.interface';
import { SharedserviceService } from 'src/app/sharedservice.service';
import { ObtenerActividadesDocenteService } from 'src/app/modules/docente/contenido/actividades/servicios/obtener-actividades-docente.service';

@Component({
  selector: 'app-mitesis',
  templateUrl: './mitesis.component.html',
  styleUrls: ['./mitesis.component.scss']
})
export class MitesisComponent implements OnInit {

  actividadesAlumno : ActividadAlumno[] = new Array<ActividadAlumno>();

  constructor( public shared: SharedserviceService, private obtenerActividadDocente: ObtenerActividadesDocenteService) { }
  entidadId: number;
  ngOnInit() {
    this.entidadId= this.shared.entidadId;
    
    this.obtenerActividadDocente.obtenerActividadesDocente(this.entidadId).subscribe(
      activiadadesAlumno=>{
        this.actividadesAlumno = activiadadesAlumno;
      }
    )
  }

}
