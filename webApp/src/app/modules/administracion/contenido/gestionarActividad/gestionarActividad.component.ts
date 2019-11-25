import { Component, OnInit } from '@angular/core';
import {Actividad} from './interfaces/actividad.interface';
import {GestionarActividadService} from '././servicios/gestionar-actividad.service';
import { Escuela } from '././interfaces/escuela.interface';
import { EscuelaService } from '././servicios/escuela.service';
import { CicloAcademico } from '././interfaces/cicloAcademico.interface';
import { CicloAcademicoService } from '././servicios/ciclo-academico.service';
import { Asesor } from '././interfaces/asesor.interface';
import { AsesorService } from '././servicios/asesor.service';
import { Alumno } from '././interfaces/alumno.interface';
import { AlumnoService } from '././servicios/alumno.service';
import { GuardarActividadService } from '././servicios/guardar-actividad.service';

@Component({
  selector: 'app-gestionarActividad',
  templateUrl: './gestionarActividad.component.html',
  styleUrls: ['./gestionarActividad.component.scss']
})
export class GestionarActividadComponent implements OnInit {

  actividad: Actividad[] = new Array<Actividad>();
  escuela: Escuela[]=new Array<Escuela>();
  cicloacademico: CicloAcademico[]=new Array<CicloAcademico>();
  asesor: Asesor[] = new Array<Asesor>();
  alumno: Alumno[] = new Array<Alumno>();

  AlumnoId: number;
  Titulo: string;
  Resumen: string;
  Descripcion: string;
  AsesorId: number;
  ActividadTipoId: number;
  escuelaId: number;
  nombre: undefined;

  constructor(
    private gestionarActividadService: GestionarActividadService,
    private escuelas: EscuelaService,
    private cicloAcademico: CicloAcademicoService,
    private asesorEscuela: AsesorService,
    private alumnoEscuela: AlumnoService,
    private actividades: GuardarActividadService
    ) { }
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
        alert('Esta actividad fue guardar en la puta base de datos con un puto exito')
        this.limpiarFormulario();

      },err=>{
        alert('no funciona we :( , sigue intentando tu puedes campion')
      },()=>{

      }
    )    
  }

  limpiarFormulario(){
    this.Titulo='';
    this.Descripcion = '';
    this.Resumen = '';
    this.AlumnoId = undefined;
    this.ActividadTipoId = undefined;
    this.nombre= undefined;
    this.AsesorId = undefined;
    this.escuelaId = undefined;
  }
}