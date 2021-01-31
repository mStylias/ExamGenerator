using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator.CustomControls
{
    public class TogglablePanel : Panel
    {
        public void ShowPanel(ControlCollection targetContainerControls)
        {
            foreach (Panel panel in targetContainerControls.OfType<Panel>())
            {
                if (panel is TogglablePanel)
                    panel.Hide();
                else
                    ShowPanel(panel.Controls);
            }
            this.Show();
        }
    }
}
