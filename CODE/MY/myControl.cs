using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public static class myMenu
    {
        public static bool InvertCheck(ToolStripMenuItem prmMenu)
        {
            prmMenu.Checked = !prmMenu.Checked; return prmMenu.Checked;
        }

    }
}
