import { Routes } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';

export const routes: Routes = [
    { path: "", redirectTo: "homepage", pathMatch: "full" },
    { path: 'profile', component: SignInComponent },
    { path: 'sign-up', component: SignUpComponent },
    { path: 'sign-in', component: SignInComponent },

    { path: 'transactions', component: ProfileComponent },
    { path: 'products', component: ProfileComponent },
    { path: 'messages', component: ProfileComponent },
    { path: "top-bar", loadComponent: () => import('./top-bar/top-bar.component').then(c => c.TopBarComponent) },
    { path: "homepage", loadComponent: () => import('./homepage/homepage.component').then(c => c.HomepageComponent) },
    { path: "footer", loadChildren: () => import('./footer/footer.component').then(m => m.FooterComponent) },
    // { path: "sign-up", loadChildren: () => import('./sign-up/sign-up.component').then(m => m.SignUpComponent) },

    // { path: "profile", loadChildren: () => import('./profile/profile.component').then(m => m.ProfileComponent) }

];
