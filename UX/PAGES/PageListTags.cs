using Katty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.PAGES.ListTags
{
    internal class PageListTags
    {
        internal PageBuilder Page;

        internal PageListTags()
        {
            Page = new PageBuilder(new TreeView());
        }
        public void Setup(EditorCLI prmEditor) => Page.Setup(prmEditor);

        public void Build() => Page.Build();
    }

    internal class PageBuilder : PageControl
    {
        internal PageActions Actions;

        internal PageResources Resources;

        internal PageStructure Structure;

        internal PageBuilder(Control prmControl) : base(prmControl)
        {
            Actions = new PageActions(this);

            Resources = new PageResources(this);

            Structure = new PageStructure(this);
        }

        internal new void Setup(EditorCLI prmEditor)
        {
            base.Setup(prmEditor);

            Actions.Setup();

            Resources.Setup();

            Structure.Build();
        }

        internal void Build()
        {
            Structure.Build();
        }

    }
    internal class PageResources
    {
        private PageBuilder Builder;

        internal PageEvents Events;

        internal TreeView TreeView => (TreeView)Builder.GetControl();

        internal TreeNode Root;

        internal PageResources(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void Setup()
        {
            Events = new PageEvents(Builder);

            Builder.Editor.Format.SetPadrao(TreeView, prmCheckBoxes: true);
        }
        internal void Reset()
        {
            TreeView.Nodes.Clear(); Root = Builder.Structure.AddNode(prmItem: "Tags");
        }

    }
    internal class PageActions : PageBase
    {
        internal PageActions(PageBuilder prmBuilder) : base(prmBuilder) { }

        internal void Setup() { }

        internal void AfterCheck(TreeNode prmNode)
        {
            if (Editor.IsFree)
            {
                if (prmNode.Nodes.Count != 0)
                    Builder.Structure.InverterTodos(prmNode);
                else
                    Editor.OnFilterTagChecked(prmTag: prmNode.Parent.Text, prmOption: prmNode.Text, prmChecked: prmNode.Checked);
            }
        }

    }
    internal class PageEvents : PageBase
    {
        private PageActions Actions => Builder.Actions;

        internal PageEvents(PageBuilder prmBuilder) : base(prmBuilder)
        {
            TreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(AfterCheck);
        }
        private void AfterCheck(object sender, TreeViewEventArgs e)
        {
            Actions.AfterCheck(e.Node);
        }

    }
    internal class PageStructure : PageBase
        {
        private AppRegisterScript Bag => Editor.App.Register.Script;


        internal PageStructure(PageBuilder prmBuilder) : base(prmBuilder) { }

        internal void Build()
        {

            Resources.Reset();

            foreach (myTag Tag in Editor.Project.Tags)
                Popular(Tag);

            Root.Expand();

        }
        private void Popular(myTag prmTag)
        {

            TreeNode Folha = AddNode(prmItem: prmTag.name, Root, prmCor: Editor.Cor.Tag.GetCor(prmTag), prmChecked: false);

            foreach (myTagOption Option in prmTag)
                AddNode(Option.value, Folha, prmCor: Editor.Cor.Option.GetCor(Option), prmChecked: true);

            Folha.Expand();
        }
        internal void InverterTodos(TreeNode prmNode)
        {
            foreach (TreeNode item in prmNode.Nodes)
                item.Checked = !(item.Checked);
        }
        internal TreeNode AddNode(string prmItem) => TreeView.Nodes.Add(prmItem);

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

    internal class PageBase
    {

        internal AppCLI App => Builder.App;
        internal EditorCLI Editor => Builder.Editor;

        internal PageBuilder Builder;
        internal PageResources Resources => Builder.Resources;

        internal TreeView TreeView => Resources.TreeView;
        internal TreeNode Root => Resources.Root;

        internal PageBase(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }
    }
}
