namespace BlueRocket
{
    partial class usrLabelTextBox
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescription.Enabled = false;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(3, 23);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 23);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.Text = "fffff]";
            // 
            // lblTag
            // 
            this.lblTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(3, 5);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 22;
            this.lblTag.Text = "......";
            // 
            // usrLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTag);
            this.MinimumSize = new System.Drawing.Size(0, 50);
            this.Name = "usrLabelTextBox";
            this.Size = new System.Drawing.Size(235, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTag;
    }
}
