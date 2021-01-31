using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator.MainFiles
{
    public partial class AddQuestionsSection : UserControl
    {
        public Subject subject;
        public AddQuestionsSection()
        {
            InitializeComponent();
        }

        private void AddQuestionsSection_Load(object sender, EventArgs e)
        {
            //listBox1.Update();
            ////listBox1.DataSource = subject.SubjectTags;
        }

        public void OnLoad(Subject subject)
        {
            this.subject = subject;
            if (!subject.SubjectTags.Any()) listBox1.Items.Add("You haven't created a tag yet.");
            else
            {
                if (listBox1.Items.Contains("You haven't created a tag yet.")) listBox1.Items.Remove("You haven't created a tag yet.");
                foreach (string s in subject.SubjectTags)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                HashSet<string> tags = new HashSet<string>();
                if(listBox1.SelectedItem != null) tags = (HashSet<string>)listBox1.SelectedItem;
                if (richTextBox4.Text != null)
                {
                    tags.Add(richTextBox4.Text);
                }
                List<string> answers = new List<string>();
                foreach(RichTextBox textbox in panel3.Controls.OfType<RichTextBox>())
                {
                    answers.Add(textbox.Text);
                }
                Question q = new Question(subject, tags, richTextBoxQuestion.Text, answers, richTextBoxCorrectAnswer.Text, comboBox1.SelectedItem.ToString());
                if (q != null) MessageBox.Show("Question added successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static int textboxCounter = 2; // Used to name the new textboxes correctly
        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            // Locations
            int addQuestionY = AddAnswerButton.Location.Y + 70;
            int addQuestionX = AddAnswerButton.Location.X;
            AddAnswerButton.Location = new Point(addQuestionX, addQuestionY);

            int answerTextboxY = addQuestionY - 70;

            // Advance the counter
            textboxCounter++;

            // Make the new textbox
            RichTextBox t = new RichTextBox
            {
                Anchor = AnchorStyles.Top,
                Dock = DockStyle.Top,
                Font = new Font("Century Gothic", 11),
                Location = new Point(addQuestionX, answerTextboxY),
                Margin = new Padding(3, 0, 3, 0),
                Multiline = true,

                // Make the new textbox
                Name = "AnswerTextBox" + textboxCounter,
                Size = new Size(647, 40),
                TabIndex = 0,
                Text = textboxCounter + "."
            };

            // Add the new text box to panelAddQuestion
            panel3.Controls.Add(t);
            panel3.Controls.SetChildIndex(t, 2);
            foreach (Control c in panel1.Controls)
            {
                if(c.TabIndex > panel3.TabIndex)
                {
                    //MessageBox.Show(c.Name + " " + c.TabIndex);
                    c.Location = new Point(c.Location.X, c.Location.Y + 40);
                }
            }
            
            // Make remove button visible
            RemoveAnswerButton.Visible = true;

            // Move remove button
            RemoveAnswerButton.Location = new Point(RemoveAnswerButton.Location.X, RemoveAnswerButton.Location.Y + 40);
        }

        private void RemoveAnswerButton_Click(object sender, EventArgs e)
        {
            foreach (Control textBox in panel3.Controls.OfType<RichTextBox>())
            {

                if (textboxCounter < 3)
                {
                    break;
                }
                else if (textBox.Name.Equals("AnswerTextBox" + textboxCounter))
                {
                    // Remove the textBox
                    panel3.Controls.Remove(textBox);
                    // Move the AddQuestion button
                    AddAnswerButton.Location = new Point(AddAnswerButton.Location.X, AddAnswerButton.Location.Y - 40);
                    // Move the RemoveAnswer button
                    RemoveAnswerButton.Location = new Point(RemoveAnswerButton.Location.X, RemoveAnswerButton.Location.Y - 40);

                    textboxCounter--;

                    // Make the remove button invisible when there are only 2 textboxes so it doesnt remove more
                    if (textboxCounter < 3)
                    {
                        RemoveAnswerButton.Visible = false;
                    }
                    break;
                }
            }
        }
    }
}
