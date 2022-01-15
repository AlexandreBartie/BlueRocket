using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrActionScript : UserControl
    {

        private EditorScripts Editor;

        private void cmdPlay_Click(object sender, EventArgs e) => Editor.OnScriptPlay();
        private void cmdSave_Click(object sender, EventArgs e) => Editor.OnScriptSave();
        private void cmdUndo_Click(object sender, EventArgs e) => Editor.OnScriptUndo();

        public usrActionScript()
        {
            InitializeComponent();
        }

        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(cmdPlay);
            Editor.Config.SetPadrao(cmdSave);
            Editor.Config.SetPadrao(cmdUndo);

        }

        public void SetRefresh()
        {

            cmdPlay.Enabled = Editor.Script.IsCanPlay;

            cmdSave.Enabled = Editor.Script.IsChanged;
            cmdPlay.Enabled = Editor.Script.IsChanged;

        }

    }
}
