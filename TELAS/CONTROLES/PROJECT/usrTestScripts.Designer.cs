﻿namespace BlueRocket
{
    partial class usrTestScripts
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
            this.components = new System.ComponentModel.Container();
            this.lstScripts = new System.Windows.Forms.ListView();
            this.imgScripts = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstScripts
            // 
            this.lstScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScripts.HideSelection = false;
            this.lstScripts.Location = new System.Drawing.Point(0, 0);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.Size = new System.Drawing.Size(636, 564);
            this.lstScripts.SmallImageList = this.imgScripts;
            this.lstScripts.TabIndex = 1;
            this.lstScripts.UseCompatibleStateImageBehavior = false;
            this.lstScripts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstScripts_ItemSelectionChanged);
            this.lstScripts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstScripts_MouseDoubleClick);
            // 
            // imgScripts
            // 
            this.imgScripts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgScripts.ImageSize = new System.Drawing.Size(16, 16);
            this.imgScripts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // usrTestScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstScripts);
            this.Name = "usrTestScripts";
            this.Size = new System.Drawing.Size(636, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstScripts;
        private System.Windows.Forms.ImageList imgScripts;
    }
}
