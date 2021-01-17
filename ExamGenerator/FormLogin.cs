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

namespace ExamGenerator
{
    public partial class FormLogin : Form
    {
        Dictionary<string, Subject> subjects = new Dictionary<string, Subject>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoadData();
            CustomizeButtonsHover();
        }

        private void LoadData()
        {
            // Get saved subjects
            var temp = Serialize.LoadSubjects();
            if (temp != null)
                subjects = temp;

            // Load them to the dropdown menu
            if (subjects != null)
                foreach (var subject in subjects)
                {
                    dropdownListSubjects.Items.Add(subject.Key);
                }
        }

        private void CustomizeButtonsHover()
        {
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 166, 243);
            buttonMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 166, 243);
        }

        /* Titlebar buttons */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region ...Ability to move the login form...
        /* For moving form from title bar */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void movablePanels_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        /* Initiate textboxes */
        private void textboxName_Load(object sender, EventArgs e)
        {
            textboxUsername.InitiateField("Username");
        }

        private void textBoxSubject_Load(object sender, EventArgs e)
        {
            textBoxSubject.InitiateField("Subject");
        }

        
        





        /* Open the main form with the correct information */
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (InfoIsCorrect())
                LoadOrCreateSubject();   
        }


        /* Returns true if only one of the options to choose 
         * how the subject will be loaded is selected and
         * the username field is not empty. e.g. If
         * the user selects an item from the list and writes
         * a name for a new subject this method returns false */
        private bool InfoIsCorrect()
        {         
            if (string.IsNullOrWhiteSpace(textboxUsername.Text))
            {
                MessageBox.Show("Please type your name on the appropriate textbox",
                               "Username required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }                

            // If both are empty
            if (string.IsNullOrWhiteSpace(textBoxSubject.Text) && !IsDropdownUsed())
            {
                MessageBox.Show("Please choose a subject from the list or create a new one" +
                                " by typing it on the appropriate textbox",
                                "No subject is selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }                

            // If both are not empty
            if (!string.IsNullOrWhiteSpace(textBoxSubject.Text) && IsDropdownUsed())
            {
                MessageBox.Show("Either choose a subject from the list or create a new one" +
                                " by typing it on the appropriate textbox but don't do both!",
                                "Can't determine subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
                

            return true;
        }

        private bool IsDropdownUsed()
        {
            if (dropdownListSubjects.SelectedItem == null)
                return false;
            else if (dropdownListSubjects.SelectedItem.ToString().Equals("No subject is selected"))
                return false;
            else
                return true;
        }

        /* Create or load a subject with the given
         * information and open the main form */
        private void LoadOrCreateSubject()
        {
            Subject subject;

            if (IsDropdownUsed())
            {
                subject = subjects[dropdownListSubjects.SelectedItem.ToString()];
            }
            // Make sure that the given subject doesn't already exist in the list
            else if (!subjects.TryGetValue(textBoxSubject.Text, out subject))
            {
            
                subject = new Subject(textBoxSubject.Text);
                subjects.Add(subject.Name, subject);

                Serialize.SaveSubjects(subjects);
            }

            var form = new FormMain(subject, textboxUsername.Text);
            this.Close();
            form.Show();
        }
    }
}
