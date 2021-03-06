import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GestionarActividadComponent } from './gestionarActividad.component';
import { GestionarActividadRoutingModule } from './gestionarActividad-routing.module';
import { MatToolbarModule, MatSelectModule, MatInputModule, MatDialogModule } from '@angular/material';
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatIconModule} from '@angular/material/icon'
import {MatButtonModule} from '@angular/material/button';
import { MatTableModule } from '@angular/material';
import { TablaActividadesComponent } from './tabla-actividades/tabla-actividades.component'  
import { FormsModule } from '@angular/forms';
import { AgregarActividadComponent } from './agregar-actividad/agregar-actividad.component';

@NgModule({
  declarations: [
    GestionarActividadComponent, 
    TablaActividadesComponent,
    AgregarActividadComponent],
  entryComponents: [ AgregarActividadComponent],
  imports: [
    CommonModule,
    GestionarActividadRoutingModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatSelectModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    MatTableModule,
    FormsModule,
    MatDialogModule
  ]
})
export class GestionarActividadModule { }
