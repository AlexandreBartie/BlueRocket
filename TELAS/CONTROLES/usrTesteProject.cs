using Dooggy.Factory.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DooggyCLI;

namespace DooggyCLI.Telas
{
    public partial class usrTesteProject : usrMoldura
    {

        private EditorScripts Editor;

        public usrTesteProject()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Lista de Arquivos INI");

        }
        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsRootSelected())
                Editor.OnRootINISelected();

            else if (IsScriptSelected())
                Editor.OnScriptSelected();

        }
        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(trvProjeto);

            Popular();

        }
        public void Popular()
        {

            TreeNode Pai = AddNode(prmItem: "ini");

            foreach (TestScript Script in Editor.Scripts)
                AddNode(prmItem: Script.Log.nome_INI, Pai);

            Pai.Expand();

        }

        public void Formatar()
        {

            trvProjeto.SelectedNode.ForeColor = Editor.GetForeColor();

        }

        private bool IsRootSelected() => (trvProjeto.SelectedNode.Parent == null);

        private bool IsScriptSelected()
        {

            if ((trvProjeto.SelectedNode != null) && (trvProjeto.SelectedNode.Parent != null))

                if (Editor.SetScript(prmKey: trvProjeto.SelectedNode.Text))
                    return true;

            return false;

        }

        private TreeNode AddNode(string prmItem) => (trvProjeto.Nodes.Add(prmItem));
        private TreeNode AddNode(string prmItem, TreeNode prmPai) => (prmPai.Nodes.Add(prmItem));

    }
}
