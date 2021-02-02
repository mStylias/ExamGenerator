using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator.MainFiles
{
    public partial class FormManualGenerate : Form
    { 
        List<Question> questions;
        string subjectName;
        public FormManualGenerate(string subjectName, List<Question> questions)
        {
            InitializeComponent();
            this.subjectName = subjectName;
            this.questions = questions;
        }

        /* Make the form draggable */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void labelQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /* Close the form */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Generate the exam into a microsoft word document */
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //if (MicrosoftWordManager.CreateExamDocument(subjectName, questions, @"C:\Users\Michalis\Desktop",
            //                                        Convert.ToInt32(LayoutNumericUpDown.Value)))
            //    MessageBox.Show("Succesfully generated exam!", "Success");
            //else
            //    MessageBox.Show("An error occured during exam generation. " +
            //                    "If the document already exists close any programs that might be using it " +
            //                    "and try again.", "Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
