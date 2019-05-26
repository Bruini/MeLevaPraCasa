import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Pet } from 'src/app/models/pet';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const apiUrl = 'https://localhost:5001/';
const feed = apiUrl + 'api/pet';
const score = apiUrl + 'api/pet/Match';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  constructor(
    private _httpClient: HttpClient
  ) { }

  getPets(): Observable<Pet[]> {
    return this._httpClient.get<Pet[]>(feed)
      .pipe(
        tap(pets => console.log('leu os pets')),
        catchError(this.handleError('getPets', []))
      );
  }

  getScore(): Observable<Pet[]> {
    return this._httpClient.get<Pet[]>(score)
      .pipe(
        tap(score => console.log('leu os score')),
        catchError(this.handleError('getScore', []))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }

}
