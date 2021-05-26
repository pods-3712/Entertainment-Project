using Entertainment.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entertainment.API.Repositories
{
   public  interface IEntQuestionandAnswersRepository
    {
        EntQuestionandAnswers GetQuestionandAnswerLists();
    }
}
