import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Login } from 'src/app/Models/login';
import { User } from 'src/app/Models/user';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  submitted = false;
  login: Login;
  user:User;
  constructor(private frombuilder: FormBuilder, private account_service: AccountService,private router:Router) {
    this.login = new Login();
  }

  ngOnInit() {
    this.loginForm = this.frombuilder.group({
      email: ['', Validators.required],
      pwd: ['', Validators.required]
    });
  }
  onSubmit() {
    this.submitted = true;
    if (this.loginForm.valid) {

      this.login.email=this.loginForm.value["email"];
      this.login.password=this.loginForm.value['pwd']
      this.account_service.Login(this.login).subscribe(response => {
        this.user=response
      if(this.user!=null)
      {
      if(this.user.role.toUpperCase()=="USER")
      {
        //landing to user dash-board
        localStorage.userId=this.user.userId;
        this.router.navigateByUrl('/user');
      }
      else
      {
          //landing to admin dash-board
          this.router.navigateByUrl('/admin');
      }
      }
      else
      console.log("Login Fail");
      })

    }


  }
  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }
  onReset() {

    this.submitted = false;
    this.loginForm.reset();
  }

}
