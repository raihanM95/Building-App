import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Building } from './Building.model';
import { DataField } from './datafield.model';
import { Object } from './object.model';


@Injectable({
  providedIn: 'root'
})
export class DropdownService {

  readonly baseURL = 'https://localhost:44301/api/';

  formData: Building= new Building();
  buildingList: Building[] = [];
  objectList: Object[] = [];
  dataFieldList: DataField[] = [];


  constructor(private http: HttpClient) { }

  getBuildingList() {
    this.http.get(this.baseURL + "Building")
      .toPromise()
      .then(res =>this.buildingList = res as Building[]);
  }

  getObjectList() {
    this.http.get(this.baseURL + "Object")
      .toPromise()
      .then(res =>this.objectList = res as Object[]);
  }

  getDataFieldList() {
    this.http.get(this.baseURL + "DataField")
      .toPromise()
      .then(res =>this.dataFieldList = res as DataField[]);
  }
}
