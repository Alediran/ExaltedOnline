import { Injectable } from "@angular/core";
import { Adapter } from "./adapter";

export interface CharmModel {
  message: String;
  didError: Boolean;
  errorMessage: String;
  model: Charm[];
  pageSize: Number;
  pageNumber: Number;
  itemsCount: Number;
  pageCount: Number;
}

export interface BoolModel {
  message: String;
  didError: Boolean;
  errorMessage: String;
  model: Boolean;
}

export interface Charm {
  characterCharms: any[];
  charmCosts: any[];
  charmKeywords: any[];
  charmPrerequisites: any[];
  charmPrerequisitescharmPrerequisite: any[];
  charmTraits: any[];
  description: String;
  duration: any;
  durationId: Number;
  essence: Number;
  gameId: Number;
  id: Number;
  isCustomCharm: Boolean;
  title: String;
  treeTypeId: Number;
  type: any;
  typeId: Number;
}

//export class CharmModelAdapter implements Adapter<CharmModel>{

//    adapt(item: any): CharmModel {
//        return new CharmModel(
//            item.message,
//            item.didError,
//            item.errorMessage,
//            item.model,
//            item.pageSize,
//            item.pageNumber,
//            item.itemsCount,
//            item.pageCount,
//        );
//    };
//}

export interface User {
  password: string;
  id?: number;
  userName: string;
  email: string;
  passwordHash: string;
  passwordSalt: string;
  userRole: number;
  signatureFirst: string;
}
