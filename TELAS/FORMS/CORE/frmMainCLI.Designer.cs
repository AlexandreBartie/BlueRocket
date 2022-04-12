namespace BlueRocket
{
    partial class frmMainCLI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCLI));
            this.usrMenu = new BlueRocket.usrActionMenu();
            this.usrStatus = new BlueRocket.usrActionStatus();
            this.pagScripts = new BlueRocket.pagScripts();
            this.separadorV = new System.Windows.Forms.Splitter();
            this.pagEdition = new BlueRocket.pagEdition();
            this.SuspendLayout();
            // 
            // usrMenu
            // 
            this.usrMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrMenu.Location = new System.Drawing.Point(0, 0);
            this.usrMenu.Name = "usrMenu";
            this.usrMenu.Size = new System.Drawing.Size(1257, 27);
            this.usrMenu.TabIndex = 18;
            // 
            // usrStatus
            // 
            this.usrStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrStatus.Location = new System.Drawing.Point(0, 755);
            this.usrStatus.Name = "usrStatus";
            this.usrStatus.Size = new System.Drawing.Size(1257, 25);
            this.usrStatus.TabIndex = 19;
            // 
            // pagScripts
            // 
            this.pagScripts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pagScripts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagScripts.Location = new System.Drawing.Point(0, 27);
            this.pagScripts.Name = "pagScripts";
            this.pagScripts.Size = new System.Drawing.Size(402, 728);
            this.pagScripts.TabIndex = 20;
            // 
            // separadorV
            // 
            this.separadorV.Location = new System.Drawing.Point(402, 27);
            this.separadorV.Name = "separadorV";
            this.separadorV.Size = new System.Drawing.Size(3, 728);
            this.separadorV.TabIndex = 21;
            this.separadorV.TabStop = false;
            // 
            // pagEdition
            // 
            this.pagEdition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagEdition.Location = new System.Drawing.Point(405, 27);
            this.pagEdition.Name = "pagEdition";
            this.pagEdition.Size = new System.Drawing.Size(852, 728);
            this.pagEdition.TabIndex = 22;
            // 
            // frmMainCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 780);
            this.Controls.Add(this.pagEdition);
            this.Controls.Add(this.separadorV);
            this.Controls.Add(this.pagScripts);
            this.Controls.Add(this.usrStatus);
            this.Controls.Add(this.usrMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "blue rocket";
            this.Load += new System.EventHandler(this.frmTestDataFactoryConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private usrActionMenu usrMenu;
        private usrActionStatus usrStatus;
        private pagScripts pagScripts;
        private System.Windows.Forms.Splitter separadorV;
        private pagEdition pagEdition;
    }
}