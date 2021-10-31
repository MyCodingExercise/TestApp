import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { PersonService } from './person.service';

@Component({
  selector: 'app-person-component',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  baseUrl: string = "https://localhost:44368/api/";
  public people: any[];
  public personForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private personService: PersonService) {
    this.personForm = this.formBuilder.group({
      firstName: '',
      lastName: ''
    });
  }

  ngOnInit(): void {
    //
  }

  submitPersonDetails() {
    this.personService.addPerson(this.personForm.value);
  }
}
