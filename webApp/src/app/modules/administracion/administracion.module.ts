import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdministracionRoutingModule } from './administracion-routing.module';
import {AdministracionComponent} from './administracion.component'
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon'
import {MatGridListModule} from '@angular/material/grid-list';
import { RouterModule, Routes } from '@angular/router';
import { NavegacionLateralComponent } from './navegacion-lateral/navegacion-lateral.component';



@NgModule({
  declarations: [
    AdministracionComponent,
    NavegacionLateralComponent
  ],
  imports: [
    CommonModule,
    AdministracionRoutingModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatGridListModule,
    RouterModule
  ]
})
export class AdministracionModule { }
