import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrovisitanteComponent } from './registrovisitante.component';

describe('RegistrovisitanteComponent', () => {
  let component: RegistrovisitanteComponent;
  let fixture: ComponentFixture<RegistrovisitanteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrovisitanteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrovisitanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
