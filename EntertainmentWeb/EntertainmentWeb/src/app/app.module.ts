import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from  '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EntquestionandanswersComponent } from './EntQuestionandAnswers/components/entquestionandanswers/entquestionandanswers.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EntquestionandanswersService } from './EntQuestionandAnswers/services/entquestionandanswers.service';

@NgModule({
  declarations: [
    AppComponent,
    EntquestionandanswersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [EntquestionandanswersService],
  bootstrap: [AppComponent]
})
export class AppModule { }
