﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrTitulo : UserControl
    {
        public usrTitulo()
        {
            InitializeComponent();
        }

        public void SetTitulo(string prmTexto) { cmdTitulo.Text = prmTexto; }

    }
}
