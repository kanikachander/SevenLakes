import { Component, OnInit } from '@angular/core';
import { UserServiceService } from '../user-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  ngOnInit() {
  }

  title = 'SevenLakesUI';
  username: string;
  password: string;
  message: string;
  constructor(private service: UserServiceService, private router: Router) { }

  login(){
    let user = {
      "usr": this.username,
      "pwd": this.password
    }
    this.service.Login(user).subscribe(data => {
      console.log(data);
      this.router.navigateByUrl("page/" + data);
      

    })
  }

  resetPassword(){
    let user = {
      "usr": this.username,
      "pwd": this.password
    }
    this.service.Login(user).subscribe(data => {
      console.log(data);
      this.router.navigateByUrl("page/" + data);
      

    })
  }

}
