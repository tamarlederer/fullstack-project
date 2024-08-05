import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from '../Models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  baseUrl = 'https://localhost:7223/api/Category';

  constructor(private httpClient: HttpClient) { }

  getAllCategories(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(`${this.baseUrl}`)
  }

  getCategoryById(id: number): Observable<Category> {
    return this.httpClient.get<Category>(`${this.baseUrl}/${id}`)
  }
  postCategory(formData: FormData): Observable<Category> {
    return this.httpClient.post<Category>(`${this.baseUrl}`, formData)
  }
  putCategory(id: number, formData: FormData): Observable<Category> {
    return this.httpClient.put<Category>(`${this.baseUrl}/${id}`, formData)
  }
  deleteCategory(id: number): Observable<Category> {
    return this.httpClient.delete<Category>(`${this.baseUrl}/${id}`)
  }
}