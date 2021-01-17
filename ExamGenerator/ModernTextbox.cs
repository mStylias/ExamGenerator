using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator
{
    public partial class ModernTextbox : UserControl
    {
        public ModernTextbox()
        {
            InitializeComponent();
        }

        private void ModernTextbox_Load(object sender, EventArgs e)
        {
            SetFocusEvents(Controls);
        }

        private void SetFocusEvents(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.GotFocus += ControlGotFocus;
                control.LostFocus += ControlLostFocus;
                control.Click += Focus_OnClick;
                control.Cursor = Cursors.IBeam;

                if (control is Panel)
                    SetFocusEvents(control.Controls);
            }
        }

        /* Set the name of the field */
        public void InitiateField(string fieldName, string sampleText)
        {
            labelFieldName.Text = fieldName;
            textBox.Text = sampleText;
        }

        public void InitiateField(string fieldName)
        {
            labelFieldName.Text = fieldName;
            textBox.Text = "";
        }

        /* Associates the text of the user control with the textbox */
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Text = textBox.Text; 
        }

        /* Make the side color appear and disapear according to focus */
        private void ControlGotFocus(object sender, EventArgs e)
        {
            panelSideColor.BackColor = Color.FromArgb(164, 166, 243);
        }

        private void ControlLostFocus(object sender, EventArgs e)
        {
            panelSideColor.BackColor = Color.FromArgb(250, 250, 245);
        }

        private void Focus_OnClick(object sender, EventArgs e)
        {
            textBox.Focus();
        }


        /* Stop the user from writting more than one line in the textbox */
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

       
    }
}
