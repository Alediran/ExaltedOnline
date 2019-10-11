import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgxPrettyCheckboxModule } from 'ngx-pretty-checkbox';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ApiService } from './core/api.service'
import { CircularCheckComponent } from './circular-check/circular-check.component';
import { TraitComponent } from './trait/trait.component';
import { CharmComponent } from './charm/charm.component';
import { CharacterSheetComponent } from './character-sheet/character-sheet.component';

const RoutesApp: Routes = [
    { path: 'charm', component: CharmComponent },
    { path: 'trait', component: TraitComponent }

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
        HttpClientModule,
        NgxPrettyCheckboxModule
  ],
    providers: [ApiService],
    bootstrap: [AppComponent]
})
export class AppModule { }
