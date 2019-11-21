import { Component, OnInit } from '@angular/core';
import { Docente } from './docente.interface';
import { ActividadesService } from './actividades.service';

@Component({
  selector: 'app-actividades',
  templateUrl: './actividades.component.html',
  styleUrls: ['./actividades.component.scss']
})
export class ActividadesComponent implements OnInit {

  docentes: Docente[] = new Array<Docente>();

  constructor( private actividadesService: ActividadesService ) { 
  }

  ngOnInit() {
    this.actividadesService.getDocentes().subscribe(
      docentesAPI => {
        this.docentes = docentesAPI;
      }
    );
  }

  

}
