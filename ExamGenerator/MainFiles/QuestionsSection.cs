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

            var possibleAnswers = new List<string>();
            possibleAnswers.Add("1. Who the fuck knows");
            possibleAnswers.Add("2. Certainly not me");
            possibleAnswers.Add("3. Only the people who teach this shit");
            var correctAnswer = "2. Certainly not me";
            var difficulty = "Medium";

            for (int i = 0; i < 50; i++)
            {
                string questionBody = "Test" + i;

                var tags = new HashSet<string>();
                tags.Add("Limits");
                if (i % 5 == 0)
                    tags.Add("Modulo");

                CurrentSubject.Questions.Add(new Question(tags, questionBody, possibleAnswers, correctAnswer, difficulty));
            }
                

            InitializeQuestionModels();
            DisplayQuestionModels();
            ToggleNavigationButtons();
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

        static int topDistance = 25;
        static int leftDistance = 0;
        static int verticalSpacing = 30;
        static int horizontalSpacing = 15;
        int maximumModelsNum = 0;
        private void DisplayQuestionModels()
        {
            if (QuestionModels.Count > 0)
            {
                // With default size only 3 questions can be displayed per line and 2 per row
                int modelsPerLine = 3;
                int modelsPerRow = 2;

                // Determine how many models fit in the current screen
                modelsPerLine += (this.Width - initialWidth) / QuestionModels[0].Width;
                modelsPerRow += (this.Height - initialHeight) / QuestionModels[0].Height;

                // Modify the position values to keep models centered
                horizontalSpacing = (panelControlQuestions.Width - (modelsPerLine * QuestionModels[0].Width)) / modelsPerLine;

                // Currently displayed models number
                int modelsDisplayedOnCurrentLine = 0;
                int modelsDisplayedOnCurrentRow = 0; 
                
                maximumModelsNum = modelsPerLine * modelsPerRow;

                // Determines which model is going to be displayed next
                int i = (page-1) * maximumModelsNum;

                while (i < maximumModelsNum * page && i < QuestionModels.Count)
                {

                    QuestionModels[i].Left = QuestionModels[i].Width * modelsDisplayedOnCurrentLine +
                                             horizontalSpacing * modelsDisplayedOnCurrentLine + leftDistance;

                    QuestionModels[i].Top = QuestionModels[i].Height * modelsDisplayedOnCurrentRow +
                                            verticalSpacing * modelsDisplayedOnCurrentRow + topDistance;

                    panelQuestions.Controls.Add(QuestionModels[i]);
                    QuestionModels[i].Show();

                    modelsDisplayedOnCurrentLine++;
                    if (modelsDisplayedOnCurrentLine % modelsPerLine == 0)
                    {
                        modelsDisplayedOnCurrentLine = 0;
                        modelsDisplayedOnCurrentRow++;
                    }
                    i++;
                }

            }
        }

        int page = 1;
        private void buttonForward_Click(object sender, EventArgs e)
        {
            page++;
            DisplayQuestionModels();
            ToggleNavigationButtons();

            for (int i = (page - 2) * maximumModelsNum; i < (page-1) * maximumModelsNum && i < QuestionModels.Count; i++)
                QuestionModels[i].Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            page--;
            DisplayQuestionModels();
            ToggleNavigationButtons();

            for (int i = page * maximumModelsNum; i < (page+1) * maximumModelsNum && i < QuestionModels.Count; i++)
                QuestionModels[i].Hide();
        }

        private void ToggleNavigationButtons()
        {
            if (QuestionModels.Count > page * maximumModelsNum)
                buttonForward.Show();
            else
                buttonForward.Hide();

            if (page > 1)
                buttonBack.Show();
            else
                buttonBack.Hide();
        }

        public void OnResizeEnd()
        {
            DisplayQuestionModels();
            ToggleNavigationButtons();

            // Hide all the models except for the ones currently on screen
            for (int i = 0; i < QuestionModels.Count; i++)
                if (i < (page - 1) * maximumModelsNum || i >= page * maximumModelsNum)
                    QuestionModels[i].Hide();
                
        }

    }
}
