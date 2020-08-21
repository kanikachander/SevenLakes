import { Component, OnInit } from '@angular/core';
import { UserServiceService } from '../user-service.service';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from '../User.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private service: UserServiceService, private router: Router, private _activatedRouter: ActivatedRoute) { }

  username: string;
  user: User;

  ngOnInit() {
    this._activatedRouter.params.subscribe(params => { this.username = params['username']; });
    this.service.GetUser(this.username).subscribe(data => {
      this.user = data;
    })

  }

}
