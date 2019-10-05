import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgxPrettyCheckboxModule } from 'ngx-pretty-checkbox';

import { AppComponent } from './app.component';
import { CircularCheckComponent } from './circular-check/circular-check.component';
import { TraitComponent } from './trait/trait.component';

@NgModule({
  declarations: [
        AppComponent,
        CircularCheckComponent,
        TraitComponent
  ],
  imports: [
      BrowserModule,
      NgxPrettyCheckboxModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
