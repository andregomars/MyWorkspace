//*** TODO: Import the Component and OnInit objects from @angular/core
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-component',
  templateUrl: 'app.component.html'
})
export class AppComponent implements OnInit {

  filmTitle: string;        //Title of the film
  characters: any[];        //A string array
  selectedCharacter: any;   //A character from the heroes array

  constructor() {  }

  ngOnInit() {

    this.characters = [
      { name: 'Kylo Ren', theme: 'red' },
      { name: 'Darth Vader', theme: 'black' },
      { name: 'Rey', theme: 'gray' },
      { name: 'Luke Skywalker', theme: 'blue' }
    ];

    /***
          TODO: Assign a value to the filmTitle and selectedCharacter properties.
                The selectedCharacter property should be
                assigned a member from  the characters array
                (such as the first item in the array).
    ***/
    this.filmTitle = 'Avengers';
    // this.selectedCharacter =
    //   { name: 'Darth Vader', theme: 'black' };
  }

}
