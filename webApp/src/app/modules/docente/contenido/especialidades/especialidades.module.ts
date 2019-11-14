import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspecialidadesComponent } from './especialidades.component';
import { EspecialidadesRoutingModule } from './especialidades-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule } from '@angular/material';


@NgModule({
  declarations: [
    EspecialidadesComponent,
    
  ],
  imports: [
    CommonModule,
    EspecialidadesRoutingModule,
    MatToolbarModule,
    MatTabsModule,
    MatCardModule,
    MatGridListModule
    
  ]
})
export class EspecialidadesModule { }
