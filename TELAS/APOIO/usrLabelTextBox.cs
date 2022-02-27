using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rocket.Telas
{
    public partial class usrLabelTextBox : UserControl
    {

        public string label { get => lblTag.Text; set => lblTag.Text = value; }
        public string text { get => txtDescription.Text; set => txtDescription.Text = value; }

        public usrLabelTextBox()
        {
            InitializeComponent();
        }

        public void SetText(string prmLabel, string prmDescription)
        {

            label = prmLabel;
            text = prmDescription;

        }


    }
}
