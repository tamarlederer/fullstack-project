import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Appointment } from '../Models/appointment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  baseUrl = 'https://localhost:7223/api/Appointment';

  constructor(private httpClient: HttpClient) { }

  getAllAppointments(): Observable<Appointment[]> {
    return this.httpClient.get<Appointment[]>(`${this.baseUrl}`)
  }

  getAppointmentById(id: number): Observable<Appointment> {
    return this.httpClient.get<Appointment>(`${this.baseUrl}/${id}`)
  }
  postAppointment(formData: FormData): Observable<Appointment> {
    return this.httpClient.post<Appointment>(`${this.baseUrl}`, formData)
  }
  putUAppointment(id: number, formData: FormData): Observable<Appointment> {
    return this.httpClient.put<Appointment>(`${this.baseUrl}/${id}`, formData)
  }
  deleteAppointment(id: number): Observable<Appointment> {
    return this.httpClient.delete<Appointment>(`${this.baseUrl}/${id}`)
  }
}