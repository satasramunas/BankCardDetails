import { Injectable } from '@angular/core';
import { CardDetail } from './card-detail.model';

@Injectable({
  providedIn: 'root'
})
export class CardDetailService {

  constructor() { }

  formData:CardDetail = new CardDetail();
}
