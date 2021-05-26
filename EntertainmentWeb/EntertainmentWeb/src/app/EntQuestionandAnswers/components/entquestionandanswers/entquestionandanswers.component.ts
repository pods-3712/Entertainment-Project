import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import {EntquestionandanswersService} from '../../services/entquestionandanswers.service';

@Component({
  selector: 'app-entquestionandanswers',
  templateUrl: './entquestionandanswers.component.html',
  styleUrls: ['./entquestionandanswers.component.scss'],
})

export class EntquestionandanswersComponent implements OnInit {
  pages: any = [];
  myForm: FormGroup;
  CorrectAnswer = 0;
  IncorrectAnswer = 0;
  show: boolean = false;
  emptyAnswer = 0;
 
  constructor(private entQuestionandAnswersService: EntquestionandanswersService, private formbuilder:  FormBuilder) {
  }

  ngOnInit() {
    this.getquestanswerlist();
    this.onrefresh();
  }


  getquestanswerlist() {
    this.entQuestionandAnswersService.getPages().subscribe(data => {
      this.pages = data;
      this.myForm = this.formbuilder.group({
        answeropt: this.formbuilder.array([])
      });
      for (var i = 0; i < this.pages.length; i++) {
        (<FormArray>this.myForm.get('answeropt')).push(new FormControl());
      }
    });
  }

  onrefresh() {
    this.entQuestionandAnswersService.getPages().subscribe(data => {
      this.pages = data;
      var currentIndex = this.pages.length, temporaryValue, randomIndex;

      // While there remain elements to shuffle...
      while (0 !== currentIndex) {

        // Pick a remaining element...
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex -= 1;

        // And swap it with the current element.
        temporaryValue = this.pages[currentIndex];
        this.pages[currentIndex] = this.pages[randomIndex];
        this.pages[randomIndex] = temporaryValue;
      }
    });
  }

  onSubmit() {
    this.emptyAnswer = 0;
    var allans = true;
    for (let i = 0; i < this.myForm.value.answeropt.length; i++) {
      if (this.myForm.value.answeropt[i] == null) {
        allans = false;
        this.emptyAnswer++ 
      } 
    }
     this.showPopup(this.emptyAnswer);
    
    if (allans) {
      for (let j = 0; j < this.pages.length; j++) {
        if (this.myForm.value.answeropt[j] == this.pages[j].correctAns) {
          this.CorrectAnswer++;
        }
        else {
          this.IncorrectAnswer++;
        }
      }
    } 
  }
  showPopup(incorrectcount : any) {
    if(incorrectcount > 0)
    {
    this.show = true;
    }
  }
}
