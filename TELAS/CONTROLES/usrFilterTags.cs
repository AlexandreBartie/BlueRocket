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

            foreach (TagCLI Tag in Editor.Project.Tags)
                PopularOpcoes(Tag);

            Root.Expand();
        }

        private void PopularOpcoes(TagCLI prmTag)
        {

            TreeNode Folha = AddNode(prmItem: prmTag.name, Root, prmCor: prmTag.Cor.GetCodeColor(), prmChecked: false);

            foreach (OptionTagCLI Opcao in prmTag.Options)
                AddNode(Opcao.value, Folha, prmCor: Opcao.Cor.GetCodeColor(), prmChecked: true);

            Folha.Expand();
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
