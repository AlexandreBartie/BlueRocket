namespace DooggyCLI.Telas
{
    partial class usrActionScript
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
            this.cmdUndo = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUndo
            // 
            this.cmdUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUndo.Location = new System.Drawing.Point(740, 4);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(94, 30);
            this.cmdUndo.TabIndex = 6;
            this.cmdUndo.Text = "UNDO";
            this.cmdUndo.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(619, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(97, 30);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "SAVE CODE";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(3, 4);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(97, 30);
            this.cmdPlay.TabIndex = 7;
            this.cmdPlay.Text = "PLAY >>>";
            this.cmdPlay.UseVisualStyleBackColor = true;
            // 
            // usrActionScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdUndo);
            this.Controls.Add(this.cmdSave);
            this.Name = "usrActionScript";
            this.Size = new System.Drawing.Size(837, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdPlay;
    }
}
