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

        private bool IsNodeSelected => (trvProjeto.SelectedNode != null);

        private bool IsRootSelected => (IsNodeSelected && (trvProjeto.SelectedNode.Parent == null));

        private bool IsItemSelected => (IsNodeSelected && !IsRootSelected);

        public usrTesteProject()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Lista de Arquivos INI");

        }

        private void mnuRefresh_Click(object sender, EventArgs e) => Editor.OnProjectRefresh();

        private void trvProjeto_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (IsRootSelected)
                InverterTodos();

            else if (IsScriptSelected(prmKey: e.Node.Text))
                Editor.OnScriptChecked(prmHabilitar: e.Node.Checked);

        }

        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsRootSelected)
                Editor.OnRootSelected();

            else if (IsScriptSelected(prmKey: trvProjeto.SelectedNode.Text))
                Editor.OnScriptChanged();

        }
        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(trvProjeto);

            Refresh();

        }
        
        public new void Refresh()
        {

            Popular();

            StatusView();

        }
        
        private void Popular()
        {

            trvProjeto.Nodes.Clear();

            TreeNode Pai = AddNode(prmItem: "ini");

            foreach (TestScript Script in Editor.Scripts)
                AddNode(prmItem: Script.Log.name_INI, Pai);

            Pai.Expand();

        }

        public void View()
        {

            if (Editor.TemScript)
                trvProjeto.SelectedNode.ForeColor = Editor.GetForeColor();

            StatusView();

        }

        private void StatusView()
        {

            rodDBStatusOnLine.Visible = Editor.Console.IsDbOK;

            rodDBStatusOffLine.Visible = !Editor.Console.IsDbOK;

        }

        private bool IsScriptSelected(string prmKey)
        {

            if (IsItemSelected)

                if (Editor.SetScript(prmKey))
                    return true;

            return false;

        }

        private void InverterTodos()
        {

            //foreach (TreeNode item in trvProjeto.SelectedNode.Nodes)
                //item.Checked = !(item.Checked);

        }

        private TreeNode AddNode(string prmItem) => (trvProjeto.Nodes.Add(prmItem));
        private TreeNode AddNode(string prmItem, TreeNode prmPai) => (prmPai.Nodes.Add(prmItem));

    }
}
