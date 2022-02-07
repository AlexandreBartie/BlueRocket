namespace DooggyCLI.Telas
{
    partial class usrTestProject
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
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.usrAction = new DooggyCLI.Telas.usrActionProject();
            this.SuspendLayout();
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(0, 40);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(663, 441);
            this.trvProjeto.TabIndex = 7;
            this.trvProjeto.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterCheck);
            this.trvProjeto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterSelect);
            this.trvProjeto.DoubleClick += new System.EventHandler(this.trvProjeto_DoubleClick);
            // 
            // usrAction
            // 
            this.usrAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrAction.Location = new System.Drawing.Point(0, 481);
            this.usrAction.Name = "usrAction";
            this.usrAction.Size = new System.Drawing.Size(663, 25);
            this.usrAction.TabIndex = 8;
            // 
            // usrTestProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvProjeto);
            this.Controls.Add(this.usrAction);
            this.Name = "usrTestProject";
            this.Size = new System.Drawing.Size(663, 506);
            this.Controls.SetChildIndex(this.usrAction, 0);
            this.Controls.SetChildIndex(this.trvProjeto, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvProjeto;
        private usrActionProject usrAction;
        private usrActionConfig usrMaster;
    }
}
