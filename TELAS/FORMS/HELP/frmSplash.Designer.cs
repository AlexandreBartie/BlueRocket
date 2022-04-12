namespace BlueRocket
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.alarme = new System.Windows.Forms.Timer(this.components);
            this.lblAnoMainRelease = new System.Windows.Forms.Label();
            this.lblFramework = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lvlRelease = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // alarme
            // 
            this.alarme.Tick += new System.EventHandler(this.alarme_Tick);
            // 
            // lblAnoMainRelease
            // 
            this.lblAnoMainRelease.AutoSize = true;
            this.lblAnoMainRelease.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnoMainRelease.Location = new System.Drawing.Point(26, 26);
            this.lblAnoMainRelease.Name = "lblAnoMainRelease";
            this.lblAnoMainRelease.Size = new System.Drawing.Size(132, 65);
            this.lblAnoMainRelease.TabIndex = 0;
            this.lblAnoMainRelease.Tag = "";
            this.lblAnoMainRelease.Text = "2022";
            this.lblAnoMainRelease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFramework
            // 
            this.lblFramework.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFramework.AutoSize = true;
            this.lblFramework.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFramework.Location = new System.Drawing.Point(512, 309);
            this.lblFramework.Name = "lblFramework";
            this.lblFramework.Size = new System.Drawing.Size(265, 65);
            this.lblFramework.TabIndex = 1;
            this.lblFramework.Tag = "";
            this.lblFramework.Text = "blue rocket";
            this.lblFramework.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(686, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Tag = "";
            this.label1.Text = "framework";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(437, 309);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(68, 65);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // lvlRelease
            // 
            this.lvlRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlRelease.AutoSize = true;
            this.lvlRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlRelease.Location = new System.Drawing.Point(35, 91);
            this.lvlRelease.Name = "lvlRelease";
            this.lvlRelease.Size = new System.Drawing.Size(49, 15);
            this.lvlRelease.TabIndex = 15;
            this.lvlRelease.Tag = "";
            this.lvlRelease.Text = "Release:";
            this.lvlRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 447);
            this.Controls.Add(this.lvlRelease);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFramework);
            this.Controls.Add(this.lblAnoMainRelease);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.frmSplash_Click);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer alarme;
        private System.Windows.Forms.Label lblAnoMainRelease;
        private System.Windows.Forms.Label lblFramework;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lvlRelease;
    }
}