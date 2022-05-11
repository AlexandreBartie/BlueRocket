using BlueRocket.PAGES.ListScripts;
using Dooggy;
using Katty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrListScripts : PageControl
    {
        internal PageListScripts Page; 
       
        private void lstScripts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Page.Actions.SetFocus(prmScript: Page.Actions.GetTag(e.Item));
        }

        private void lstScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = Page.Actions.GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                Page.Actions.DoubleClick(prmScript: Page.Actions.GetTag(item));
        }

        public bool IsMultiSelected => Page.Resources.IsMultiSelected;

        public usrListScripts()
        {
            InitializeComponent();

            Page = new PageListScripts(prmPage: this, prmListView: lstScripts);
        }

        public new void Setup(EditorCLI prmEditor)
        {
            Page.Setup(prmEditor);
        }

        public void Build() => Page.Build();

        public void ViewAll(bool prmSetup) => Page.ViewAll(prmSetup);
        public void ViewScript(ScriptCLI prmScript) => Page.ViewScript(prmScript);

        public void ViewCurrent() => Page.ViewCurrent();

        public void SetFocus(ScriptCLI prmScript) => Page.Actions.SetFocus(prmScript);

        public bool FindScript(ScriptCLI prmScript) => Page.Actions.FindScript(prmScript);

        public void GetSelected() => Page.Actions.GetSelected();

        public void ViewSelections() => Page.Actions.ViewSelections();

    }

}