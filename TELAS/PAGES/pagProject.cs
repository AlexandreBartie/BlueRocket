using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{

    public enum ePageScripts : int
    {
        ePageLista = 0,
        ePageFiltro = 1,
        ePageEstrutura = 2,
    }

    public partial class pagProject : usrMoldura
    {

        private EditorCLI Editor;

        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPage.SelectedIndex == (int)ePageScripts.ePageLista)
                Editor.OnFilterTagChanged();
        }

        public bool IsMultiSelected => usrTestScripts.IsMultiSelected;

        public void GetSelected() => usrTestScripts.GetSelected();

        public pagProject()
        {
            InitializeComponent();

        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            usrTestScripts.Setup(Editor);
            usrTestTags.Setup(Editor);
        }

        public void Build()
        {
            SetTitle(prmText: Editor.Project.GetConsoleTitle());

            usrTestScripts.Build();

            usrTestTags.Build();
        }

        public void ViewSelections() => usrTestScripts.ViewSelections();

        public void ViewAll(bool prmSetup) => usrTestScripts.ViewAll(prmSetup);

        public void ViewScript(ScriptCLI prmScript) => usrTestScripts.ViewScript(prmScript);
        public void ViewCurrent() => usrTestScripts.ViewCurrent();

        public bool FindScript(ScriptCLI prmScript) => usrTestScripts.FindScript(prmScript);

    }
}
