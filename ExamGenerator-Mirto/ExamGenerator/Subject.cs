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
        public List<Question> Questions { get; set; } = new List<Question>();
        public static Dictionary<string, Subject> Subjects { get; set; } = new Dictionary<string, Subject>();
        public HashSet<string> SubjectTags { get; set; } = new HashSet<string>();

        public Subject(string name)
        {
            Name = name;
        }

        public List<Question> SortQuestionsByTag(string tag)
        {
            var sortedList = new List<Question>();
            foreach (Question question in Questions)
            {
                if (question.QuestionTags.Contains(tag))
                    sortedList.Add(question);
            }
            return sortedList;
        }

        public List<Question> SortQuestionsByDifficulty(string difficulty)
        {
            var sortedList = new List<Question>();
            foreach (Question question in Questions)
            {
                if (question.Difficulty.Equals(difficulty))
                    sortedList.Add(question);
            }
            return sortedList;
        }
    }
}
