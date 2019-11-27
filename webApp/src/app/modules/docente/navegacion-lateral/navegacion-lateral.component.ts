import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedserviceService } from 'src/app/sharedservice.service';

@Component({
  selector: 'app-navegacion-lateral',
  templateUrl: './navegacion-lateral.component.html',
  styleUrls: ['./navegacion-lateral.component.scss']
})
export class NavegacionLateralComponent implements OnInit {

  constructor(private router: Router, public obtenerDatosSesion: SharedserviceService) { }
  
  ngOnInit() {        
  }
  salir(): void{
    this.router.navigate(["../autenticacion"]);
  }
}
