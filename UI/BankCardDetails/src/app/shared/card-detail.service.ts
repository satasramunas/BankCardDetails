import { Injectable } from '@angular/core';
import { CardDetail } from './card-detail.model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardDetailService {

  baseApiUrl: string = environment.baseApiUrl;
  private url = '/api/BankCard';

  constructor(private http:HttpClient) { }

  formData:CardDetail = new CardDetail();
  card: CardDetail = new CardDetail();

  getCardDetails(): Observable<CardDetail[]> {
    return this.http.get<CardDetail[]>(this.baseApiUrl + this.url);
  }

  postCardDetails(card: CardDetail): Observable<CardDetail> {
    return this.http.post<CardDetail>(this.baseApiUrl + this.url, card);
  }
}
