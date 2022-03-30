namespace BlueRocket
{
    partial class pagEdicao
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
            this.splSeparadorH = new System.Windows.Forms.Splitter();
            this.splSeparadorV = new System.Windows.Forms.Splitter();
            this.usrResultadoTeste = new BlueRocket.usrTestResult();
            this.usrScriptTeste = new BlueRocket.usrTestCode();
            this.usrProjetoTeste = new BlueRocket.usrTestProject();
            this.SuspendLayout();
            // 
            // splSeparadorH
            // 
            this.splSeparadorH.Location = new System.Drawing.Point(557, 0);
            this.splSeparadorH.Name = "splSeparadorH";
            this.splSeparadorH.Size = new System.Drawing.Size(3, 805);
            this.splSeparadorH.TabIndex = 16;
            this.splSeparadorH.TabStop = false;
            // 
            // splSeparadorV
            // 
            this.splSeparadorV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splSeparadorV.Location = new System.Drawing.Point(560, 426);
            this.splSeparadorV.Name = "splSeparadorV";
            this.splSeparadorV.Size = new System.Drawing.Size(701, 3);
            this.splSeparadorV.TabIndex = 18;
            this.splSeparadorV.TabStop = false;
            // 
            // usrResultadoTeste
            // 
            this.usrResultadoTeste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usrResultadoTeste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrResultadoTeste.Location = new System.Drawing.Point(560, 429);
            this.usrResultadoTeste.Name = "usrResultadoTeste";
            this.usrResultadoTeste.Size = new System.Drawing.Size(701, 376);
            this.usrResultadoTeste.TabIndex = 17;
            // 
            // usrScriptTeste
            // 
            this.usrScriptTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrScriptTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrScriptTeste.Location = new System.Drawing.Point(560, 0);
            this.usrScriptTeste.Name = "usrScriptTeste";
            this.usrScriptTeste.Size = new System.Drawing.Size(701, 426);
            this.usrScriptTeste.TabIndex = 19;
            // 
            // usrProjetoTeste
            // 
            this.usrProjetoTeste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usrProjetoTeste.Dock = System.Windows.Forms.DockStyle.Left;
            this.usrProjetoTeste.Location = new System.Drawing.Point(0, 0);
            this.usrProjetoTeste.Name = "usrProjetoTeste";
            this.usrProjetoTeste.Size = new System.Drawing.Size(557, 805);
            this.usrProjetoTeste.TabIndex = 15;
            // 
            // PagEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usrScriptTeste);
            this.Controls.Add(this.splSeparadorV);
            this.Controls.Add(this.usrResultadoTeste);
            this.Controls.Add(this.splSeparadorH);
            this.Controls.Add(this.usrProjetoTeste);
            this.Name = "PagEdicao";
            this.Size = new System.Drawing.Size(1261, 805);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splSeparadorH;
        private System.Windows.Forms.Splitter splSeparadorV;
        private usrTestResult usrResultadoTeste;
        private usrTestCode usrScriptTeste;
        private usrTestProject usrProjetoTeste;
    }
}
