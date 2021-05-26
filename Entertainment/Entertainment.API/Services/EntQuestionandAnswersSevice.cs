using Entertainment.API.Models;
using Entertainment.API.Repositories;
using System.Collections.Generic;

namespace Entertainment.API.Services
{
    public class EntQuestionandAnswersSevice : IEntQuestionandAnswersSevice
    {
        public List<QuestionandAnswers> GetQuestionandAnswerLists()
        {
            EntQuestionandAnswersRepository _entQuestionandAnswersRepository = new EntQuestionandAnswersRepository();
            var response = _entQuestionandAnswersRepository.GetQuestionandAnswerLists();
            List<Result> resultquestans = response.results;
            List<QuestionandAnswers> questionandAnswers = new List<QuestionandAnswers>();
            foreach (Result re in resultquestans)
            {
                QuestionandAnswers questionandAnswer = new QuestionandAnswers();
                questionandAnswer.question = re.question;
                List<string> op = new List<string>();
                op.Add(re.correct_answer);
                foreach (string s in re.incorrect_answers)
                {
                    op.Add(s);
                }
                questionandAnswer.options = op;
                questionandAnswer.correctAns = re.correct_answer;
                questionandAnswers.Add(questionandAnswer);
            }
            return questionandAnswers;
        }
    }
}
