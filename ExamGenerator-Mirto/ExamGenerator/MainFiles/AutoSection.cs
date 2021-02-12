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

        public void OnLoad(Subject subject)
        {
            CurrentSubject = subject;

            foreach (string tag in CurrentSubject.AllTags)
            {
                DisplayTag(tag);
            }
            
        }

        public void UpdateUI()
        {
            DisposeTags();
            tagsNumbers.Clear();
            OnLoad(CurrentSubject);
        }

        private void DisposeTags()
        {
            var controls = new List<Control>();
            foreach (Control control in togglePanelTags.Controls)
                controls.Add(control);

            togglePanelTags.Controls.Clear();
            foreach (Control control in controls)
            {
                control.Dispose();
            }
            Console.WriteLine("Successfully cleared. KAPPA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LayoutNumericUpDown.Value <= 0)
            {
                MessageBox.Show("The number of layouts must be at least one", "Incorrect number of layouts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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

                if (tagNumber != null && tagNumber.Value > 0)
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

            //Console.Write("\n\n\nEND\n\n\n");
        }

        [STAThread]
        private void GenerateWordDocuments(List<Question> finalQuestions)
        {
            foreach (Question question in finalQuestions)
            {
                //Console.WriteLine("---------------------------");
                //Console.WriteLine(question.Body);
                //foreach (string tag in question.Tags)
                //    Console.Write(tag + ", ");
                //Console.WriteLine();
                //Console.WriteLine(question.Difficulty);
            }


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = "";
                if (string.IsNullOrWhiteSpace(textBoxFilename.Text))
                {
                    fileName = CurrentSubject.Name;
                }
                else
                    fileName = textBoxFilename.Text;

                string folderPath = folderBrowserDialog.SelectedPath;

                int layoutsNum = (int)LayoutNumericUpDown.Value;

                try
                {
                    MicrosoftWordManager.CreateExamDocument(CurrentSubject.Name, finalQuestions, folderPath, fileName, layoutsNum);
                    MessageBox.Show("Successfully generated exam!", "Success");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show("Microsoft word failed to generate the exam. Make sure that the file name follows the rules of Windows file naming",
                                    "Failed to generate test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

    }
}