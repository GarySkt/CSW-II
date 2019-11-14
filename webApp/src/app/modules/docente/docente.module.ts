import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DocenteComponent } from './docente.component';
import {DocenteRoutingModule} from './docente-routing.module'

import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon'
import {MatGridListModule} from '@angular/material/grid-list';
import { RouterModule, Routes } from '@angular/router';
import { NavegacionLateralComponent } from './navegacion-lateral/navegacion-lateral.component';



@NgModule({
  declarations: [
    DocenteComponent,
    NavegacionLateralComponent
  ],
  imports: [
    CommonModule,
    DocenteRoutingModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatGridListModule,
    RouterModule
  ]
})
export class DocenteModule { }
