import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'inicio',
    loadChildren: () => import('./modules/inicio/inicio.module').then(m => m.InicioModule)
  },

  {
    path: 'alumno',
    loadChildren: () => import('./modules/alumno/alumno.module').then(m => m.AlumnoModule)
  },

  {
    path: 'autenticacion',
    loadChildren: () => import('./modules/autenticacion/autenticacion.module').then(m => m.AutenticacionModule)
  },
  {
    path: 'administracion',
    loadChildren: () => import('./modules/administracion/administracion.module').then(m => m.AdministracionModule)
  },
  {
    path: 'docente',
    loadChildren: () => import('./modules/docente/docente.module').then(m => m.DocenteModule)
  },

  { path: '', redirectTo: 'autenticacion', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }
