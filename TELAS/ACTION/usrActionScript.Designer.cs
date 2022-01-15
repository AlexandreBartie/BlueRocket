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
            this.cmdUndo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdUndo.Location = new System.Drawing.Point(740, 3);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(94, 22);
            this.cmdUndo.TabIndex = 6;
            this.cmdUndo.Text = "UNDO";
            this.cmdUndo.UseVisualStyleBackColor = true;
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSave.Location = new System.Drawing.Point(619, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(97, 22);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "SAVE CODE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPlay.Location = new System.Drawing.Point(3, 3);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(97, 22);
            this.cmdPlay.TabIndex = 7;
            this.cmdPlay.Text = "PLAY >>>";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // usrActionScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdUndo);
            this.Controls.Add(this.cmdSave);
            this.Name = "usrActionScript";
            this.Size = new System.Drawing.Size(837, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdPlay;
    }
}
