import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IVisitante } from './visitante';

@Injectable()
export class VisitanteService {

  private baseUrl = "https://localhost:44389";
  //private baseUrl = "http://localhost:60492";
  private controller = "/api/visitante/";

  private apiUrlCreateVisitante = this.baseUrl + this.controller + "CreateVisitante";
  private apiUrlGetVisitantesProcesados = this.baseUrl + this.controller + "GetVisitantesProcesados";

  constructor(private http: HttpClient) { }
  
  createVisitante(visitante: IVisitante): Observable<number> {
    return this.http.post<number>(this.apiUrlCreateVisitante, visitante);
  }

  getVisitantesProcesados(): Observable<IVisitante[]> {
    return this.http.get<IVisitante[]>(this.apiUrlGetVisitantesProcesados);
  }
}
