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
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.pagEdicao = new BlueRocket.pagEdicao();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.pagFiltro = new BlueRocket.pagFiltro();
            this.tabPages.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.tabFilter.SuspendLayout();
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
            // tabPages
            // 
            this.tabPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPages.Controls.Add(this.tabEditor);
            this.tabPages.Controls.Add(this.tabFilter);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(0, 27);
            this.tabPages.Multiline = true;
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1257, 728);
            this.tabPages.TabIndex = 20;
            this.tabPages.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPages_Selected);
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.pagEdicao);
            this.tabEditor.Location = new System.Drawing.Point(4, 4);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditor.Size = new System.Drawing.Size(1249, 700);
            this.tabEditor.TabIndex = 0;
            this.tabEditor.Text = "Editor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // pagEdicao
            // 
            this.pagEdicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagEdicao.Location = new System.Drawing.Point(3, 3);
            this.pagEdicao.Name = "pagEdicao";
            this.pagEdicao.Size = new System.Drawing.Size(1243, 694);
            this.pagEdicao.TabIndex = 0;
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.pagFiltro);
            this.tabFilter.Location = new System.Drawing.Point(4, 4);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilter.Size = new System.Drawing.Size(1249, 700);
            this.tabFilter.TabIndex = 1;
            this.tabFilter.Text = "...";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // pagFiltro
            // 
            this.pagFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagFiltro.Location = new System.Drawing.Point(3, 3);
            this.pagFiltro.Name = "pagFiltro";
            this.pagFiltro.Size = new System.Drawing.Size(1243, 694);
            this.pagFiltro.TabIndex = 0;
            // 
            // frmMainCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 780);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.usrStatus);
            this.Controls.Add(this.usrMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue-Rocket Console";
            this.Load += new System.EventHandler(this.frmTestDataFactoryConsole_Load);
            this.tabPages.ResumeLayout(false);
            this.tabEditor.ResumeLayout(false);
            this.tabFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private usrActionMenu usrMenu;
        private usrActionStatus usrStatus;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabEditor;
        private System.Windows.Forms.TabPage tabFilter;
        private pagEdicao pagEdicao;
        private pagFiltro pagFiltro;
    }
}