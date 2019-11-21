import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActividadesComponent } from './actividades.component';
import { ActividadesRoutingModule } from './actividades-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule } from '@angular/material';


@NgModule({
  declarations: [
    ActividadesComponent,
    
  ],
  imports: [
    CommonModule,
    ActividadesRoutingModule,
    MatToolbarModule,
    MatTabsModule,
    MatCardModule,
    MatGridListModule
    
  ]
})
export class ActividadesModule { }
