import { Injectable } from "@angular/core";
import { Adapter } from "../adapter";
import { Charm } from "./charm.structure";

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

export class User {
  public password: string;
  public id?: number;
  public userName: string;
  public email: string;
  public passwordHash: string;
  public passwordSalt: string;
  public userRole: number;
  public signatureFirst: string;

  constructor() {
    this.id = 0;
    this.userName = "";
    this.email = "";
    this.passwordSalt = "";
    this.passwordHash = "";
    this.userRole = 1;
    this.signatureFirst = "";
  }
}
