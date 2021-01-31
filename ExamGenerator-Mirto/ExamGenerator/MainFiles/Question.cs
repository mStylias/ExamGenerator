using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.MainFiles
{
    [Serializable]
    public class Question
    {
        public HashSet<string> Tags { get; set; } = new HashSet<string>();
        public string Body { get; set; }
        public List<string> PossibleAnswers { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }
        public string Difficulty { get; set; }

        public Question(HashSet<string> tags, string questionBody, List<string> possibleAnswers, string correctAnswer, string difficulty)
        {
            Tags = tags;

            Body = questionBody;

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
