using Entertainment.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entertainment.API.Services
{
    public interface IEntQuestionandAnswersSevice
    {
        List<QuestionandAnswers> GetQuestionandAnswerLists();
    }
}
