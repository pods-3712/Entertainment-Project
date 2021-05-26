import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EntquestionandanswersComponent } from './EntQuestionandAnswers/components/entquestionandanswers/entquestionandanswers.component';

const routes: Routes = [
  {path: 'Entertainment', component: EntquestionandanswersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
