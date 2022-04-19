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
        private AppCLI App;

        private void alarme_Tick(object sender, EventArgs e) => Finished();
        private void frmSplash_Click(object sender, EventArgs e) => Finished();

        public frmSplash(AppCLI prmApp)
        {
            InitializeComponent(); App = prmApp;

            View();  Start(); ShowDialog();
        }

        private void View()
        {
            lblFramework.Text = App.Info.productSplash;

            lblRelease.Text = App.Info.productRelease;

            lblYearRelease.Text = App.Info.productYearRelease;
        }

        private void Start()
        {
            alarme.Interval = 6000;

            alarme.Start();
        }

        private void Finished()
        {
            alarme.Stop();

            Close();
        }

     }
}
