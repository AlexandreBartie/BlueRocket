namespace PainelTestes.TELAS.CONTROLES
{
    partial class usrResultadoTeste
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMassaDados = new System.Windows.Forms.TabPage();
            this.txtMassaDados = new System.Windows.Forms.TextBox();
            this.tabLogExecucao = new System.Windows.Forms.TabPage();
            this.txtLogExecucao = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabMassaDados.SuspendLayout();
            this.tabLogExecucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabMassaDados);
            this.tabControl.Controls.Add(this.tabLogExecucao);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(565, 484);
            this.tabControl.TabIndex = 5;
            // 
            // tabMassaDados
            // 
            this.tabMassaDados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabMassaDados.Controls.Add(this.txtMassaDados);
            this.tabMassaDados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMassaDados.Location = new System.Drawing.Point(4, 4);
            this.tabMassaDados.Name = "tabMassaDados";
            this.tabMassaDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabMassaDados.Size = new System.Drawing.Size(557, 453);
            this.tabMassaDados.TabIndex = 0;
            this.tabMassaDados.Text = "Massa Dados";
            // 
            // txtMassaDados
            // 
            this.txtMassaDados.AcceptsReturn = true;
            this.txtMassaDados.BackColor = System.Drawing.SystemColors.Info;
            this.txtMassaDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMassaDados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMassaDados.Location = new System.Drawing.Point(3, 3);
            this.txtMassaDados.Multiline = true;
            this.txtMassaDados.Name = "txtMassaDados";
            this.txtMassaDados.Size = new System.Drawing.Size(551, 447);
            this.txtMassaDados.TabIndex = 5;
            // 
            // tabLogExecucao
            // 
            this.tabLogExecucao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabLogExecucao.Controls.Add(this.txtLogExecucao);
            this.tabLogExecucao.Location = new System.Drawing.Point(4, 4);
            this.tabLogExecucao.Name = "tabLogExecucao";
            this.tabLogExecucao.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogExecucao.Size = new System.Drawing.Size(557, 453);
            this.tabLogExecucao.TabIndex = 1;
            this.tabLogExecucao.Text = "Log Execução";
            // 
            // txtLogExecucao
            // 
            this.txtLogExecucao.AcceptsReturn = true;
            this.txtLogExecucao.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogExecucao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogExecucao.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogExecucao.Location = new System.Drawing.Point(3, 3);
            this.txtLogExecucao.Multiline = true;
            this.txtLogExecucao.Name = "txtLogExecucao";
            this.txtLogExecucao.Size = new System.Drawing.Size(551, 447);
            this.txtLogExecucao.TabIndex = 6;
            // 
            // usrResultadoTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControl);
            this.Name = "usrResultadoTeste";
            this.Size = new System.Drawing.Size(565, 524);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.tabControl.ResumeLayout(false);
            this.tabMassaDados.ResumeLayout(false);
            this.tabMassaDados.PerformLayout();
            this.tabLogExecucao.ResumeLayout(false);
            this.tabLogExecucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMassaDados;
        private System.Windows.Forms.TextBox txtMassaDados;
        private System.Windows.Forms.TabPage tabLogExecucao;
        private System.Windows.Forms.TextBox txtLogExecucao;
    }
}
