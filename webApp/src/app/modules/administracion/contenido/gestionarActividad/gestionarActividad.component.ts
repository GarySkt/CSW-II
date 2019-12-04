import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material'
import { AgregarActividadComponent } from './agregar-actividad/agregar-actividad.component';
import { ObtenerListaActividadesService } from './servicios/obtener-lista-actividades.service';
import { EliminarActividadService } from './servicios/eliminar-actividad.service';
import { TablaActividadesComponent } from './tabla-actividades/tabla-actividades.component';
import { Actividad } from './interfaces/actividad.interface';

@Component({
  selector: 'app-gestionarActividad',
  templateUrl: './gestionarActividad.component.html',
  styleUrls: ['./gestionarActividad.component.scss']
})
export class GestionarActividadComponent implements OnInit {
  
  actividades: any[];
  @ViewChild('tablaactividades', {static: false}) tablaActividadesComponent: TablaActividadesComponent;


  constructor(    
    public dialog: MatDialog,
    private obtenerListaActividades: ObtenerListaActividadesService,
    private eliminarActividades: EliminarActividadService, 
    ) { }
  ngOnInit() { 
    this.obtenerDatosTablaActividades();
  }  
  agregarActividad(){
    let dialogRef = this.dialog.open(AgregarActividadComponent);   

    dialogRef.afterClosed().subscribe(respuesta => {
      this.actividades.push(this.mapearActividad(respuesta))
      this.tablaActividadesComponent.ActualizarActividaadesTabla(this.actividades);
    })
  }

  mapearActividad(actividadFea: any): any{

    let actividadBonita: any = {
      actividadId: actividadFea.actividadId,
      finalizada: actividadFea.finalizada,
      alumnoId: actividadFea.alumnoId,
      actividadTitulo: actividadFea.titulo,
      actividadResumen: actividadFea.resumen,
      actividadDescripcion: actividadFea.descripcion,
      asesesorId: actividadFea.asesorId,
      actividadTipoId: actividadFea.ActividadTipoId,
      actividadNombreTipo: actividadFea.Nombre,
      docenteNombre: actividadFea.asesor.asesorNavigation.Docentee.Nombre,
      docenteApellido: actividadFea.docente.Apellido,
    }

    return actividadBonita

    //{,"alumno":{"alumnoId":1,"creditoAprobado":190,"alumnoNavigation":{"entidadId":1,"rolId":1,"escuelaId":1,"estaActivo":1,"persona":{"entidadId":1,"nombre":"Aldo","apellido":"Lopez","fechaNacimiento":"1992-09-28T00:00:00","dni":"47714976"},"entidadCiclo":[]},"actividad":[]},"asesor":{"asesorId":3,"disponibilidad":1,"asesorNavigation":{"docenteId":3,"titulo":"Doctor","docenteNavigation":{"entidadId":3,"rolId":3,"escuelaId":1,"estaActivo":1,"persona":{"entidadId":3,"nombre":"Enrique","apellido":"Lanchipa Valencia","fechaNacimiento":"2222-02-02T00:00:00","dni":"2222222 "},"entidadCiclo":[]},"lineaInvestigacionDocente":[]},"actividad":[]},"entregable":[]}
//{"asesorId":6,"actividadTipoId":2,"entregable":[]}
    // ActividadId = act.ActividadId,
    //                                     Finalizada = act.Finalizada,
    //                                     AlumnoId = act.AlumnoId,
    //                                     CreditoAprobado = alu.CreditoAprobado,
    //                                     AlumnoEntidadID = enta.EntidadId,
    //                                     AlumnoEntidadActivo = enta.EstaActivo,
    //                                     AlumnoNombre = pera.Nombre,
    //                                     AlumnoApellido = pera.Apellido,
    //                                     ActividadTitulo = act.Titulo,
    //                                     ActividadResumen = act.Resumen,
    //                                     ActividadDescripcion = act.Descripcion,
    //                                     AsesorId = ase.AsesorId,
    //                                     DocenteID = doc.DocenteId,
    //                                     DocenteTitulo = doc.Titulo,
    //                                     DocenteEntidadID = ent.EntidadId,
    //                                     DocenteEntidadActivo = ent.EstaActivo,
    //                                     DocenteNombre = per.Nombre,
    //                                     DocenteApellido = per.Apellido,
    //                                     ActividadTipoId = act.ActividadTipoId,
    //                                     ActividadNombreTipo = actt.Nombre
  }
 

  obtenerDatosTablaActividades(){
    this.obtenerListaActividades.obtenerDatosTablaActividades().subscribe(
      actividades => {
        this.actividades = actividades;
        this.tablaActividadesComponent.ActualizarActividaadesTabla(actividades);

      }
    )
  }

  eliminaractividad(actividadId){
    this.eliminarActividades.eliminaractividad(actividadId).subscribe(
      actividadeliminada=>{
          //this.actividad = actividadeliminada;
          alert('Actividad eliminada.');
      })    
  }
  editarActividad(actividadId){
    alert('Editar' + actividadId);
  }
  
}