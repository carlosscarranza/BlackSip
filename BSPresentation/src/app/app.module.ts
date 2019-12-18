import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VisitanteComponent } from './visitante/visitante.component';
import { SitemenuComponent } from './sitemenu/sitemenu.component';

@NgModule({
  declarations: [
    AppComponent,
    VisitanteComponent,
    SitemenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
