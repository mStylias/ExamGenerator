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

        /* Menu functionality */
        private void radioMenuQuestions_Click(object sender, EventArgs e)
        {
            // Show the color panel associated with the selected menu radio button
            TogglablePanel.ShowPanel(panelMenuButtons.Controls, panelQuestionsActive);
        }

        private void radioMenuAddQuestions_Click(object sender, EventArgs e)
        {
            TogglablePanel.ShowPanel(panelMenuButtons.Controls, panelAddQuestionsActive);
        }

        private void radioMenuManual_Click(object sender, EventArgs e)
        {
            TogglablePanel.ShowPanel(panelMenuButtons.Controls, panelManualActive);
        }

        private void radioMenuAuto_Click(object sender, EventArgs e)
        {
            TogglablePanel.ShowPanel(panelMenuButtons.Controls, panelAutoActive);
        }
    }
}
