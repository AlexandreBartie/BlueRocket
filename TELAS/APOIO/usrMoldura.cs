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
    
    public partial class usrMoldura : PageControl
    {

        public event Notify_PageTituloClick PageTituloClick;

        public usrMoldura()
        {
            InitializeComponent();
        }

        private void usrTitulo_TituloClick() => PageTituloClick?.Invoke();

        public void SetText(string prmText) => usrTitle.SetText(prmText);

    }
}
