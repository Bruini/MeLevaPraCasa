import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Pet } from 'src/app/models/pet';
import { ApiResult } from 'src/app/interfaces/cadastro.interface';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const apiUrl = 'https://angelhackapi.azurewebsites.net/';
const feed = apiUrl + 'api/pet';
const score = apiUrl + 'api/pet/Match';
const cadastro = apiUrl + 'api/pet/Cadastro';

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
        tap(scored => console.log('leu os score')),
        catchError(this.handleError('getScore', []))
      );
  }

  postPet(pet: Pet) {
		return this._httpClient.post<ApiResult<Pet>>(cadastro, pet);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }

}
