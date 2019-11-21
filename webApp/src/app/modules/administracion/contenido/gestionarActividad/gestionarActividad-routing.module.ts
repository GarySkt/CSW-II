import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GestionarActividadComponent } from './gestionarActividad.component';

const routes: Routes = [
  { path: '', component: GestionarActividadComponent }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GestionarActividadRoutingModule { }
