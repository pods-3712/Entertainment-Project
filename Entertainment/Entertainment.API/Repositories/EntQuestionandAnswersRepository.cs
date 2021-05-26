using Entertainment.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Entertainment.API.Repositories
{
    public class EntQuestionandAnswersRepository : IEntQuestionandAnswersRepository
    {
        public EntQuestionandAnswers GetQuestionandAnswerLists()
        {
            try
            {
                EntQuestionandAnswers entQuestionandAnswers = new EntQuestionandAnswers();
                entQuestionandAnswers.response_code = 0;
                List<Result> results = new List<Result>()
                {
                     new Result()
                     {
                        category = "Entertainment: Books",
                        type =  "multiple",
                        difficulty = "hard",
                        question = "In the Fallout series, on which date did The Great War happen?",
                        correct_answer = "October 23rd, 2077",
                        incorrect_answers = new List<string>()
                        {
                            "May 15th, 2058",
                            "December 14th, 2069",
                            "November 5th, 2076"
                        }
                     },
                     new Result()
                     {
                        category = "History",
                        type =  "multiple",
                        difficulty = "hard",
                        question = "What was found in 1946 by two young shepards near a cave?",
                        correct_answer = "Dead Sea Scrolls",
                        incorrect_answers = new List<string>()
                        {
                            "The Blackbeard Chest",
                            "Sheep",
                            "The First Oaxaca Cave Sleeper"
                        }
                     },
                     new Result()
                     {
                        category = "General Knowledge",
                        type =  "multiple",
                        difficulty = "medium",
                        question = "What is the Portuguese word for Brazil?",
                        correct_answer = "Brasil",
                        incorrect_answers = new List<string>()
                        {
                            "Brazil",
                            "Brasilia",
                            "Brasiacutel"
                        }
                     },
                     new Result()
                     {
                        category = "Geography",
                        type =  "multiple",
                        difficulty = "medium",
                        question = "What are the four corner states of the US?",
                        correct_answer = "Utah, Colorado, Arizona, New Mexico",
                        incorrect_answers = new List<string>()
                        {
                            "Oregon, Idaho, Nevada, Utah",
                            "Kansas, Oklahoma, Arkansas, Louisiana",
                            "South Dakota, Minnesota, Nebraska, Iowa"
                        }
                     },
                     new Result()
                     {
                        category = "Mythology",
                        type =  "multiple",
                        difficulty = "easy",
                        question = "Who in Greek mythology, who led the Argonauts in search of the Golden Fleece?",
                        correct_answer = "Jason",
                        incorrect_answers = new List<string>()
                        {
                            "Castor",
                            "Daedalus",
                            "Odysseus"
                        }
                     }
                };
                entQuestionandAnswers.results = results;
                return entQuestionandAnswers;

            }
            catch (Exception)
            {

                throw ;
            } 

        }
    }
}
