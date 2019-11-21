import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlumnoComponent } from './alumno.component';

const routes: Routes = [
  { 
    path: '',
    component: AlumnoComponent ,    
    children:[
      {
        path:'',
        loadChildren: () => import('./contenido/contenido.module').then(m => m.ContenidoModule)
      }
    ]
  },  
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AlumnoRoutingModule { }
