import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MenugijgoComponent } from './menugijgo.component';

describe('MenugijgoComponent', () => {
  let component: MenugijgoComponent;
  let fixture: ComponentFixture<MenugijgoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MenugijgoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MenugijgoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
