import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-charm',
  templateUrl: './charm.component.html',
  styleUrls: ['./charm.component.scss']
})
export class CharmComponent implements OnInit {

    @Input() Name: string = 'Wise Arrow';
    @Input() Cost: string = '1m';
    @Input() Mins: string = 'Archery 2, Essence 1';
    @Input() Description: string = 'Your arror makes a <b>mess</b> of the enemy ';

  constructor() { }

    ngOnInit() {
       
  }    
}
