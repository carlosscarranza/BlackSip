import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { ISiteMenu } from './sitemenu';

@Injectable()
export class SitemenuService {

    private baseUrl = "https://localhost:44389";
    private controller = "/api/sitemenu/";

    private apiUrlGetMenu = this.baseUrl + this.controller + "GetMenu";

    constructor(private http: HttpClient) { }
    
    getMenu(): Observable<string> {
      return this.http.get<string>(this.apiUrlGetMenu)};
    }

