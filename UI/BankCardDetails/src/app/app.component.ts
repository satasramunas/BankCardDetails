import { formatCurrency } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Card } from './model/card.model';
import { CardsService } from './service/cards.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'BankCard';
  cards: Card[] = [];
  card: Card = {
    id: 0,
    cardHolderName: '',
    cardNumber: '',
    expiryMonth: '',
    expiryYear: '',
    cvc: ''
  }

  constructor(private cardsService: CardsService) {

  }

  ngOnInit(): void {
    this.getAllCards();
  }

  getAllCards() {
    this.cardsService.getAllCards()
    .subscribe(
      response => {
        this.cards = response;
      }
    );
  }

  onSubmit () {
    this.cardsService.addCard(this.card)
    .subscribe(
      response => {
        this.getAllCards();
        this.card = {
          id: 0,
          cardHolderName: '',
          cardNumber: '',
          expiryMonth: '',
          expiryYear: '',
          cvc: ''
        };
      }
    )
  }
}
