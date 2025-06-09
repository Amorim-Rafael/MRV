import { Component, OnInit } from '@angular/core';
import { LeadService } from '../../shared/lead.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-lead-details-accepted',
  imports: [CommonModule],
  templateUrl: './lead-details-accepted.html',
  styles: ``
})
export class LeadDetailsAccepted implements OnInit {

  constructor(public service: LeadService) { }

  ngOnInit(): void {
    this.service.getLeadsAccepted();
  }
}
