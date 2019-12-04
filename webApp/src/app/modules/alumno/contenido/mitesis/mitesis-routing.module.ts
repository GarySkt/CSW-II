import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MitesisComponent } from './mitesis.component';
import { EntregablesComponent } from './entregables/entregables.component';

const routes: Routes = [
  {
    path: '', component: MitesisComponent 
  },{
    path:':actividadId/entregables',
    component: EntregablesComponent    
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
export class MitesisRoutingModule { }
