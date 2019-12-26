import { Component, OnInit, ViewChild } from '@angular/core'
import { Router } from '@angular/router';
import { TreeComponent } from 'gijgo-angular-wrappers'
import * as types from 'gijgo'

@Component({
  selector: 'app-menugijgo',
  templateUrl: './menugijgo.component.html',
  styleUrls: ['./menugijgo.component.css']
})

export class MenugijgoComponent implements OnInit {

  @ViewChild("tree", {static: true}) tree: TreeComponent;
  configuration: types.TreeSettings;

  constructor(private router: Router) {
    this.configuration = {
      dataSource: [ 
        { text: 'Home', url: '/',
            children: [ 
              { text: 'Node 1.1', url: '/' }, 
              { text: 'Node 1.2' },  
              { text: 'Node 1.3' } 
            ] 
        },
        { text: 'Visitante', url: '/visitante',
            children: 
            [ 
              { text: 'Node 2.1', url: '/visitante' }, 
              { text: 'Node 2.2' } 
            ] 
        },
        { text: 'Reporte',  url: '/registrovisitante',
            children:
            [ 
              { text: 'Node 3.1', 
                  children: 
                  [ 
                    { text: 'Node 3.1.1', url: '/registrovisitante' } 
                  ] 
              }, 
              { text: 'Node 3.2' } 
            ] 
        }
      ],
      uiLibrary: 'bootstrap4',
      select: (e, node, id) => {
        var node = this.tree.instance.getDataById(id);
        this.router.navigate([node["url"]]);
      }
    };
  }

  expandAll() {
    this.tree.instance.expandAll();
  }

  collapseAll() {
    this.tree.instance.collapseAll();
  } 

  ngOnInit() {
    
  }

}
