using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class frmSplash : Form
    {
        private void alarme_Tick(object sender, EventArgs e) => Finished();
        private void frmSplash_Click(object sender, EventArgs e) => Finished();

        public frmSplash()
        {
            InitializeComponent(); Start();
        }

        private void Start()
        {
            alarme.Interval = 5000;

            alarme.Start();
        }

        private void Finished()
        {
            alarme.Stop();

            Close();
        }

    }
}
