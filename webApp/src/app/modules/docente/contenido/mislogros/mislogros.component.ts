import { Component, OnInit } from '@angular/core';
import {Medallas} from './medallas.interface';
import {MislogrosService} from './mislogros.service'

@Component({
  selector: 'app-mislogros',
  templateUrl: './mislogros.component.html',
  styleUrls: ['./mislogros.component.scss']
})
export class MislogrosComponent implements OnInit {

  medallas: Medallas[] = new Array<Medallas>();
  constructor(private mislogrosService: MislogrosService) { }

  ngOnInit() {
    this.mislogrosService.obtenerMedallas().subscribe(
      medallasAPI => {
        this.medallas = medallasAPI;
      }
    )
  }

}
