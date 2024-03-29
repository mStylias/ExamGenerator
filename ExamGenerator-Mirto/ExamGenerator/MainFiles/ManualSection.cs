﻿using System;
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
        private List<QuestionModel> SortedQuestionModels { get; set; }
        private int initialWidth;
        private int initialHeight;

        public ManualSection()
        { 
            InitializeComponent();
            initialWidth = this.Width;
            initialHeight = this.Height;
        }

        public void OnLoad(Subject subject)
        {
            CurrentSubject = subject;

            foreach (string tag in CurrentSubject.AllTags)
            {
                DisplayTag(tag);
            }

            InitializeQuestionModels();
            DisplayQuestionModels();
            ToggleNavigationButtons();
        }

        public void UpdateUI()
        {
            // Update tags
            togglePanelTags.Controls.Clear();
            foreach (string tag in CurrentSubject.AllTags)
            {
                DisplayTag(tag);
            }

            // Update question models
            var previousQuestions = new List<Question>();
            foreach (QuestionModel model in AllQuestionModels)
            {
                previousQuestions.Add(model.Question);
            }

            foreach (Question question in CurrentSubject.Questions)
            {
                if (!previousQuestions.Contains(question))
                    CreateAndAddQuestionModel(question);
            }

            // Display new models
            page = 1;
            SearchAndDisplayQuestions();
        }

        private void InitializeQuestionModels()
        {
            foreach (Question question in CurrentSubject.Questions)
            {
                CreateAndAddQuestionModel(question);
            }
            SortedQuestionModels = AllQuestionModels.ToList();
        }

        private void CreateAndAddQuestionModel(Question question)
        {
            QuestionModel model = new QuestionModel(question);
            model.Visible = false;
            model.AddClickEvent(QuestionModelClick);
            AllQuestionModels.Add(model);
            panelQuestions.Controls.Add(model);
        }

        private void QuestionModelClick(object sender, EventArgs e)
        {
            if (QuestionModel.SelectedModelsNum > 0)
            {
                buttonDeleteQuestions.Show();
                if (QuestionModel.SelectedModelsNum == SortedQuestionModels.Count)
                    checkBoxSectionTitle.Checked = true;
                else
                    checkBoxSectionTitle.Checked = false;
            }
            else
            {
                buttonDeleteQuestions.Hide();
                checkBoxSectionTitle.Checked = false;
            }    
        }

        static int topDistance = 10;
        static int leftDistance = 0;
        static int verticalSpacing = 10;
        static int horizontalSpacing = 15;
        int maximumModelsNum = 0;
        private void DisplayQuestionModels()
        {
            if (SortedQuestionModels.Count > 0)
            {
                // With default size only 3 questions can be displayed per line and 2 per row
                int modelsPerLine = 3;
                int modelsPerRow = 2;

                // Determine how many models fit in the current screen
                modelsPerLine += (this.Width - initialWidth) / SortedQuestionModels[0].Width;
                modelsPerRow += (this.Height - initialHeight) / SortedQuestionModels[0].Height;

                // Modify the position values to keep models centered
                horizontalSpacing = (panelControlQuestions.Width - (modelsPerLine * SortedQuestionModels[0].Width)) / modelsPerLine;

                // Currently displayed models number
                int modelsDisplayedOnCurrentLine = 0;
                int modelsDisplayedOnCurrentRow = 0; 
                
                maximumModelsNum = modelsPerLine * modelsPerRow;

                // Determines which model is going to be displayed next
                int i = (page-1) * maximumModelsNum;

                while (i < maximumModelsNum * page && i < SortedQuestionModels.Count)
                {

                    SortedQuestionModels[i].Left = SortedQuestionModels[i].Width * modelsDisplayedOnCurrentLine +
                                             horizontalSpacing * modelsDisplayedOnCurrentLine + leftDistance;

                    SortedQuestionModels[i].Top = SortedQuestionModels[i].Height * modelsDisplayedOnCurrentRow +
                                            verticalSpacing * modelsDisplayedOnCurrentRow + topDistance;

                    SortedQuestionModels[i].Show();

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

            for (int i = (page - 2) * maximumModelsNum; i < (page-1) * maximumModelsNum && i < SortedQuestionModels.Count; i++)
                SortedQuestionModels[i].Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            page--;
            DisplayQuestionModels();
            ToggleNavigationButtons();

            for (int i = page * maximumModelsNum; i < (page+1) * maximumModelsNum && i < SortedQuestionModels.Count; i++)
                SortedQuestionModels[i].Hide();
        }

        private void ToggleNavigationButtons()
        {
            if (SortedQuestionModels.Count > page * maximumModelsNum)
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
            page = 1;

            DisplayQuestionModels();
            ToggleNavigationButtons();

            // Hide all the models except for the ones currently on screen
            for (int i = 0; i < SortedQuestionModels.Count; i++)
                if (i < (page - 1) * maximumModelsNum || i >= page * maximumModelsNum)
                    SortedQuestionModels[i].Hide();
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

        private void TagsButton_Click(object sender, EventArgs e)
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

            if (!togglePanelTags.Controls.Contains(checkbox))
                togglePanelTags.Controls.Add(checkbox);
        }

        HashSet<string> ActiveTags { get; set; } = new HashSet<string>();
        private void Tag_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in togglePanelTags.Controls.OfType<CheckBox>())
            {
                if (!checkBox.Checked)
                {
                    ActiveTags.Remove(checkBox.Text);
                    continue;
                }
                else if (!ActiveTags.Contains(checkBox.Text))
                {
                    ActiveTags.Add(checkBox.Text);
                }  
            }

            SearchAndDisplayQuestions();

            // Perform the question model click event to identify weather the 
            // delete button should be visible and the questions checkbox checked
            if (SortedQuestionModels.Count > 0)
                QuestionModelClick(SortedQuestionModels[0], EventArgs.Empty);
        }

        string Difficulty { get; set; } = "Any";
        private void radioDifficultyAll_Click(object sender, EventArgs e)
        {
            Difficulty = ((RadioButton)sender).Text;
            SearchAndDisplayQuestions();

            // Perform the question model click event to identify weather the 
            // delete button should be visible and the questions checkbox checked
            if (SortedQuestionModels.Count > 0)
                QuestionModelClick(SortedQuestionModels[0], EventArgs.Empty);
        }

        string SearchBarText { get; set; } = null;
        public void SearchQuestions(string searchBarText)
        {
            SearchBarText = searchBarText;
            SearchAndDisplayQuestions();

            // Perform the question model click event to identify weather the 
            // delete button should be visible and the questions checkbox checked
            if (SortedQuestionModels.Count > 0)
                QuestionModelClick(SortedQuestionModels[0], EventArgs.Empty);
        }
        private void SearchAndDisplayQuestions()
        {
            List<Question> sortedQuestions;
            sortedQuestions = CurrentSubject.SearchQuestions(Difficulty, ActiveTags, SearchBarText);

            page = 1;

            SortedQuestionModels.Clear();
            foreach (QuestionModel model in AllQuestionModels)
            {
                if (sortedQuestions.Contains(model.Question))
                    SortedQuestionModels.Add(model);
                model.Hide();
                model.Selected = false;
            }

            // Perform the click event to identify weather the delete button 
            // should be visible and the questions checkbox checked
            if (SortedQuestionModels.Count > 0)
                QuestionModelClick(SortedQuestionModels[0], EventArgs.Empty);

            DisplayQuestionModels();
            ToggleNavigationButtons();
        }

        /* Opens the manual generate dialog with the selected questions */
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var questions = new List<Question>();
            foreach (QuestionModel model in SortedQuestionModels)
            {
                if (model.Selected)
                    questions.Add(model.Question);
            }

            if (questions.Count > 0)
            {
                FormManualGenerate form = new FormManualGenerate(CurrentSubject.Name, questions);
                form.ShowDialog();
            }
            else
                MessageBox.Show("No questions were selected. Select at least 1 question and try again", "No selected questions",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        /* Check or unckeck everything that corresponds to search criteria */
        private void checkBoxSectionTitle_Click(object sender, EventArgs e)
        {
            if (SortedQuestionModels.Count > 0)
                if (checkBoxSectionTitle.Checked)
                    foreach (QuestionModel model in SortedQuestionModels)
                    {
                        if (!model.Selected)
                        {
                            model.Selected = true;
                            buttonDeleteQuestions.Show();
                        }
                        
                    }
                else
                    foreach (QuestionModel model in SortedQuestionModels)
                    {
                        if (model.Selected)
                        {
                            model.Selected = false;
                            buttonDeleteQuestions.Hide();
                        }
                    }
            else
                checkBoxSectionTitle.Checked = false;
        }


        private void buttonDeleteQuestions_Click(object sender, EventArgs e)
        {
            var userResponse = MessageBox.Show("Are you sure you want to delete the selected questions? This action is not reversible!", "Confirmation", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (userResponse == DialogResult.Yes)
            {
                foreach (QuestionModel model in SortedQuestionModels)
                {
                    if (model.Selected)
                    {
                        CurrentSubject.RemoveQuestion(model.Question);
                        QuestionModel.SelectedModelsNum--;
                    }    
                }

                checkBoxSectionTitle.Checked = false;
                buttonDeleteQuestions.Hide();

                FormMain form = (FormMain)Application.OpenForms["formMain"];
                form.UpdateAndSave();
            }
        }
    }
}
