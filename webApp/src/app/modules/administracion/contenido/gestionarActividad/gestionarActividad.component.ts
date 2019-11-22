import { Component, OnInit } from '@angular/core';
import {Actividad} from './actividad.interface';
import {GestionarActividadService} from './gestionar-actividad.service';
import { Escuela } from './escuela.interface';
import { EscuelaService } from './escuela.service';
import { CicloAcademico } from './cicloAcademico.interface';
import { CicloAcademicoService } from './ciclo-academico.service';
import { Asesor } from './asesor.interface';
import { AsesorService } from './asesor.service';
import { Alumno } from './alumno.interface';
import { AlumnoService } from './alumno.service';

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

  constructor(
    private gestionarActividadService: GestionarActividadService,
    private escuelas: EscuelaService,
    private cicloAcademico: CicloAcademicoService,
    private asesorEscuela: AsesorService,
    private alumnoEscuela: AlumnoService
    ) { }
  ngOnInit() {
    this.gestionarActividadService.obtenerActividades().subscribe(
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

  

}
