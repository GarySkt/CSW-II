import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { datosActividadTabla } from '../interfaces/datosActividadTabla.interface';
import { ObtenerListaActividadesService } from '../servicios/obtener-lista-actividades.service';
import { DataSource } from '@angular/cdk/table';
import { Observable } from 'rxjs';
import { EliminarActividadService } from '../servicios/eliminar-actividad.service';
import { Actividad } from '../interfaces/actividad.interface';
import { MatDialog } from '@angular/material';
import { AgregarActividadComponent } from '../agregar-actividad/agregar-actividad.component';

@Component({
  selector: 'app-tabla-actividades',
  templateUrl: './tabla-actividades.component.html',
  styleUrls: ['./tabla-actividades.component.scss']
})
export class TablaActividadesComponent implements OnInit {
  displayedColumns: string[] = ['actividad', 'alumno', 'asesor','titulo', 'descripcion','estado','acciones'];  
  dataSource = new DatosTablaActividad(this.obtenerListaActividades);

  actividad: Actividad[] = new Array<Actividad>();

  actividades: datosActividadTabla[] = new Array<datosActividadTabla>();  
  actividadId: number;
  
  constructor( 
    private obtenerListaActividades: ObtenerListaActividadesService,    
    private eliminarActividades: EliminarActividadService,
    public dialog: MatDialog
    ) { }

  ngOnInit() {      
    let dialogRef = this.dialog.open(AgregarActividadComponent);

    dialogRef.afterClosed().subscribe(respuestaActividad=>{
      this.actividades.push(respuestaActividad);
    })
  }
  eliminaractividad(actividadId){
    this.eliminarActividades.eliminaractividad(actividadId).subscribe(
      actividadeliminada=>{
          this.actividad = actividadeliminada;
          alert('Actividad eliminada.');
      })    
  }
  editarActividad(actividadId){
    alert('Editar' + actividadId);
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