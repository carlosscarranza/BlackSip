import { Component, OnInit } from '@angular/core';
import { SitemenuService } from './sitemenu.service';
import { Router } from '@angular/router';
import { ISiteMenu } from './sitemenu';

@Component({
  selector: 'app-sitemenu',
  templateUrl: './sitemenu.component.html',
  styleUrls: ['./sitemenu.component.css']
})
export class SitemenuComponent implements OnInit {

  constructor(private siteMenuService: SitemenuService,
    private router: Router) { }

    sitemenu: ISiteMenu[];
    jsonsitemenu: string;

  ngOnInit() {
    this.siteMenuService.getMenu().subscribe(sitemenuWs => this.jsonsitemenu = sitemenuWs,
      error => console.error(error),
      () => { console.log(this.jsonsitemenu) });
  }
}
