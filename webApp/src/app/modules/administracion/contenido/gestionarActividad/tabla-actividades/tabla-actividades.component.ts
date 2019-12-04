import { Component, OnInit, ChangeDetectorRef, Input } from '@angular/core';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-tabla-actividades',
  templateUrl: './tabla-actividades.component.html',
  styleUrls: ['./tabla-actividades.component.scss']
})
export class TablaActividadesComponent implements OnInit {

  displayedColumns: string[] = ['actividad', 'alumno', 'asesor','titulo', 'descripcion','estado','acciones'];  

  @Input() actividadesTabla: any[];

  dataSource: any;

  constructor( 
    private changeDetectorRefs: ChangeDetectorRef
    ) { }

  ngOnInit() {      
    this.dataSource = new MatTableDataSource(this.actividadesTabla)
  }

  public Log(){
    console.log(this.actividadesTabla);
  }

  public ActualizarActividaadesTabla(nuevasActividades: any[]){
    this.actividadesTabla = nuevasActividades;
    this.dataSource.data = this.actividadesTabla;
    this.changeDetectorRefs.detectChanges();
  }
}