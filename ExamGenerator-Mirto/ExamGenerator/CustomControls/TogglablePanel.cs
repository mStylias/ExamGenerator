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
        public static void ShowPanel(ControlCollection controls, TogglablePanel panelToShow)
        {
            foreach (TogglablePanel tPanel in controls.OfType<TogglablePanel>())
            {
                if (tPanel != panelToShow)
                    tPanel.Hide();
            }
            panelToShow.Show();
        }
    }
}
