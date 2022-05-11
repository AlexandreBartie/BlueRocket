namespace BlueRocket
{
    partial class usrViewData
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
            this.grdDataFeed = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDataFeed
            // 
            this.grdDataFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDataFeed.Location = new System.Drawing.Point(0, 0);
            this.grdDataFeed.Name = "grdDataFeed";
            this.grdDataFeed.RowTemplate.Height = 25;
            this.grdDataFeed.Size = new System.Drawing.Size(610, 468);
            this.grdDataFeed.TabIndex = 0;
            // 
            // usrTestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdDataFeed);
            this.Name = "usrTestData";
            this.Size = new System.Drawing.Size(610, 468);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDataFeed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
