import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgxPrettyCheckboxModule } from 'ngx-pretty-checkbox';

import { AppComponent } from './app.component';
import { CircularCheckComponent } from './circular-check/circular-check.component';
import { TraitComponent } from './trait/trait.component';
import { CharmComponent } from './charm/charm.component';
import { CharacterSheetComponent } from './character-sheet/character-sheet.component';

const RoutesApp: Routes = [
    { path: 'charm', component:CharmComponent }

]


@NgModule({
  declarations: [
        AppComponent,
        CircularCheckComponent,
        TraitComponent,
        CharmComponent,
        CharacterSheetComponent
  ],
    imports: [
        RouterModule.forRoot(RoutesApp),
      BrowserModule,
      NgxPrettyCheckboxModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
