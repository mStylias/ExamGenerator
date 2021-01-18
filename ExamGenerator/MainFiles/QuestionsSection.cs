using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExamGenerator.CustomControls;

namespace ExamGenerator.MainFiles
{
    public partial class QuestionsSection : UserControl
    {
        public Subject CurrentSubject { get; set; } = null;
        private List<QuestionModel> QuestionModels;
        private int initialWidth;
        private int initialHeight;

        public QuestionsSection()
        {
            
            InitializeComponent();
            initialWidth = this.Width;
            initialHeight = this.Height;  
        }

        private void QuestionsSection_Load(object sender, EventArgs e)
        {
            // Temporary load subject
            CurrentSubject = new Subject("Math");

            var tags = new List<string>();
            tags.Add("Limits");
            var questionBody = "What is the limit of x with x tiniing to infinity";
            var possibleAnswers = new List<string>();
            possibleAnswers.Add("1. Who the fuck knows");
            possibleAnswers.Add("2. Certainly not me");
            possibleAnswers.Add("3. Only the people who teach this shit");
            var correctAnswer = "2. Certainly not me";
            var difficulty = "Medium";

            CurrentSubject.Questions.Add(new Question(tags, questionBody, possibleAnswers, correctAnswer, difficulty));

            InitializeQuestionModels();
            //DisplayQuestionModels();
        }


        private void InitializeQuestionModels()
        {
            QuestionModels = new List<QuestionModel>();
            foreach (Question question in CurrentSubject.Questions)
            {
                QuestionModel model = new QuestionModel(question);
                model.Visible = false;
                QuestionModels.Add(model);
            }

        }

        static readonly int TOP_DISTANCE = 96;
        static readonly int VERTICAL_SPACING = 30;
        static readonly int LEFT_DISTANCE = 60;
        static readonly int HORIZONTAL_SPACING = 15;
        private void DisplayQuestionModels()
        {
            if (QuestionModels.Count > 0)
            {
                panelQuestions.Controls.Clear();
                // With default size only 3 questions can be displayed per line and 2 per row
                int modelsPerLine = 3;
                int modelsPerRow = 2;
                int modelsDisplayedOnCurrentLine = 0;
                int modelsDisplayedOnCurrentRow = 0;

                modelsPerLine += (this.Width - initialWidth) / QuestionModels[0].Width - 1;
                modelsPerRow += (this.Height - initialHeight) / QuestionModels[0].Height - 1;

                int maximumModelsNum = modelsPerLine + modelsPerRow;
                int i = 0;
                while (i < maximumModelsNum && i < QuestionModels.Count)
                {

                    QuestionModels[i].Left = QuestionModels[i].Width * modelsDisplayedOnCurrentLine +
                                             HORIZONTAL_SPACING * modelsDisplayedOnCurrentLine + LEFT_DISTANCE;

                    QuestionModels[i].Top = QuestionModels[i].Height * modelsDisplayedOnCurrentRow +
                                            VERTICAL_SPACING * modelsDisplayedOnCurrentRow + TOP_DISTANCE;

                    panelQuestions.Controls.Add(QuestionModels[i]);

                    modelsDisplayedOnCurrentLine++;
                    if (modelsDisplayedOnCurrentLine % modelsPerLine == 0)
                    {
                        modelsDisplayedOnCurrentLine = 0;
                        modelsDisplayedOnCurrentRow++;
                    }
                    i++;
                }

                foreach (Control control in panelQuestions.Controls)
                    control.Show();
            }
        }
        

    }
}
