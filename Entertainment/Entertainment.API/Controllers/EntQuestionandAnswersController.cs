using Entertainment.API.Models;
using Entertainment.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Entertainment.API.Controllers
{
    [ApiController]
    public class EntQuestionandAnswersController : Controller
    {
        [HttpGet("/getQuestAns")]
        public ActionResult<List<QuestionandAnswers>> GetQuestionandAnswerLists()
        {
            EntQuestionandAnswersSevice entQuestionandAnswersSevice = new EntQuestionandAnswersSevice();
            List<QuestionandAnswers> queandanslist = entQuestionandAnswersSevice.GetQuestionandAnswerLists();
            return queandanslist;
        }
    }
}
