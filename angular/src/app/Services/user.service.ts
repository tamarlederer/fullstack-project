import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl = 'https://localhost:7223/api/User';

  constructor(private _httpClient: HttpClient) { }

  getAllUsers(): Observable<User[]> {
    return this._httpClient.get<User[]>(`${this.baseUrl}`)
  }

  getUserById(id: number): Observable<User> {
    return this._httpClient.get<User>(`${this.baseUrl}/${id}`)
  }
  postUser(formData: FormData): Observable<User> {
    return this._httpClient.post<User>(`${this.baseUrl}`, formData)
  }
  putUser(id: number, formData: FormData): Observable<User> {
    return this._httpClient.put<User>(`${this.baseUrl}/${id}`, formData)
  }
  deleteUser(id: number): Observable<User> {
    return this._httpClient.delete<User>(`${this.baseUrl}/${id}`)
  }
}