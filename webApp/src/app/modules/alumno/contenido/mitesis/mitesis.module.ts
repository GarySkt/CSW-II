import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MitesisComponent } from './mitesis.component';
import { MitesisRoutingModule } from './mitesis-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule, MatButtonModule, MatIconModule, MatDialogModule, MatInputModule, MatProgressBarModule } from '@angular/material';
import { EntregablesComponent } from './entregables/entregables.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    MitesisComponent,
    EntregablesComponent
  ],
  imports: [
    CommonModule,
    MitesisRoutingModule,
    MatToolbarModule,
    MatTabsModule,
    MatCardModule,
    MatGridListModule,    
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    MatInputModule,
    FormsModule,
    MatProgressBarModule
  ]
})
export class MitesisModule { }
