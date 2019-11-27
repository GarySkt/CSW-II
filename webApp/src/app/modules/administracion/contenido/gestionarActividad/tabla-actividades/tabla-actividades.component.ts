import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { datosActividadTabla } from '../interfaces/datosActividadTabla.interface';
import { ObtenerListaActividadesService } from '../servicios/obtener-lista-actividades.service';
import { DataSource } from '@angular/cdk/table';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tabla-actividades',
  templateUrl: './tabla-actividades.component.html',
  styleUrls: ['./tabla-actividades.component.scss']
})
export class TablaActividadesComponent implements OnInit {
  displayedColumns: string[] = ['actividad', 'alumno', 'asesor','titulo', 'descripcion','estado','acciones'];  
  dataSource = new DatosTablaActividad(this.obtenerListaActividades);

  actividades: datosActividadTabla[] = new Array<datosActividadTabla>();  
  
  constructor( private obtenerListaActividades: ObtenerListaActividadesService,
    private changeDetectorRefs: ChangeDetectorRef) { } 

  ngOnInit() {      
  }
}

export class DatosTablaActividad extends DataSource<any>{
  constructor(private obtenerListaActividades: ObtenerListaActividadesService) { 
    super();
  }connect():Observable<datosActividadTabla[]>{
    return this.obtenerListaActividades.obtenerDatosTablaActividades(); 
  }
  disconnect(){}
}


