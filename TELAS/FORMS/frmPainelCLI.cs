using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class frmPainelCLI : Form
    {

        private PainelCLI Painel;

        public frmPainelCLI()
        {
            InitializeComponent();
        }

        public void Setup(PainelCLI prmPainel)
        {

            Painel = prmPainel;

            Painel.ProjectSelected += ProjectSelected;

            usrAction.Setup(prmPainel);

            this.ShowDialog();

        }

        private void ProjectSelected()
        {

            usrAction.Refresh();

            Painel.Editor.Show();

        }

    }
}
