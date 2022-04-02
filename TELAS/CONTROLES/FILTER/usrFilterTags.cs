using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrFilterTags : usrMoldura
    {
        private EditorCLI Editor;

        private TreeNode Root;

        private void trvTags_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (Editor.IsFree)
            {
                if (e.Node.Nodes.Count != 0)
                    InverterTodos(e.Node);
                else
                    Editor.OnFilterTagChecked(prmTag: e.Node.Parent.Text, prmOption: e.Node.Text, prmChecked: e.Node.Checked);
            }
        }

        public usrFilterTags()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Filtragem por TAGS");
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(trvTags, prmCheckBoxes: true);
        }

        public new void Refresh()
        {
            trvTags.Nodes.Clear();

            Root = AddNode(prmItem: "Tags");

            foreach (DataTag Tag in Editor.Project.Tags)
                PopularOpcoes(Tag);

            Root.Expand();
        }

        private void PopularOpcoes(DataTag prmTag)
        {

            TreeNode Folha = AddNode(prmItem: prmTag.name, Root, prmCor: Editor.Format.Cor.GetPadrao(), prmChecked: false);

            foreach (OptionTag Opcao in prmTag)
                AddNode(Opcao.value, Folha, prmCor: Editor.Format.Cor.GetPadrao(), prmChecked: true);

            Folha.Expand();
        }

        private void InverterTodos(TreeNode prmNode)
        {
            foreach (TreeNode item in prmNode.Nodes)
                item.Checked = !(item.Checked);
        }
        private TreeNode AddNode(string prmItem) => trvTags.Nodes.Add(prmItem);

        private TreeNode AddNode(string prmItem, TreeNode prmPai, myColor prmCor, bool prmChecked)
        {

            TreeNode node = prmPai.Nodes.Add(prmItem);

            if (node.TreeView.CheckBoxes)
                node.Checked = prmChecked;

            return SetNodeColor(node, prmCor);
        }
        private TreeNode SetNodeColor(TreeNode prmNode, myColor prmCor)
        {
            prmNode.ForeColor = prmCor.frente;
            prmNode.BackColor = prmCor.fundo;

            return prmNode;
        }

    }
}
