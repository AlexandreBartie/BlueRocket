using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class pagFiltro : UserControl
    {

        private EditorCLI Editor;
        public pagFiltro()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(SeparadorH);

            usrFilterTags.Setup(Editor);
            usrFilterScripts.Setup(Editor);

        }

        public new void Refresh()
        {
            usrFilterTags.Refresh();

            usrFilterScripts.Refresh();
        }

        public void View()
        {
            usrFilterScripts.View();
        }
    }
}
