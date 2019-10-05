import { Component, OnInit, Input, HostListener } from '@angular/core';

@Component({
  selector: 'app-circular-check',
  templateUrl: './circular-check.component.html',
  styleUrls: ['./circular-check.component.scss']
})
export class CircularCheckComponent implements OnInit {
    @Input() Position: Number = 0;
    @Input() Name: string;
    @Input() Checked: boolean;
    Id: string;
    check: HTMLInputElement;

    constructor() {

        this.Checked = false;
    }

    ngOnInit() {
        
    }

    ngAfterContentChecked() {
        this.Id = this.Name + '_' + this.Position;

        this.check = document.getElementById(this.Name + '_' + this.Position) as HTMLInputElement;

        if (this.check != null)
            this.check.checked = this.Checked;
    }
}
