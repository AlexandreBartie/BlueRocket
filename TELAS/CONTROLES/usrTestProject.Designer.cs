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
            this.usrAction = new BlueRocket.usrActionProject();
            this.tabProject = new System.Windows.Forms.TabControl();
            this.tabNavegador = new System.Windows.Forms.TabPage();
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.tabFiltro = new System.Windows.Forms.TabPage();
            this.trvFiltro = new System.Windows.Forms.TreeView();
            this.tabProject.SuspendLayout();
            this.tabNavegador.SuspendLayout();
            this.tabFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrAction
            // 
            this.usrAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrAction.Location = new System.Drawing.Point(0, 481);
            this.usrAction.Name = "usrAction";
            this.usrAction.Size = new System.Drawing.Size(663, 25);
            this.usrAction.TabIndex = 8;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.tabNavegador);
            this.tabProject.Controls.Add(this.tabFiltro);
            this.tabProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProject.Location = new System.Drawing.Point(0, 40);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(663, 441);
            this.tabProject.TabIndex = 9;
            // 
            // tabNavegador
            // 
            this.tabNavegador.Controls.Add(this.trvProjeto);
            this.tabNavegador.Location = new System.Drawing.Point(4, 24);
            this.tabNavegador.Name = "tabNavegador";
            this.tabNavegador.Padding = new System.Windows.Forms.Padding(3);
            this.tabNavegador.Size = new System.Drawing.Size(655, 413);
            this.tabNavegador.TabIndex = 0;
            this.tabNavegador.Text = "Navegador";
            this.tabNavegador.UseVisualStyleBackColor = true;
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(3, 3);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(649, 407);
            this.trvProjeto.TabIndex = 8;
            // 
            // tabFiltro
            // 
            this.tabFiltro.Controls.Add(this.trvFiltro);
            this.tabFiltro.Location = new System.Drawing.Point(4, 24);
            this.tabFiltro.Name = "tabFiltro";
            this.tabFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiltro.Size = new System.Drawing.Size(655, 413);
            this.tabFiltro.TabIndex = 1;
            this.tabFiltro.Text = "Filtro";
            this.tabFiltro.UseVisualStyleBackColor = true;
            // 
            // trvFiltro
            // 
            this.trvFiltro.BackColor = System.Drawing.SystemColors.Info;
            this.trvFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFiltro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvFiltro.Location = new System.Drawing.Point(3, 3);
            this.trvFiltro.Name = "trvFiltro";
            this.trvFiltro.Size = new System.Drawing.Size(649, 407);
            this.trvFiltro.TabIndex = 9;
            // 
            // usrTestProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabProject);
            this.Controls.Add(this.usrAction);
            this.Name = "usrTestProject";
            this.Size = new System.Drawing.Size(663, 506);
            this.Controls.SetChildIndex(this.usrAction, 0);
            this.Controls.SetChildIndex(this.tabProject, 0);
            this.tabProject.ResumeLayout(false);
            this.tabNavegador.ResumeLayout(false);
            this.tabFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private usrActionProject usrAction;
        private usrActionConfig usrMaster;
        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabNavegador;
        private System.Windows.Forms.TreeView trvProjeto;
        private System.Windows.Forms.TabPage tabFiltro;
        private System.Windows.Forms.TreeView trvFiltro;
    }
}
