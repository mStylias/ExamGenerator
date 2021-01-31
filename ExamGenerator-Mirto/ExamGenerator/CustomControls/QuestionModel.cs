using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExamGenerator.MainFiles;

namespace ExamGenerator.CustomControls
{
    public partial class QuestionModel : UserControl
    {
        public Question Question { get; set; }
        public QuestionModel(Question question)
        {
            this.Question = question;
            InitializeComponent();
        }

        private void QuestionModel_Load(object sender, EventArgs e)
        {
            // Question
            labelQuestion.Text = Question.Body;

            // Tags
            var sb = new StringBuilder();
            foreach (string tag in Question.Tags)
                sb.Append(tag).Append(", ");
            // Remove the last "," and white space
            sb.Remove(sb.Length-2, 2);
            labelTags.Text = sb.ToString();

            // Possible answers
            sb.Clear();
            foreach (string answer in Question.PossibleAnswers)
            {
                sb.AppendLine(answer);
            }
            
            labelAnswers.Text = sb.ToString();

            // Correct answer
            labelCorrectAnswer.Text = Question.CorrectAnswer;

            // Difficulty
            labelDifficulty.Text = Question.Difficulty;
        }
    }
}
