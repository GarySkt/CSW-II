import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionarActividadComponent } from './gestionarActividad.component';
import { GestionarActividadRoutingModule } from './gestionarActividad-routing.module';
import { MatToolbarModule, MatSelectModule, MatInputModule } from '@angular/material';
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatIconModule} from '@angular/material/icon'
import {MatButtonModule} from '@angular/material/button';

@NgModule({
  declarations: [GestionarActividadComponent],
  imports: [
    CommonModule,
    GestionarActividadRoutingModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatSelectModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule
  ]
})
export class GestionarActividadModule { }
