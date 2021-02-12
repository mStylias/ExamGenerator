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
                if (CurrentSubject.AllTags.Contains("No Tags yet!")) CurrentSubject.AllTags.Remove("No Tags yet!");
                foreach (string tag in CurrentSubject.AllTags)
                {
                    DisplayTag(tag);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> allRemainingDifficultyNums = new Dictionary<string, int>();

            List<string> selectedDifficulties = new List<string>();

            if (EasyNumericUpDown.Value > 0)
            {
                selectedDifficulties.Add("Easy");
                allRemainingDifficultyNums.Add("Easy", (int)EasyNumericUpDown.Value);
            }
            if (MediumNumericUpDown.Value > 0)
            {
                selectedDifficulties.Add("Medium");
                allRemainingDifficultyNums.Add("Medium", (int)MediumNumericUpDown.Value);
            }
            if (HardNumericUpDown.Value > 0)
            {
                selectedDifficulties.Add("Hard");
                allRemainingDifficultyNums.Add("Hard", (int)HardNumericUpDown.Value);
            }

            Dictionary<string, int> allRemainingTagsNums = new Dictionary<string, int>();

            HashSet<string> selectedTags = new HashSet<string>();
            var tagsNumbersCopy = tagsNumbers.ToList();

            foreach (string tag in CurrentSubject.AllTags)
            {
                NumericUpDown tagNumber = tagsNumbersCopy.Find(x => x.Name.Equals(tag + "NumericUpDown"));

                if (tagNumber.Value > 0)
                {
                    selectedTags.Add(tag);
                    allRemainingTagsNums.Add(tag, (int)tagNumber.Value);
                }

            }

            // Check
            int counter = 0;
            foreach (NumericUpDown numeric in tagsNumbersCopy)
                counter += (int)numeric.Value;

            if (counter < EasyNumericUpDown.Value + MediumNumericUpDown.Value + HardNumericUpDown.Value && counter != 0)
            {
                MessageBox.Show("Select at least as many tags as the specified number of questions or leave them all 0",
                                "Unable to generate test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Question> possibleQuestions = CurrentSubject.SearchQuestions(selectedDifficulties, selectedTags);
            possibleQuestions.Shuffle();
            Console.WriteLine(possibleQuestions.Count + " possible questions");

            int possibleQuestionsCount = possibleQuestions.Count;
            if (possibleQuestionsCount < QuestionsNumericUpDown.Value)
            {
                var userResponse = MessageBox.Show("Only " + possibleQuestionsCount + " questions can be selected with the given criteria. Do you want to create a test with only " +
                                possibleQuestionsCount + " questions?", "Not enough questions found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userResponse == DialogResult.Yes)
                {
                    QuestionsNumericUpDown.Value = possibleQuestionsCount;
                }
                else
                    return;
            }



            List<Question> finalQuestions = new List<Question>();

            List<List<Question>> allTagsQuestions = new List<List<Question>>();
            foreach (string tag in selectedTags)
            {
                List<Question> tagQuestions = new List<Question>();
                foreach (Question question in possibleQuestions)
                    if (question.Tags.Contains(tag))
                        tagQuestions.Add(question);

                allTagsQuestions.Add(tagQuestions);
            }
            Console.WriteLine(allTagsQuestions.Count + " number of tags");

            List<List<Question>> allDiffQuestions = new List<List<Question>>();
            foreach (string diff in selectedDifficulties)
            {
                List<Question> diffQuestions = new List<Question>();
                foreach (Question question in possibleQuestions)
                    if (question.Difficulty.Equals(diff))
                        diffQuestions.Add(question);

                allDiffQuestions.Add(diffQuestions);
            }

            Dictionary<Question, int> mostCommonQuestions = new Dictionary<Question, int>();
            foreach (Question question in possibleQuestions)
                mostCommonQuestions.Add(question, 0);

            foreach (Question question in possibleQuestions)
            {
                foreach (List<Question> tagQuestions in allTagsQuestions)
                    if (tagQuestions.Contains(question))
                        mostCommonQuestions[question]++;

                foreach (List<Question> diffQuestions in allDiffQuestions)
                    if (diffQuestions.Contains(question))
                        mostCommonQuestions[question]++;
            }

            //foreach (var keyValue in mostCommonQuestions)
            //{
            //    Console.WriteLine(keyValue.Value);
            //}

            var sortedMostCommonQuestions = from entry in mostCommonQuestions orderby entry.Value descending select entry;

            Console.WriteLine(sortedMostCommonQuestions.Count() + " sorted questions");

            foreach (var keyValue in sortedMostCommonQuestions)
            {
                if (finalQuestions.Count == QuestionsNumericUpDown.Value)
                {
                    break;
                }

                bool AreTagsValid = true;
                foreach (string tag in keyValue.Key.Tags)
                {
                    if (!allRemainingTagsNums.ContainsKey(tag))
                        AreTagsValid = true;
                    else if (allRemainingTagsNums[tag] > 0)
                    {
                        AreTagsValid = true;
                        break;
                    }
                    else
                    {
                        AreTagsValid = false;
                        break;
                    }
                }

                if (!AreTagsValid)
                    continue;

                if (allRemainingDifficultyNums.ContainsKey(keyValue.Key.Difficulty) && allRemainingDifficultyNums[keyValue.Key.Difficulty] == 0)
                    continue;

                if (allRemainingDifficultyNums.ContainsKey(keyValue.Key.Difficulty) && allRemainingDifficultyNums[keyValue.Key.Difficulty] > 0)
                    allRemainingDifficultyNums[keyValue.Key.Difficulty]--;

                foreach (string tag in keyValue.Key.Tags)
                    if (allRemainingTagsNums.ContainsKey(tag))
                        allRemainingTagsNums[tag]--;

                Console.WriteLine(keyValue.Key.Body + "");
                //// show question
                //Console.WriteLine("---------------------------");
                //Console.WriteLine(keyValue.Key.Body);
                //foreach (string tag in keyValue.Key.Tags)
                //    Console.Write(tag + ", ");
                //Console.WriteLine();
                //Console.WriteLine(keyValue.Key.Difficulty);
                ////

                finalQuestions.Add(keyValue.Key);
            }

            foreach (var keyValue in allRemainingTagsNums)
                if (keyValue.Value > 0)
                {
                    MessageBox.Show("Couldn't generate test with the given number of questions and criteria");
                    return;
                }

            foreach (var keyValue in allRemainingDifficultyNums)
                if (keyValue.Value > 0)
                {
                    MessageBox.Show("Couldn't generate test with the given number of questions and criteria");
                    return;
                }


            if (finalQuestions.Count == 0)
            {
                MessageBox.Show("Choose the number of questions that the exam should contain", "Unable to create exam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (finalQuestions.Count < QuestionsNumericUpDown.Value)
            {
                var userResponse = MessageBox.Show("A maximum of " + finalQuestions.Count + " questions can be generated with the given criteria. " +
                                "Do you want to generate only " + finalQuestions.Count + " instead of " + QuestionsNumericUpDown.Value + " questions?",
                                "Not enought questions found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userResponse == DialogResult.Yes)
                    GenerateWordDocuments(finalQuestions);
            }
            else
            {
                GenerateWordDocuments(finalQuestions);
            }

            Console.Write("\n\n\nEND\n\n\n");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //if (togglePanelTags.Controls.OfType<NumericUpDown>().All(x => x.Value == 0) && togglePanelDifficulty.Controls.OfType<NumericUpDown>().All(x => x.Value == 0))
            //{
            //    for (int i = 0; i < QuestionsNumericUpDown.Value; i++)
            //    {
            //        int k = random.Next(0, CurrentSubject.Questions.Count());
            //        if (!TestQuestions.Contains(CurrentSubject.Questions[k]))
            //        {
            //            TestQuestions.Add(CurrentSubject.Questions[k]);
            //        }
            //    }
            //}
            //else if (!ChooseQuestionsByTagOrDifficulty())
            //    return;

            //if(ChooseQuestionsByTagOrDifficulty() == false)
            //{
            //    return;
            //}

            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string folderPath = folderBrowserDialog1.SelectedPath;
            //    string fileName;
            //    if (string.IsNullOrWhiteSpace(textBox1.Text))
            //        fileName = CurrentSubject.Name;
            //    else
            //        fileName = textBox1.Text;

            //    // Create exam
            //    if (MicrosoftWordManager.CreateExamDocument(CurrentSubject.Name, TestQuestions, folderPath, fileName, Convert.ToInt32(LayoutNumericUpDown.Value)))
            //        MessageBox.Show("Succesfully generated exam!", "Success");
            //    else
            //        MessageBox.Show("An error occured during exam generation. " +
            //                        "If the document already exists close any programs that might be using it " +
            //                        "and try again.", "Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void GenerateWordDocuments(List<Question> finalQuestions)
        {
            foreach (Question question in finalQuestions)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(question.Body);
                foreach (string tag in question.Tags)
                    Console.Write(tag + ", ");
                Console.WriteLine();
                Console.WriteLine(question.Difficulty);
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

        List<NumericUpDown> tagsNumbers = new List<NumericUpDown>();
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
            tagsNumbers.Add(numericUpDown);

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