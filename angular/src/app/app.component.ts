import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TopBarComponent } from './Components/top-bar/top-bar.component';
import { FooterComponent } from './Components/footer/footer.component';
import { HomepageComponent } from './Components/homepage/homepage.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { CommonModule } from '@angular/common';
import { PrimeNGConfig } from 'primeng/api';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule, TopBarComponent, FooterComponent, HomepageComponent, ProfileComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular-project';
}
