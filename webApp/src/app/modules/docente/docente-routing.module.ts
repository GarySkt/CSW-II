import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DocenteComponent } from './docente.component';

const routes: Routes = [
  { 
    path: '',
     component: DocenteComponent,
     children:[
      {
        path:'',
        loadChildren: () => import('./contenido/contenido.module').then(m => m.ContenidoModule)
      }
    ]
  }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DocenteRoutingModule { }
