using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entertainment.API.Models
{
    public class QuestionandAnswers
    {
        public string question { get; set; }

        public List<string> options { get; set; }

        public string correctAns { get; set; }
    }
}
