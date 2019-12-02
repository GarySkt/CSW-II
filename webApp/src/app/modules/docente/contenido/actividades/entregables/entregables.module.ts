import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EntregablesComponent } from './entregables.component';
import { MatIconModule, MatDialogModule } from '@angular/material';
import {MatButtonModule} from '@angular/material/button';




@NgModule({
  declarations: [
    EntregablesComponent,
    
  ],
  
  imports: [
    CommonModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule
  ]
})
export class EntregablesModule { }
