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
            this.usrTestScripts = new BlueRocket.usrTestScripts();
            this.usrTestTags = new BlueRocket.usrTestTags();
            this.SeparadorH = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // usrTestScripts
            // 
            this.usrTestScripts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrTestScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrTestScripts.Location = new System.Drawing.Point(0, 0);
            this.usrTestScripts.Name = "usrTestScripts";
            this.usrTestScripts.Size = new System.Drawing.Size(721, 447);
            this.usrTestScripts.TabIndex = 0;
            // 
            // usrTestTags
            // 
            this.usrTestTags.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrTestTags.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrTestTags.Location = new System.Drawing.Point(0, 450);
            this.usrTestTags.Name = "usrTestTags";
            this.usrTestTags.Size = new System.Drawing.Size(721, 209);
            this.usrTestTags.TabIndex = 1;
            // 
            // SeparadorH
            // 
            this.SeparadorH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparadorH.Location = new System.Drawing.Point(0, 447);
            this.SeparadorH.Name = "SeparadorH";
            this.SeparadorH.Size = new System.Drawing.Size(721, 3);
            this.SeparadorH.TabIndex = 2;
            this.SeparadorH.TabStop = false;
            // 
            // pagScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usrTestScripts);
            this.Controls.Add(this.SeparadorH);
            this.Controls.Add(this.usrTestTags);
            this.Name = "pagScripts";
            this.Size = new System.Drawing.Size(721, 659);
            this.ResumeLayout(false);

        }

        #endregion

        private usrTestScripts usrTestScripts;
        private usrTestTags usrTestTags;
        private System.Windows.Forms.Splitter SeparadorH;
    }
}
