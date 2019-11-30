import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ActividadesComponent } from './actividades.component';

const routes: Routes = [
  { 
    path: '', component: ActividadesComponent 
  },
  {
    path:'entregables',
    loadChildren:()=>import('./entregables/entregables.module').then(m=>m.EntregablesModule)
  },

];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ActividadesRoutingModule { }
