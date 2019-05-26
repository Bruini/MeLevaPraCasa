import { Component } from '@angular/core';
import { ModalService } from '../services/modal/modal.service';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-subscribe-donation',
  templateUrl: './subscribe-donation.page.html',
  styleUrls: ['./subscribe-donation.page.scss'],
})

export class SubscribeDonationPage {

  doeForm = new FormGroup({
    nome: new FormControl(),
    idade: new FormControl(),
    descricao: new FormControl(),
    localizacao: new FormControl(),
    tutor: new FormControl(),
  });


  constructor(
    private _modalService: ModalService,
    private _formBuilder: FormBuilder
  ) {
      this.createForm();
  }

  async abreModal() {
    const modal = await this._modalService.abreModal();
    modal.present();
  }

  createForm() {
    this.doeForm = this._formBuilder.group({
      nome: '',
      idade: '',
      descricao: '',
      localizacao: '',
      tutor: ''
    });
  }

}
