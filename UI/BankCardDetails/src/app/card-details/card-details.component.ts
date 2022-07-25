import { Component, OnInit } from '@angular/core';
import { CardDetail } from '../shared/card-detail.model';
import { CardDetailService } from '../shared/card-detail.service';
import { CardDetailsFormComponent } from './card-details-form/card-details-form.component';

@Component({
  selector: 'app-card-details',
  templateUrl: './card-details.component.html',
  styleUrls: ['./card-details.component.css']
})
export class CardDetailsComponent implements OnInit {

  list: CardDetail[];

  constructor(public service:CardDetailService) { }

  ngOnInit(): void {
    this.service.getCardDetails()
    .subscribe({
      next: (list) => {
        this.list = list;
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

}
