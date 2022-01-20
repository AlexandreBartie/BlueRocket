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
    public partial class usrTestProject : usrMoldura
    {

        private EditorCLI Editor;

        private TreeNode Root;

        private bool IsNodeSelected => (trvProjeto.SelectedNode != null);
        private bool IsRootSelected => (IsNodeSelected && (trvProjeto.SelectedNode.Parent == null));
        private bool IsItemSelected => (IsNodeSelected && !IsRootSelected);

        public usrTestProject()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Lista de Arquivos INI");

        }

        private void mnuRefresh_Click(object sender, EventArgs e) => Editor.OnProjectRefresh();

        private void trvProjeto_DoubleClick(object sender, EventArgs e)
        {
            if (IsItemSelected)
                Editor.OnScriptLocked();
        }

        private void trvProjeto_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (IsRootSelected)
                InverterTodos();

        }

        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (IsScriptSelected(prmKey: trvProjeto.SelectedNode.Text))
                Editor.OnScriptChanged();

        }
        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetPadrao(trvProjeto);

            usrAction.Setup(Editor.Painel);

            Refresh();

        }
    
        public new void Refresh()
        {

            Popular();

            usrAction.Refresh();

        }
        
        private void Popular()
        {

            trvProjeto.Nodes.Clear();

            Root = AddNode(prmItem: "ini");

            foreach (TestScript Script in Editor.Scripts)
                AddNode(prmItem: Script.Result.name_INI, Root);

            Root.Expand();

        }

        public void View()
        {

            if (Editor.TemScript)
                trvProjeto.SelectedNode.ForeColor = Editor.GetColorLog();

            usrAction.Refresh();

        }

        public void MultiSelection()
        { 
            trvProjeto.CheckBoxes = Editor.IsMultiSelection; 
            
            Root.Expand();

            usrAction.Refresh();

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
