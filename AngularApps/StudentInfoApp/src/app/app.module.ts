import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule,ReactiveFormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentsComponent } from './students/students.component';
import { StudentInsertComponent } from './Students/student-insert/student-insert.component';
import { StudentDeleteComponent } from './Students/student-delete/student-delete.component';
import { StudentUpdateComponent } from './Students/student-update/student-update.component';
import { StudentListComponent } from './Students/student-list/student-list.component';
import { RouterModule,Routes } from '@angular/router';
import { APP_BASE_HREF, LocationStrategy, HashLocationStrategy } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    StudentsComponent,
    StudentInsertComponent,
    StudentDeleteComponent,
    StudentUpdateComponent,
    StudentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,FormsModule
  ],
  providers: [
    { provide: APP_BASE_HREF,    useValue: '/' },
    { provide: LocationStrategy, useClass: HashLocationStrategy },
  ],
  exports: [RouterModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
