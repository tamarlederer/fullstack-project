import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Doctor } from '../Models/doctor';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {

  baseUrl = 'hhttps://localhost:7223/api/Doctor';

  constructor(private httpClient: HttpClient) { }

  getAllDoctors(): Observable<Doctor[]> {
    return this.httpClient.get<Doctor[]>(`${this.baseUrl}`)
  }

  getDoctorById(id: number): Observable<Doctor> {
    return this.httpClient.get<Doctor>(`${this.baseUrl}/${id}`)
  }
  postDoctor(formData: FormData): Observable<Doctor> {
    return this.httpClient.post<Doctor>(`${this.baseUrl}`, formData)
  }
  putDoctor(id: number, formData: FormData): Observable<Doctor> {
    return this.httpClient.put<Doctor>(`${this.baseUrl}/${id}`, formData)
  }
  deleteDoctor(id: number): Observable<Doctor> {
    return this.httpClient.delete<Doctor>(`${this.baseUrl}/${id}`)
  }
}