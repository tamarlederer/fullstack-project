import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Doctor } from '../Models/doctor';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {

  baseUrl = 'hhttps://localhost:7223/api/Doctor';

  constructor(private _httpClient: HttpClient) { }

  getAllDoctors(): Observable<Doctor[]> {
    return this._httpClient.get<Doctor[]>(`${this.baseUrl}`)
  }

  getDoctorById(id: number): Observable<Doctor> {
    return this._httpClient.get<Doctor>(`${this.baseUrl}/${id}`)
  }
  postDoctor(formData: FormData): Observable<Doctor> {
    return this._httpClient.post<Doctor>(`${this.baseUrl}`, formData)
  }
  putDoctor(id: number, formData: FormData): Observable<Doctor> {
    return this._httpClient.put<Doctor>(`${this.baseUrl}/${id}`, formData)
  }
  deleteDoctor(id: number): Observable<Doctor> {
    return this._httpClient.delete<Doctor>(`${this.baseUrl}/${id}`)
  }
}