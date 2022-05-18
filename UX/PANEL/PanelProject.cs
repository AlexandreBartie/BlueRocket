using BlueRocket.PAGES.ListScripts;
using BlueRocket.PAGES.ListTags;
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

        //private usrListScripts pagListScripts => (usrListScripts)Builder.GetElement("Scripts");

        private PageListTags ListTags;// = new PageListTags();
        private PageListScripts ListScripts;// = new PageListScripts();

        //private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabPage.SelectedIndex == (int)ePageScripts.ePageLista)
        //        Editor.OnFilterTagChanged();
        //}

        public bool IsMultiSelected => ListScripts.IsMultiSelected;

        public void GetSelected() => ListScripts.GetSelected();

        public PanelProject()
        {

            ListTags = new PageListTags();
            ListScripts = new PageListScripts();

            Builder = new UXBuilder(this, prmTitle: true);

            Builder.AddElement("Scripts", ListScripts.Page);
            Builder.AddElement("Filter", ListTags.Page);

            Builder.AddTab(prmPages: "Scripts,Filter", prmAligment: TabAlignment.Bottom);
        }

        public new void Setup(EditorCLI prmEditor)
        {
            base.Setup(prmEditor);

            ListScripts.Setup(Editor);
            ListTags.Setup(Editor);
        }

        public void Build()
        {
            Builder.SetText(prmText: Editor.Project.GetConsoleTitle());

            ListTags.Build();

            ListScripts.Build();

        }

        public void ViewSelections() => ListScripts.ViewSelections();

        public void ViewAll(bool prmSetup) => ListScripts.ViewAll(prmSetup);
        public void ViewScript(ScriptCLI prmScript) => ListScripts.ViewScript(prmScript);
        public void ViewCurrent() => ListScripts.ViewCurrent();

        public bool FindScript(ScriptCLI prmScript) => ListScripts.FindScript(prmScript);

    }
}
