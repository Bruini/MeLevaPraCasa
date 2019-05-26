import { Component } from '@angular/core';
import { ModalService } from '../services/modal/modal.service';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { PetService } from '../services/pet/pet.service';
import { Pet } from '../models/pet';
import { Router } from '@angular/router';

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
    nomeTutor: new FormControl(),
    vacinado:  new FormControl(),
    castrado: new FormControl(),
    imagem: new FormControl(),
    cidade: new FormControl(),
    estado: new FormControl()
  });

  constructor(
    private _petService: PetService,
    private _formBuilder: FormBuilder,
    private _router: Router,
  ) {
      this.createForm();
  }

  createForm() {
    this.doeForm = this._formBuilder.group({
      nome: '',
      idade: null,
      descricao: '',
      nomeTutor: '',
      vacinado: '',
      castrado: '',
      imagem: '',
      bairro: '',
      cidade: '',
      estado: '',
    });
  }

  criarPet(): void {
    const pet = new Pet();
    pet.nome = this.doeForm.controls.nome.value;
    pet.idade = Number(this.doeForm.controls.idade.value);
    pet.descricao = this.doeForm.controls.descricao.value;
    pet.nomeTutor = this.doeForm.controls.nomeTutor.value;
    pet.vacinado = true;
    pet.castrado = true;
    pet.imagem = this.doeForm.controls.imagem.value;
    pet.bairro = this.doeForm.controls.bairro.value;
    pet.cidade = this.doeForm.controls.cidade.value;
    pet.estado = this.doeForm.controls.estado.value;
    console.log(pet);
    this.inserir(pet);
  }

  inserir(pet: Pet) {
    this._petService.postPet(pet).subscribe();
    this.home();
  }

  home() {
    this._router.navigate(['tabs/feed']);
  }
}
