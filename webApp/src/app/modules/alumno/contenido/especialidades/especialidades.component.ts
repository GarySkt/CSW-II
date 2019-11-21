import { Component, OnInit } from '@angular/core';
import { Docente } from './docente.interface';
import { EspecialidadesService } from './especialidades.service';

@Component({
  selector: 'app-especialidades',
  templateUrl: './especialidades.component.html',
  styleUrls: ['./especialidades.component.scss']
})
export class EspecialidadesComponent implements OnInit {

  docentes: Docente[] = new Array<Docente>();

  constructor( private especialidadesService: EspecialidadesService ) { 
  }

  ngOnInit() {
    this.especialidadesService.getDocentes().subscribe(
      docentesAPI => {
        this.docentes = docentesAPI;
      }
    );
  }

  

}
