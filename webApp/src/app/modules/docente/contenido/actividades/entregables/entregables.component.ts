import { Component, OnInit,Inject } from '@angular/core';
import { MatDialog } from '@angular/material';
import { AgregarEntregableComponent } from '../agregar-entregable/agregar-entregable.component';
import { ActivatedRoute } from '@angular/router';
import { Entregable } from '../interfaces/entregableActividad';
import { ObtenerEntregablesActividadService } from '../servicios/obtener-entregables-actividad.service';

@Component({
  selector: 'app-entregables',
  templateUrl: './entregables.component.html',
  styleUrls: ['./entregables.component.scss']
})
export class EntregablesComponent implements OnInit {
  actividadId: number;

  entregables: Entregable[] = new Array<Entregable>();
  mostrarProgressBar: boolean = false;    
  constructor(
    public dialog: MatDialog,
    private route: ActivatedRoute,
    private entrgableServicio: ObtenerEntregablesActividadService
    ) { }
  ngOnInit() {    
    this.route.params.subscribe(params=>{
      this.actividadId = params['actividadId'];      
    }),
    this.mostrarProgressBar = true;     
    this.entrgableServicio.obtenerEntregablesActividad(this.actividadId).subscribe(
      entregableActividad => {
        this.entregables = entregableActividad;        
        this.mostrarProgressBar = false;
      },err => {
        alert("Error al obtener los entregables");        
      }, ()=>  {        
      }
    )    
  }
  agregarEntregable(){
    let dialogRef = this.dialog.open(AgregarEntregableComponent, {
      data: {
        actividadId: this.actividadId        
      }
    });

    dialogRef.afterClosed().subscribe(respuestaEntregable => {
      console.log(respuestaEntregable);
      this.entregables.push(respuestaEntregable);
    });
    
  }
  
}
