import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-update',
  templateUrl: './student-update.component.html',
  styleUrls: ['./student-update.component.css']
})
export class StudentUpdateComponent implements OnInit {

  StudentupdateGroup: FormGroup;
  result: any;
  sid: any;
  sname: any;
  smobileno: any;
  semail: any;
  spassword: any;
  sfees: any;

  constructor(private activateRouter: ActivatedRoute, private router: Router, private formBuilder: FormBuilder, private http: HttpClient) {

  }

  ngOnInit() {
    this.sid = this.activateRouter.snapshot.paramMap.get("id");
    this.http.get('https://localhost:44391/api/Students' + "/" + this.sid).subscribe(t => {
      this.result = t;
      const data = this.result[0];

      this.sname = data.name;
      this.semail = data.emailId;
      this.spassword = data.password
      this.smobileno = data.mobileNo
      this.sfees = data.mobileNo


      this.StudentupdateGroup = this.formBuilder.group({
        name: [this.sname, Validators.required],
        mobileNumber: [this.smobileno, Validators.required],
        email: [this.semail, Validators.required],
        password: [this.spassword, Validators.required],
        fees: [this.sfees, Validators.required],
      })

    })
  }
  
  UpdateStudent() {
    this.http.post<any[]>('https://localhost:44391/api/Students', { "name": this.StudentupdateGroup.value.name, "mobileNumber": this.StudentupdateGroup.value.mobileNumber, "emailId": this.StudentupdateGroup.value.email, "password": this.StudentupdateGroup.value.password, "fees": this.StudentupdateGroup.value.fees }).subscribe(t => {
      this.result = t;
      alert("Student Updates succesfully");
    })
  }
}
