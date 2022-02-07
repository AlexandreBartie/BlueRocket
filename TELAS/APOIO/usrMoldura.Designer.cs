namespace DooggyCLI.Telas
{
    partial class usrMoldura
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
            this.usrTitulo = new DooggyCLI.Telas.usrTitulo();
            this.SuspendLayout();
            // 
            // usrTitulo
            // 
            this.usrTitulo.BackColor = System.Drawing.Color.DarkMagenta;
            this.usrTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usrTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.usrTitulo.Location = new System.Drawing.Point(0, 0);
            this.usrTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.usrTitulo.Name = "usrTitulo";
            this.usrTitulo.Size = new System.Drawing.Size(556, 40);
            this.usrTitulo.TabIndex = 4;
            this.usrTitulo.TituloClick += new DooggyCLI.Telas.Notify_TituloClick(this.usrTitulo_TituloClick);
            // 
            // usrMoldura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.usrTitulo);
            this.Name = "usrMoldura";
            this.Size = new System.Drawing.Size(556, 427);
            this.ResumeLayout(false);

        }

        #endregion

        private usrTitulo usrTitulo;
    }
}
