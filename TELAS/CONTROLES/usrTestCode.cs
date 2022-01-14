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

            Editor.SetCode(txtCode.Text);
            
            Editor.OnScriptCodeChanged();

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

        }

        public void Exibir()
        {

            txtCode.Text = Editor.Log.code;

        }

        public void Formatar()
        {

            txtCode.ForeColor = Editor.GetForeColor();

        }


    }
}
