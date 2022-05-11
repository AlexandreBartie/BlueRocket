namespace BlueRocket
{
    partial class usrViewResult
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDataOut = new System.Windows.Forms.TabPage();
            this.txtMassaDados = new System.Windows.Forms.TextBox();
            this.tabTraceLog = new System.Windows.Forms.TabPage();
            this.lstLogExecucao = new System.Windows.Forms.ListView();
            this.colOrdem = new System.Windows.Forms.ColumnHeader();
            this.colTipo = new System.Windows.Forms.ColumnHeader();
            this.colDescricao = new System.Windows.Forms.ColumnHeader();
            this.tabTraceErrors = new System.Windows.Forms.TabPage();
            this.lstLogErrors = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.tabSqlCommands = new System.Windows.Forms.TabPage();
            this.lstSqlCommands = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabControl.SuspendLayout();
            this.tabDataOut.SuspendLayout();
            this.tabTraceLog.SuspendLayout();
            this.tabTraceErrors.SuspendLayout();
            this.tabSqlCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabDataOut);
            this.tabControl.Controls.Add(this.tabTraceLog);
            this.tabControl.Controls.Add(this.tabTraceErrors);
            this.tabControl.Controls.Add(this.tabSqlCommands);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(565, 484);
            this.tabControl.TabIndex = 5;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabDataOut
            // 
            this.tabDataOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabDataOut.Controls.Add(this.txtMassaDados);
            this.tabDataOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDataOut.Location = new System.Drawing.Point(4, 4);
            this.tabDataOut.Name = "tabDataOut";
            this.tabDataOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataOut.Size = new System.Drawing.Size(557, 457);
            this.tabDataOut.TabIndex = 0;
            this.tabDataOut.Text = "Data Out";
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
            this.txtMassaDados.Size = new System.Drawing.Size(551, 451);
            this.txtMassaDados.TabIndex = 5;
            // 
            // tabTraceLog
            // 
            this.tabTraceLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTraceLog.Controls.Add(this.lstLogExecucao);
            this.tabTraceLog.Location = new System.Drawing.Point(4, 4);
            this.tabTraceLog.Name = "tabTraceLog";
            this.tabTraceLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraceLog.Size = new System.Drawing.Size(557, 457);
            this.tabTraceLog.TabIndex = 1;
            this.tabTraceLog.Text = "Trace Log";
            // 
            // lstLogExecucao
            // 
            this.lstLogExecucao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrdem,
            this.colTipo,
            this.colDescricao});
            this.lstLogExecucao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogExecucao.HideSelection = false;
            this.lstLogExecucao.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lstLogExecucao.Location = new System.Drawing.Point(3, 3);
            this.lstLogExecucao.Name = "lstLogExecucao";
            this.lstLogExecucao.Size = new System.Drawing.Size(551, 451);
            this.lstLogExecucao.TabIndex = 0;
            this.lstLogExecucao.UseCompatibleStateImageBehavior = false;
            this.lstLogExecucao.View = System.Windows.Forms.View.Details;
            // 
            // colOrdem
            // 
            this.colOrdem.Text = "#";
            this.colOrdem.Width = 0;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colDescricao
            // 
            this.colDescricao.Text = "Descrição";
            this.colDescricao.Width = 482;
            // 
            // tabTraceErrors
            // 
            this.tabTraceErrors.Controls.Add(this.lstLogErrors);
            this.tabTraceErrors.Location = new System.Drawing.Point(4, 4);
            this.tabTraceErrors.Name = "tabTraceErrors";
            this.tabTraceErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraceErrors.Size = new System.Drawing.Size(557, 457);
            this.tabTraceErrors.TabIndex = 3;
            this.tabTraceErrors.Text = "Trace Errors";
            this.tabTraceErrors.UseVisualStyleBackColor = true;
            // 
            // lstLogErrors
            // 
            this.lstLogErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstLogErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogErrors.HideSelection = false;
            this.lstLogErrors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lstLogErrors.Location = new System.Drawing.Point(3, 3);
            this.lstLogErrors.Name = "lstLogErrors";
            this.lstLogErrors.Size = new System.Drawing.Size(551, 451);
            this.lstLogErrors.TabIndex = 1;
            this.lstLogErrors.UseCompatibleStateImageBehavior = false;
            this.lstLogErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descrição";
            this.columnHeader6.Width = 482;
            // 
            // tabSqlCommands
            // 
            this.tabSqlCommands.Controls.Add(this.lstSqlCommands);
            this.tabSqlCommands.Location = new System.Drawing.Point(4, 4);
            this.tabSqlCommands.Name = "tabSqlCommands";
            this.tabSqlCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabSqlCommands.Size = new System.Drawing.Size(557, 457);
            this.tabSqlCommands.TabIndex = 2;
            this.tabSqlCommands.Text = "SQL Commands";
            this.tabSqlCommands.UseVisualStyleBackColor = true;
            // 
            // lstSqlCommands
            // 
            this.lstSqlCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstSqlCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSqlCommands.HideSelection = false;
            this.lstSqlCommands.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.lstSqlCommands.Location = new System.Drawing.Point(3, 3);
            this.lstSqlCommands.Name = "lstSqlCommands";
            this.lstSqlCommands.Size = new System.Drawing.Size(551, 451);
            this.lstSqlCommands.TabIndex = 1;
            this.lstSqlCommands.UseCompatibleStateImageBehavior = false;
            this.lstSqlCommands.View = System.Windows.Forms.View.Details;
            this.lstSqlCommands.DoubleClick += new System.EventHandler(this.lstSqlCommands_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tempo";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrição";
            this.columnHeader3.Width = 482;
            // 
            // usrTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControl);
            this.Name = "usrTestResult";
            this.Size = new System.Drawing.Size(565, 524);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.tabControl.ResumeLayout(false);
            this.tabDataOut.ResumeLayout(false);
            this.tabDataOut.PerformLayout();
            this.tabTraceLog.ResumeLayout(false);
            this.tabTraceErrors.ResumeLayout(false);
            this.tabSqlCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDataOut;
        private System.Windows.Forms.TextBox txtMassaDados;
        private System.Windows.Forms.TabPage tabTraceLog;
        private System.Windows.Forms.ListView lstLogExecucao;
        private System.Windows.Forms.ColumnHeader colOrdem;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colDescricao;
        private System.Windows.Forms.TabPage tabSqlCommands;
        private System.Windows.Forms.ListView lstSqlCommands;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabTraceErrors;
        private System.Windows.Forms.ListView lstLogErrors;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
