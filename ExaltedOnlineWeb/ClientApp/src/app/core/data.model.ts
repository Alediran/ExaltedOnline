import { Injectable } from '@angular/core';
import { Adapter } from './adapter';

@Injectable({
    providedIn: 'root'
})

export class CharmModel {
    constructor(
        public message: String,
        public didError: Boolean,
        public errorMessage: String,
        public model: Charm[],
        public pageSize: Number,
        public pageNumber: Number,
        public itemsCount: Number,
        public pageCount: Number
    ) {}
}

export class BoolModel {
    constructor(
        public message: String,
        public didError: Boolean,
        public errorMessage: String,
        public model: Boolean
    ) {}
}

export class Charm {
    constructor(
        public characterCharms: any[],
        public charmCosts: any[],
        public charmKeywords: any[],
        public charmPrerequisites: any[],
        public charmPrerequisitescharmPrerequisite: any[],
        public charmTraits: any[],
        public description: String,
        public duration: any,
        public durationId: Number,
        public essence: Number,
        public gameId: Number,
        public id: Number,
        public isCustomCharm: Boolean,
        public title: String,
        public treeTypeId: Number,
        public type: any,
        public typeId: Number
    ) {}
}

export class CharmModelAdapter implements Adapter<CharmModel>{

    adapt(item: any): CharmModel {
        return new CharmModel(
            item.message,
            item.didError,
            item.errorMessage,
            item.model,
            item.pageSize,
            item.pageNumber,
            item.itemsCount,
            item.pageCount,
        );
    };
}

export class CharmAdapter implements Adapter<Charm>{

    adapt(item: any): Charm {
        return new Charm(
            item.characterCharms,
            item.charmCosts,
            item.charmKeywords,
            item.charmPrerequisites,
            item.charmPrerequisitescharmPrerequisite,
            item.charmTraits,
            item.description,
            item.duration,
            item.durationId,
            item.essence,
            item.gameId,
            item.id,
            item.isCustomCharm,
            item.name,
            item.treeTypeId,
            item.type,
            item.typeId
        );
    };
}

export class User {

    public password: string;
    public id?: number;
    public userName: string;
    public passwordHash: string;
    public passwordSalt: string;
    public userRole: number;
    public signatureFirst: string;

    constructor() {
        this.id = 0;
        this.passwordSalt = '';
        this.passwordHash = '';
        this.userRole = 1;
        this.signatureFirst = '';

    }
}

