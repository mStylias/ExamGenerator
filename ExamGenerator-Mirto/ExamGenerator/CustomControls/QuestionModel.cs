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
        Question question;
        public QuestionModel(Question question)
        {
            this.question = question;
            InitializeComponent();
        }

        private void QuestionModel_Load(object sender, EventArgs e)
        {
            // Question
            labelQuestion.Text = question.QuestionBody;

            // Tags
            var sb = new StringBuilder();
            foreach (string tag in question.QuestionTags)
                sb.Append(tag).Append(", ");
            // Remove the last "," and white space
            sb.Remove(sb.Length-2, 2);
            labelTags.Text = sb.ToString();

            // Possible answers
            sb.Clear();
            foreach (string answer in question.PossibleAnswers)
            {
                sb.AppendLine(answer);
            }
            
            labelAnswers.Text = sb.ToString();

            // Correct answer
            labelCorrectAnswer.Text = question.CorrectAnswer;

            // Difficulty
            labelDifficulty.Text = question.Difficulty;
        }
    }
}
