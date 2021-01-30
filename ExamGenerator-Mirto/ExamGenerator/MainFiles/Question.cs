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
        public Subject subject = new Subject("");
        public HashSet<string> QuestionTags { get; set; } = new HashSet<string>();
        public string QuestionBody { get; set; }
        public List<string> PossibleAnswers { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }
        public string Difficulty { get; set; }

        public Question(Subject subject, HashSet<string> tags, string questionBody, List<string> possibleAnswers, string correctAnswer, string difficulty)
        {
            this.subject = subject;
            QuestionTags = tags;
            foreach(string tag in QuestionTags)
            {
                try
                {
                    if (subject.SubjectTags.Contains(tag)) continue;
                    else subject.SubjectTags.Add(tag);
                }
                catch(NullReferenceException)
                {
                    subject.SubjectTags.Add(tag);
                }
            }
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
