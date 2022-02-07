namespace DooggyCLI.Telas
{
    partial class usrWaiting
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
            this.picWaiting = new System.Windows.Forms.PictureBox();
            this.lblAguarde = new System.Windows.Forms.Label();
            this.lblProcessando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // picWaiting
            // 
            this.picWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picWaiting.Cursor = System.Windows.Forms.Cursors.Default;
            this.picWaiting.Image = global::DooggyCLI.Properties.Resources.waiting;
            this.picWaiting.Location = new System.Drawing.Point(37, 48);
            this.picWaiting.Name = "picWaiting";
            this.picWaiting.Size = new System.Drawing.Size(192, 154);
            this.picWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWaiting.TabIndex = 0;
            this.picWaiting.TabStop = false;
            // 
            // lblAguarde
            // 
            this.lblAguarde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAguarde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAguarde.Location = new System.Drawing.Point(49, 14);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(171, 31);
            this.lblAguarde.TabIndex = 1;
            this.lblAguarde.Text = "... AGUARDE ...";
            this.lblAguarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessando
            // 
            this.lblProcessando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcessando.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcessando.Location = new System.Drawing.Point(21, 184);
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(224, 58);
            this.lblProcessando.TabIndex = 2;
            this.lblProcessando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblProcessando);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.picWaiting);
            this.Name = "usrWaiting";
            this.Size = new System.Drawing.Size(262, 251);
            ((System.ComponentModel.ISupportInitialize)(this.picWaiting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWaiting;
        private System.Windows.Forms.Label lblAguarde;
        private System.Windows.Forms.Label lblProcessando;
    }
}
