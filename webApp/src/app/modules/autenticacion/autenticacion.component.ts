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
        if(respuestalogin.token){
          this.router.navigate(["../inicio"]);
        }
      },
      err => {
        alert("ahorita no joven");
        this.mostrarProgressBar = false;
      }, ()=>  {
        
      }
    )


    // setTimeout(() => {

    //   if (this.username == '2013000664' && this.password == '331904') {
    //     this.router.navigate(["../inicio"]);
    //   } else {
    //     alert("Datos invalidos");
    //   }

    // }, 3500)
  }

}
