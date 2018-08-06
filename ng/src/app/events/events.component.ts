import { Component, OnInit } from '@angular/core';
import { Event } from '../event';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {
  title = 'no events'
  event: Event = {
    id: 1,
    start: new Date('2018-08-16'),
    title: 'dob',
  }
  events: Event[] = [{
    id: 1,
    start: new Date('2018-08-16'),
    title: 'dob',
    url: 'https://prasanjeevi.github.io'
  },{
    id: 2,
    start: new Date('2018-09-02'),
    title: 'Prasanna',
  }]

  constructor() { }

  ngOnInit() {
  }

  onSave() {
  }
}
