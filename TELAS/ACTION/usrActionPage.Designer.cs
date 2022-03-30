namespace BlueRocket.TELAS.ACTION
{
    partial class usrActionPage
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
            this.cmdFilter = new System.Windows.Forms.Button();
            this.cmdEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFilter
            // 
            this.cmdFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdFilter.FlatAppearance.BorderSize = 2;
            this.cmdFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFilter.Location = new System.Drawing.Point(4, 87);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Size = new System.Drawing.Size(65, 50);
            this.cmdFilter.TabIndex = 1;
            this.cmdFilter.Text = "Page Filtro";
            this.cmdFilter.UseVisualStyleBackColor = false;
            // 
            // cmdEditor
            // 
            this.cmdEditor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdEditor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEditor.FlatAppearance.BorderSize = 2;
            this.cmdEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditor.Location = new System.Drawing.Point(3, 17);
            this.cmdEditor.Name = "cmdEditor";
            this.cmdEditor.Size = new System.Drawing.Size(65, 50);
            this.cmdEditor.TabIndex = 2;
            this.cmdEditor.Text = "Page Editor";
            this.cmdEditor.UseVisualStyleBackColor = false;
            // 
            // usrActionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cmdEditor);
            this.Controls.Add(this.cmdFilter);
            this.Name = "usrActionPage";
            this.Size = new System.Drawing.Size(72, 679);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFilter;
        private System.Windows.Forms.Button cmdEditor;
    }
}
