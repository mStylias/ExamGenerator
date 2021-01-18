using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator
{
    public partial class FormMain : Form
    {
        Subject subject;
        string username;
        public FormMain(Subject subject, string username)
        {
            InitializeComponent();
            this.subject = subject;
            this.username = username;
        }

        /* Gives the focus to the search textbox when a control in 
         * the search area is clicked */
        private void searchArea_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        private void radioMenuQuestions_Click(object sender, EventArgs e)
        {

        }
    }
}
