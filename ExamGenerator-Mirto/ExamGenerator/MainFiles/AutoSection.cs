using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamGenerator.MainFiles;
using Microsoft.Win32;

namespace ExamGenerator
{
    public partial class AutoSection : UserControl
    {
        private Subject CurrentSubject { get; set; } 
        public List<Question> TestQuestions = new List<Question>();
        Random random = new Random();

        public AutoSection()
        {
            InitializeComponent();
        }

        private void AutoSection_Load(object sender, EventArgs e)
        {
            
        }

        public void OnLoad(Subject subject)
        {
            CurrentSubject = subject;
            if (!CurrentSubject.AllTags.Any()) 
                CurrentSubject.AllTags.Add("No Tags yet!");
            else
            {
                if(CurrentSubject.AllTags.Contains("No Tags yet!")) CurrentSubject.AllTags.Remove("No Tags yet!");
                foreach (string tag in CurrentSubject.AllTags)
                {
                    DisplayTag(tag);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (togglePanelTags.Controls.OfType<NumericUpDown>().All(x => x.Value == 0) && togglePanelDifficulty.Controls.OfType<NumericUpDown>().All(x => x.Value == 0))
            {
                for (int i = 0; i < QuestionsNumericUpDown.Value; i++)
                {
                    int k = random.Next(0, CurrentSubject.Questions.Count());
                    if (!TestQuestions.Contains(CurrentSubject.Questions[k]))
                    {
                        TestQuestions.Add(CurrentSubject.Questions[k]);
                    }
                }
            }
            else if (!ChooseQuestionsByTagOrDifficulty())
                return;

            if(ChooseQuestionsByTagOrDifficulty() == false)
            {
                return;
            }
           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                string fileName;
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    fileName = CurrentSubject.Name;
                else
                    fileName = textBox1.Text;

                // Create exam
                if (MicrosoftWordManager.CreateExamDocument(CurrentSubject.Name, TestQuestions, folderPath, fileName, Convert.ToInt32(LayoutNumericUpDown.Value), MicrosoftWordManager.FindOfficeVersion()))
                    MessageBox.Show("Succesfully generated exam!", "Success");
                else
                    MessageBox.Show("An error occured during exam generation. " +
                                    "If the document already exists close any programs that might be using it " +
                                    "and try again.", "Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Sort Panels open, close, mouse enter and mouse leave behaviour
        bool IsTagsPanelVisible = false;
        bool IsDifficultyPanelVisible = false;

        private void button3_Click(object sender, EventArgs e)
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
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
            }
        }

        private void togglablePanel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void togglablePanel2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void DisplayTag(string name)
        {
            Panel panel = new Panel();
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Padding = new Padding(0, 0, 18, 0);
            panel.AutoSize = true;
            panel.MinimumSize = new Size(169, 42);

            Button button = new Button();
            button.Dock = System.Windows.Forms.DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Location = new System.Drawing.Point(0, 0);
            button.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            //ttonon.Size = new System.Drawing.Size(171, 30);
            button.TabIndex = 5;
            button.Text = name;
            button.UseVisualStyleBackColor = true;

            Panel panel2 = new Panel();
            panel2.Padding = new Padding(0, 11, 0, 0);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.AutoSize = true;
            panel2.MinimumSize = new System.Drawing.Size(48, 20);

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Dock = System.Windows.Forms.DockStyle.Right;
            numericUpDown.Location = new System.Drawing.Point(120, 5);
            numericUpDown.AutoSize = false;
            numericUpDown.Size = new System.Drawing.Size(48, 20);
            numericUpDown.TabIndex = 5;
            numericUpDown.Name = name + "NumericUpDown";

            panel2.Controls.Add(numericUpDown);

            panel.Controls.Add(button);
            panel.Controls.Add(panel2);
            togglePanelTags.Controls.Add(panel);
        }

        private bool ChooseQuestionsByTagOrDifficulty()
        {
            if(EasyNumericUpDown.Value + MediumNumericUpDown.Value + HardNumericUpDown.Value > QuestionsNumericUpDown.Value)
            {
                MessageBox.Show("Number of questions per difficulty exceeds selected questions number. Please try again!");
                return false;
            }

            foreach (string tag in CurrentSubject.AllTags)
            {
                Control control = Controls.Find(tag + "NumericUpDown", true).FirstOrDefault();
                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    if (numericUpDown.Value == 0) continue;
                    if (numericUpDown.Value > QuestionsNumericUpDown.Value)
                    {
                        MessageBox.Show("Number of questions per tag exceeds selected questions number. Please try again!");
                        return false;
                    }

                    next1:  int k = random.Next(0, 4);
                    switch (k)
                    {
                        case 0:
                            if (CurrentSubject.QuestionsNumberByAttribute(null, tag) < (int)numericUpDown.Value) 
                            {
                                MessageBox.Show("Problem1");
                                goto next1;
                            } 
                            SearchRandomQuestions(null, tag, (int)numericUpDown.Value);
                            if (SearchRandomQuestions(null, tag, (int)numericUpDown.Value) == false) return false;
                            numericUpDown.Value--;
                            break;
                        case 1:
                            if (CurrentSubject.QuestionsNumberByAttribute("Easy", tag) < (int)numericUpDown.Value)
                            {
                                MessageBox.Show("Problem2");
                                goto next1;
                            }
                            SearchRandomQuestions("Easy", tag, (int)numericUpDown.Value);
                            if (SearchRandomQuestions("Easy", tag, (int)numericUpDown.Value) == false) return false;
                            numericUpDown.Value--;
                            EasyNumericUpDown.Value--;
                            break;
                        case 2:
                            if (CurrentSubject.QuestionsNumberByAttribute("Medium", tag) < (int)numericUpDown.Value)
                            { 
                                MessageBox.Show("Problem3");
                                goto next1;
                            }
                            SearchRandomQuestions("Medium", tag, (int)numericUpDown.Value);
                            if (SearchRandomQuestions("Medium", tag, (int)numericUpDown.Value) == false) return false;
                            numericUpDown.Value--;
                            MediumNumericUpDown.Value--;
                            break;
                        case 3:
                            if (CurrentSubject.QuestionsNumberByAttribute("Hard", tag) < (int)numericUpDown.Value)
                            {
                                MessageBox.Show("Problem4");
                                goto next1;
                            }
                                SearchRandomQuestions("Hard", tag, (int)numericUpDown.Value);
                            if (SearchRandomQuestions("Hard", tag, (int)numericUpDown.Value) == false) return false;
                            numericUpDown.Value--;
                            HardNumericUpDown.Value--;
                            break;
                        default:
                            MessageBox.Show("Can't find question!");
                            return false;
                    }
                }
                else 
                {
                    MessageBox.Show("Can't find tag!");
                    return false;
                }
            }

            int j = random.Next(0,3);
            switch (j)
            {
                case 0:
                    if (CurrentSubject.QuestionsNumberByAttribute("Easy", null) < (int)EasyNumericUpDown.Value) MessageBox.Show("Not enough questions of easy difficulty. Please, try again!"); //βγαινω απο τη μεθοδο πατημα κουμπιου (με καποιο τροπο)
                    SearchRandomQuestions("Easy", null, (int)EasyNumericUpDown.Value);
                    if (SearchRandomQuestions("Easy", null, (int)EasyNumericUpDown.Value) == false) return false;
                    EasyNumericUpDown.Value--;
                    break;
                case 1:
                    if (CurrentSubject.QuestionsNumberByAttribute("Medium", null) < (int)MediumNumericUpDown.Value) MessageBox.Show("Not enough questions of medium difficulty. Please, try again!"); //βγαινω απο τη μεθοδο πατημα κουμπιου(με καποιο τροπο)
                    SearchRandomQuestions("Medium", null, (int)MediumNumericUpDown.Value);
                    if (SearchRandomQuestions("Medium", null, (int)MediumNumericUpDown.Value) == false) return false;
                    MediumNumericUpDown.Value--;
                    break;
                case 2:
                    if (CurrentSubject.QuestionsNumberByAttribute("Hard", null) < (int)HardNumericUpDown.Value) MessageBox.Show("Not enough questions of medium difficulty. Please, try again!"); //βγαινω απο τη μεθοδο πατημα κουμπιου (με καποιο τροπο)
                    SearchRandomQuestions("Hard", null, (int)HardNumericUpDown.Value);
                    if (SearchRandomQuestions("Hard", null, (int)HardNumericUpDown.Value) == false) return false;
                    HardNumericUpDown.Value--;
                    break;
                default:
                    MessageBox.Show("Can't find question!");
                    break;
            }
            if(TestQuestions.Count() < QuestionsNumericUpDown.Value)
            {
                int k = random.Next(0, CurrentSubject.Questions.Count() - 1);
                if (!TestQuestions.Contains(CurrentSubject.Questions[k]))
                {
                    TestQuestions.Add(CurrentSubject.Questions[k]);
                }
            }
            return true;
        }


        public bool SearchRandomQuestions(string difficulty, string tag, int number)
        {
            if(number > CurrentSubject.Questions.Count())
            {
                MessageBox.Show("Not enough questions available!");
                return false;
            }
            int count = 0; 
            Random random = new Random();
            while (count < number)
            {
                int k = random.Next(0, CurrentSubject.Questions.Count());
                if (!TestQuestions.Contains(CurrentSubject.Questions[k]))
                {
                    if (tag != null)
                    {
                        if(difficulty != null)
                        {
                                if (CurrentSubject.Questions[k].Tags.Contains(tag) && CurrentSubject.Questions[k].Equals(difficulty))
                                {
                                    TestQuestions.Add(CurrentSubject.Questions[k]);
                                    count++;
                                }
                        }
                        else
                        {
                                if (CurrentSubject.Questions[k].Tags.Contains(tag))
                                {
                                    TestQuestions.Add(CurrentSubject.Questions[k]);
                                    count++;
                                }  
                        }
                    }
                    else 
                    {
                        if(difficulty == null)
                        {
                            if (CurrentSubject.Questions[k].Difficulty.Equals(difficulty))
                            {
                                TestQuestions.Add(CurrentSubject.Questions[k]);
                                count++;
                            }     
                        }
                    }
                }
            }
            return true;
        }

    }
}