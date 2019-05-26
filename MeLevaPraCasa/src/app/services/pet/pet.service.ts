import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Pet } from 'src/app/models/pet';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const apiUrl = 'http://angelhackapi-dev.us-west-2.elasticbeanstalk.com/';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  constructor(
    private _httpClient: HttpClient
  ) { }

  getPets(): Observable<Pet[]> {
    return this._httpClient.get<Pet[]>(apiUrl)
      .pipe(
        tap(pets => console.log('leu os pets')),
        catchError(this.handleError('getPets', []))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }

}
