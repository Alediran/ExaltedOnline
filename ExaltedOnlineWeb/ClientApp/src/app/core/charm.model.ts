import { Injectable } from '@angular/core';
import { Adapter } from './adapter';

export class Charm {
    constructor(
        public id: Number,
        public Name: String,
        public Essence: Number,
        public Description: String,
        public IsCustomCharm: Boolean,
    ) {}
}

@Injectable({
    providedIn: 'root'
})

export class CharmAdapter implements Adapter<Charm>{

    adapt(item: any): Charm {
        return new Charm(
            item.id,
            item.Name,
            item.Essence,
            item.Description,
            item.IsCustomCharm,
        );
    };
}
