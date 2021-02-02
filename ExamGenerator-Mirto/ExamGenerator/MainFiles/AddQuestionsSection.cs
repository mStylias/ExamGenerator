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

        private enum TagLocation{
            Left,
            Right
        }

        TagLocation nextTagLocation = TagLocation.Left;
        public void OnLoad(Subject subject)
        {
            //this.subject = subject;
            //if (!subject.AllTags.Any()) listBoxTags.Items.Add("You haven't created a tag yet.");

            //else
            //{
            //    if (listBoxTags.Items.Contains("You haven't created a tag yet.")) listBoxTags.Items.Remove("You haven't created a tag yet.");
            //    foreach (string s in subject.AllTags)
            //    {
            //        listBoxTags.Items.Add(s);
            //    }
            //}

            this.subject = subject;
            
            foreach (string tag in subject.AllTags)
            {
                if (nextTagLocation == TagLocation.Left)
                {
                    DisplayTag(tag, panelLeftTags);
                    nextTagLocation = TagLocation.Right;
                }
                else
                {
                    DisplayTag(tag, panelRightTags);
                    nextTagLocation = TagLocation.Left;
                }
            }
        }

        private void DisplayTag(string name, Panel panel)
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
            checkbox.AutoEllipsis = true;
            checkbox.UseVisualStyleBackColor = true;

            panel.Controls.Add(checkbox);
        }

        private void buttonCreateTag_Click(object sender, EventArgs e)
        {
            string tag;
            if (!string.IsNullOrWhiteSpace(richTextBoxCreateTag.Text))
                tag = richTextBoxCreateTag.Text;
            else
            {
                MessageBox.Show("Type a tag in the textbox in order to create it", "Unable to create tag",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!subject.AllTags.Contains(tag))
            {
                if (nextTagLocation == TagLocation.Left)
                {
                    DisplayTag(tag, panelLeftTags);
                    nextTagLocation = TagLocation.Right;
                }
                else
                {
                    DisplayTag(tag, panelRightTags);
                    nextTagLocation = TagLocation.Left;
                }

                subject.AllTags.Add(tag);
            }
            else
                MessageBox.Show("The tag you typed already exists. Select it instead", "Tag already exists",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                HashSet<string> tags = new HashSet<string>();
                //if(listBoxTags.SelectedItem != null) tags = (HashSet<string>)listBoxTags.SelectedItem;
                if (richTextBoxCreateTag.Text != null)
                {
                    tags.Add(richTextBoxCreateTag.Text);
                }
                List<string> answers = new List<string>();

                foreach(RichTextBox textbox in panelPossibleAnswers.Controls.OfType<RichTextBox>())
                {
                    answers.Add(textbox.Text);
                }
                Question q = new Question(tags, richTextBoxQuestion.Text, answers, richTextBoxCorrectAnswer.Text, comboBoxDifficulty.SelectedItem.ToString());

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
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Top,
                Font = new Font("Century Gothic", 11),
                Location = new Point(addQuestionX, answerTextboxY),
                Margin = new Padding(3, 0, 3, 0),
                Multiline = true,

                // Make the new textbox
                Name = "AnswerTextBox" + textboxCounter,
                Size = new Size(647, 40),
                TabIndex = 0,
                Text = textboxCounter + ". "
            };

            // Add the new text box to panelAddQuestion
            panelPossibleAnswers.Controls.Add(t);
            panelPossibleAnswers.Controls.SetChildIndex(t, 2);
            //foreach (Control c in panelAllFields.Controls)
            //{
            //    if(c.TabIndex > panelPossibleAnswers.TabIndex)
            //    {
            //        //MessageBox.Show(c.Name + " " + c.TabIndex);
            //        c.Location = new Point(c.Location.X, c.Location.Y + 40);
            //    }
            //}
            
            // Make remove button visible
            RemoveAnswerButton.Visible = true;

            // Move remove button
            RemoveAnswerButton.Location = new Point(RemoveAnswerButton.Location.X, RemoveAnswerButton.Location.Y + 40);
        }

        private void RemoveAnswerButton_Click(object sender, EventArgs e)
        {
            foreach (Control textBox in panelPossibleAnswers.Controls.OfType<RichTextBox>())
            {

                if (textboxCounter < 3)
                {
                    break;
                }
                else if (textBox.Name.Equals("AnswerTextBox" + textboxCounter))
                {
                    // Remove the textBox
                    panelPossibleAnswers.Controls.Remove(textBox);
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
