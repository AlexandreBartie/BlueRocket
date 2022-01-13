using Dooggy.Factory.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PainelTestes.TELAS.CONTROLES
{
    public partial class usrProjetoTeste : usrMoldura
    {

        private TestPainelScript Painel;

        private TestConsole Console => Painel.Console;

        public usrProjetoTeste()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Lista de Arquivos INI");

        }
        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsExibirScript())
                Painel.OnScriptSelecionado();

        }
        public void Setup(TestPainelScript prmPainel)
        {

            Painel = prmPainel;

            Painel.SetPadrao(trvProjeto);

            Popular();

        }

        public void Popular()
        {

            TreeNode Pai = AddNode(prmItem: "ini");

            foreach (TestConsoleScript file in Console.GetScripts())
                AddNode(prmItem: file.Log.nome_INI, Pai);

            Pai.Expand();

        }

        private bool IsExibirScript()
        {

            if ((trvProjeto.SelectedNode != null) && (trvProjeto.SelectedNode.Parent != null))

                if (Console.SetScript(prmKey: trvProjeto.SelectedNode.Text))
                    return true;

            return false;

        }

        private TreeNode AddNode(string prmItem) => (trvProjeto.Nodes.Add(prmItem));
        private TreeNode AddNode(string prmItem, TreeNode prmPai) => (prmPai.Nodes.Add(prmItem));

    }
}
