using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator
{
    public partial class FormLoad : Form
    {
        Subject subject;
        string username;
        FormMain formMain;

        public FormLoad(Subject subject, string username)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;

            this.subject = subject;
            this.username = username;

            InitializeLoading();
        }

        [STAThread]
        private void InitializeLoading()
        {
            Thread loadMain = new Thread(LoadFormMain);
            loadMain.SetApartmentState(ApartmentState.STA);
            loadMain.Start();
        }

        [STAThread]
        private void LoadFormMain()
        {
            formMain = new FormMain(subject, username);
            formMain.Show();
            Invoke((Action)(() => this.Hide()));
            Invoke((Action)(() => pictureBox1.Enabled = false));
            Application.Run();
            Invoke((Action)(() => Application.Exit()));
            Console.WriteLine("Exit success");
        }
    }
}
