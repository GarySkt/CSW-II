import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspecialidadesComponent } from './especialidades.component';
import { EspecialidadesRoutingModule } from './especialidades-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule } from '@angular/material';
import { MatTabEtiquetaComponent } from './mat-tab-etiqueta/mat-tab-etiqueta.component';




@NgModule({
  declarations: [
    EspecialidadesComponent,
    MatTabEtiquetaComponent
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
