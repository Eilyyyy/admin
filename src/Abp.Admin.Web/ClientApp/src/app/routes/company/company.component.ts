import { Component, OnInit } from '@angular/core';
import { STColumn } from '@delon/abc';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styles: []
})
export class CompanyComponent implements OnInit {

  params: { name?: string } = {};
  url = '/api/company';
  columns: STColumn[] = [
    { title: '名称', index: 'companyName' },
    { title: '地址', index: 'address' }
  ];

  constructor() { }

  ngOnInit() {
  }

}
