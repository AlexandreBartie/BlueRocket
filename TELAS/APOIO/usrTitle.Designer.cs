namespace BlueRocket
{
    partial class usrTitle
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
            this.cmdTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTitle
            // 
            this.cmdTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdTitle.Location = new System.Drawing.Point(0, 0);
            this.cmdTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTitle.Name = "cmdTitle";
            this.cmdTitle.Size = new System.Drawing.Size(455, 40);
            this.cmdTitle.TabIndex = 0;
            this.cmdTitle.Text = "<<< TITLE >>>";
            this.cmdTitle.UseVisualStyleBackColor = false;
            this.cmdTitle.Click += new System.EventHandler(this.cmdTitulo_Click);
            // 
            // usrTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.Controls.Add(this.cmdTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usrTitle";
            this.Size = new System.Drawing.Size(455, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdTitle;
    }
}
