namespace ConsoleTestes
{
    partial class usrScriptTeste
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
            this.usrTitulo = new ConsoleTestes.usrTitulo();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usrTitulo
            // 
            this.usrTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usrTitulo.Location = new System.Drawing.Point(0, 0);
            this.usrTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.usrTitulo.Name = "usrTitulo";
            this.usrTitulo.Size = new System.Drawing.Size(652, 40);
            this.usrTitulo.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsReturn = true;
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(0, 40);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(652, 313);
            this.txtCode.TabIndex = 4;
            // 
            // usrScriptTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.usrTitulo);
            this.Name = "usrScriptTeste";
            this.Size = new System.Drawing.Size(652, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usrTitulo usrTitulo;
        private System.Windows.Forms.TextBox txtCode;
    }
}
