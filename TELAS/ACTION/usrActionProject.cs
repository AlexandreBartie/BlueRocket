using Dooggy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrActionProject : UserControl
    {

        private PainelCLI Painel;
        private EditorCLI Editor => Painel.Editor;

        public usrActionProject()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => Painel.Page.AboutShow();
        private void rodMultiSelection_Click(object sender, EventArgs e) => Editor.OnMultiSelection(rodMultiSelection.Checked);
        private void rodProjectRefresh_Click(object sender, EventArgs e) => Editor.OnProjectRefresh();


        private void rodSaveAll_Click(object sender, EventArgs e)
        {

        }

        private void rodPlayAll_Click(object sender, EventArgs e)
        {

        }

        public void Setup(PainelCLI prmPainel)
        {
            Painel = prmPainel;

            Editor.Format.SetPadrao(rodStatus);
        }
        private void usrActionProject_Load(object sender, EventArgs e)
        {
            this.Size = rodStatus.Size;
        }

        public new void Refresh()
        {
            Editor.Format.SetTurnOnOff(prmON: Editor.IsDbOk, rodDBStatusOnLine, rodDBStatusOffLine);

            rodCodePlayAll.Visible = Editor.ICanPlayAll;
            rodPlaySaveAll.Visible = Editor.ICanSaveAll;

        }

    }
}
