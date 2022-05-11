using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrViewCode : PageControl
    {

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e) => Editor.OnScriptCodeEditing();
        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            if (Editor.HasScript)
            {
                Editor.Console.SetCode(txtCode.Text);

                Editor.OnScriptCodeChanged();
            }

        }  

        public usrViewCode()
        {
            InitializeComponent();
        }

        public new void Setup(EditorCLI prmEditor)
        {

            base.Setup(prmEditor);

            Editor.Format.SetMemo(txtCode);

            usrAction.Setup(prmEditor);

        }

        public void View()
        {

            if (Editor.HasScript)
            {

                txtCode.Enabled = true;
                txtCode.ReadOnly = Editor.Script.IsLocked;

                txtCode.Text = Editor.Script.code;
                txtCode.ForeColor = Editor.Script.Cor.GetCorFrente();
                txtCode.BackColor = Editor.Script.Cor.GetCorFundo();
            }
            else
            {

                txtCode.Enabled = false;

                txtCode.Text = "";

            }

            usrAction.Refresh();

        }

    }
}
