import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-agregar-entregable',
  templateUrl: './agregar-entregable.component.html',
  styleUrls: ['./agregar-entregable.component.scss']
})
export class AgregarEntregableComponent implements OnInit {

  constructor() { }

  Titulo: string;
  comentario: string;

  ngOnInit() {
  }
  guardarEntregable(){
    
  }

}
