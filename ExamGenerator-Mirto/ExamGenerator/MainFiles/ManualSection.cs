using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExamGenerator;
using ExamGenerator.CustomControls;

namespace ExamGenerator.MainFiles
{
    public partial class ManualSection : UserControl
    {
        private Subject CurrentSubject { get; set; }
        private List<QuestionModel> AllQuestionModels { get; set; } = new List<QuestionModel>();
        private List<QuestionModel> ActiveQuestionModels { get; set; }
        private HashSet<string> activeTags = new HashSet<string>();
        private int initialWidth;
        private int initialHeight;

        public ManualSection()
        {
            
            InitializeComponent();
            initialWidth = this.Width;
            initialHeight = this.Height;

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

                if (i % 3 == 0)
                {
                    difficulty = "Easy";
                }
                else if (i % 3 == 2)
                    difficulty = "Hard";
                else
                {
                    difficulty = "Medium";
                }

                var tags = new HashSet<string>();
                tags.Add("Limits");
                if (i % 5 == 0)
                    tags.Add("Modulo");

                CurrentSubject.AddQuestion(new Question(tags, questionBody, possibleAnswers, correctAnswer, difficulty));
            }


            foreach (string tag in CurrentSubject.AllTags)
            {
                DisplayTag(tag);
            }

            Console.WriteLine(CurrentSubject.Questions.Count);
            InitializeQuestionModels();
            DisplayQuestionModels();
            ToggleNavigationButtons();
        }

        private void InitializeQuestionModels()
        {
            var tempQuestions = CurrentSubject.Questions.ToList();
            foreach (Question question in tempQuestions)
            {
                QuestionModel model = new QuestionModel(question);
                model.Visible = false;
                AllQuestionModels.Add(model);
                panelQuestions.Controls.Add(model);
            }
            ActiveQuestionModels = AllQuestionModels.ToList();

        }

        static int topDistance = 10;
        static int leftDistance = 0;
        static int verticalSpacing = 10;
        static int horizontalSpacing = 15;
        int maximumModelsNum = 0;
        private void DisplayQuestionModels()
        {
            if (ActiveQuestionModels.Count > 0)
            {
                // With default size only 3 questions can be displayed per line and 2 per row
                int modelsPerLine = 3;
                int modelsPerRow = 2;

                // Determine how many models fit in the current screen
                modelsPerLine += (this.Width - initialWidth) / ActiveQuestionModels[0].Width;
                modelsPerRow += (this.Height - initialHeight) / ActiveQuestionModels[0].Height;

                // Modify the position values to keep models centered
                horizontalSpacing = (panelControlQuestions.Width - (modelsPerLine * ActiveQuestionModels[0].Width)) / modelsPerLine;

                // Currently displayed models number
                int modelsDisplayedOnCurrentLine = 0;
                int modelsDisplayedOnCurrentRow = 0; 
                
                maximumModelsNum = modelsPerLine * modelsPerRow;

                // Determines which model is going to be displayed next
                int i = (page-1) * maximumModelsNum;

                while (i < maximumModelsNum * page && i < ActiveQuestionModels.Count)
                {

                    ActiveQuestionModels[i].Left = ActiveQuestionModels[i].Width * modelsDisplayedOnCurrentLine +
                                             horizontalSpacing * modelsDisplayedOnCurrentLine + leftDistance;

                    ActiveQuestionModels[i].Top = ActiveQuestionModels[i].Height * modelsDisplayedOnCurrentRow +
                                            verticalSpacing * modelsDisplayedOnCurrentRow + topDistance;

                    ActiveQuestionModels[i].Show();

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

            for (int i = (page - 2) * maximumModelsNum; i < (page-1) * maximumModelsNum && i < ActiveQuestionModels.Count; i++)
                ActiveQuestionModels[i].Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            page--;
            DisplayQuestionModels();
            ToggleNavigationButtons();

            for (int i = page * maximumModelsNum; i < (page+1) * maximumModelsNum && i < ActiveQuestionModels.Count; i++)
                ActiveQuestionModels[i].Hide();
        }

        private void ToggleNavigationButtons()
        {
            if (ActiveQuestionModels.Count > page * maximumModelsNum)
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
            for (int i = 0; i < ActiveQuestionModels.Count; i++)
                if (i < (page - 1) * maximumModelsNum || i >= page * maximumModelsNum)
                    ActiveQuestionModels[i].Hide();
                
        }




        // Sort Panels open, close, mouse enter and mouse leave behaviour
        bool IsTagsPanelVisible = false;
        bool IsDifficultyPanelVisible = false;

        private void buttonSort_MouseEnter(object sender, EventArgs e)
        {
            ControlCollection controls = ((Button)sender).Parent.Controls;
            foreach (Button button in controls.OfType<Button>())
                button.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void buttonSort_MouseLeave(object sender, EventArgs e)
        {
            if (!IsTagsPanelVisible)
                foreach (Button button in panelSortTags.Controls.OfType<Button>())
                    button.BackColor = Color.FromArgb(255, 255, 255);

            if (!IsDifficultyPanelVisible)
                foreach (Button button in panelSortDifficulty.Controls.OfType<Button>())
                    button.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Tags_Click(object sender, EventArgs e)
        {
            if (IsTagsPanelVisible)
            {
                IsTagsPanelVisible = false;
                togglePanelTags.Hide();
            }
            else
            {
                IsTagsPanelVisible = true;
                togglePanelTags.ShowPanel(Controls);

                IsDifficultyPanelVisible = false;
                foreach (Button button in panelSortDifficulty.Controls.OfType<Button>())
                    button.BackColor = Color.FromArgb(255, 255, 255);
            }  
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {
            if (IsDifficultyPanelVisible)
            {
                IsDifficultyPanelVisible = false;
                togglePanelDifficulty.Hide();
            }
            else
            {
                IsDifficultyPanelVisible = true;
                togglePanelDifficulty.ShowPanel(Controls);

                IsTagsPanelVisible = false;
                foreach (Button button in panelSortTags.Controls.OfType<Button>())
                    button.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        // Sort panels inside controls
        private void DisplayTag(string name)
        {
            CheckBox checkbox = new CheckBox();

            checkbox.Dock = System.Windows.Forms.DockStyle.Top;
            checkbox.FlatAppearance.BorderSize = 0;
            checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkbox.Location = new System.Drawing.Point(0, 0);
            checkbox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            checkbox.Size = new System.Drawing.Size(128, 34);
            checkbox.TabIndex = 5;
            checkbox.Text = name;
            checkbox.UseVisualStyleBackColor = true;
            checkbox.Click += Tag_Click;

            togglePanelTags.Controls.Add(checkbox);
        }

        private void Tag_Click(object sender, EventArgs e)
        {
            activeTags.Clear();
            foreach (CheckBox checkBox in togglePanelTags.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    activeTags.Add(checkBox.Text);
                }
            }

            SearchAndDisplayQuestions();
        }

        private void radioDifficultyAll_Click(object sender, EventArgs e)
        {
            SearchAndDisplayQuestions();
        }

        private void SearchAndDisplayQuestions()
        {
            List<Question> sortedQuestions = null;
            foreach (RadioButton radio in togglePanelDifficulty.Controls.OfType<RadioButton>())
                if (radio.Checked)
                {
                    Console.WriteLine(activeTags.Count);
                    if (activeTags.Count > 0)
                        sortedQuestions = CurrentSubject.SearchQuestions(radio.Text, activeTags, null);
                    else
                        sortedQuestions = CurrentSubject.SearchQuestions(radio.Text, null, null);
                }


            page = 1;

            ActiveQuestionModels = AllQuestionModels.ToList();

            for (int i = ActiveQuestionModels.Count - 1; i >= 0; i--)
            {
                if (!sortedQuestions.Contains(CurrentSubject.Questions[i]))
                {
                    ActiveQuestionModels[i].Hide();
                    ActiveQuestionModels.RemoveAt(i);
                }

            }



            //foreach (QuestionModel model in ActiveQuestionModels)
            //{
            //    if (!sortedQuestions.Contains(model.Question))
            //    {

            //    }
            //}

            DisplayQuestionModels();
            ToggleNavigationButtons();
            
        }

        public void SearchAndDisplayQuestions(string search)
        {
            List<Question> sortedQuestions = null;
            foreach (RadioButton radio in togglePanelDifficulty.Controls.OfType<RadioButton>())
                if (radio.Checked)
                {
                    sortedQuestions = CurrentSubject.SearchQuestions(radio.Text, activeTags, search);
                }


            page = 1;

            ActiveQuestionModels = AllQuestionModels.ToList();

            for (int i = ActiveQuestionModels.Count - 1; i >= 0; i--)
            {
                if (!sortedQuestions.Contains(CurrentSubject.Questions[i]))
                {
                    ActiveQuestionModels[i].Hide();
                    ActiveQuestionModels.RemoveAt(i);
                }

            }

            DisplayQuestionModels();
            ToggleNavigationButtons();

        }

        /* Opens the manual generate dialog with the selected questions */
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            List<Question> questions = new List<Question>();
            foreach (QuestionModel model in panelQuestions.Controls.OfType<QuestionModel>())
            {
                if (model.Checked)
                    questions.Add(model.Question);
            }

            FormManualGenerate form = new FormManualGenerate(CurrentSubject.Name, questions);
            form.ShowDialog();

        }
    }
}
