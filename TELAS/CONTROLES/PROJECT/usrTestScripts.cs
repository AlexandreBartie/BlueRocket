using Dooggy;
using Katty;
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
       
        internal PageActions Actions => Builder.Actions;

        private void lstScripts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Actions.SetFocus(prmScript: Actions.GetTag(e.Item));
        }

        private void lstScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = Actions.GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                Actions.DoubleClick(prmScript: Actions.GetTag(item));
        }

        public bool IsMultiSelected => Actions.Resource.IsMultiSelected;

        public usrTestScripts()
        {
            InitializeComponent();

            Builder = new PageBuilder(prmPage: this, prmListView: lstScripts);

        }

        public void Setup(EditorCLI prmEditor)
        {
            Builder.Setup(prmEditor);

            Builder.App.Events.ViewScriptChanged += Actions.ViewScriptChanged;
        }

        public void Build() => Builder.Build();

        public void ViewAll(bool prmSetup) => Builder.ViewAll(prmSetup);
        public void ViewScript(ScriptCLI prmScript) => Builder.ViewScript(prmScript);

        public void ViewCurrent() => Builder.ViewCurrent();

        public void SetFocus(ScriptCLI prmScript) => Actions.SetFocus(prmScript);

        public bool FindScript(ScriptCLI prmScript) => Actions.FindScript(prmScript);

        public void GetSelected() => Actions.GetSelected();

        public void ViewSelections() => Actions.ViewSelections();

    }

    internal class PageBuilder
    {
        internal EditorCLI Editor;
       
        internal PageResource Resource;

        internal PageStructure Structure;

        internal PageElements Elements;

        internal PageActions Actions;

        internal AppCLI App => Editor.App;

        internal PageBuilder(UserControl prmPage, Control prmListView)
        {
            Resource = new PageResource(this);

            Structure = new PageStructure(this);

            Elements = new PageElements(this);

            Actions = new PageActions(this);

            Resource.SetPage(prmPage, prmListView);
        }

        internal void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Resource.Setup();

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
            Elements.ViewScript(Editor.Script);
        }
        internal void ViewScript(ScriptCLI prmScript)
        {
            Elements.ViewScript(prmScript); 
        }

    }

    internal class PageActions : PageBase
    { 
        internal PageActions(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void DoubleClick(string prmScript)
        {
            SetFocus(prmScript);

            if (Editor.Script.IsLocked)
                Editor.OnScriptCodeLocked();

            if (Editor.Script.ICanPlay)
            { Editor.OnScriptCodePlay(); Builder.ViewCurrent(); }
        }

        internal void SetFocus(string prmScript) => SetFocus(Editor.Project.GetScript(prmScript));
        internal void SetFocus(ScriptCLI prmScript)
        {
            Editor.SetScript(prmScript);

            Editor.OnScriptCodeSelect();
        }

        internal bool FindScript(ScriptCLI prmScript)
        {
            foreach (ListViewItem item in Builder.Resource.Itens)
                if (prmScript.IsMatch(GetTag(item)))
                { item.Focused = true; item.Selected = true; return true; }

            return false;
        }

        internal void GetSelected()
        {
            foreach (ListViewItem item in Builder.Resource.Selecionados)
                Builder.Editor.Batch.Add(prmKey: GetTag(item));

            Resource.ListView.SelectedItems.Clear();
        }

        internal void ViewScriptChanged()
        {
            Builder.Structure.ChangeSkin();
        }

        internal void ViewSelections()
        {
            foreach (ScriptCLI Script in Builder.Editor.Batch.Select)
                Builder.ViewScript(Script);
        }
        internal ListViewItem GetListItem(int prmMouseX, int prmMouseY)
        {
            ListViewHitTestInfo info = Resource.ListView.HitTest(prmMouseX, prmMouseY);
            ListViewItem item = info.Item;

            return (item);
        }

        internal string GetTag(ListViewItem prmItem) => prmItem.Tag.ToString();

    }
    internal class PageStructure : PageBase
    {
        private AppRegisterScript Bag => Builder.Editor.App.Register.Script;

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
            HeaderScripts(); ChangeSkin();
        }

        private void HeaderScripts()
        {

            ListView.Columns.Clear();

            ListView.Columns.Add("", 20, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("#", 40, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Script", -2);
            ListView.Columns.Add("Tests", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Max", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Avg", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Sum", 80, textAlign: HorizontalAlignment.Center);

            Resource.qtde_colunas = ListView.Columns.Count;

            HeaderTags();

        }

        private void HeaderTags()
        {
            if (Editor.HasProject)
            {
                foreach (myTag Tag in Editor.Project.Tags)
                    ListView.Columns.Add(Tag.name, -2, textAlign: HorizontalAlignment.Center);
            }
        }

        internal void ChangeSkin()
        {
            for (int index = 3; index < ListView.Columns.Count; index++)
            {
                if (index == 3)
                    HeaderVisible(prmIndex: index, prmVisible: Bag.DataCount.IsChecked);
                else if (myInt.IsIntervalo(index, 4, 6))
                    HeaderVisible(prmIndex: index, prmVisible: Bag.TimeAnalisys.IsChecked);
                else
                    HeaderVisible(prmIndex: index, prmVisible: Bag.AssociatedTags.IsChecked);
            }
        }

        private void HeaderVisible(int prmIndex, bool prmVisible)
        {
            ColumnHeader col = ListView.Columns[prmIndex];

            if (prmVisible)
            {
                if (col.Width == 0)
                    col.Width = -2;
            }
            else if (myInt.IsNoZero(col.Width))
                    col.Width = 0;
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
        internal AppCLI App => Builder.App;
        internal EditorCLI Editor => Builder.Editor;

        internal ListView ListView => Resource.ListView;
        internal int qtde_colunas => Resource.qtde_colunas;

        internal PageResource Resource => Builder.Resource;

    }
    internal class PageResource
    {
        private PageBuilder Builder;

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

        internal void Setup()
        {
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