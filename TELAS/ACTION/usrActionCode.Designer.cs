namespace Rocket.Telas
{
    partial class usrActionCode
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rodStatus = new System.Windows.Forms.ToolStrip();
            this.rodCodeUndo = new System.Windows.Forms.ToolStripButton();
            this.SeparatorAction = new System.Windows.Forms.ToolStripSeparator();
            this.rodCodeSave = new System.Windows.Forms.ToolStripButton();
            this.SeparatorRight = new System.Windows.Forms.ToolStripSeparator();
            this.rodPlaySave = new System.Windows.Forms.ToolStripButton();
            this.rodCodeEditionOFF = new System.Windows.Forms.ToolStripButton();
            this.rodCodeEditionON = new System.Windows.Forms.ToolStripButton();
            this.SeparatorLeft = new System.Windows.Forms.ToolStripSeparator();
            this.rodLogOK = new System.Windows.Forms.ToolStripButton();
            this.rodLogError = new System.Windows.Forms.ToolStripButton();
            this.rodCodePlay = new System.Windows.Forms.ToolStripButton();
            this.rodCodePlaying = new System.Windows.Forms.ToolStripButton();
            this.rodCodeStop = new System.Windows.Forms.ToolStripButton();
            this.rodStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rodStatus
            // 
            this.rodStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodCodeUndo,
            this.SeparatorAction,
            this.rodCodeSave,
            this.SeparatorRight,
            this.rodPlaySave,
            this.rodCodeEditionOFF,
            this.rodCodeEditionON,
            this.SeparatorLeft,
            this.rodLogOK,
            this.rodLogError,
            this.rodCodePlay,
            this.rodCodePlaying,
            this.rodCodeStop});
            this.rodStatus.Location = new System.Drawing.Point(0, 0);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(706, 25);
            this.rodStatus.TabIndex = 17;
            // 
            // rodCodeUndo
            // 
            this.rodCodeUndo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodCodeUndo.BackColor = System.Drawing.Color.Sienna;
            this.rodCodeUndo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rodCodeUndo.Image = global::Rocket.Properties.Resources.cancel;
            this.rodCodeUndo.ImageTransparentColor = System.Drawing.Color.Orchid;
            this.rodCodeUndo.Name = "rodCodeUndo";
            this.rodCodeUndo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodCodeUndo.Size = new System.Drawing.Size(56, 22);
            this.rodCodeUndo.Text = "Undo";
            this.rodCodeUndo.ToolTipText = "Undo";
            this.rodCodeUndo.Click += new System.EventHandler(this.rodUndoCode_Click);
            // 
            // SeparatorAction
            // 
            this.SeparatorAction.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SeparatorAction.Name = "SeparatorAction";
            this.SeparatorAction.Size = new System.Drawing.Size(6, 25);
            // 
            // rodCodeSave
            // 
            this.rodCodeSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodCodeSave.BackColor = System.Drawing.Color.SeaGreen;
            this.rodCodeSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rodCodeSave.Image = global::Rocket.Properties.Resources.confirm;
            this.rodCodeSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodeSave.Name = "rodCodeSave";
            this.rodCodeSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodCodeSave.Size = new System.Drawing.Size(51, 22);
            this.rodCodeSave.Text = "Save";
            this.rodCodeSave.ToolTipText = "Save";
            this.rodCodeSave.Click += new System.EventHandler(this.rodSaveCode_Click);
            // 
            // SeparatorRight
            // 
            this.SeparatorRight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SeparatorRight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SeparatorRight.Name = "SeparatorRight";
            this.SeparatorRight.Size = new System.Drawing.Size(6, 25);
            // 
            // rodPlaySave
            // 
            this.rodPlaySave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodPlaySave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rodPlaySave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rodPlaySave.Image = global::Rocket.Properties.Resources.save;
            this.rodPlaySave.ImageTransparentColor = System.Drawing.Color.SteelBlue;
            this.rodPlaySave.Name = "rodPlaySave";
            this.rodPlaySave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodPlaySave.Size = new System.Drawing.Size(99, 22);
            this.rodPlaySave.Text = "Play and Save";
            this.rodPlaySave.Click += new System.EventHandler(this.rodPlaySave_Click);
            // 
            // rodCodeEditionOFF
            // 
            this.rodCodeEditionOFF.BackColor = System.Drawing.Color.Gold;
            this.rodCodeEditionOFF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodCodeEditionOFF.Image = global::Rocket.Properties.Resources.locked;
            this.rodCodeEditionOFF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodeEditionOFF.Name = "rodCodeEditionOFF";
            this.rodCodeEditionOFF.Size = new System.Drawing.Size(23, 22);
            this.rodCodeEditionOFF.Text = "Locked";
            this.rodCodeEditionOFF.Click += new System.EventHandler(this.rodCodeEditionOFF_Click);
            // 
            // rodCodeEditionON
            // 
            this.rodCodeEditionON.BackColor = System.Drawing.Color.Gainsboro;
            this.rodCodeEditionON.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodCodeEditionON.Image = global::Rocket.Properties.Resources.edit;
            this.rodCodeEditionON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodeEditionON.Name = "rodCodeEditionON";
            this.rodCodeEditionON.Size = new System.Drawing.Size(23, 22);
            this.rodCodeEditionON.Text = "Editing ...";
            this.rodCodeEditionON.ToolTipText = "Edition:";
            this.rodCodeEditionON.Click += new System.EventHandler(this.rodCodeEditionON_Click);
            // 
            // SeparatorLeft
            // 
            this.SeparatorLeft.Name = "SeparatorLeft";
            this.SeparatorLeft.Size = new System.Drawing.Size(6, 25);
            // 
            // rodLogOK
            // 
            this.rodLogOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rodLogOK.Image = global::Rocket.Properties.Resources.confirm;
            this.rodLogOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodLogOK.Name = "rodLogOK";
            this.rodLogOK.Size = new System.Drawing.Size(66, 22);
            this.rodLogOK.Text = "Log OK";
            this.rodLogOK.Click += new System.EventHandler(this.rodLogOK_Click);
            // 
            // rodLogError
            // 
            this.rodLogError.BackColor = System.Drawing.Color.Crimson;
            this.rodLogError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rodLogError.Image = global::Rocket.Properties.Resources.cancel;
            this.rodLogError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodLogError.Name = "rodLogError";
            this.rodLogError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodLogError.Size = new System.Drawing.Size(75, 22);
            this.rodLogError.Text = "Log Error";
            this.rodLogError.Click += new System.EventHandler(this.rodLogError_Click);
            // 
            // rodCodePlay
            // 
            this.rodCodePlay.BackColor = System.Drawing.Color.SteelBlue;
            this.rodCodePlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rodCodePlay.Image = global::Rocket.Properties.Resources.play;
            this.rodCodePlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodePlay.Name = "rodCodePlay";
            this.rodCodePlay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodCodePlay.Size = new System.Drawing.Size(49, 22);
            this.rodCodePlay.Text = "Play";
            this.rodCodePlay.ToolTipText = "Play";
            this.rodCodePlay.Click += new System.EventHandler(this.rodPlayCode_Click);
            // 
            // rodCodePlaying
            // 
            this.rodCodePlaying.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.rodCodePlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rodCodePlaying.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rodCodePlaying.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rodCodePlaying.Image = global::Rocket.Properties.Resources.waiting;
            this.rodCodePlaying.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodePlaying.Name = "rodCodePlaying";
            this.rodCodePlaying.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodCodePlaying.Size = new System.Drawing.Size(62, 22);
            this.rodCodePlaying.Text = "... Playing";
            // 
            // rodCodeStop
            // 
            this.rodCodeStop.BackColor = System.Drawing.Color.Crimson;
            this.rodCodeStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rodCodeStop.Image = global::Rocket.Properties.Resources.cancel;
            this.rodCodeStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodeStop.Name = "rodCodeStop";
            this.rodCodeStop.Size = new System.Drawing.Size(51, 22);
            this.rodCodeStop.Text = "Stop";
            this.rodCodeStop.Click += new System.EventHandler(this.rodStopPlaying_Click);
            // 
            // usrActionCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rodStatus);
            this.Name = "usrActionCode";
            this.Size = new System.Drawing.Size(706, 25);
            this.Load += new System.EventHandler(this.usrActionCode_Load);
            this.rodStatus.ResumeLayout(false);
            this.rodStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip rodStatus;
        private System.Windows.Forms.ToolStripButton rodCodeUndo;
        private System.Windows.Forms.ToolStripButton rodCodeSave;
        private System.Windows.Forms.ToolStripButton rodCodeEditionON;
        private System.Windows.Forms.ToolStripButton rodCodeEditionOFF;
        private System.Windows.Forms.ToolStripButton rodCodePlay;
        private System.Windows.Forms.ToolStripSeparator SeparatorLeft;
        private System.Windows.Forms.ToolStripSeparator SeparatorRight;
        private System.Windows.Forms.ToolStripButton rodCodeStop;
        private System.Windows.Forms.ToolStripButton rodPlaySave;
        private System.Windows.Forms.ToolStripSeparator SeparatorAction;
        private System.Windows.Forms.ToolStripButton rodCodePlaying;
        private System.Windows.Forms.ToolStripButton rodLogError;
        private System.Windows.Forms.ToolStripButton rodLogOK;
    }
}
