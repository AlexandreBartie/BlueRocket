namespace DooggyCLI.Telas
{
    partial class usrActionProject
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
            this.rodStatus = new System.Windows.Forms.ToolStrip();
            this.rodMainMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorRefresh = new System.Windows.Forms.ToolStripSeparator();
            this.rodProjectRefresh = new System.Windows.Forms.ToolStripButton();
            this.SeparatorAction = new System.Windows.Forms.ToolStripSeparator();
            this.rodMultiSelection = new System.Windows.Forms.ToolStripButton();
            this.SeparatorMenu = new System.Windows.Forms.ToolStripSeparator();
            this.rodCodePlayAll = new System.Windows.Forms.ToolStripButton();
            this.rodDBStatusOffLine = new System.Windows.Forms.ToolStripButton();
            this.rodDBStatusOnLine = new System.Windows.Forms.ToolStripButton();
            this.rodSituacaoDB = new System.Windows.Forms.ToolStripLabel();
            this.SeparatorEnd = new System.Windows.Forms.ToolStripSeparator();
            this.rodPlaySaveAll = new System.Windows.Forms.ToolStripButton();
            this.rodStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rodStatus
            // 
            this.rodStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodMainMenu,
            this.SeparatorRefresh,
            this.rodProjectRefresh,
            this.SeparatorAction,
            this.rodMultiSelection,
            this.SeparatorMenu,
            this.rodCodePlayAll,
            this.rodDBStatusOffLine,
            this.rodDBStatusOnLine,
            this.rodSituacaoDB,
            this.SeparatorEnd,
            this.rodPlaySaveAll});
            this.rodStatus.Location = new System.Drawing.Point(0, 1);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(601, 25);
            this.rodStatus.TabIndex = 9;
            // 
            // rodMainMenu
            // 
            this.rodMainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.rodMainMenu.Image = global::DooggyCLI.Properties.Resources.menu;
            this.rodMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodMainMenu.Name = "rodMainMenu";
            this.rodMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rodMainMenu.Size = new System.Drawing.Size(29, 22);
            this.rodMainMenu.Text = "Main Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SeparatorRefresh
            // 
            this.SeparatorRefresh.Name = "SeparatorRefresh";
            this.SeparatorRefresh.Size = new System.Drawing.Size(6, 25);
            // 
            // rodProjectRefresh
            // 
            this.rodProjectRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodProjectRefresh.Image = global::DooggyCLI.Properties.Resources.refresh;
            this.rodProjectRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodProjectRefresh.Name = "rodProjectRefresh";
            this.rodProjectRefresh.Size = new System.Drawing.Size(23, 22);
            this.rodProjectRefresh.Text = "Project Refresh";
            this.rodProjectRefresh.ToolTipText = "Refresh";
            this.rodProjectRefresh.Click += new System.EventHandler(this.rodProjectRefresh_Click);
            // 
            // SeparatorAction
            // 
            this.SeparatorAction.Name = "SeparatorAction";
            this.SeparatorAction.Size = new System.Drawing.Size(6, 25);
            // 
            // rodMultiSelection
            // 
            this.rodMultiSelection.CheckOnClick = true;
            this.rodMultiSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodMultiSelection.Image = global::DooggyCLI.Properties.Resources.itens;
            this.rodMultiSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodMultiSelection.Name = "rodMultiSelection";
            this.rodMultiSelection.Size = new System.Drawing.Size(23, 22);
            this.rodMultiSelection.Text = "Multi-Selection";
            this.rodMultiSelection.Click += new System.EventHandler(this.rodMultiSelection_Click);
            // 
            // SeparatorMenu
            // 
            this.SeparatorMenu.Name = "SeparatorMenu";
            this.SeparatorMenu.Size = new System.Drawing.Size(6, 25);
            // 
            // rodCodePlayAll
            // 
            this.rodCodePlayAll.Image = global::DooggyCLI.Properties.Resources.play;
            this.rodCodePlayAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodCodePlayAll.Name = "rodCodePlayAll";
            this.rodCodePlayAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodCodePlayAll.Size = new System.Drawing.Size(66, 22);
            this.rodCodePlayAll.Text = "Play All";
            this.rodCodePlayAll.Click += new System.EventHandler(this.rodPlayAll_Click);
            // 
            // rodDBStatusOffLine
            // 
            this.rodDBStatusOffLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOffLine.BackColor = System.Drawing.Color.Pink;
            this.rodDBStatusOffLine.Image = global::DooggyCLI.Properties.Resources.off_line;
            this.rodDBStatusOffLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOffLine.Name = "rodDBStatusOffLine";
            this.rodDBStatusOffLine.Size = new System.Drawing.Size(77, 22);
            this.rodDBStatusOffLine.Text = "OFF-LINE";
            // 
            // rodDBStatusOnLine
            // 
            this.rodDBStatusOnLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOnLine.BackColor = System.Drawing.Color.Wheat;
            this.rodDBStatusOnLine.Image = global::DooggyCLI.Properties.Resources.on_line;
            this.rodDBStatusOnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOnLine.Name = "rodDBStatusOnLine";
            this.rodDBStatusOnLine.Size = new System.Drawing.Size(74, 22);
            this.rodDBStatusOnLine.Text = "ON-LINE";
            // 
            // rodSituacaoDB
            // 
            this.rodSituacaoDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodSituacaoDB.Name = "rodSituacaoDB";
            this.rodSituacaoDB.Size = new System.Drawing.Size(60, 22);
            this.rodSituacaoDB.Text = "DB Status:";
            // 
            // SeparatorEnd
            // 
            this.SeparatorEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SeparatorEnd.Name = "SeparatorEnd";
            this.SeparatorEnd.Size = new System.Drawing.Size(6, 25);
            // 
            // rodPlaySaveAll
            // 
            this.rodPlaySaveAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodPlaySaveAll.Image = global::DooggyCLI.Properties.Resources.save;
            this.rodPlaySaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodPlaySaveAll.Name = "rodPlaySaveAll";
            this.rodPlaySaveAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodPlaySaveAll.Size = new System.Drawing.Size(116, 22);
            this.rodPlaySaveAll.Text = "Play and Save All";
            this.rodPlaySaveAll.Click += new System.EventHandler(this.rodSaveAll_Click);
            // 
            // usrActionProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rodStatus);
            this.Name = "usrActionProject";
            this.Size = new System.Drawing.Size(601, 26);
            this.Load += new System.EventHandler(this.usrActionProject_Load);
            this.rodStatus.ResumeLayout(false);
            this.rodStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip rodStatus;
        private System.Windows.Forms.ToolStripButton rodDBStatusOffLine;
        private System.Windows.Forms.ToolStripButton rodDBStatusOnLine;
        private System.Windows.Forms.ToolStripLabel rodSituacaoDB;
        private System.Windows.Forms.ToolStripButton rodPlaySaveAll;
        private System.Windows.Forms.ToolStripButton rodProjectRefresh;
        private System.Windows.Forms.ToolStripSeparator SeparatorRefresh;
        private System.Windows.Forms.ToolStripButton rodCodePlayAll;
        private System.Windows.Forms.ToolStripButton rodMultiSelection;
        private System.Windows.Forms.ToolStripSeparator SeparatorAction;
        private System.Windows.Forms.ToolStripSeparator SeparatorEnd;
        private System.Windows.Forms.ToolStripDropDownButton rodMainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorMenu;
    }
}
