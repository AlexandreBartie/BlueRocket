namespace BlueRocket
{
    partial class usrListTags
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
            this.trvTags = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvTags
            // 
            this.trvTags.BackColor = System.Drawing.SystemColors.Info;
            this.trvTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvTags.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvTags.Location = new System.Drawing.Point(0, 40);
            this.trvTags.Name = "trvTags";
            this.trvTags.Size = new System.Drawing.Size(446, 520);
            this.trvTags.TabIndex = 9;
            // 
            // usrFilterTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvTags);
            this.Name = "usrFilterTags";
            this.Size = new System.Drawing.Size(446, 560);
            this.Controls.SetChildIndex(this.trvTags, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTags;
    }
}
