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
        public static Dictionary<string, Subject> Subjects { get; set; } = new Dictionary<string, Subject>();
        public string Name { get; set; }
        public List<Question> Questions { get; private set; } = new List<Question>();
        public HashSet<string> AllTags { get; set; } = new HashSet<string>();
        public Dictionary<string, int> TagsNum { get; set; } = new Dictionary<string, int>(); // Contains how many times a tag exists in all questions

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
                {
                    TagsNum[tag]++;
                    continue;
                }
                else
                {
                    TagsNum.Add(tag, 1);
                    AllTags.Add(tag);
                }  
            }
        }

        public void RemoveQuestion(Question question)
        {
            // Decrement the number of every tag in the dictionary that counts the tags
            // and completely remove the tag if neccessary
            foreach (string tag in question.Tags)
            {
                TagsNum[tag]--;
                if (TagsNum[tag] == 0)
                {
                    TagsNum.Remove(tag);
                    AllTags.Remove(tag);
                }
            }

            Questions.Remove(question);

        }

        public List<Question> SearchQuestions(string difficulty, HashSet<string> tags, string typedSearch)
        {
            var sortedQuestions = new List<Question>();
            foreach (Question question in Questions)
            {
                if (!(difficulty.Equals("Any") || question.Difficulty.Equals(difficulty)))
                    continue;

                if (tags != null && tags.Count > 0)
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
                    

                if (!string.IsNullOrWhiteSpace(typedSearch) && !question.Body.Contains(typedSearch))
                    continue;

                sortedQuestions.Add(question);
            }

            return sortedQuestions;
        }

        public int QuestionsNumberByAttribute(string difficulty, string tag)
        {
            int countTagAndDifficulty = 0;
            int countTag = 0;
            int countDifficulty = 0;
            foreach (Question question in Questions)
            {
                if (tag != null)
                {
                    if (difficulty != null)
                    {
                        if (question.Tags.Contains(tag) && question.Equals(difficulty))
                        {
                            countTagAndDifficulty++;
                        }
                    }
                    else
                    {
                        if (question.Tags.Contains(tag))
                        {
                            countTag++;
                        }
                    }
                }
                else
                {
                    if (difficulty != null)
                    {
                        if (question.Difficulty.Equals(difficulty))
                        {
                            countDifficulty++;
                        }
                    }
                }
            }
            if (tag != null && difficulty != null) return countTagAndDifficulty;
            else if (tag != null && difficulty == null) return countTag;
            else if (tag == null && difficulty != null) return countDifficulty;
            else return -1;
        }

    }
}
