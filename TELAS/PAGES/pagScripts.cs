using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class pagScripts : UserControl
    {

        private EditorCLI Editor;
        public pagScripts()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(SeparadorH);

            usrTestScripts.Setup(Editor);
            usrTestTags.Setup(Editor);
        }

        public void Build()
        {
            usrTestScripts.Build();

            usrTestTags.Build();
        }
        public void View() => usrTestScripts.View();

        public void ViewAll(bool prmCleanup) => usrTestScripts.ViewAll(prmCleanup);

    }
}
