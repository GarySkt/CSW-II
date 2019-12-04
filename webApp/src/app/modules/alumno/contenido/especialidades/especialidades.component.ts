import { Component, OnInit } from '@angular/core';
import { Docente } from './interfaces/docente.interface';
import { DocenteLineaInvestigacionService } from './servicios/obtener-docentes-linea-investigacion.service';

@Component({
  selector: 'app-especialidades',
  templateUrl: './especialidades.component.html',
  styleUrls: ['./especialidades.component.scss']
})
export class EspecialidadesComponent implements OnInit {

  docentes: Docente[] = new Array<Docente>();

  constructor( private especialidadesService: DocenteLineaInvestigacionService ) { 
  }

  ngOnInit() {
    this.especialidadesService.getDocentes().subscribe(
      docentesAPI => {
        this.docentes = docentesAPI;
      }
    );
  }

  

}
