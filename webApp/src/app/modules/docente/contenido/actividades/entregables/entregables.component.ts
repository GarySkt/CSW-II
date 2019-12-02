import { Component, OnInit,Inject } from '@angular/core';
import { MatDialog } from '@angular/material';
import { AgregarEntregableComponent } from '../agregar-entregable/agregar-entregable.component';

@Component({
  selector: 'app-entregables',
  templateUrl: './entregables.component.html',
  styleUrls: ['./entregables.component.scss']
})
export class EntregablesComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
  }
  agregarEntregable(){
    this.dialog.open(AgregarEntregableComponent);
  }
 
}
