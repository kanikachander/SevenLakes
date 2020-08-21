import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { UserServiceService } from '../user-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.css']
})
export class ResetPasswordComponent implements OnInit {

  constructor(private service: UserServiceService, private router: Router) { }
  username: string;
  password: string;

  ngOnInit() {
  }

  reset(){
    let user = {
      "usr": this.username,
      "pwd": this.password
    }
    this.service.ResetPassword(user).subscribe(data => {
      this.router.navigateByUrl("page/" + data);


    })
  }
}
