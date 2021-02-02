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
                if (!(difficulty.Equals("Any") || question.Difficulty.Equals(difficulty)))
                    continue;

                if (tags != null)
                {
                    bool areAllTagsPresent = true;
                    foreach (string necessaryTag in tags)
                        if (!question.Tags.Contains(necessaryTag))
                        {
                            areAllTagsPresent = false;
                            continue;
                        }
                            
                    if (!areAllTagsPresent)
                        continue;
                }
                    

                if (typedSearch != null && !question.Body.Contains(typedSearch))
                    continue;

                sortedQuestions.Add(question);
            }

            return sortedQuestions;
        }

    }
}
