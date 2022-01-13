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
    public partial class frmTestDataFactoryConsole : Form
    {

        public TestConsole Console;

        private TestConsoleScript Script => Console.Script;

        public frmTestDataFactoryConsole()
        {
            InitializeComponent();
        }

        public void Iniciar(TestConsole prmConsole)
        {

            Console = prmConsole;

            this.ShowDialog();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e)
        {

            CarregarDados();

        }

        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {

            ExibirScript();
                
        }

        private void CarregarDados()
        {

            CarregarListaScripts();

            ExibirScript();

        }

        private void CarregarListaScripts()
        {

            TreeNode Pai = AddNode(prmItem: "ini");

            foreach (TestConsoleScript file in Console.GetScripts())
                AddNode(prmItem: file.Log.nome_INI, Pai);

            Pai.Expand();

        }

        private void ExibirScript()
        {

            if ((trvProjeto.SelectedNode != null) && (trvProjeto.SelectedNode.Parent != null))

                if (Console.SetScript(prmKey: trvProjeto.SelectedNode.Text))
                    MostrarDadosScript();

        }

        private void MostrarDadosScript()
        {

            //txtCode.Text = Console.Log.code;
            //txtResultado.Text = Console.Log.resultado;

        }
        
        private TreeNode AddNode(string prmItem) => (trvProjeto.Nodes.Add(prmItem));
        private TreeNode AddNode(string prmItem, TreeNode prmPai) => (prmPai.Nodes.Add(prmItem));
    }

}
