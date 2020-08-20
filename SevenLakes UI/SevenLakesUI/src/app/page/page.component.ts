import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.css']
})
export class PageComponent implements OnInit {

  constructor(private _activatedRouter: ActivatedRoute) { }
  message: string;
  displayMessage: string;

  ngOnInit() {
    this._activatedRouter.params.subscribe(params => { this.message = params['msg']; });
    if(this.message == "LoginSuccessful")
        this.displayMessage = "Login Successful";
      else if(this.message == "LoginUnsuccessful")
        this.displayMessage = "Incorrect Password";
      else
      this.displayMessage = "User Not Found";
  }

}
