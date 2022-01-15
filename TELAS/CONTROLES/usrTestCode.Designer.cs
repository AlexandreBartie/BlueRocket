namespace DooggyCLI.Telas
{
    partial class usrTestCode
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
            this.usrAction = new DooggyCLI.Telas.usrActionScript();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usrAction
            // 
            this.usrAction.BackColor = System.Drawing.Color.Gainsboro;
            this.usrAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrAction.Location = new System.Drawing.Point(0, 404);
            this.usrAction.Name = "usrAction";
            this.usrAction.Size = new System.Drawing.Size(767, 29);
            this.usrAction.TabIndex = 14;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 40);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(767, 364);
            this.txtCode.TabIndex = 15;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // usrTestCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.usrAction);
            this.Name = "usrTestCode";
            this.Size = new System.Drawing.Size(767, 433);
            this.Controls.SetChildIndex(this.usrAction, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usrActionScript usrAction;
        private System.Windows.Forms.TextBox txtCode;
    }
}
