namespace BlueRocket
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
            this.tabProject = new System.Windows.Forms.TabControl();
            this.tabEstrutura = new System.Windows.Forms.TabPage();
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.tabProject.SuspendLayout();
            this.tabEstrutura.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.tabEstrutura);
            this.tabProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProject.Location = new System.Drawing.Point(0, 40);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(794, 520);
            this.tabProject.TabIndex = 9;
            // 
            // tabEstrutura
            // 
            this.tabEstrutura.Controls.Add(this.trvProjeto);
            this.tabEstrutura.Location = new System.Drawing.Point(4, 24);
            this.tabEstrutura.Name = "tabEstrutura";
            this.tabEstrutura.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstrutura.Size = new System.Drawing.Size(786, 492);
            this.tabEstrutura.TabIndex = 0;
            this.tabEstrutura.Text = "Estrutura";
            this.tabEstrutura.UseVisualStyleBackColor = true;
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(3, 3);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(780, 486);
            this.trvProjeto.TabIndex = 8;
            this.trvProjeto.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterCheck);
            this.trvProjeto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterSelect);
            this.trvProjeto.DoubleClick += new System.EventHandler(this.trvProjeto_DoubleClick);
            // 
            // usrTestProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabProject);
            this.Name = "usrTestProject";
            this.Size = new System.Drawing.Size(794, 560);
            this.Controls.SetChildIndex(this.tabProject, 0);
            this.tabProject.ResumeLayout(false);
            this.tabEstrutura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabEstrutura;
        private System.Windows.Forms.TreeView trvProjeto;
    }
}
