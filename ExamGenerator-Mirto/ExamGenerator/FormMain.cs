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
        public Subject subject;
        string username;

        public FormMain(Subject subject, string username)
        {
            InitializeComponent();
            previousSize = Size; // Used to make user controls responsive
            this.subject = subject;
            this.username = username;
            //questionsSection.CurrentSubject = subject;
            autoSection1.OnLoad(subject);
            addQuestionsSection1.OnLoad(subject);
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
            manualSection.SearchAndDisplayQuestions(textBoxSearch.Text);
        }

    }
}
