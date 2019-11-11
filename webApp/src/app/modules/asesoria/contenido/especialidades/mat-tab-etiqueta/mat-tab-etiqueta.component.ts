import { Component, OnInit,Input } from '@angular/core';

import {Observable} from 'rxjs';
import {PostI} from '../post.interface';

@Component({
  selector: 'app-mat-tab-etiqueta',
  templateUrl: './mat-tab-etiqueta.component.html',
  styleUrls: ['./mat-tab-etiqueta.component.scss'],
  providers: []
})
export class MatTabEtiquetaComponent implements OnInit {

  @Input() area:PostI;

  constructor() { }

  areas$: Observable<PostI[]>;

  ngOnInit() {
    
    
  }

}
