namespace BlueRocket
{
    partial class usrActionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrActionMenu));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorAction = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorNew = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorExit = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebugMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLockedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnlockedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPlayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewScript = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewScriptCount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewScriptTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewScriptTags = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorMode = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProject,
            this.mnuScripts,
            this.mnuView,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(628, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Select actions to improving your job ...";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileClose,
            this.SeparatorAction,
            this.mnuFileRefresh,
            this.SeparatorNew,
            this.mnuNewWindow,
            this.SeparatorExit,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(145, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(145, 22);
            this.mnuFileClose.Text = "Close";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // SeparatorAction
            // 
            this.SeparatorAction.Name = "SeparatorAction";
            this.SeparatorAction.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuFileRefresh
            // 
            this.mnuFileRefresh.Image = global::BlueRocket.Properties.Resources.refresh;
            this.mnuFileRefresh.Name = "mnuFileRefresh";
            this.mnuFileRefresh.Size = new System.Drawing.Size(145, 22);
            this.mnuFileRefresh.Text = "Refresh";
            this.mnuFileRefresh.Click += new System.EventHandler(this.mnuFileRefresh_Click);
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
            this.mnuNewWindow.Click += new System.EventHandler(this.mnuNewWindow_Click);
            // 
            // SeparatorExit
            // 
            this.SeparatorExit.Name = "SeparatorExit";
            this.SeparatorExit.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(145, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAutoLoad,
            this.mnuAutoSave,
            this.SeparatorMode,
            this.mnuDebugMode});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(56, 20);
            this.mnuProject.Text = "Project";
            // 
            // mnuAutoLoad
            // 
            this.mnuAutoLoad.Name = "mnuAutoLoad";
            this.mnuAutoLoad.Size = new System.Drawing.Size(180, 22);
            this.mnuAutoLoad.Text = "Auto-Loading";
            this.mnuAutoLoad.Click += new System.EventHandler(this.mnuAutoLoad_Click);
            // 
            // mnuDebugMode
            // 
            this.mnuDebugMode.Name = "mnuDebugMode";
            this.mnuDebugMode.Size = new System.Drawing.Size(180, 22);
            this.mnuDebugMode.Text = "Debug Mode";
            this.mnuDebugMode.Click += new System.EventHandler(this.mnuDebugMode_Click);
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
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewScript});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            // 
            // mnuViewScript
            // 
            this.mnuViewScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewScriptCount,
            this.mnuViewScriptTime,
            this.mnuViewScriptTags});
            this.mnuViewScript.Name = "mnuViewScript";
            this.mnuViewScript.Size = new System.Drawing.Size(180, 22);
            this.mnuViewScript.Text = "Script";
            // 
            // mnuViewScriptCount
            // 
            this.mnuViewScriptCount.Name = "mnuViewScriptCount";
            this.mnuViewScriptCount.Size = new System.Drawing.Size(180, 22);
            this.mnuViewScriptCount.Text = "Data Count";
            this.mnuViewScriptCount.Click += new System.EventHandler(this.mnuViewScriptCount_Click);
            // 
            // mnuViewScriptTime
            // 
            this.mnuViewScriptTime.Name = "mnuViewScriptTime";
            this.mnuViewScriptTime.Size = new System.Drawing.Size(180, 22);
            this.mnuViewScriptTime.Text = "Time Analisys";
            this.mnuViewScriptTime.Click += new System.EventHandler(this.mnuViewScriptTime_Click);
            // 
            // mnuViewScriptTags
            // 
            this.mnuViewScriptTags.Name = "mnuViewScriptTags";
            this.mnuViewScriptTags.Size = new System.Drawing.Size(180, 22);
            this.mnuViewScriptTags.Text = "Associated Tags";
            this.mnuViewScriptTags.Click += new System.EventHandler(this.mnuViewScriptTags_Click);
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
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuAutoSave
            // 
            this.mnuAutoSave.Name = "mnuAutoSave";
            this.mnuAutoSave.Size = new System.Drawing.Size(180, 22);
            this.mnuAutoSave.Text = "Auto-Saving";
            this.mnuAutoSave.Click += new System.EventHandler(this.mnuAutoSave_Click);
            // 
            // SeparatorMode
            // 
            this.SeparatorMode.Name = "SeparatorMode";
            this.SeparatorMode.Size = new System.Drawing.Size(177, 6);
            // 
            // usrActionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuMain);
            this.Name = "usrActionMenu";
            this.Size = new System.Drawing.Size(628, 42);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator SeparatorAction;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRefresh;
        private System.Windows.Forms.ToolStripSeparator SeparatorExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
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
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewScript;
        private System.Windows.Forms.ToolStripMenuItem mnuViewScriptCount;
        private System.Windows.Forms.ToolStripMenuItem mnuViewScriptTime;
        private System.Windows.Forms.ToolStripMenuItem mnuViewScriptTags;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuDebugMode;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoSave;
        private System.Windows.Forms.ToolStripSeparator SeparatorMode;
    }
}
