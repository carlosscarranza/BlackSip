import { Component, OnInit } from '@angular/core';
import { VisitanteService } from '../visitante/visitante.service';
import { IVisitante } from '../visitante/visitante';

@Component({
  selector: 'app-registrovisitante',
  templateUrl: './registrovisitante.component.html',
  styleUrls: ['./registrovisitante.component.css']
})
export class RegistrovisitanteComponent implements OnInit {

  visitante: IVisitante[];

  constructor(private visitaneService: VisitanteService) { }

  ngOnInit() {
    this.visitaneService.getVisitantesProcesados().subscribe(visitanteWs => this.visitante = visitanteWs,
      error => console.error(error),
      () => { console.log(this.visitante) });
  }

}
