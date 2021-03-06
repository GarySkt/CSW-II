import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedserviceService} from '../../../sharedservice.service'

@Component({
  selector: 'app-navegacion-lateral',
  templateUrl: './navegacion-lateral.component.html',
  styleUrls: ['./navegacion-lateral.component.scss']
})
export class NavegacionLateralComponent implements OnInit {

  constructor(private router: Router, public shared: SharedserviceService) { }

  ngOnInit() {
  }

  salir(): void{
    this.router.navigate(["../autenticacion"]);
  }

}
