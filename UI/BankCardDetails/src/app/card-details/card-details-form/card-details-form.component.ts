import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CardDetail } from 'src/app/shared/card-detail.model';
import { CardDetailService } from 'src/app/shared/card-detail.service';

@Component({
  selector: 'app-card-details-form',
  templateUrl: './card-details-form.component.html',
  styleUrls: ['./card-details-form.component.css']
})
export class CardDetailsFormComponent implements OnInit {
  @Input() card?: CardDetail;

  constructor(public service:CardDetailService) { } // dependency injection

  ngOnInit(): void {
    this.service.getCardDetails()
    .subscribe({
      next: (CardDetail) => {
        console.log(CardDetail);
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

  onSubmit(form: NgForm) {
    this.service.postCardDetails()
    .subscribe({
      next: (CardDetail) => {
        console.log(CardDetail);
      },
      error: (response) => {
        console.log(response);
      }
  });
}
}
