using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.UX
{
    public class PanelMain : UserControl
    {
        private UXBuilder Builder;

        internal PanelProject pagProject => (PanelProject)Builder.GetElement("Project");
        internal PanelEdition pagEdition => (PanelEdition)Builder.GetElement("Edition");

        public PanelMain(frmMainCLI prmMain, EditorCLI prmEditor)
        {

            prmMain.Setup(prmEditor);

            Builder = new UXBuilder(prmMain);

            Builder.AddElement("Project", new PanelProject(), prmDockStyle: DockStyle.Left, prmSplitter: true);
            Builder.AddElement("Edition", new PanelEdition());

            Builder.Setup(prmEditor);
        }
    }
}
