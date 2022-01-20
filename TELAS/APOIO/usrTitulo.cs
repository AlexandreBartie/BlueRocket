using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrTitulo : UserControl
    {

        private EditorCLI Editor;

        public usrTitulo()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetPadrao(cmdTitulo);

        }
        public void SetTitulo(string prmTexto) { cmdTitulo.Text = prmTexto; }

    }
}
