using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PainelTestes.TELAS.CONTROLES
{
    public partial class usrResultadoTeste : usrMoldura
    {

        private TestPainelScript Painel;

        public usrResultadoTeste()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Resultado Gerado");

        }

        public void Setup(TestPainelScript prmPainel)
        {

            Painel = prmPainel;

            Painel.SetPadrao(txtMassaDados);
            Painel.SetPadrao(txtLogExecucao);

        }

        public void Exibir()
        {

            txtMassaDados.Text = Painel.Console.Log.resultado;

            txtLogExecucao.Text = Painel.Console.Log.txt;

        }

    }
}
