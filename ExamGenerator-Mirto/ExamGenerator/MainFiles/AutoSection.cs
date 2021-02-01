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
        public StringBuilder FileContent = new StringBuilder();
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
            for(int i=0; i<QuestionsNumericUpDown.Value-1; i++)
            {
                int k = random.Next(0, subject.Questions.Count()-1);
                if(!TestQuestions.Contains(subject.Questions[k]))
                {
                    TestQuestions.Add(subject.Questions[k]);
                    FileContent.Append(subject.Questions[k].ToString() + Environment.NewLine);
                    CorrectAnswers.Add(subject.Questions[k].CorrectAnswer);
                    FileContent.Append(subject.Questions[k].CorrectAnswer.ToString() + Environment.NewLine);
                }
            }
            WriteToFile("CorrectAnswers.doc", FileContent.ToString());
            FileContent.Clear();

            //different test layout
            for (int i=0; i<LayoutNumericUpDown.Value-1; i++)
            {
                for(int m=0; m < TestQuestions.Count() - 1; m++)
                {
                    int j = random.Next(0, TestQuestions.Count() - 1);
                    bool n = FileContent.ToString().Contains(TestQuestions[j].ToString());
                    if (!n) FileContent.Append(Environment.NewLine + Environment.NewLine + TestQuestions[j].ToString() + Environment.NewLine + Environment.NewLine);
                    for (int y=0; y< TestQuestions[j].PossibleAnswers.Count(); y++)
                    {
                        int l = random.Next(0, TestQuestions[j].PossibleAnswers.Count() - 1);
                        bool w = FileContent.ToString().Contains(TestQuestions[j].PossibleAnswers[l].ToString());
                        if (!w) FileContent.Append(TestQuestions[j].PossibleAnswers[l] + Environment.NewLine);
                    }
                }

                WriteToFile("Test" + i + "doc", FileContent.ToString());
                FileContent.Clear();
            }
        }

        private void WriteToFile(string filepath, string content)
        {
            //Word 2007 - 2019 Version
            if (officeNumberVersion == "12" || officeNumberVersion == "14" || officeNumberVersion == "15" || officeNumberVersion == "16")
            {
                StreamWriter sw = new StreamWriter(filepath + 'x');
                sw.WriteLine(content);
            }
            //Word 97 - 2003 Version
            else if (officeNumberVersion == "7" || officeNumberVersion == "8" || officeNumberVersion == "9" || officeNumberVersion == "10" || officeNumberVersion == "11")
            {
                StreamWriter sw = new StreamWriter(filepath);
                sw.WriteLine(content);
            }
        }
    }
}
