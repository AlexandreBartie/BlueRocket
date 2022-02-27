using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rocket.Telas
{
    public partial class usrWaiting : UserControl
    {
        public usrWaiting()
        {
            InitializeComponent();
        }

        public void TurnON() //UserControl prmControl)
        {

            this.Visible = true;

            this.BringToFront();

        }

        public void TurnOFF()
        {
            this.Visible = false;

            this.SendToBack();

        }

        private void Posicionar(UserControl prmControl)
        {

            this.Left = prmControl.Top;

            this.Size = prmControl.Size;

        }

    }
}
