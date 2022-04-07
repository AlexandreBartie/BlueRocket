using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrTestCode : usrMoldura
    {

        private EditorCLI Editor;

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e) => Editor.OnScriptCodeEditing();
        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            if (Editor.TemScript)
            {

                Editor.Console.SetCode(txtCode.Text);

                Editor.OnScriptCodeChanged();

            }

        }
     

        public usrTestCode()
        {
         
            InitializeComponent();

            SetTitulo(prmTexto: "Script INI");

        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetMemo(txtCode);

            usrAction.Setup(prmEditor);

        }

        public void View()
        {

            if (Editor.TemScript)
            {

                SetTitulo(prmTexto: Editor.Script.title);

                txtCode.Enabled = true;
                txtCode.ReadOnly = Editor.Script.IsLocked;

                txtCode.Text = Editor.Script.code;
                txtCode.ForeColor = Editor.Script.Cor.GetCorFrente();
                txtCode.BackColor = Editor.Script.Cor.GetCorFundo();
            }
            else
            {

                SetTitulo(prmTexto: "SCRIPT INI");

                txtCode.Enabled = false;

                txtCode.Text = "";

            }

            usrAction.Refresh();

        }

    }
}
