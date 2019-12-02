import { Component, OnInit, Inject } from '@angular/core';
import { MatDialog } from '@angular/material'
import { AgregarActividadComponent } from './agregar-actividad/agregar-actividad.component';

@Component({
  selector: 'app-gestionarActividad',
  templateUrl: './gestionarActividad.component.html',
  styleUrls: ['./gestionarActividad.component.scss']
})
export class GestionarActividadComponent implements OnInit {
  constructor(    
    public dialog: MatDialog
    ) { }
  ngOnInit() {    
  }  
  agregarActividad(){
    this.dialog.open(AgregarActividadComponent);
  }
 
  
}