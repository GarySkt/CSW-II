import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdministracionComponent } from './administracion.component';

const routes: Routes = [
  { 
    path: '',
     component: AdministracionComponent,
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
export class AdministracionRoutingModule { }
