namespace BlueRocket
{
    partial class pagFiltro
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
            this.usrFilterScripts = new BlueRocket.usrFilterScripts();
            this.usrFilterTags = new BlueRocket.usrFilterTags();
            this.SeparadorH = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // usrFilterScripts
            // 
            this.usrFilterScripts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrFilterScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrFilterScripts.Location = new System.Drawing.Point(0, 0);
            this.usrFilterScripts.Name = "usrFilterScripts";
            this.usrFilterScripts.Size = new System.Drawing.Size(458, 659);
            this.usrFilterScripts.TabIndex = 0;
            // 
            // usrFilterTags
            // 
            this.usrFilterTags.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrFilterTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.usrFilterTags.Location = new System.Drawing.Point(461, 0);
            this.usrFilterTags.Name = "usrFilterTags";
            this.usrFilterTags.Size = new System.Drawing.Size(260, 659);
            this.usrFilterTags.TabIndex = 1;
            // 
            // SeparadorH
            // 
            this.SeparadorH.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeparadorH.Location = new System.Drawing.Point(458, 0);
            this.SeparadorH.Name = "SeparadorH";
            this.SeparadorH.Size = new System.Drawing.Size(3, 659);
            this.SeparadorH.TabIndex = 2;
            this.SeparadorH.TabStop = false;
            // 
            // pagFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usrFilterScripts);
            this.Controls.Add(this.SeparadorH);
            this.Controls.Add(this.usrFilterTags);
            this.Name = "pagFiltro";
            this.Size = new System.Drawing.Size(721, 659);
            this.ResumeLayout(false);

        }

        #endregion

        private usrFilterScripts usrFilterScripts;
        private usrFilterTags usrFilterTags;
        private System.Windows.Forms.Splitter SeparadorH;
    }
}
