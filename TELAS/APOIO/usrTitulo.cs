using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PainelTestes
{
    public partial class usrTitulo : UserControl
    {
        public usrTitulo()
        {
            InitializeComponent();
        }

        public void SetTitulo(string prmTexto) { this.cmdTitulo.Text = prmTexto; }

    }
}
