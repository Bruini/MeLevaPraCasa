import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubscribeAdoPage } from './subscribe-ado.page';

describe('SubscribeAdoPage', () => {
  let component: SubscribeAdoPage;
  let fixture: ComponentFixture<SubscribeAdoPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubscribeAdoPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubscribeAdoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
