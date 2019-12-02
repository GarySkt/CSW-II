import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ActividadesComponent } from './actividades.component';
import { EntregablesComponent } from './entregables/entregables.component';

const routes: Routes = [
  { 
    path: '', component: ActividadesComponent 
  },
  {
    path:'entregables/:actividadId',
    component: EntregablesComponent    
  },

];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ActividadesRoutingModule { }
