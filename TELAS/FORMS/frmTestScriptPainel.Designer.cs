namespace MassaTestes
{
    partial class frmTestScriptPainel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usrProjetoTeste = new PainelTestes.TELAS.CONTROLES.usrProjetoTeste();
            this.splSeparador = new System.Windows.Forms.Splitter();
            this.containerScript = new System.Windows.Forms.SplitContainer();
            this.usrScriptTeste = new PainelTestes.usrScriptTeste();
            this.usrResultadoTeste = new PainelTestes.TELAS.CONTROLES.usrResultadoTeste();
            ((System.ComponentModel.ISupportInitialize)(this.containerScript)).BeginInit();
            this.containerScript.Panel1.SuspendLayout();
            this.containerScript.Panel2.SuspendLayout();
            this.containerScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrProjetoTeste
            // 
            this.usrProjetoTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrProjetoTeste.Dock = System.Windows.Forms.DockStyle.Left;
            this.usrProjetoTeste.Location = new System.Drawing.Point(0, 0);
            this.usrProjetoTeste.Name = "usrProjetoTeste";
            this.usrProjetoTeste.Size = new System.Drawing.Size(557, 755);
            this.usrProjetoTeste.TabIndex = 8;
            // 
            // splSeparador
            // 
            this.splSeparador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splSeparador.Location = new System.Drawing.Point(557, 0);
            this.splSeparador.Name = "splSeparador";
            this.splSeparador.Size = new System.Drawing.Size(3, 755);
            this.splSeparador.TabIndex = 9;
            this.splSeparador.TabStop = false;
            // 
            // containerScript
            // 
            this.containerScript.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.containerScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerScript.Location = new System.Drawing.Point(560, 0);
            this.containerScript.Name = "containerScript";
            this.containerScript.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerScript.Panel1
            // 
            this.containerScript.Panel1.Controls.Add(this.usrScriptTeste);
            // 
            // containerScript.Panel2
            // 
            this.containerScript.Panel2.Controls.Add(this.usrResultadoTeste);
            this.containerScript.Size = new System.Drawing.Size(697, 755);
            this.containerScript.SplitterDistance = 375;
            this.containerScript.TabIndex = 10;
            // 
            // usrScriptTeste
            // 
            this.usrScriptTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrScriptTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrScriptTeste.Location = new System.Drawing.Point(0, 0);
            this.usrScriptTeste.Name = "usrScriptTeste";
            this.usrScriptTeste.Size = new System.Drawing.Size(697, 375);
            this.usrScriptTeste.TabIndex = 0;
            // 
            // usrResultadoTeste
            // 
            this.usrResultadoTeste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usrResultadoTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrResultadoTeste.Location = new System.Drawing.Point(0, 0);
            this.usrResultadoTeste.Name = "usrResultadoTeste";
            this.usrResultadoTeste.Size = new System.Drawing.Size(697, 376);
            this.usrResultadoTeste.TabIndex = 0;
            // 
            // frmTestScriptPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 755);
            this.Controls.Add(this.containerScript);
            this.Controls.Add(this.splSeparador);
            this.Controls.Add(this.usrProjetoTeste);
            this.Name = "frmTestScriptPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console SCRIPT INI";
            this.Load += new System.EventHandler(this.frmTestDataFactoryConsole_Load);
            this.containerScript.Panel1.ResumeLayout(false);
            this.containerScript.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerScript)).EndInit();
            this.containerScript.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PainelTestes.TELAS.CONTROLES.usrProjetoTeste usrProjetoTeste;
        private System.Windows.Forms.Splitter splSeparador;
        private System.Windows.Forms.SplitContainer containerScript;
        private PainelTestes.usrScriptTeste usrScriptTeste;
        private PainelTestes.TELAS.CONTROLES.usrResultadoTeste usrResultadoTeste;
    }
}