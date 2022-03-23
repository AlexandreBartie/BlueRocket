using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public delegate void Notify_TituloClick();
    public partial class usrTitulo : UserControl
    {

        public event Notify_TituloClick TituloClick;

        private EditorCLI Editor;

        private void cmdTitulo_Click(object sender, EventArgs e) => TituloClick?.Invoke();

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
