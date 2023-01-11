import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { empty, Observable } from 'rxjs';
import { TypeofExpr } from '@angular/compiler';
import { Data } from '@angular/router';
import { DATE_PIPE_DEFAULT_TIMEZONE } from '@angular/common';


@Component({
  selector: 'app-add-form',
  templateUrl: './add-form.component.html'
})



export class AddFormComponent {
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
  }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };
  url: string;
  filevalue: File | undefined;
 

  public userform: UserForm = {
      name: '',
      username: '',
      address: '',
      dateofbirth: new Date(),
      file: undefined
  }
  onFileChange(event: any) {
    this.filevalue = event.target.files[0] as File;
  }



  add(userform: any) {
    const body = JSON.stringify(userform);
    userform.file = this.filevalue;
    console.log(userform)
    return this.http.post<UserForm>(this.url + 'insert/', body, this.httpOptions).subscribe(result => {
      console.log(result)

    }, error => console.error(error));
   
  }

}

interface UserForm {
  name: string;
  username: string;
  address: string;
  dateofbirth: Date;
  file?: File
}
