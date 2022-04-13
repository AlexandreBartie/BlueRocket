using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlueRocket
{
    partial class frmAboutBox : Form
    {

        private EditorCLI Editor;
        private void cmdClose_Click(object sender, EventArgs e) => this.Close();

        public frmAboutBox()
        {
            InitializeComponent();

            this.Text = String.Format("About: {0}", Application.ProductName);

            lblVersion.Text = String.Format("Version: {0}", Application.ProductVersion);
        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            View();

            this.ShowDialog();

        }

        public void View()
        {

            //usrTagName.SetText(prmLabel: "Product:", prmDescription: AssemblyProduct);
            //usrTagVersion.SetText(prmLabel: "Version:", prmDescription: String.Format("Versão {0}", AssemblyVersion));
            //usrTagCompany.SetText(prmLabel: "Company:", prmDescription:  AssemblyCompany);

        }

    }
}
