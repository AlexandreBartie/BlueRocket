namespace BlueRocket
{
    partial class usrActionMain
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrActionMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectClose = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorAction = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorNew = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorExit = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLockedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnlockedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPlayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProject,
            this.mnuScripts,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(628, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Select actions to improving your job ...";
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectOpen,
            this.mnuProjectClose,
            this.SeparatorAction,
            this.mnuProjectRefresh,
            this.SeparatorNew,
            this.mnuNewWindow,
            this.SeparatorExit,
            this.mnuProjectExit});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(56, 20);
            this.mnuProject.Text = "Project";
            // 
            // mnuProjectOpen
            // 
            this.mnuProjectOpen.Name = "mnuProjectOpen";
            this.mnuProjectOpen.Size = new System.Drawing.Size(145, 22);
            this.mnuProjectOpen.Text = "Open";
            this.mnuProjectOpen.Click += new System.EventHandler(this.mnuProjectOpen_Click);
            // 
            // mnuProjectClose
            // 
            this.mnuProjectClose.Name = "mnuProjectClose";
            this.mnuProjectClose.Size = new System.Drawing.Size(145, 22);
            this.mnuProjectClose.Text = "Close";
            this.mnuProjectClose.Click += new System.EventHandler(this.mnuProjectClose_Click);
            // 
            // SeparatorAction
            // 
            this.SeparatorAction.Name = "SeparatorAction";
            this.SeparatorAction.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuProjectRefresh
            // 
            this.mnuProjectRefresh.Image = global::BlueRocket.Properties.Resources.refresh;
            this.mnuProjectRefresh.Name = "mnuProjectRefresh";
            this.mnuProjectRefresh.Size = new System.Drawing.Size(145, 22);
            this.mnuProjectRefresh.Text = "Refresh";
            this.mnuProjectRefresh.Click += new System.EventHandler(this.mnuProjectRefresh_Click);
            // 
            // SeparatorNew
            // 
            this.SeparatorNew.Name = "SeparatorNew";
            this.SeparatorNew.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuNewWindow
            // 
            this.mnuNewWindow.Name = "mnuNewWindow";
            this.mnuNewWindow.Size = new System.Drawing.Size(145, 22);
            this.mnuNewWindow.Text = "New Window";
            // 
            // SeparatorExit
            // 
            this.SeparatorExit.Name = "SeparatorExit";
            this.SeparatorExit.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuProjectExit
            // 
            this.mnuProjectExit.Name = "mnuProjectExit";
            this.mnuProjectExit.Size = new System.Drawing.Size(145, 22);
            this.mnuProjectExit.Text = "Exit";
            this.mnuProjectExit.Click += new System.EventHandler(this.mnuProjectExit_Click);
            // 
            // mnuScripts
            // 
            this.mnuScripts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLockedAll,
            this.mnuUnlockedAll,
            this.Separator,
            this.mnuPlayAll,
            this.mnuSaveAll});
            this.mnuScripts.Name = "mnuScripts";
            this.mnuScripts.Size = new System.Drawing.Size(54, 20);
            this.mnuScripts.Text = "Scripts";
            // 
            // mnuLockedAll
            // 
            this.mnuLockedAll.Image = global::BlueRocket.Properties.Resources.locked;
            this.mnuLockedAll.Name = "mnuLockedAll";
            this.mnuLockedAll.Size = new System.Drawing.Size(141, 22);
            this.mnuLockedAll.Text = "Locked All";
            this.mnuLockedAll.Click += new System.EventHandler(this.mnuLockedAll_Click);
            // 
            // mnuUnlockedAll
            // 
            this.mnuUnlockedAll.Image = global::BlueRocket.Properties.Resources.edit;
            this.mnuUnlockedAll.Name = "mnuUnlockedAll";
            this.mnuUnlockedAll.Size = new System.Drawing.Size(141, 22);
            this.mnuUnlockedAll.Text = "Unlocked All";
            this.mnuUnlockedAll.Click += new System.EventHandler(this.mnuUnlockedAll_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(138, 6);
            // 
            // mnuPlayAll
            // 
            this.mnuPlayAll.Image = global::BlueRocket.Properties.Resources.play;
            this.mnuPlayAll.Name = "mnuPlayAll";
            this.mnuPlayAll.Size = new System.Drawing.Size(141, 22);
            this.mnuPlayAll.Text = "Play All";
            this.mnuPlayAll.Click += new System.EventHandler(this.mnuPlayAll_Click);
            // 
            // mnuSaveAll
            // 
            this.mnuSaveAll.Image = global::BlueRocket.Properties.Resources.confirm;
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.Size = new System.Drawing.Size(141, 22);
            this.mnuSaveAll.Text = "Save All";
            this.mnuSaveAll.Click += new System.EventHandler(this.mnuSaveAll_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // usrActionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuMain);
            this.Name = "usrActionMain";
            this.Size = new System.Drawing.Size(628, 42);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectClose;
        private System.Windows.Forms.ToolStripSeparator SeparatorAction;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectRefresh;
        private System.Windows.Forms.ToolStripSeparator SeparatorExit;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectExit;
        private System.Windows.Forms.ToolStripMenuItem mnuScripts;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayAll;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripSeparator SeparatorNew;
        private System.Windows.Forms.ToolStripMenuItem mnuNewWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuLockedAll;
        private System.Windows.Forms.ToolStripMenuItem mnuUnlockedAll;
    }
}
