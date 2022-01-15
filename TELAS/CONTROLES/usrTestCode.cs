using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DooggyCLI;

namespace DooggyCLI.Telas
{
    public partial class usrTestCode : usrMoldura
    {

        private EditorScripts Editor;

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            if (Editor.TemScript)
            {

                Editor.SetCode(txtCode.Text);

                Editor.OnScriptChanged();

            }

        }
        
        public usrTestCode()
        {
         
            InitializeComponent();

            SetTitulo(prmTexto: "Script INI");

        }

        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(txtCode, prmEditavel: true);

            usrAction.Setup(prmEditor);

        }

        public void View()
        {

            if (Editor.TemScript)
            {

                SetTitulo(prmTexto: Editor.Script.title);

                txtCode.Enabled = Editor.Script.IsEnabled;

                txtCode.Text = Editor.Script.code;
                txtCode.ForeColor = Editor.GetForeColor();

            }
            else
            {

                SetTitulo(prmTexto: "SCRIPT INI");

                txtCode.Enabled = false;

                txtCode.Text = "";

            }

        }
    }
}
