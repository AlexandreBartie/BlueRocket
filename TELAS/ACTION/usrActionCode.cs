using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrActionCode : PageControl
    {
        private void rodCodeEditionON_Click(object sender, EventArgs e) => Editor.OnScriptCodeLocked();
        private void rodCodeEditionOFF_Click(object sender, EventArgs e) => Editor.OnScriptCodeLocked();

        private void rodPlayCode_Click(object sender, EventArgs e) => Editor.OnScriptCodePlay();

        private void rodStopPlaying_Click(object sender, EventArgs e) => Editor.OnScriptPlayStop();

        private void rodPlaySave_Click(object sender, EventArgs e) => Editor.OnScriptPlaySave();
        private void rodSaveCode_Click(object sender, EventArgs e) => Editor.OnScriptCodeSave();
        private void rodUndoCode_Click(object sender, EventArgs e) => Editor.OnScriptCodeUndo();

        private void rodLogOK_Click(object sender, EventArgs e) => Editor.OnScriptResultOK();
        private void rodLogError_Click(object sender, EventArgs e) => Editor.OnScriptResultError();

        public usrActionCode()
        {
            InitializeComponent();
        }

        private void usrActionCode_Load(object sender, EventArgs e)
        {
            this.Size = rodStatus.Size;
        }
        public new void Setup(EditorCLI prmEditor)
        {
            base.Setup(prmEditor);

            Editor.Format.SetPadrao(rodStatus, prmVisible: false);
        }

        public new void Refresh()
        {
            rodStatus.Visible = Editor.HasScript;

            if (Editor.HasScript)
            {
                Editor.Format.SetTurnOnOff(prmON: Editor.Script.ICanEdit, rodCodeEditionON, rodCodeEditionOFF);

                rodLogOK.Visible = Editor.Script.IsLogOK && !Editor.Script.IsPlaying;
                rodLogError.Visible = Editor.Script.IsLogError && !Editor.Script.IsPlaying;

                rodCodePlay.Visible = Editor.Script.ICanPlay;

                rodCodePlaying.Visible = Editor.Script.IsPlaying;
                rodCodeStop.Visible = false;

                rodPlaySave.Visible = Editor.Script.ICanPlaySave;
                rodCodeSave.Visible = Editor.Script.ICanSave;
                rodCodeUndo.Visible = Editor.Script.ICanUndo;
            }

        }

    }
}
