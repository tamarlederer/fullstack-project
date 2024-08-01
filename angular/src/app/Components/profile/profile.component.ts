import { Component } from '@angular/core';
import { AvatarModule } from 'primeng/avatar';
import { BadgeModule } from 'primeng/badge';
import { CarouselModule } from 'primeng/carousel';
import { ButtonModule } from 'primeng/button';
import { TagModule } from 'primeng/tag';
import { Appointment } from '../../Models/appointment';
import { Router } from '@angular/router';
import { AppointmentService } from '../../Services/appointment.service';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [AvatarModule, BadgeModule, CarouselModule, ButtonModule, TagModule],
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent {
  public appointmentList: Appointment[] |null|undefined;
  responsiveOptions: any[] = [];
constructor(private router:Router, private _appointmentService:AppointmentService){}
  ngOnInit() :void{
    this._appointmentService.getAllAppointments().subscribe({
      next:appointments=>{
        this.appointmentList=appointments
        console.log("Appointments Retrieved:",appointments);
        
      },
      error:err=>console.error("Error retrieving members:", err)
      
    });
  
    // this.appointmentList = [
    //   { image: 'assets/doctor1.png', name: 'Dr. Smith', status: 'Confirmed', date: '2024-07-03' },
    //   { image: '/assets/doctor2.png', name: 'Dr. Johnson', status: 'Pending', date: '2024-07-05' },
    //   { image: '/assets/doctor3.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
    //   { image: '/assets/doctor2.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
    //   { image: '/assets/doctor1.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
    //   { image: '/assets/doctor3.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },
    //   { image: '/assets/doctor1.png', name: 'Dr. Williams', status: 'Cancelled', date: '2024-07-07' },

    // ];

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

  getSeverity(status: number) {
    switch (status) {
      case 1:
        return 'success';
      case 2:
        return 'warning';
      default:
        return 'info';  // ברירת מחדל עבור ערכים לא מוכרים
    }
  }
}
