namespace BlueRocket
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.cmdOpenProject = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblFramework = new System.Windows.Forms.Label();
            this.chkAutoLoad = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdOpenProject
            // 
            this.cmdOpenProject.AllowDrop = true;
            this.cmdOpenProject.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmdOpenProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdOpenProject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdOpenProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdOpenProject.Location = new System.Drawing.Point(607, 96);
            this.cmdOpenProject.Name = "cmdOpenProject";
            this.cmdOpenProject.Size = new System.Drawing.Size(181, 83);
            this.cmdOpenProject.TabIndex = 0;
            this.cmdOpenProject.Text = "Find your Project";
            this.cmdOpenProject.UseVisualStyleBackColor = false;
            this.cmdOpenProject.Click += new System.EventHandler(this.cmdFindProject_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.HideSelection = false;
            this.lstHistory.Location = new System.Drawing.Point(12, 96);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(575, 361);
            this.lstHistory.TabIndex = 1;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHistory_MouseDoubleClick);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistorico.Location = new System.Drawing.Point(12, 69);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(136, 25);
            this.lblHistorico.TabIndex = 2;
            this.lblHistorico.Text = "Access History:";
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmdExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExit.Location = new System.Drawing.Point(607, 399);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(181, 58);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblFramework
            // 
            this.lblFramework.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFramework.AutoSize = true;
            this.lblFramework.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFramework.Location = new System.Drawing.Point(12, 9);
            this.lblFramework.Name = "lblFramework";
            this.lblFramework.Size = new System.Drawing.Size(295, 50);
            this.lblFramework.TabIndex = 4;
            this.lblFramework.Tag = "";
            this.lblFramework.Text = "blue rocket 2022";
            this.lblFramework.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkAutoLoad
            // 
            this.chkAutoLoad.AutoSize = true;
            this.chkAutoLoad.BackColor = System.Drawing.SystemColors.Info;
            this.chkAutoLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkAutoLoad.FlatAppearance.BorderSize = 4;
            this.chkAutoLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkAutoLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAutoLoad.Location = new System.Drawing.Point(404, 73);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoLoad.Size = new System.Drawing.Size(183, 22);
            this.chkAutoLoad.TabIndex = 5;
            this.chkAutoLoad.Text = "Auto-Loading Last Project";
            this.chkAutoLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAutoLoad.UseVisualStyleBackColor = false;
            this.chkAutoLoad.CheckedChanged += new System.EventHandler(this.chkLoadAutomatic_CheckedChanged);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.chkAutoLoad);
            this.Controls.Add(this.lblFramework);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdOpenProject);
            this.Controls.Add(this.lblHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access History:";
            this.Activated += new System.EventHandler(this.frmStart_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStart_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenProject;
        private System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblFramework;
        private System.Windows.Forms.CheckBox chkAutoLoad;
    }
}