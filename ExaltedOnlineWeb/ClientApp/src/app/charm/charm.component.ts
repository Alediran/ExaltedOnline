import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

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
    charm: Object;

    constructor(private http: HttpClient) { }

    ngOnInit() {
        this.readCharm();
    }

    readCharm() {
        this.http.get('http://localhost:65069/api/Charms/Charms/1').subscribe(
            (response: Response) => { this.charm = response.json(); });
    }
}
