import { Injectable } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { ModalComponent } from 'src/app/components/modal/modal.component';

@Injectable({
  providedIn: 'root'
})
export class ModalService {

  constructor(
    public modalController: ModalController
  ) { }

  async abreModal(height: string = '255px') {
    return await this._abreModal(height);
  }

  private async _abreModal(height?: string) {
    const modal = await this.modalController.create({
      component: ModalComponent,
      componentProps: {
        height
      },
      cssClass: 'alert'
    });
    return modal;
  }
}
