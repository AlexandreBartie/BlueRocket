namespace BlueRocket
{
    partial class usrActionStatus
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
            this.rodDBStatusOffLine = new System.Windows.Forms.ToolStripButton();
            this.rodDBStatusOnLine = new System.Windows.Forms.ToolStripButton();
            this.rodStatusDB = new System.Windows.Forms.ToolStripLabel();
            this.rodMultiSelect = new System.Windows.Forms.ToolStripButton();
            this.rodProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.rodSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.rodActionStatus = new System.Windows.Forms.ToolStripButton();
            this.rodAction = new System.Windows.Forms.ToolStripLabel();
            this.rodStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rodStatus
            // 
            this.rodStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rodStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodDBStatusOffLine,
            this.rodDBStatusOnLine,
            this.rodStatusDB,
            this.rodMultiSelect,
            this.rodProgressBar,
            this.rodSeparator,
            this.rodActionStatus,
            this.rodAction});
            this.rodStatus.Location = new System.Drawing.Point(0, 1);
            this.rodStatus.Name = "rodStatus";
            this.rodStatus.Size = new System.Drawing.Size(601, 25);
            this.rodStatus.TabIndex = 9;
            // 
            // rodDBStatusOffLine
            // 
            this.rodDBStatusOffLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOffLine.BackColor = System.Drawing.Color.Pink;
            this.rodDBStatusOffLine.Image = global::BlueRocket.Properties.Resources.off_line;
            this.rodDBStatusOffLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOffLine.Name = "rodDBStatusOffLine";
            this.rodDBStatusOffLine.Size = new System.Drawing.Size(77, 22);
            this.rodDBStatusOffLine.Text = "OFF-LINE";
            this.rodDBStatusOffLine.Click += new System.EventHandler(this.rodDBStatusOffLine_Click);
            // 
            // rodDBStatusOnLine
            // 
            this.rodDBStatusOnLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodDBStatusOnLine.BackColor = System.Drawing.Color.Wheat;
            this.rodDBStatusOnLine.Image = global::BlueRocket.Properties.Resources.on_line;
            this.rodDBStatusOnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodDBStatusOnLine.Name = "rodDBStatusOnLine";
            this.rodDBStatusOnLine.Size = new System.Drawing.Size(74, 22);
            this.rodDBStatusOnLine.Text = "ON-LINE";
            // 
            // rodStatusDB
            // 
            this.rodStatusDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rodStatusDB.Name = "rodStatusDB";
            this.rodStatusDB.Size = new System.Drawing.Size(60, 22);
            this.rodStatusDB.Text = "DB Status:";
            // 
            // rodMultiSelect
            // 
            this.rodMultiSelect.CheckOnClick = true;
            this.rodMultiSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodMultiSelect.Image = global::BlueRocket.Properties.Resources.itens;
            this.rodMultiSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodMultiSelect.Name = "rodMultiSelect";
            this.rodMultiSelect.Size = new System.Drawing.Size(23, 22);
            this.rodMultiSelect.Text = "MultiSelect";
            this.rodMultiSelect.Click += new System.EventHandler(this.rodMultiSelect_Click);
            // 
            // rodProgressBar
            // 
            this.rodProgressBar.Name = "rodProgressBar";
            this.rodProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // rodSeparator
            // 
            this.rodSeparator.Name = "rodSeparator";
            this.rodSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // rodActionStatus
            // 
            this.rodActionStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodActionStatus.Image = global::BlueRocket.Properties.Resources.rocket;
            this.rodActionStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rodActionStatus.Name = "rodActionStatus";
            this.rodActionStatus.Size = new System.Drawing.Size(23, 22);
            this.rodActionStatus.ToolTipText = "Status Action";
            // 
            // rodAction
            // 
            this.rodAction.Name = "rodAction";
            this.rodAction.Size = new System.Drawing.Size(60, 22);
            this.rodAction.Text = "Waiting ...";
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
        private System.Windows.Forms.ToolStripLabel rodStatusDB;
        private System.Windows.Forms.ToolStripLabel rodAction;
        private System.Windows.Forms.ToolStripProgressBar rodProgressBar;
        private System.Windows.Forms.ToolStripSeparator rodSeparator;
        private System.Windows.Forms.ToolStripButton rodActionStatus;
        private System.Windows.Forms.ToolStripButton rodMultiSelect;
    }
}
