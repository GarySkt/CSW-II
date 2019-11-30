import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EntregablesComponent } from './actividades/entregables/entregables.component';
import { EntregablesModule } from './actividades/entregables/entregables.module';


const routes: Routes = [
  {
    path: 'actividades',
    loadChildren: () => import('./actividades/actividades.module').then(m => m.ActividadesModule)   
  },
  {
    path: 'mislogros',
    loadChildren: () => import('./mislogros/mislogros.module').then(m => m.MislogrosModule)
  },   
  {
    path: 'mitesis',
    loadChildren: () => import('./mitesis/mitesis.module').then(m => m.MitesisModule)
  },
  {
    path: 'requisitos',    
    loadChildren: () => import('./requisitos/requisitos.module').then(m => m.RequisitosModule)
  },
  {
    path:'',
    redirectTo: 'actividades'
  }          
  
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContenidoRoutingModule { }
