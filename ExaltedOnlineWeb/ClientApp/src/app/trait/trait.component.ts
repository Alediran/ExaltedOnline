import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-trait',
    templateUrl: './trait.component.html',
    styleUrls: ['./trait.component.scss']
})
export class TraitComponent implements OnInit {
    Name: String = "Strength";
    MinValue: number = 1;
    MaxValue: number = 5;
    CurrentValue: number = 2;
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
    }

    setCurrent(currentValue: number) {
        this.CurrentValue = currentValue;
        var i;

        for (i = 0; i < this.MaxValue; i++) {
            this.checklist[i].isSelected = (i <= Math.max(this.MinValue, this.CurrentValue)) ? true : false;
        }
    }

}
