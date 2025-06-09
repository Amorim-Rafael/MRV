import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Lead } from './lead.model';

@Injectable({
  providedIn: 'root'
})
export class LeadService {

  url:string = environment.apiBaseUrl + '/Leads/'
  listLeadsInvited: Lead[] = []
  listLeadsAccepted: Lead[] = []
  constructor(private http: HttpClient) { }

  getLeadsInvited() {
    this.http.get(this.url + 'GetLeadsInvited')
      .subscribe({
        next: resp => { this.listLeadsInvited = resp as Lead[] },
        error: err => { console.log(err) }
      })
  }

  getLeadsAccepted() {
    this.http.get(this.url + 'GetLeadsAccepted')
      .subscribe({
        next: resp => { this.listLeadsAccepted = resp as Lead[] },
        error: err => { console.log(err) }
    })
  }

  updateLeadStatus(id: any) {
    const body = { id: id };

    this.http.put(this.url + 'UpdateLead/'+id, body)
      .subscribe(resp => { 
        window.location.reload();
       })
  }
}
