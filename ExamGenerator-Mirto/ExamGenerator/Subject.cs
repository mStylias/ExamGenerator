using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExamGenerator.MainFiles;

namespace ExamGenerator
{
    [Serializable]
    public class Subject
    {
        public string Name { get; set; }
        public List<Question> Questions { get; private set; } = new List<Question>();
        public static Dictionary<string, Subject> Subjects { get; set; } = new Dictionary<string, Subject>();
        public HashSet<string> AllTags { get; set; } = new HashSet<string>();

        public Subject(string name)
        {
            Name = name;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            foreach (string tag in question.Tags)
            {
                if (AllTags.Contains(tag))
                    continue;
                else
                    AllTags.Add(tag);
            }
        }

        public List<Question> SearchQuestions(string difficulty, HashSet<string> tags, string typedSearch)
        {
            var sortedQuestions = new List<Question>();
            foreach (Question question in Questions)
            {
                if (question.Difficulty.Equals(difficulty) || difficulty.Equals("Any"))
                {
                    if (tags != null && tags.Count > 0)
                    {
                        foreach (string tag in tags)
                            if (question.Tags.Contains(tag) && question.Body.Contains(typedSearch))
                                sortedQuestions.Add(question);
                    }
                    else if (typedSearch != null && question.Body.Contains(typedSearch))
                        sortedQuestions.Add(question);
                }
            }

            return sortedQuestions;
        }

        //public List<Question> SearchQuestionsByDifficulty(string difficulty)
        //{
        //    var sortedList = new List<Question>();
        //    foreach (Question question in Questions)
        //    {
        //        if (question.Difficulty.Equals(difficulty))
        //            sortedList.Add(question);
        //    }
        //    return sortedList;
        //}
    }
}
