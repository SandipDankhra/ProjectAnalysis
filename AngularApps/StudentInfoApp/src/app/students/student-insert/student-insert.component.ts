import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-insert',
  templateUrl: './student-insert.component.html',
  styleUrls: ['./student-insert.component.css']
})
export class StudentInsertComponent implements OnInit {
  StudentinsertGroup: FormGroup;
  result: any;
  constructor(private activateRouter: ActivatedRoute, private router: Router, private formBuilder: FormBuilder, private http: HttpClient) { }

  ngOnInit() {
    this.StudentinsertGroup = this.formBuilder.group({
      name: ['', Validators.required],
      mobileNumber: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
      fees: ['', Validators.required],
    });
  }

  InsertStudent() {
    this.http.post<any[]>('https://localhost:44391/api/Students', { "name": this.StudentinsertGroup.value.name, "mobileNumber": this.StudentinsertGroup.value.mobileNumber, "emailId": this.StudentinsertGroup.value.email, "password": this.StudentinsertGroup.value.password, "fees": this.StudentinsertGroup.value.fees }).subscribe(t => {
      this.result = t;
      alert("Student inserted succesfully");
    })
  }
}
