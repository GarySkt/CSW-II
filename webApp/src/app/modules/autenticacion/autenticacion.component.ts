import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutenticacionService} from './autenticacion.service'
import {SharedserviceService} from '../../sharedservice.service';

@Component({
  selector: 'app-autenticacion',
  templateUrl: './autenticacion.component.html',
  styleUrls: ['./autenticacion.component.scss']
})
export class AutenticacionComponent implements OnInit {

  username: string;
  password: string;
  mostrarProgressBar: boolean = false;    

  constructor(
    private router: Router,
    private autenticacion: AutenticacionService,
    public shared: SharedserviceService) {   } 

  ngOnInit() {
  }

  login(): void {
    this.mostrarProgressBar = true;     
   this.autenticacion.autenticarUsuario(this.username,this.password).subscribe(
      respuestalogin => {
          this.shared.nombreEntidad=respuestalogin.nombreEntidad;
          this.shared.apellidoEntidad=respuestalogin.apellidoEntidad;
          this.shared.entidadId=respuestalogin.entidadId;
        if(respuestalogin.token && respuestalogin.rolId == 1){                
          this.router.navigate(["../inicio"]);
          alert('Bienvenido '+respuestalogin.nombreEntidad+' '+respuestalogin.apellidoEntidad);
        }else if(respuestalogin.token && respuestalogin.rolId == 2){          
          this.router.navigate(["../docente"]);
          alert('Bienvenido '+respuestalogin.nombreEntidad+' '+respuestalogin.apellidoEntidad);
        }else if(respuestalogin.token && respuestalogin.rolId == 3){
          this.router.navigate(["../administracion"]);
          alert('Bienvenido '+respuestalogin.nombreEntidad+' '+respuestalogin.apellidoEntidad);
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
