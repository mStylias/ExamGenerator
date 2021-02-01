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
using Microsoft.Win32;

namespace ExamGenerator
{
    public partial class AutoSection : UserControl
    {
        public Subject subject;
        public List<MainFiles.Question> TestQuestions = new List<MainFiles.Question>();
        public List<string> CorrectAnswers = new List<string>();
        Random random = new Random();

        public AutoSection()
        {
            InitializeComponent();
        }

        private void AutoSection_Load(object sender, EventArgs e)
        {
            FindOfficeVersion();
        }

        string officeNumberVersion;
        private void FindOfficeVersion()
        {
            try
            {
                //Get Office Version
                RegistryKey rk = Registry.ClassesRoot.OpenSubKey(@"Word.Application\\CurVer");
                string officeVersion = rk.GetValue("").ToString();
                officeNumberVersion = officeVersion.Split('.')[officeVersion.Split('.').GetUpperBound(0)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Questions Generation
            for(int i=0; i<QuestionsNumericUpDown.Value; i++)
            {
                int k = random.Next(0, subject.Questions.Count()-1);
                if(!TestQuestions.Contains(subject.Questions[k]))
                {
                    TestQuestions.Add(subject.Questions[k]);
                    //ίσως προσθήκη σε ένα άλλο word (ερώτηση-σωστή απάντηση)
                    CorrectAnswers.Add(subject.Questions[k].CorrectAnswer);
                }
            }

            //different test layout
            for(int i=0; i<LayoutNumericUpDown.Value; i++)
            {
                int j = random.Next(0, TestQuestions.Count()-1);
                foreach(string answer in TestQuestions[j].PossibleAnswers)
                {
                    int l = random.Next(0, TestQuestions[j].PossibleAnswers.Count() - 1);
                }

                //Word 2007 - 2019 Version
                if (officeNumberVersion == "12" || officeNumberVersion == "14" || officeNumberVersion == "15" || officeNumberVersion == "16")
                {
                    WriteToFile("Test" + i + ".docx");
                }
                //Word 97 - 2003 Version
                else if (officeNumberVersion == "7" || officeNumberVersion == "8" || officeNumberVersion == "9" || officeNumberVersion == "10" || officeNumberVersion == "11")
                {
                    WriteToFile("Test" + i + ".doc");
                }
            }
        }

        private void WriteToFile(string filepath)
        {

        }
    }
}
