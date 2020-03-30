import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentInsertComponent } from './Students/student-insert/student-insert.component';
import { AppComponent } from './app.component';
import { StudentUpdateComponent } from './Students/student-update/student-update.component';
import { StudentDeleteComponent } from './Students/student-delete/student-delete.component';
import { StudentListComponent } from './Students/student-list/student-list.component';
import { StudentsComponent } from './students/students.component';


const routes: Routes = [
  {
		path: '', redirectTo: 'home', pathMatch: 'full',
	},
  {
    path:'home',
    component:StudentsComponent
  },
  {
    path:'insert',
    component:StudentInsertComponent
  },
  {
    path:'update/:id',
    component:StudentUpdateComponent
  },
  {
    path:'delete/:id',
    component:StudentDeleteComponent
  },
  {
    path:'list',
    component:StudentListComponent
  },
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
