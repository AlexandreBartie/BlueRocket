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
    public partial class usrTestScripts : UserControl
    {
        internal PageBuilder Builder; 

        private void lstScripts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Builder.SetFocus(prmScript: GetTag(e.Item));
        }

        private void lstScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                Builder.DoubleClick(prmScript: GetTag(item));
        }

        public bool IsMultiSelected => Builder.Resource.IsMultiSelected;

        public usrTestScripts()
        {
            InitializeComponent();

            Builder = new PageBuilder(prmPage: this, prmListView: lstScripts);
        }

        public void Setup(EditorCLI prmEditor) => Builder.Setup(prmEditor);

        public void Build() => Builder.Build();

        public void SetFocus(ScriptCLI prmScript) => Builder.SetFocus(prmScript);

        public void ViewAll(bool prmSetup) => Builder.ViewAll(prmSetup);
        public void ViewScript(ScriptCLI prmScript) => Builder.ViewScript(prmScript);

        public void ViewCurrent() { Builder.ViewCurrent(); }

        public bool FindScript(ScriptCLI prmScript)
        {
            foreach (ListViewItem item in Builder.Resource.Itens)
                if (prmScript.IsMatch(GetTag(item)))
                    { item.Focused = true; item.Selected = true; return true; }

            return false;
        }

        public void GetSelected()
        {
            foreach (ListViewItem item in Builder.Resource.Selecionados)
                Builder.Editor.Batch.Add(prmKey: GetTag(item));

            lstScripts.SelectedItems.Clear();
        }

        public void ViewSelections()
        {
            foreach (ScriptCLI Script in Builder.Editor.Batch.Select)
                Builder.ViewScript(Script);
        }

        private ListViewItem GetListItem(int prmMouseX, int prmMouseY)
        {
            ListViewHitTestInfo info = lstScripts.HitTest(prmMouseX, prmMouseY);
            ListViewItem item = info.Item;

            return (item);
        }

        private string GetTag(ListViewItem prmItem) => prmItem.Tag.ToString();

    }

    internal class PageBuilder
    {
        internal PageResource Resource;

        internal PageStructure Structure;

        internal PageElements Elements;

        internal EditorCLI Editor => Resource.Editor;

        internal PageBuilder(UserControl prmPage, Control prmListView)
        {
            Resource = new PageResource(this);

            Structure = new PageStructure(this);

            Elements = new PageElements(this);

            Resource.SetPage(prmPage, prmListView);
        }

        internal void Setup(EditorCLI prmEditor)
        {
            Resource.Setup(prmEditor);

            Structure.Setup();

            ViewAll(prmSetup: true);
        }

        internal void Reset()
        {           
            Structure.Build();
        }
        
        internal void Build()
        {
            Reset(); ViewAll(prmSetup: true);
        }

        internal void ViewAll(bool prmSetup)
        {
            Elements.ViewAll(prmSetup);
        }

        internal void ViewCurrent()
        {
            Elements.ViewScript(Editor.Script); //Resource.SetFocus();
        }
        internal void ViewScript(ScriptCLI prmScript)
        {
            Elements.ViewScript(prmScript); 
        }

        internal void DoubleClick(string prmScript)
        {
            SetFocus(prmScript);

            if (Editor.Script.IsLocked)
                Editor.OnScriptCodeLocked();

            if (Editor.Script.ICanPlay)
            { Editor.OnScriptCodePlay(); ViewCurrent(); }
        }

        internal void SetFocus(string prmScript) => SetFocus(Editor.Project.GetScript(prmScript));
        internal void SetFocus(ScriptCLI prmScript)
        {
            Editor.SetScript(prmScript);

            Editor.OnScriptCodeSelect();
        }
    }
    internal class PageStructure : PageBase
    {

        private PageResource Resource => Builder.Resource;
        private PageElements Elements => Builder.Elements;

        internal PageStructure(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void Setup()
        {
            Editor.Format.SetPadrao(ListView);

            Build();
        }
        internal void Build()
        {
            CabecalhoScripts();
        }

        private void CabecalhoScripts()
        {

            ListView.Columns.Clear();

            ListView.Columns.Add("", 20, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("#", 40, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Script", 400);
            ListView.Columns.Add("Tests", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Max", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Avg", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Sum", 80, textAlign: HorizontalAlignment.Center);

            Resource.qtde_colunas = ListView.Columns.Count;

            CabecalhoTags();

        }

        private void CabecalhoTags()
        {
            if (Editor.HasProject)
            {
                foreach (myTag Tag in Editor.Project.Tags)
                    ListView.Columns.Add(Tag.name, -2, textAlign: HorizontalAlignment.Center);
            }
        }

    }
    internal class PageElements : PageBase
    {

        internal PageElements(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void ViewAll(bool prmSetup) 
        {
            if (prmSetup)
                ListView.Items.Clear();

            if (Editor.HasAtivos)
                ViewScripts(prmSetup);
        }

        private void ViewScripts(bool prmSetup)
        {

            ListViewItem linha; int cont = 0;

            foreach (ScriptCLI Script in Editor.Project.Scripts.Ativos)
            {

                if (prmSetup)
                {

                    linha = ListView.Items.Add("");

                    for (int x = 1; x < qtde_colunas; x++)
                        linha.SubItems.Add("");
                }

                linha = ListView.Items[cont];
                
                ViewScript(linha, Script);

                ViewTAGS(Script, linha, prmSetup);

                cont++;

            }

        }
        internal void ViewScript(ScriptCLI prmScript) => ViewScript(prmLinha: FindScript(prmScript), prmScript);
        internal void ViewScript(ListViewItem prmLinha, ScriptCLI prmScript)
        {
            if (prmLinha == null) return;

            string index; bool IsTimeColumn;

            index = myFormat.GetKey(prmLinha.Index + 1, 3);

            prmLinha.Tag = prmScript.name;

            prmLinha.ToolTipText = prmScript.status;

            prmLinha.SubItems[1].Text = index;
            prmLinha.SubItems[2].Text = prmScript.name;
            prmLinha.SubItems[3].Text = prmScript.qtdTests;
            prmLinha.SubItems[4].Text = prmScript.timeBigger;
            prmLinha.SubItems[5].Text = prmScript.timeAverage;
            prmLinha.SubItems[6].Text = prmScript.timeSeconds;

            prmLinha.UseItemStyleForSubItems = false;

            for (int x = 1; x < qtde_colunas; x++)
            {
                IsTimeColumn = (x >= qtde_colunas-3);  // Time: Bigger + Average + Seconds

                prmLinha.SubItems[x].ForeColor = prmScript.Cor.GetCorFrente(IsTimeColumn);
                prmLinha.SubItems[x].BackColor = prmScript.Cor.GetCorFundo();
            }

            ViewIcon(prmScript, prmLinha);

        }

        private void ViewIcon(ScriptCLI prmScript, ListViewItem prmLinha) => prmLinha.ImageIndex = (int) prmScript.Status.id;
        private void ViewTAGS(ScriptCLI prmScript, ListViewItem prmLinha, bool prmSetup)
        {

            ListViewItem.ListViewSubItem celula; int cont = qtde_colunas;

            foreach (myTag Tag in prmScript.Tags)
            {
                if (prmSetup)
                    prmLinha.SubItems.Add("");

                celula = prmLinha.SubItems[cont];

                celula.Text = Tag.value;

                celula.ForeColor = Editor.Cor.Tag.GetCorFrente(Tag);
                celula.BackColor = Editor.Cor.Tag.GetCorFundo(Tag);

                cont++;

            }

        }

        private ListViewItem FindScript(ScriptCLI prmScript)
        {
            foreach (ListViewItem item in ListView.Items)
                if (prmScript.IsMatch(item.Tag.ToString()))
                    return item;

            return null;
        }
        private ScriptCLI FindScript(ListViewItem prmItem)
        {
            return Editor.Project.GetScript(prmName: prmItem.Tag.ToString());
        }

    }

    internal class PageBase
    {
        internal PageBuilder Builder;

        internal EditorCLI Editor => Resource.Editor;
        internal ListView ListView => Resource.ListView;
        internal int qtde_colunas => Resource.qtde_colunas;

        private PageResource Resource => Builder.Resource;

    }
    internal class PageResource
    {
        private PageBuilder Builder;

        internal EditorCLI Editor;

        internal usrTestScripts Page;

        internal ListView ListView;

        internal bool IsMultiSelected => (ListView.SelectedItems.Count > 1);

        internal ListView.ListViewItemCollection Itens => ListView.Items;
        internal ListView.SelectedListViewItemCollection Selecionados => ListView.SelectedItems;


        internal int qtde_colunas;

        internal PageResource(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void SetFocus()
        {
            ListView.Refresh();
        }
        
        internal void SetPage(UserControl prmPage, Control prmListView)
        {
            Page = (usrTestScripts)prmPage;

            ListView = (ListView)prmListView;

        }

        internal void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            ListView.SmallImageList = GetViewImages(new ImageList());
        }

        private ImageList GetViewImages(ImageList prmListImage)
        {
            prmListImage.Images.Add(Properties.Resources.locked);
            prmListImage.Images.Add(Properties.Resources.edit);
            prmListImage.Images.Add(Properties.Resources.save);
            prmListImage.Images.Add(Properties.Resources.play);
            prmListImage.Images.Add(Properties.Resources.waiting);
            prmListImage.Images.Add(Properties.Resources.confirm);
            prmListImage.Images.Add(Properties.Resources.cancel);

            return prmListImage;

        }

    }

}