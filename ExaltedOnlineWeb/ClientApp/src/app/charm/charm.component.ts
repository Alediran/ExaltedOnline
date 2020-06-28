import { Component, OnInit, Input } from "@angular/core";
import { ApiService } from "../core/api.service";
import { CharmModel } from "../core/model/data.model";

@Component({
  selector: "app-charm",
  templateUrl: "./charm.component.html",
  styleUrls: ["./charm.component.scss"],
})
export class CharmComponent implements OnInit {
  @Input() Name: string = "Wise Arrow";
  @Input() Cost: string = "1m";
  @Input() Mins: string = "Archery 2, Essence 1";
  @Input() Description: string = "Your arror makes a <b>mess</b> of the enemy ";
  charmModel: CharmModel;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.loadCharm();
  }

  loadCharm() {
    this.apiService.getCharm(1).subscribe((data: CharmModel) => {
      this.charmModel = data;
      console.log(this.charmModel);
    });
  }
}
