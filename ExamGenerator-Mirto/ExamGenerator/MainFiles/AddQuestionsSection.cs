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
            /*listBox1.Items.Add("No1");
            listBox1.Items.Add("No2");
            listBox1.Items.Add("No3");*/
        }

        private void AddQuestionsSection_Load(object sender, EventArgs e)
        {
            //listBox1.DataSource = subject.SubjectTags;
            /*if(subject.SubjectTags == null) listBox1.Items.Add("You haven't created a tag yet.");
            else
            {
                if (listBox1.Items.Contains("You haven't created a tag yet.")) listBox1.Items.Remove("You haven't created a tag yet.");
                foreach (string s in subject.SubjectTags)
                {
                    listBox1.Items.Add(s);
                }
            }*/
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
                answers.AddRange(richTextBoxAnswers.Text.Split(Environment.NewLine.ToCharArray()));
                Question q = new Question(tags, richTextBoxQuestion.Text, answers, richTextBoxCorrectAnswer.Text, comboBox1.SelectedItem.ToString());
                if (q != null) MessageBox.Show("Question added successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
