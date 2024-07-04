import { Component } from '@angular/core';
import { AvatarModule } from 'primeng/avatar';
import { BadgeModule } from 'primeng/badge';
import { CarouselModule } from 'primeng/carousel';
import { ButtonModule } from 'primeng/button';
import { TagModule } from 'primeng/tag';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [AvatarModule, BadgeModule, CarouselModule, ButtonModule, TagModule],
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent {
  appointments: any[] = [];

  responsiveOptions: any[] = [];

  ngOnInit() {
    this.appointments = [
      { image: 'assets/doctor1.png', name: 'Dr. Smith', status: 'Confirmed', date: '2024-07-03' },
      { image: '/assets/doctor2.png', name: 'Dr. Johnson', status: 'Pending', date: '2024-07-05' },
      { image: '/assets/doctor3.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
      { image: '/assets/doctor2.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
      { image: '/assets/doctor1.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
      { image: '/assets/doctor3.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
      { image: '/assets/doctor1.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },

    ];

    this.responsiveOptions = [
      {
        breakpoint: '1199px',
        numVisible: 1,
        numScroll: 1
      },
      {
        breakpoint: '991px',
        numVisible: 2,
        numScroll: 1
      },
      {
        breakpoint: '767px',
        numVisible: 1,
        numScroll: 1
      }
    ];
  }

  getSeverity(status: string) {
    switch (status) {
      case 'Confirmed':
        return 'success';
      case 'Pending':
        return 'warning';
      case 'Cancelled':
        return 'danger';
      default:
        return 'info';  // ברירת מחדל עבור ערכים לא מוכרים
    }
  }
}
