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
            this.cmdOpenProject = new System.Windows.Forms.Button();
            this.lsvHistory = new System.Windows.Forms.ListView();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOpenProject
            // 
            this.cmdOpenProject.AllowDrop = true;
            this.cmdOpenProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdOpenProject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdOpenProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdOpenProject.Location = new System.Drawing.Point(570, 37);
            this.cmdOpenProject.Name = "cmdOpenProject";
            this.cmdOpenProject.Size = new System.Drawing.Size(195, 58);
            this.cmdOpenProject.TabIndex = 0;
            this.cmdOpenProject.Text = "Find your Project";
            this.cmdOpenProject.UseVisualStyleBackColor = true;
            this.cmdOpenProject.Click += new System.EventHandler(this.cmdOpenProject_Click);
            // 
            // lsvHistory
            // 
            this.lsvHistory.HideSelection = false;
            this.lsvHistory.Location = new System.Drawing.Point(27, 37);
            this.lsvHistory.Name = "lsvHistory";
            this.lsvHistory.Size = new System.Drawing.Size(515, 391);
            this.lsvHistory.TabIndex = 1;
            this.lsvHistory.UseCompatibleStateImageBehavior = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistorico.Location = new System.Drawing.Point(27, 9);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(297, 25);
            this.lblHistorico.TabIndex = 2;
            this.lblHistorico.Text = "Access History: Project BlueRocket";
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExit.Location = new System.Drawing.Point(570, 370);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(195, 58);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvHistory);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdOpenProject);
            this.Controls.Add(this.lblHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access History:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenProject;
        private System.Windows.Forms.ListView lsvHistory;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button cmdExit;
    }
}