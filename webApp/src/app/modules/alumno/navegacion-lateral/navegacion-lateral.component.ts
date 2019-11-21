import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navegacion-lateral',
  templateUrl: './navegacion-lateral.component.html',
  styleUrls: ['./navegacion-lateral.component.scss']
})
export class NavegacionLateralComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
  salir(): void{
    this.router.navigate(["../autenticacion"]);
  }
}
