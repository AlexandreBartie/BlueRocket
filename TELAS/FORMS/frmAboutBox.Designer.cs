namespace Rocket
{
    partial class frmAboutBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.usrTagCompany = new Rocket.Telas.usrLabelTextBox();
            this.usrTagVersion = new Rocket.Telas.usrLabelTextBox();
            this.usrTagName = new Rocket.Telas.usrLabelTextBox();
            this.lblFramework = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.grpInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Image = global::Rocket.Properties.Resources.rocket;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 13);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(224, 234);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(421, 227);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(119, 28);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // grpInformations
            // 
            this.grpInformations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpInformations.Controls.Add(this.usrTagCompany);
            this.grpInformations.Controls.Add(this.usrTagVersion);
            this.grpInformations.Controls.Add(this.usrTagName);
            this.grpInformations.Location = new System.Drawing.Point(243, 13);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.Size = new System.Drawing.Size(297, 208);
            this.grpInformations.TabIndex = 21;
            this.grpInformations.TabStop = false;
            // 
            // usrTagCompany
            // 
            this.usrTagCompany.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usrTagCompany.label = "xxx";
            this.usrTagCompany.Location = new System.Drawing.Point(14, 149);
            this.usrTagCompany.MinimumSize = new System.Drawing.Size(0, 50);
            this.usrTagCompany.Name = "usrTagCompany";
            this.usrTagCompany.Size = new System.Drawing.Size(277, 50);
            this.usrTagCompany.TabIndex = 26;
            this.usrTagCompany.text = "";
            // 
            // usrTagVersion
            // 
            this.usrTagVersion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usrTagVersion.label = "xxx";
            this.usrTagVersion.Location = new System.Drawing.Point(14, 84);
            this.usrTagVersion.MinimumSize = new System.Drawing.Size(0, 50);
            this.usrTagVersion.Name = "usrTagVersion";
            this.usrTagVersion.Size = new System.Drawing.Size(277, 50);
            this.usrTagVersion.TabIndex = 25;
            this.usrTagVersion.text = "";
            // 
            // usrTagName
            // 
            this.usrTagName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usrTagName.label = "xxx";
            this.usrTagName.Location = new System.Drawing.Point(14, 19);
            this.usrTagName.MinimumSize = new System.Drawing.Size(0, 50);
            this.usrTagName.Name = "usrTagName";
            this.usrTagName.Size = new System.Drawing.Size(277, 50);
            this.usrTagName.TabIndex = 24;
            this.usrTagName.text = "";
            // 
            // lblFramework
            // 
            this.lblFramework.AutoSize = true;
            this.lblFramework.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblFramework.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFramework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFramework.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFramework.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFramework.Location = new System.Drawing.Point(50, 229);
            this.lblFramework.Name = "lblFramework";
            this.lblFramework.Size = new System.Drawing.Size(152, 23);
            this.lblFramework.TabIndex = 22;
            this.lblFramework.Text = "ROCKET Framework";
            // 
            // frmAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 260);
            this.Controls.Add(this.lblFramework);
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutBox";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About ...";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.grpInformations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox grpInformations;
        private Telas.usrLabelTextBox usrTagName;
        private Telas.usrLabelTextBox usrTagCompany;
        private Telas.usrLabelTextBox usrTagVersion;
        private System.Windows.Forms.Label lblFramework;
    }
}
