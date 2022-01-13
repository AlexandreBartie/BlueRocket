namespace MassaTestes
{
    partial class frmTestDataFactoryConsole
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
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.splSeparador = new System.Windows.Forms.Splitter();
            this.containerScript = new System.Windows.Forms.SplitContainer();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.usrScriptTeste = new ConsoleTestes.usrScriptTeste();
            ((System.ComponentModel.ISupportInitialize)(this.containerScript)).BeginInit();
            this.containerScript.Panel1.SuspendLayout();
            this.containerScript.Panel2.SuspendLayout();
            this.containerScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(0, 0);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(389, 755);
            this.trvProjeto.TabIndex = 5;
            this.trvProjeto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterSelect);
            // 
            // splSeparador
            // 
            this.splSeparador.Location = new System.Drawing.Point(389, 0);
            this.splSeparador.Name = "splSeparador";
            this.splSeparador.Size = new System.Drawing.Size(3, 755);
            this.splSeparador.TabIndex = 6;
            this.splSeparador.TabStop = false;
            // 
            // containerScript
            // 
            this.containerScript.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.containerScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerScript.Location = new System.Drawing.Point(392, 0);
            this.containerScript.Name = "containerScript";
            this.containerScript.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerScript.Panel1
            // 
            this.containerScript.Panel1.Controls.Add(this.usrScriptTeste);
            // 
            // containerScript.Panel2
            // 
            this.containerScript.Panel2.Controls.Add(this.txtResultado);
            this.containerScript.Size = new System.Drawing.Size(865, 755);
            this.containerScript.SplitterDistance = 376;
            this.containerScript.TabIndex = 7;
            // 
            // txtResultado
            // 
            this.txtResultado.AcceptsReturn = true;
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(0, 0);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(865, 375);
            this.txtResultado.TabIndex = 4;
            // 
            // usrScriptTeste
            // 
            this.usrScriptTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrScriptTeste.Location = new System.Drawing.Point(0, 0);
            this.usrScriptTeste.Name = "usrScriptTeste";
            this.usrScriptTeste.Size = new System.Drawing.Size(865, 376);
            this.usrScriptTeste.TabIndex = 0;
            // 
            // frmTestDataFactoryConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 755);
            this.Controls.Add(this.containerScript);
            this.Controls.Add(this.splSeparador);
            this.Controls.Add(this.trvProjeto);
            this.Name = "frmTestDataFactoryConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTestDataFactoryConsole";
            this.Load += new System.EventHandler(this.frmTestDataFactoryConsole_Load);
            this.containerScript.Panel1.ResumeLayout(false);
            this.containerScript.Panel2.ResumeLayout(false);
            this.containerScript.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerScript)).EndInit();
            this.containerScript.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trvProjeto;
        private System.Windows.Forms.Splitter splSeparador;
        private System.Windows.Forms.SplitContainer containerScript;
        private System.Windows.Forms.TextBox txtResultado;
        private ConsoleTestes.usrScriptTeste usrScriptTeste;
    }
}