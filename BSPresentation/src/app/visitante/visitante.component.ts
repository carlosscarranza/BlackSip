import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { VisitanteService } from './visitante.service';
import { IVisitante } from './visitante';

@Component({
  selector: 'app-visitante',
  templateUrl: './visitante.component.html',
  styleUrls: ['./visitante.component.css']
})
export class VisitanteComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private visitaneService: VisitanteService,
    private router: Router) { }

    formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      cedula: null,
      nombre: "",
      email: "",
      telefono: null
    });
  }

  save() {
    let visitante: IVisitante = Object.assign({}, this.formGroup.value);

      this.visitaneService.createVisitante(visitante).subscribe(profesor => this.onSaveSuccess(),
      error => console.error(error));
  }

  onSaveSuccess() {
    this.router.navigate(["/"]);
  }

}
