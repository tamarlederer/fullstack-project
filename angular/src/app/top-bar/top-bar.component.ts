import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { TabMenuModule } from 'primeng/tabmenu';
import { Router, RouterModule } from '@angular/router';


@Component({
  selector: 'app-top-bar',
  standalone: true,
  imports: [RouterModule, TabMenuModule],
  templateUrl: './top-bar.component.html',
  styleUrl: './top-bar.component.css'
})
export class TopBarComponent implements OnInit{
  items: MenuItem[] | undefined;

  ngOnInit() {
      this.items = [
          { label: 'Profile', icon: 'pi pi-user', routerLink: '/profile' },
          { label: 'Transactions', icon: 'pi pi-chart-line', routerLink: '/home' },
          { label: 'Products', icon: 'pi pi-list', routerLink: '/home' },
          { label: 'Messages', icon: 'pi pi-inbox', routerLink: '/home' }
      ]
  }

}
