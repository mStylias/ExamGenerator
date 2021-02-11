using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamGenerator.CustomControls;
using ExamGenerator.MainFiles;

namespace ExamGenerator
{
    public partial class FormMain : Form
    {
        public Subject subject;
        string username;

        public FormMain(Subject subject, string username)
        {
            InitializeComponent();
            previousSize = Size; // Used to make user controls responsive
            this.subject = subject;
            this.username = username;
            labelUsername.Text = username;

            //Temporary load subject
            subject = new Subject("Math");

            var possibleAnswers = new List<string>();
            possibleAnswers.Add("1. Who the fuck knows");
            possibleAnswers.Add("2. Certainly not me");
            possibleAnswers.Add("3. Only the people who teach this shit");
            var correctAnswer = "2. Certainly not me";
            string difficulty;

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
                    tags.Add("Modulo " + i);

                subject.AddQuestion(new Question(tags, questionBody, possibleAnswers, correctAnswer, difficulty));
            }

            autoSection1.OnLoad(subject);
            addQuestionsSection1.OnLoad(subject);
            manualSection.OnLoad(subject);
        }

        /* Updates the ui of all user controls using the subject */
        public void UpdateAndSave()
        {
            addQuestionsSection1.UpdateUI();
            manualSection.UpdateUI();
            Serialize.SaveSubjects(Subject.Subjects);
        }

        /* Gives the focus to the search textbox when a control in 
         * the search area is clicked */
        private void searchArea_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        /* Menu functionality */
        private void radioMenuAddQuestions_Click(object sender, EventArgs e)
        {
            panelAddQuestionsActive.ShowPanel(panelMenuButtons.Controls);
            addQuestionsSection1.BringToFront();
        }

        private void radioMenuManual_Click(object sender, EventArgs e)
        {
            panelManualActive.ShowPanel(panelMenuButtons.Controls);
            manualSection.BringToFront();
        }

        private void radioMenuAuto_Click(object sender, EventArgs e)
        {
            panelAutoActive.ShowPanel(panelMenuButtons.Controls);
            autoSection1.BringToFront();
        }

        /* Display subjects */
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            int counter = 1;
            foreach (KeyValuePair<string, Subject> subject in Subject.Subjects)
            {
                Button radioSubject = DisplaySubject(subject.Value);
                panelSubjects.Controls.SetChildIndex(radioSubject, counter);
                counter++;
            }
            panelSubjects.Controls.SetChildIndex(labelSubjectsList, panelSubjects.Controls.Count + 1);

        }

        private Button DisplaySubject(Subject subject)
        {
            Button button = new Button();

            button.AutoEllipsis = true;
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Location = new System.Drawing.Point(0, 72);
            button.Margin = new System.Windows.Forms.Padding(0);
            button.MinimumSize = new System.Drawing.Size(195, 50);
            button.Size = new System.Drawing.Size(195, 50);
            button.TabIndex = 10;
            button.TabStop = true;
            button.Text = subject.Name;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button.UseVisualStyleBackColor = true;
            button.Click += ChangeSubject_CheckedChanged;

            if (this.subject.Equals(subject))
                button.BackColor = Color.FromArgb(241, 241, 253);
           
            panelSubjects.Controls.Add(button);
            return button;
        }

        private void ChangeSubject_CheckedChanged(object sender, EventArgs e)
        {
            Subject subject = Subject.Subjects[((Button)sender).Text];

            this.Hide();
            FormLoad form = new FormLoad(subject, username);
            form.Show();
        } 

        // Responsiveness
        Size previousSize;
        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            if (Size != previousSize)
            {
                manualSection.OnResizeEnd();
                previousSize = Size;
            }
                
        }

        FormWindowState previousState = FormWindowState.Normal;
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState != previousState && WindowState != FormWindowState.Minimized)
            {
                manualSection.OnResizeEnd();
                previousState = WindowState;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            manualSection.SearchQuestions(textBoxSearch.Text);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
