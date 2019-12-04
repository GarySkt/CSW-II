import { Component, OnInit, Inject } from '@angular/core';
import { AgregarEntregableService } from '../servicios/agregar-entregable.service';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-agregar-entregable',
  templateUrl: './agregar-entregable.component.html',
  styleUrls: ['./agregar-entregable.component.scss']
})
export class AgregarEntregableComponent implements OnInit {
 
  ActividadId: number;
  descripcion: string;
  comentario: string;
  
  constructor(
    private entregable: AgregarEntregableService,
    public dialogRef: MatDialogRef<AgregarEntregableComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }
 

  ngOnInit() {
    this.ActividadId = this.data.actividadId;
    console.log(this.ActividadId);
    console.log(this.data);
  }

  guardarEntregable(){
    this.entregable.agregarEntregable(
      this.ActividadId,
      this.descripcion,
      this.comentario
    ).subscribe(
      respuestaEntregable=>{
        console.log(respuestaEntregable);
        this.dialogRef.close(respuestaEntregable);
      },err=>{        
        alert('Error al agregar Entregable.');
      }
    ) 
  }

}
