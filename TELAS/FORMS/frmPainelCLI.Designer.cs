namespace DooggyCLI.Telas
{
    partial class frmPainelCLI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelCLI));
            this.usrAction = new DooggyCLI.Telas.usrActionConfig();
            this.SuspendLayout();
            // 
            // usrAction
            // 
            this.usrAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrAction.Location = new System.Drawing.Point(0, 0);
            this.usrAction.Name = "usrAction";
            this.usrAction.Size = new System.Drawing.Size(800, 33);
            this.usrAction.TabIndex = 0;
            // 
            // frmPainelCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 137);
            this.Controls.Add(this.usrAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelCLI";
            this.Text = "frmAssistente";
            this.ResumeLayout(false);

        }

        #endregion

        private Telas.usrActionConfig usrActionMaster1;
        private usrActionConfig usrAction;
    }
}