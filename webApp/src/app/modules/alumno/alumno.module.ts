import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AlumnoRoutingModule } from './alumno-routing.module';
import { AlumnoComponent } from './alumno.component';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon'
import {MatGridListModule} from '@angular/material/grid-list';
import { RouterModule, Routes } from '@angular/router';
import { NavegacionLateralComponent } from './navegacion-lateral/navegacion-lateral.component';

@NgModule({
  declarations: [
    AlumnoComponent,
    NavegacionLateralComponent, 
  ],
  imports: [
    CommonModule,
    AlumnoRoutingModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatGridListModule,
    RouterModule
  ]
})
export class AlumnoModule { }
