using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrActionProject : UserControl
    {

        private EditorCLI Editor;

        public usrActionProject()
        {
            InitializeComponent();
        }
        private void usrActionProject_Load(object sender, EventArgs e) => this.Size = rodStatus.Size;

        private void rodMultiSelect_Click(object sender, EventArgs e) => Editor.OnMultiSelect(rodMultiSelect.Checked);
        private void rodDBStatusOffLine_Click(object sender, EventArgs e) => Editor.OnProjectDBConnect();

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(rodStatus);
        }
        public void View()
        {

            rodMultiSelect.Visible = Editor.TemScript;

            rodSeparator.Visible = Editor.IsRunning;
            rodProgressBar.Visible = Editor.IsRunning;

            rodStatusDB.Visible = Editor.TemProject;

            Editor.Format.SetTurnOnOff(prmON: Editor.IsDbOK, rodDBStatusOnLine, rodDBStatusOffLine, rodStatusDB);

            ViewBatch();
        }

        public void ViewBatch()
        {
            if (Editor.IsRunning)
            {
                rodProgressBar.Minimum = 0;
                rodProgressBar.Value = Editor.Batch.cont;
                rodProgressBar.Maximum = Editor.Batch.qtde;
            }
        }

        public void SetAction(string prmTexto) => rodAction.Text = prmTexto;

    }
}
