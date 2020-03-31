import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
getData:any;
  constructor(private router:Router,private http:HttpClient) { }

  ngOnInit() {
    this.http.get<any>('https://localhost:44391/api/Students').subscribe(t => {
            this.getData = t;
        });
  }

}
