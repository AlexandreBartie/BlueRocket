using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.UX
{
    //public enum ePageScripts : int
    //{
    //    ePageLista = 0,
    //    ePageFiltro = 1,
    //    ePageEstrutura = 2,
    //}

    public class PanelProject : PageControl
    {

        private UXBuilder Builder;

        private usrListScripts pagListScripts => (usrListScripts)Builder.GetElement("Scripts");
        private usrListTags pagListTags => (usrListTags)Builder.GetElement("Filter");


        //private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabPage.SelectedIndex == (int)ePageScripts.ePageLista)
        //        Editor.OnFilterTagChanged();
        //}

        public bool IsMultiSelected => pagListScripts.IsMultiSelected;

        public void GetSelected() => pagListScripts.GetSelected();

        public PanelProject()
        {
            Builder = new UXBuilder(this, prmTitle: true);

            Builder.AddElement("Scripts", new usrListScripts());
            Builder.AddElement("Filter", new usrListTags());

            Builder.AddTab(prmPages: "Scripts,Filter", prmAligment: TabAlignment.Bottom);
        }

        public new void Setup(EditorCLI prmEditor)
        {
            base.Setup(prmEditor);

            pagListScripts.Setup(Editor);
            pagListTags.Setup(Editor);
        }

        public void Build()
        {
            Builder.SetText(prmText: Editor.Project.GetConsoleTitle());

            pagListScripts.Build();

            pagListTags.Build();
        }

        public void ViewSelections() => pagListScripts.ViewSelections();

        public void ViewAll(bool prmSetup) => pagListScripts.ViewAll(prmSetup);
        public void ViewScript(ScriptCLI prmScript) => pagListScripts.ViewScript(prmScript);
        public void ViewCurrent() => pagListScripts.ViewCurrent();

        public bool FindScript(ScriptCLI prmScript) => pagListScripts.FindScript(prmScript);

    }
}
