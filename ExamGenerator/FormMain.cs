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
        string profName;
        public FormMain(Subject subject, string profName)
        {
            InitializeComponent();
            this.subject = subject;
            this.profName = profName;
        }

    }
}
