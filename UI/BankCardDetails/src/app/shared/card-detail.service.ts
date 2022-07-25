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
  list: CardDetail[];

  getCardDetails(): Observable<CardDetail[]> {
    return this.http.get<CardDetail[]>(this.baseApiUrl + this.url);
  }

  postCardDetails(formData: CardDetail): Observable<CardDetail> {
    return this.http.post<CardDetail>(this.baseApiUrl + '/api/BankCard', formData);
  }
}
