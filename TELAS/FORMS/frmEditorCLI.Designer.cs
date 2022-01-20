namespace DooggyCLI.Telas
{
    partial class frmEditorCLI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorCLI));
            this.usrProjetoTeste = new DooggyCLI.Telas.usrTestProject();
            this.splSeparadorH = new System.Windows.Forms.Splitter();
            this.usrResultadoTeste = new DooggyCLI.Telas.usrTestResult();
            this.splSeparadorV = new System.Windows.Forms.Splitter();
            this.usrScriptTeste = new DooggyCLI.Telas.usrTestCode();
            this.SuspendLayout();
            // 
            // usrProjetoTeste
            // 
            this.usrProjetoTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrProjetoTeste.Dock = System.Windows.Forms.DockStyle.Left;
            this.usrProjetoTeste.Location = new System.Drawing.Point(0, 0);
            this.usrProjetoTeste.Name = "usrProjetoTeste";
            this.usrProjetoTeste.Size = new System.Drawing.Size(557, 780);
            this.usrProjetoTeste.TabIndex = 8;
            // 
            // splSeparadorH
            // 
            this.splSeparadorH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splSeparadorH.Location = new System.Drawing.Point(557, 0);
            this.splSeparadorH.Name = "splSeparadorH";
            this.splSeparadorH.Size = new System.Drawing.Size(3, 780);
            this.splSeparadorH.TabIndex = 9;
            this.splSeparadorH.TabStop = false;
            // 
            // usrResultadoTeste
            // 
            this.usrResultadoTeste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usrResultadoTeste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrResultadoTeste.Location = new System.Drawing.Point(560, 404);
            this.usrResultadoTeste.Name = "usrResultadoTeste";
            this.usrResultadoTeste.Size = new System.Drawing.Size(697, 376);
            this.usrResultadoTeste.TabIndex = 14;
            // 
            // splSeparadorV
            // 
            this.splSeparadorV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splSeparadorV.Location = new System.Drawing.Point(560, 401);
            this.splSeparadorV.Name = "splSeparadorV";
            this.splSeparadorV.Size = new System.Drawing.Size(697, 3);
            this.splSeparadorV.TabIndex = 15;
            this.splSeparadorV.TabStop = false;
            // 
            // usrScriptTeste
            // 
            this.usrScriptTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrScriptTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrScriptTeste.Location = new System.Drawing.Point(560, 0);
            this.usrScriptTeste.Name = "usrScriptTeste";
            this.usrScriptTeste.Size = new System.Drawing.Size(697, 401);
            this.usrScriptTeste.TabIndex = 16;
            // 
            // frmEditorCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 780);
            this.Controls.Add(this.usrScriptTeste);
            this.Controls.Add(this.splSeparadorV);
            this.Controls.Add(this.usrResultadoTeste);
            this.Controls.Add(this.splSeparadorH);
            this.Controls.Add(this.usrProjetoTeste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditorCLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console SCRIPT INI";
            this.Load += new System.EventHandler(this.frmTestDataFactoryConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usrTestProject usrProjetoTeste;
        private System.Windows.Forms.Splitter splSeparadorH;
        private usrTestResult usrResultadoTeste;
        private System.Windows.Forms.Splitter splSeparadorV;
        private usrTestCode usrScriptTeste;
    }
}