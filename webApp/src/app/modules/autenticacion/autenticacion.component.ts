import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutenticacionService} from './autenticacion.service'

@Component({
  selector: 'app-autenticacion',
  templateUrl: './autenticacion.component.html',
  styleUrls: ['./autenticacion.component.scss']
})
export class AutenticacionComponent implements OnInit {

  username: string;
  password: string;
  mostrarProgressBar: boolean = false;

  constructor(private router: Router, private autenticacion: AutenticacionService) { }

  ngOnInit() {
  }

  login(): void {
    this.mostrarProgressBar = true;

    this.autenticacion.autenticarUsuario(this.username,this.password).subscribe(
      respuestalogin => {
        if(respuestalogin.token && respuestalogin.rolId == 1){
          this.router.navigate(["../inicio"]);
        }else{
          this.router.navigate(["../administracion"]);
        }
      },
      err => {
        alert("Error al iniciar la sesion");
        this.mostrarProgressBar = false;
      }, ()=>  {        
      }
    )
  }

}
