import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss'],
})

export class ModalComponent implements OnInit {

  @Input() height: string;

  constructor(
    public modalController: ModalController,
  ) { }

  ngOnInit() {
    const elements = document.querySelectorAll<HTMLInputElement>('.alert');
    elements.forEach(el => {
      el.style.setProperty('--height', this.height || '40%');
    });
  }

  fecharModal() {
    this.modalController.dismiss();
  }

}
