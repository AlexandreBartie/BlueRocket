using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    
    public delegate void Notify_PageTituloClick();
    
    public partial class usrMoldura : UserControl
    {

        public event Notify_PageTituloClick PageTituloClick;

        public usrMoldura()
        {
            InitializeComponent();
        }

        private void usrTitulo_TituloClick() => PageTituloClick?.Invoke();

        public void SetTitle(string prmText) => usrTitulo.SetTitle(prmText);

    }
}
