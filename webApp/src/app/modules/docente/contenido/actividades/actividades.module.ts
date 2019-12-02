import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActividadesComponent } from './actividades.component';
import { ActividadesRoutingModule } from './actividades-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule, MatButtonModule, MatIconModule, MatDialogModule, MatInputModule, MatProgressBarModule } from '@angular/material';
import { FlexLayoutModule} from '@angular/flex-layout';
import { EntregablesComponent } from './entregables/entregables.component';
import { AgregarEntregableComponent } from './agregar-entregable/agregar-entregable.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    ActividadesComponent,
    EntregablesComponent,
    AgregarEntregableComponent
  ],
  entryComponents: [
    AgregarEntregableComponent
  ],
  imports: [
    CommonModule,
    ActividadesRoutingModule,
    MatToolbarModule,
    MatTabsModule,
    MatCardModule,
    MatGridListModule,
    FlexLayoutModule,
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    MatInputModule,
    FormsModule,
    MatProgressBarModule
  ]
})
export class ActividadesModule { }
