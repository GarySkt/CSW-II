import { Component, OnInit } from '@angular/core';
import { Actividad } from '../interfaces/actividad';
import { ObtenerListaActividadesService } from '../servicios/obtener-lista-actividades.service';

export interface PeriodicElement {
  name: string;
  position: string;
  weight: string;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 'Tesis', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
  {position: 'Tesis', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
  {position: 'Tesis', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
  {position: 'Tesis', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
  {position: 'Tesis', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
  {position: 'Articulo', name: 'Kevin', weight: 'Alberto Flor', symbol: 'Titulo de Tesis'},
];

@Component({
  selector: 'app-tabla-actividades',
  templateUrl: './tabla-actividades.component.html',
  styleUrls: ['./tabla-actividades.component.scss']
})
export class TablaActividadesComponent implements OnInit {

  actividades: Actividad[] = new Array<Actividad>();  

  constructor( private obtenerListaActividades: ObtenerListaActividadesService) { }

  displayedColumns: string[] = ['uno', 'name', 'weight', 'symbol','descripcion','estado','acciones'];
  dataSource = ELEMENT_DATA;

  ngOnInit() {
    this.obtenerListaActividades.obtenerDatosTablaActividades().subscribe(
      respuesta => {
        this.actividades = respuesta
      }
    )
  }

}
