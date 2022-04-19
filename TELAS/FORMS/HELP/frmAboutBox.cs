using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlueRocket
{
    partial class frmAboutBox : Form
    {

        private AppCLI App;
        private void cmdClose_Click(object sender, EventArgs e) => this.Close();

        public frmAboutBox(AppCLI prmApp)
        {
            InitializeComponent(); App = prmApp;

            View();

            ShowDialog();
        }

        private void View()
        {
            Text = App.Info.productAbout;

            lblVersion.Text = App.Info.productVersion;
        }

    }
}
