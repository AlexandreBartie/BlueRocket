namespace DooggyCLI.Telas
{
    partial class usrTesteProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrTesteProject));
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.rodStatus = new System.Windows.Forms.ToolStrip();
            this.rodSituacaoDB = new System.Windows.Forms.ToolStripLabel();
            this.rodDBStatusOnLine = new System.Windows.Forms.ToolStripButton();
            this.rodDBStatusOffLine = new System.Windows.Forms.ToolStripButton();
            this.rodMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPlayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rodStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(0, 40);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(557, 441);
            this.trvProjeto.TabIndex = 7;
            this.trvProjeto.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterCheck);
            this.trvProjeto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterSelect);
            // 
            // rodStatus
            // 
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodMenu,
            this.rodDBStatusOffLine,
            this.rodDBStatusOnLine,
            this.rodSituacaoDB});
            this.rodStatus.Location = new System.Drawing.Point(0, 481);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(557, 25);
            this.rodStatus.TabIndex = 8;
            // 
            // rodSituacaoDB
            // 
            this.rodSituacaoDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodSituacaoDB.Name = "rodSituacaoDB";
            this.rodSituacaoDB.Size = new System.Drawing.Size(60, 22);
            this.rodSituacaoDB.Text = "DB Status:";
            // 
            // rodDBStatusOnLine
            // 
            this.rodDBStatusOnLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOnLine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rodDBStatusOnLine.Image = global::DooggyCLI.Properties.Resources.on_line;
            this.rodDBStatusOnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOnLine.Name = "rodDBStatusOnLine";
            this.rodDBStatusOnLine.Size = new System.Drawing.Size(74, 22);
            this.rodDBStatusOnLine.Text = "ON-LINE";
            // 
            // rodDBStatusOffLine
            // 
            this.rodDBStatusOffLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOffLine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rodDBStatusOffLine.Image = global::DooggyCLI.Properties.Resources.off_line;
            this.rodDBStatusOffLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOffLine.Name = "rodDBStatusOffLine";
            this.rodDBStatusOffLine.Size = new System.Drawing.Size(77, 22);
            this.rodDBStatusOffLine.Text = "OFF-LINE";
            // 
            // rodMenu
            // 
            this.rodMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rodMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayAll,
            this.mnuSaveAll,
            this.Separator1,
            this.mnuRefresh,
            this.Separator2,
            this.mnuExit});
            this.rodMenu.Image = ((System.Drawing.Image)(resources.GetObject("rodMenu.Image")));
            this.rodMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodMenu.Name = "rodMenu";
            this.rodMenu.Size = new System.Drawing.Size(51, 22);
            this.rodMenu.Text = "Menu";
            // 
            // mnuPlayAll
            // 
            this.mnuPlayAll.Name = "mnuPlayAll";
            this.mnuPlayAll.Size = new System.Drawing.Size(180, 22);
            this.mnuPlayAll.Text = "Play ALL";
            // 
            // mnuSaveAll
            // 
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveAll.Text = "Save ALL";
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(180, 22);
            this.mnuRefresh.Text = "Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Sair";
            // 
            // usrTesteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvProjeto);
            this.Controls.Add(this.rodStatus);
            this.Name = "usrTesteProject";
            this.Size = new System.Drawing.Size(557, 506);
            this.Controls.SetChildIndex(this.rodStatus, 0);
            this.Controls.SetChildIndex(this.trvProjeto, 0);
            this.rodStatus.ResumeLayout(false);
            this.rodStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvProjeto;
        private System.Windows.Forms.ToolStrip rodStatus;
        private System.Windows.Forms.ToolStripButton rodDBStatusOnLine;
        private System.Windows.Forms.ToolStripButton rodDBStatusOffLine;
        private System.Windows.Forms.ToolStripLabel rodSituacaoDB;
        private System.Windows.Forms.ToolStripDropDownButton rodMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayAll;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}
