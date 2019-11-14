import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MitesisComponent } from './mitesis.component';
import { MitesisRoutingModule } from './mitesis-routing.module';
import { MatToolbarModule, MatCardModule, MatCard } from '@angular/material';
import {MatProgressBarModule} from '@angular/material/progress-bar';


@NgModule({
  declarations: [MitesisComponent],
  imports: [
    CommonModule,
    MitesisRoutingModule,
    MatToolbarModule,
    MatProgressBarModule,
    MatCardModule
  ]
})
export class MitesisModule { }
