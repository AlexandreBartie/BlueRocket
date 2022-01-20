using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrActionCode : UserControl
    {
        
        private EditorCLI Editor;

        private void rodCodeEditionON_Click(object sender, EventArgs e) => Editor.OnScriptLocked();
        private void rodCodeEditionOFF_Click(object sender, EventArgs e) => Editor.OnScriptLocked();

        private void rodPlayCode_Click(object sender, EventArgs e) => Editor.OnCodePlay();
        private void rodPlaySave_Click(object sender, EventArgs e) => Editor.OnPlaySave();
        private void rodSaveCode_Click(object sender, EventArgs e) => Editor.OnCodeSave();
        private void rodUndoCode_Click(object sender, EventArgs e) => Editor.OnCodeUndo();

        public usrActionCode()
        {
            InitializeComponent();
        }

        private void usrActionCode_Load(object sender, EventArgs e)
        {
            this.Size = rodStatus.Size;
        }
        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(rodStatus, prmVisible: false);
        }

        public new void Refresh()
        {

            rodStatus.Visible = Editor.TemScript;

            if (Editor.TemScript)
            {

                Editor.Format.SetTurnOnOff(prmON: Editor.Script.ICanEdit, rodCodeEditionON, rodCodeEditionOFF);

                rodCodePlay.Visible = Editor.Script.ICanPlay;
                rodStopPlay.Visible = Editor.IsCodePlaying ;

                rodPlaySave.Visible = Editor.Script.ICanPlaySave;
                rodCodeSave.Visible = Editor.Script.ICanSave;
                rodCodeUndo.Visible = Editor.Script.ICanUndo;

            }

        }

    }
}
