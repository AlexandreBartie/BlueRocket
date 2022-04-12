namespace BlueRocket
{
    partial class pagScripts
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.usrTestScripts = new BlueRocket.usrTestScripts();
            this.tabFiltro = new System.Windows.Forms.TabPage();
            this.usrTestTags = new BlueRocket.usrTestTags();
            this.tabPage.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPage.Controls.Add(this.tabScripts);
            this.tabPage.Controls.Add(this.tabFiltro);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 40);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(721, 619);
            this.tabPage.TabIndex = 5;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.tabPage_SelectedIndexChanged);
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.usrTestScripts);
            this.tabScripts.Location = new System.Drawing.Point(4, 4);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new System.Drawing.Size(713, 591);
            this.tabScripts.TabIndex = 0;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // usrTestScripts
            // 
            this.usrTestScripts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrTestScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrTestScripts.Location = new System.Drawing.Point(3, 3);
            this.usrTestScripts.Name = "usrTestScripts";
            this.usrTestScripts.Size = new System.Drawing.Size(707, 585);
            this.usrTestScripts.TabIndex = 1;
            // 
            // tabFiltro
            // 
            this.tabFiltro.Controls.Add(this.usrTestTags);
            this.tabFiltro.Location = new System.Drawing.Point(4, 4);
            this.tabFiltro.Name = "tabFiltro";
            this.tabFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiltro.Size = new System.Drawing.Size(713, 591);
            this.tabFiltro.TabIndex = 1;
            this.tabFiltro.Text = "Filtro";
            this.tabFiltro.UseVisualStyleBackColor = true;
            // 
            // usrTestTags
            // 
            this.usrTestTags.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrTestTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrTestTags.Location = new System.Drawing.Point(3, 3);
            this.usrTestTags.Name = "usrTestTags";
            this.usrTestTags.Size = new System.Drawing.Size(707, 585);
            this.usrTestTags.TabIndex = 2;
            // 
            // pagScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPage);
            this.Name = "pagScripts";
            this.Size = new System.Drawing.Size(721, 659);
            this.Controls.SetChildIndex(this.tabPage, 0);
            this.tabPage.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.tabFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabScripts;
        private usrTestScripts usrTestScripts;
        private System.Windows.Forms.TabPage tabFiltro;
        private usrTestTags usrTestTags;
    }
}
