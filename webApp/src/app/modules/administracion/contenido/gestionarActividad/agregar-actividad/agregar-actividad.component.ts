import { Component, OnInit, Inject } from '@angular/core';
import { GuardarActividadService } from '../servicios/guardar-actividad.service';
import { Actividad } from '../interfaces/actividad.interface';
import { Escuela } from '../interfaces/escuela.interface';
import { CicloAcademico } from '../interfaces/cicloAcademico.interface';
import { Asesor } from '../interfaces/asesor.interface';
import { Alumno } from '../interfaces/alumno.interface';
import { GestionarActividadService } from '../servicios/gestionar-actividad.service';
import { EscuelaService } from '../servicios/escuela.service';
import { CicloAcademicoService } from '../servicios/ciclo-academico.service';
import { AsesorService } from '../servicios/asesor.service';
import { AlumnoService } from '../servicios/alumno.service';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-agregar-actividad',
  templateUrl: './agregar-actividad.component.html',
  styleUrls: ['./agregar-actividad.component.scss']
})
export class AgregarActividadComponent implements OnInit {
  actividad: Actividad[] = new Array<Actividad>();
  escuela: Escuela[]=new Array<Escuela>();
  cicloacademico: CicloAcademico[]=new Array<CicloAcademico>();
  asesor: Asesor[] = new Array<Asesor>();
  alumno: Alumno[] = new Array<Alumno>();
  constructor(
    private gestionarActividadService: GestionarActividadService,
    private escuelas: EscuelaService,
    private cicloAcademico: CicloAcademicoService,
    private asesorEscuela: AsesorService,
    private alumnoEscuela: AlumnoService,
    private actividades: GuardarActividadService,    
    public dialogRef: MatDialogRef<AgregarActividadComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }
  AlumnoId: number;
  Titulo: string;
  Resumen: string;
  Descripcion: string;
  AsesorId: number;
  ActividadTipoId: number;
  escuelaId: number;
  nombre: undefined;

  ngOnInit() {
    this.gestionarActividadService.obtenerTiposActividad().subscribe(
      actividadesAPI =>{
        this.actividad = actividadesAPI;
      }
    )

    this.escuelas.obtenerEscuelas().subscribe(
      escuelasAPI=>{
        this.escuela = escuelasAPI;
      }
    )

    this.cicloAcademico.obtenerCiclos().subscribe(
      ciclosacademicosAPI=>{
        this.cicloacademico = ciclosacademicosAPI;
      }
    )
  }

  obtenerAsesores(escuelaid){
    this.asesorEscuela.obtenerAsesoresPorEscuela(escuelaid).subscribe(
      asesorEscuelaAPI=>{
        this.asesor = asesorEscuelaAPI;
      }
    )
    this.alumnoEscuela.obtenerAlumnosEscuela(escuelaid).subscribe(
      alumnoEscuelaAPI=>{
        this.alumno = alumnoEscuelaAPI;
      }
    )
  }

  guardarActividad(){
    this.actividades.agregarActividad(
      this.AlumnoId,
      this.Titulo,
      this.Resumen,
      this.Descripcion,
      this.AsesorId,
      this.ActividadTipoId
    ).subscribe(
      respuestaActividad=>{        
        this.dialogRef.close(respuestaActividad);
      },err=>{
        alert('Hubo un error al guardar la actividad.')
      },()=>{

      }
    )    
  }
}
