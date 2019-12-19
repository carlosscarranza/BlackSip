import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VisitanteComponent } from './visitante/visitante.component';
import { SitemenuComponent } from './sitemenu/sitemenu.component';
import { RegistrovisitanteComponent } from './registrovisitante/registrovisitante.component';

const routes: Routes = [
  { path: "visitante", component: VisitanteComponent },
  { path: "sitemenu", component: SitemenuComponent },
  { path: "registrovisitante", component: RegistrovisitanteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
