import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { VisitanteComponent } from './visitante/visitante.component';
import { SitemenuComponent } from './sitemenu/sitemenu.component';

import { SitemenuService } from './sitemenu/sitemenu.service';
import { VisitanteService } from './visitante/visitante.service';


@NgModule({
  declarations: [
    AppComponent,
    VisitanteComponent,
    SitemenuComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule, 
    AppRoutingModule
  ],
  providers: [SitemenuService, VisitanteService],
  bootstrap: [AppComponent]
})
export class AppModule { }
