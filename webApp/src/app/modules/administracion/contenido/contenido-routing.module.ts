import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: 'especialidades',
    loadChildren: () => import('./especialidades/especialidades.module').then(m => m.EspecialidadesModule)
  },
  {
    path: 'mislogros',
    loadChildren: () => import('./mislogros/mislogros.module').then(m => m.MislogrosModule)
  },
  {
    path: 'gestionarActividad',
    loadChildren: () => import('./gestionarActividad/gestionarActividad.module').then(m => m.GestionarActividadModule)
  },
  {
    path: 'requisitos',    
    loadChildren: () => import('./requisitos/requisitos.module').then(m => m.RequisitosModule)
  },
  {
    path:'',
    redirectTo: 'gestionarActividad'
  }          
  
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContenidoRoutingModule { }
