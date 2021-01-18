using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator
{
    [Serializable]
    public class Subject
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        public Subject(string name)
        {
            Name = name;
        }
    }
}
