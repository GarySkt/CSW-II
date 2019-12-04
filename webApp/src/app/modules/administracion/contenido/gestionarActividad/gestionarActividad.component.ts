import { Component, OnInit, Inject } from '@angular/core';
import { MatDialog } from '@angular/material'
import { AgregarActividadComponent } from './agregar-actividad/agregar-actividad.component';
import { Actividad } from './interfaces/actividad.interface';
import { datosActividadTabla } from './interfaces/datosActividadTabla.interface';

@Component({
  selector: 'app-gestionarActividad',
  templateUrl: './gestionarActividad.component.html',
  styleUrls: ['./gestionarActividad.component.scss']
})
export class GestionarActividadComponent implements OnInit {
  
  actividades: datosActividadTabla[] = new Array<datosActividadTabla>();  

  constructor(    
    public dialog: MatDialog
    ) { }
  ngOnInit() {    
  }  
  agregarActividad(){
    let dialogRef = this.dialog.open(AgregarActividadComponent);

    dialogRef.afterClosed().subscribe(respuestaActividad=>{
      this.actividades.push(respuestaActividad);
    })
  }
 
  
}