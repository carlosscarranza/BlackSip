import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VisitanteComponent } from './visitante/visitante.component';
import { SitemenuComponent } from './sitemenu/sitemenu.component';
import { RegistrovisitanteComponent } from './registrovisitante/registrovisitante.component';
import { MenugijgoComponent } from './menugijgo/menugijgo.component';

const routes: Routes = [
  { path: "visitante", component: VisitanteComponent },
  { path: "sitemenu", component: SitemenuComponent },
  { path: "registrovisitante", component: RegistrovisitanteComponent },
  { path: "menugijgo", component: MenugijgoComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
