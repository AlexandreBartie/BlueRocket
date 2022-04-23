namespace BlueRocket
{
    partial class pagEdition
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
            this.splSeparadorV = new System.Windows.Forms.Splitter();
            this.usrTestResult = new BlueRocket.usrTestResult();
            this.tabScript = new System.Windows.Forms.TabControl();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.usrTestCode = new BlueRocket.usrTestCode();
            this.tabScript.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // splSeparadorV
            // 
            this.splSeparadorV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splSeparadorV.Location = new System.Drawing.Point(0, 426);
            this.splSeparadorV.Name = "splSeparadorV";
            this.splSeparadorV.Size = new System.Drawing.Size(899, 3);
            this.splSeparadorV.TabIndex = 18;
            this.splSeparadorV.TabStop = false;
            // 
            // usrTestResult
            // 
            this.usrTestResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usrTestResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrTestResult.Location = new System.Drawing.Point(0, 429);
            this.usrTestResult.Name = "usrTestResult";
            this.usrTestResult.Size = new System.Drawing.Size(899, 376);
            this.usrTestResult.TabIndex = 17;
            // 
            // tabScript
            // 
            this.tabScript.Controls.Add(this.tabCode);
            this.tabScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabScript.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabScript.Location = new System.Drawing.Point(0, 40);
            this.tabScript.Name = "tabScript";
            this.tabScript.SelectedIndex = 0;
            this.tabScript.Size = new System.Drawing.Size(899, 386);
            this.tabScript.TabIndex = 20;
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.usrTestCode);
            this.tabCode.Location = new System.Drawing.Point(4, 23);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(891, 359);
            this.tabCode.TabIndex = 0;
            this.tabCode.Text = "Code";
            this.tabCode.UseVisualStyleBackColor = true;
            // 
            // usrTestCode
            // 
            this.usrTestCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrTestCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrTestCode.Location = new System.Drawing.Point(3, 3);
            this.usrTestCode.Name = "usrTestCode";
            this.usrTestCode.Size = new System.Drawing.Size(885, 353);
            this.usrTestCode.TabIndex = 20;
            // 
            // pagEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabScript);
            this.Controls.Add(this.splSeparadorV);
            this.Controls.Add(this.usrTestResult);
            this.Name = "pagEdition";
            this.Size = new System.Drawing.Size(899, 805);
            this.Controls.SetChildIndex(this.usrTestResult, 0);
            this.Controls.SetChildIndex(this.splSeparadorV, 0);
            this.Controls.SetChildIndex(this.tabScript, 0);
            this.tabScript.ResumeLayout(false);
            this.tabCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splSeparadorV;
        private usrTestResult usrTestResult;
        private System.Windows.Forms.TabControl tabScript;
        private System.Windows.Forms.TabPage tabCode;
        private usrTestCode usrTestCode;
    }
}
