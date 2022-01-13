using PainelTestes;
using Dooggy;
using Dooggy.Factory.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MassaTestes
{
    public partial class frmTestScriptPainel : Form
    {

        private TestPainelScript Painel;

        public frmTestScriptPainel()
        {
            InitializeComponent();
        }

        public void Setup(TestPainelScript prmPainel)
        {

            Painel = prmPainel;

            Painel.ScriptSelecionado += ScriptSelecionado;

            this.ShowDialog();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e)
        {

            IniciarSetup();

        }

        private void IniciarSetup()
        {

            usrProjetoTeste.Setup(Painel);

            usrScriptTeste.Setup(Painel);

            usrResultadoTeste.Setup(Painel);

        }

        private void ScriptSelecionado()
        {

            usrScriptTeste.Exibir();

            usrResultadoTeste.Exibir();


        }

    }

}
