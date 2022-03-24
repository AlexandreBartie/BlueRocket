using Dooggy.LIBRARY;
using System;
using System.Windows.Forms;

namespace BlueRocket
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

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            if (Editor.IsFree)
                Editor.OnProjectReset();
        }

        private void trvProjeto_DoubleClick(object sender, EventArgs e)
        {
            if (Editor.IsFree)
            {
                if (IsItemSelected)
                    DoubleClickScript();
            }
        }
        private void trvProjeto_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsScriptSelected(prmKey: trvProjeto.SelectedNode.Text))
                Editor.OnScriptCodeSelect();
        }
        private void trvProjeto_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (Editor.IsFree)
            {
                if (e.Node.Nodes.Count != 0)
                    InverterTodos(e.Node);
                else
                    Editor.OnScriptCodeChecked(prmScript: e.Node.Text, prmChecked: e.Node.Checked);
            }
        }

        private void trvFiltro_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (Editor.IsFree)
            {
                if (e.Node.Nodes.Count != 0)
                    InverterTodos(e.Node);
                else
                    Editor.OnFilterTagChecked(prmTag: e.Node.Parent.Text,  prmOption: e.Node.Text, prmChecked: e.Node.Checked);
            }
        }
        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(txtStatus, prmEditavel: false);

            Editor.Format.SetPadrao(trvProjeto);
            Editor.Format.SetPadrao(trvFiltro, prmCheckBoxes: true);

            usrAction.Setup(prmEditor);

            View();
        }
    
        public new void Refresh()
        {
            SetTitulo(prmTexto: GetProjectTitle());

            Popular();

            usrAction.View();
        }
        
        private void Popular()
        {
            PopularINI();

            PopularFiltro();
        }

        private void PopularINI()
        {
            trvProjeto.Nodes.Clear();

            Root = AddProjectNode(prmItem: "ini");

            foreach (ScriptCLI Script in Editor.Project.Scripts)
                AddNode(prmItem: Script.Result.name_INI, Root, prmCor: Script.Cor.GetCodeColor(), prmChecked: false);

            Root.Expand();
        }

        private void PopularFiltro()
        {
            trvFiltro.Nodes.Clear();

            Root = AddFilterNode(prmItem: "Tags");

            foreach (TagCLI Tag in Editor.Project.Tags)
                PopularFiltroOpcoes(prmTag: Tag);

            Root.Expand();
        }

        private void PopularFiltroOpcoes(TagCLI prmTag)
        {

            TreeNode Folha = AddNode(prmItem: prmTag.name, Root, prmCor: prmTag.Cor.GetCodeColor(), prmChecked: false);

            foreach (OptionTagCLI opcao in prmTag.Options)
                AddNode(opcao.value, Folha, prmCor: opcao.Cor.GetCodeColor(), prmChecked: true);

            Folha.Expand();
        }
        public void StatusFilter()
        {
            txtStatus.Text = Editor.Filter.Ativos.log;
        }
        public void View()
        {
            if (Editor.TemScript)
                SetNodeColor(prmNode: trvProjeto.SelectedNode, prmCor: Editor.Script.Cor.GetCodeColor());

            usrAction.View();
        }

        private void DoubleClickScript()
        {
            if (Editor.Script.IsLocked)
                Editor.OnScriptCodeLocked(); 

            if (Editor.Script.ICanPlay)
                Editor.OnScriptCodePlay();
        }
        public void MultiSelect(bool prmAtivar)
        { 
            trvProjeto.CheckBoxes = Editor.Select.SetMultiSelection(prmAtivar);

            Root.Expand();

            usrAction.Refresh();
        }

        public bool FindNodeScript(ScriptCLI prmScript)
        {
            foreach (TreeNode item in Root.Nodes)
                if (prmScript.IsMatch(item.Text))
                    { trvProjeto.SelectedNode = item; return true; }

            return false;
        }
        public void UncheckedNodeScript(ScriptCLI prmScript)
        {
            foreach (TreeNode item in Root.Nodes)
                if (prmScript.IsMatch(item.Text))
                    { item.Checked = false; break; }
        }
        private bool IsScriptSelected(string prmKey)
        {
            if (IsItemSelected)
                if (Editor.SetScript(prmKey))
                    return true;

            return false;
        }

        private void InverterTodos(TreeNode prmNode)
        {
            foreach (TreeNode item in prmNode.Nodes)
                item.Checked = !(item.Checked);
        }
        private TreeNode AddProjectNode(string prmItem) => trvProjeto.Nodes.Add(prmItem);
        private TreeNode AddFilterNode(string prmItem) => trvFiltro.Nodes.Add(prmItem);

        private TreeNode AddNode(string prmItem, TreeNode prmPai, myColor prmCor, bool prmChecked)
        {

            TreeNode node = prmPai.Nodes.Add(prmItem);

            if (node.TreeView.CheckBoxes)
                node.Checked = false; // prmChecked;

            return SetNodeColor(node, prmCor);
        }
        private TreeNode SetNodeColor(TreeNode prmNode, myColor prmCor)
        {
            prmNode.ForeColor = prmCor.frente;
            prmNode.BackColor = prmCor.fundo;

            return prmNode;
        }

        private string GetProjectTitle()
        {
            if (Editor.Project.IsLoad)
                return Editor.Project.nome;

            return "Selecionar Projeto (*.cfg)";
        }
        public void SetAction(string prmTexto) => usrAction.SetAction(prmTexto);

    }
}
