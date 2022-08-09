import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { Card } from '../model/card.model';

@Injectable({
  providedIn: 'root'
})
export class CardsService {

  baseUrl = 'https://localhost:7139/api/BankCard';

  constructor(private http: HttpClient) { }

  getAllCards(): Observable<Card[]> {
    return this.http.get<Card[]>(this.baseUrl);
  }

  addCard(card: Card): Observable<Card> {
    return this.http.post<Card>(this.baseUrl, card)
  }
}