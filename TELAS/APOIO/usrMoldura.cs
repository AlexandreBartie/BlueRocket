using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrMoldura : UserControl
    {
        public usrMoldura()
        {
            InitializeComponent();
        }

        public void SetTitulo(string prmTexto) => usrTitulo.SetTitulo(prmTexto);

    }
}
