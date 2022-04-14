using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrActionConfig : UserControl
    {

        private EditorCLI Editor;

        public usrActionConfig()
        {
            InitializeComponent();
        }
        private void cmdPath_Click(object sender, EventArgs e)
        {
            //SelecionarArquivoCFG();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

           // App.Format.SetPadrao(txtPath, prmEditavel: false);
           // App.Format.SetPadrao(cmdPath);

        }

        public new void Refresh()
        {

            txtPath.Text = Editor.Project.nome;

        }

    }

}
