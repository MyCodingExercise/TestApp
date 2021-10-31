import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from './person';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  baseUrl: string = "https://localhost:44368/api/";

  constructor(private http: HttpClient) { }

  addPerson(person: Person) {
    const headers = { 'content-type': 'application/json' }
    const body = JSON.stringify(person);

    this.http.post(`${this.baseUrl}person`, body, { 'headers': headers }).subscribe((response: any) => {
      console.log(response);
      alert('submitted');
    }, error => {
      console.log(error);
    });
  }
}
