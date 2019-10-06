import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'app-trait',
    templateUrl: './trait.component.html',
    styleUrls: ['./trait.component.scss']
})
export class TraitComponent implements OnInit {
    @Input() Name: String = "Strength";
    @Input() MinValue: number = 2;
    @Input() MaxValue: number = 5;
    @Input() CurrentValue: number = 0;

    checklist: any = [];
    checkedList: any = [];

    constructor() {      
    }

    ngOnInit() {
        
        var i;

        for (i = 0; i < this.MaxValue; i++) {
            this.checklist.push({ id: i, isSelected: (i + 1 <= Math.max(this.MinValue, this.CurrentValue)) ? true : false });
        }
    }

    getCheckedItem(ev, index) {
        if (ev.target.checked == true) {
            this.checkedList.push(ev.target.value);
        }
        else {
            // removing any entry if user unchecked any previously selected value
            for (let i = 0; i < this.checkedList.length; i++) {
                if (this.checkedList[i] == ev.target.value) {
                    this.checkedList.splice(i, 1);
                    this.checklist[i].isSelected = false;
                }
            }
        }

        document.documentElement.style.setProperty('--color-dark', 'red');
    }

    setCurrent(currentValue: number) {
        
        var i;

        if (currentValue == 1 && this.CurrentValue == 1 && this.checklist[currentValue - 1].isSelected)
            currentValue = 0;
        
        this.CurrentValue = currentValue;

        for (i = 0; i < this.MaxValue; i++) {
            this.checklist[i].isSelected = (i < Math.max(this.MinValue, this.CurrentValue)) ? true : false;
        }
    }
}
