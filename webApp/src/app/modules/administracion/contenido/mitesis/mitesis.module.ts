import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MitesisComponent } from './mitesis.component';
import { MitesisRoutingModule } from './mitesis-routing.module';
import { MatToolbarModule, MatSelectModule } from '@angular/material';
import {MatFormFieldModule} from '@angular/material/form-field'



@NgModule({
  declarations: [MitesisComponent],
  imports: [
    CommonModule,
    MitesisRoutingModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatSelectModule
  ]
})
export class MitesisModule { }
