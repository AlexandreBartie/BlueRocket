using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public delegate void Notify_TitleClick();
    public partial class usrTitle : UserControl
    {

        public event Notify_TitleClick TitleClick;

        private EditorCLI Editor;

        private void cmdTitulo_Click(object sender, EventArgs e) => TitleClick?.Invoke();

        public usrTitle()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(cmdTitle);
        }

        public void SetText(string prmText) { cmdTitle.Text = prmText; }

    }
}
