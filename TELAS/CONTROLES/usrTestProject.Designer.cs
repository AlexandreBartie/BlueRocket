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
            this.tabEstrutura = new System.Windows.Forms.TabPage();
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.tabFiltro = new System.Windows.Forms.TabPage();
            this.trvFiltro = new System.Windows.Forms.TreeView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.lstScripts = new System.Windows.Forms.ListView();
            this.tabProject.SuspendLayout();
            this.tabEstrutura.SuspendLayout();
            this.tabFiltro.SuspendLayout();
            this.tabScripts.SuspendLayout();
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
            this.tabProject.Controls.Add(this.tabEstrutura);
            this.tabProject.Controls.Add(this.tabFiltro);
            this.tabProject.Controls.Add(this.tabScripts);
            this.tabProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProject.Location = new System.Drawing.Point(0, 40);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(663, 441);
            this.tabProject.TabIndex = 9;
            // 
            // tabEstrutura
            // 
            this.tabEstrutura.Controls.Add(this.trvProjeto);
            this.tabEstrutura.Location = new System.Drawing.Point(4, 24);
            this.tabEstrutura.Name = "tabEstrutura";
            this.tabEstrutura.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstrutura.Size = new System.Drawing.Size(655, 413);
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
            this.trvProjeto.Size = new System.Drawing.Size(649, 407);
            this.trvProjeto.TabIndex = 8;
            // 
            // tabFiltro
            // 
            this.tabFiltro.Controls.Add(this.trvFiltro);
            this.tabFiltro.Controls.Add(this.txtStatus);
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
            this.trvFiltro.Size = new System.Drawing.Size(649, 80);
            this.trvFiltro.TabIndex = 9;
            this.trvFiltro.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvFiltro_AfterCheck);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatus.Location = new System.Drawing.Point(3, 83);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(649, 327);
            this.txtStatus.TabIndex = 18;
            this.txtStatus.Text = "aqui ...";
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.lstScripts);
            this.tabScripts.Location = new System.Drawing.Point(4, 24);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new System.Drawing.Size(655, 413);
            this.tabScripts.TabIndex = 2;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // lstScripts
            // 
            this.lstScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScripts.HideSelection = false;
            this.lstScripts.Location = new System.Drawing.Point(3, 3);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.Size = new System.Drawing.Size(649, 407);
            this.lstScripts.TabIndex = 0;
            this.lstScripts.UseCompatibleStateImageBehavior = false;
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
            this.tabEstrutura.ResumeLayout(false);
            this.tabFiltro.ResumeLayout(false);
            this.tabFiltro.PerformLayout();
            this.tabScripts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private usrActionProject usrAction;
        private usrActionConfig usrMaster;
        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabEstrutura;
        private System.Windows.Forms.TreeView trvProjeto;
        private System.Windows.Forms.TabPage tabFiltro;
        private System.Windows.Forms.TreeView trvFiltro;
        private System.Windows.Forms.TabPage tabScripts;
        private System.Windows.Forms.ListView lstScripts;
        private System.Windows.Forms.TextBox txtStatus;
    }
}
