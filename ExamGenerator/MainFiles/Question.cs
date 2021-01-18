using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator
{
    public class Question
    {
        public List<string> Tags { get; set; }
        public string QuestionBody { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public string CorrectAnswer { get; set; }
        public string Difficulty { get; set; }

        public Question(List<string> tags, string questionBody, List<string> possibleAnswers, string correctAnswer, string difficulty)
        {
            Tags = tags;
            QuestionBody = questionBody;
            PossibleAnswers = possibleAnswers;

            if (possibleAnswers.Contains(correctAnswer))
                CorrectAnswer = correctAnswer;
            else
                throw new Exception("The correct answer must be contained in the list of possible answers");

            if (difficulty.Equals("Easy") || difficulty.Equals("Medium") || difficulty.Equals("Hard"))
                Difficulty = difficulty;
            else
                throw new Exception("Difficulty can only be Easy, Medium or Hard with case sensitivity");
        }

    }
}
