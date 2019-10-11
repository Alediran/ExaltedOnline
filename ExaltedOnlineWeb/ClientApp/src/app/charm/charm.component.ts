import { Component, OnInit, Input } from '@angular/core';
import { ApiService } from '../core/api.service';
import { Observable } from 'rxjs';
import { Charm } from '../core/charm.model';

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
    charm: any;

    constructor(private apiService: ApiService) { }

    ngOnInit() {
        this.loadCharm();
    }

    loadCharm() {
        this.apiService.getCharm(1).subscribe(response => {
            console.log(response);
            this.charm = response;
        });
    }
}
