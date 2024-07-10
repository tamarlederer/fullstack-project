import { Component, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
@Component({
  selector: 'app-sign-in',
  standalone: true,
  imports: [FormsModule,RouterModule],
  templateUrl: './sign-in.component.html',
  styleUrl: './sign-in.component.css'
})
export class SignInComponent {
  email: string = '';
  password: string = '';

  constructor() {}

  login() {
    // כאן תוסיף את הקוד לפעולת ההתחברות
    console.log('Email:', this.email);
    console.log('Password:', this.password);
    // לדוגמה, תוסיף איך לבצע אימות או לשלוח בקשת HTTP
    // לשרת כדי לבדוק את ההתחברות
  }
}


