import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './Account/login/login.component';
import { RegisterComponent } from './Account/register/register.component';
import { AdditemComponent } from './Admin/additem/additem.component';
import { UpdateitemComponent } from './Admin/updateitem/updateitem.component';
import { ItemsComponent } from './Admin/items/items.component';
import { AccountService } from './Services/account.service';
import { UserService } from './Services/user.service';
import { AdminService } from './Services/admin.service';
import { SearchComponent } from './User/search/search.component';
import { AdmingDashboardComponent } from './Admin/adming-dashboard/adming-dashboard.component';
import { UserDashboardComponent } from './User/user-dashboard/user-dashboard.component';
import { PaymentComponent } from './User/payment/payment.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    AdditemComponent,
    UpdateitemComponent,
    ItemsComponent,
    SearchComponent,
    AdmingDashboardComponent,
    UserDashboardComponent,
    PaymentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [AccountService,UserService,AdminService],
  bootstrap: [AppComponent]
})
export class AppModule { }
