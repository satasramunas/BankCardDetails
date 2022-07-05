import { Component, OnInit } from '@angular/core';
import { CardDetailService } from 'src/app/shared/card-detail.service';

@Component({
  selector: 'app-card-details-form',
  templateUrl: './card-details-form.component.html',
  styleUrls: ['./card-details-form.component.css']
})
export class CardDetailsFormComponent implements OnInit {

  constructor(public service:CardDetailService) { }

  ngOnInit(): void {
  }

}
