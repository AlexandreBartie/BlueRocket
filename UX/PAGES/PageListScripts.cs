using BlueRocket.PAGES.TestCode;
using BlueRocket.PAGES.TestData;
using Katty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.PAGES.ListScripts
{
    internal class PageListScripts : PageBuilder
    {

        //internal PageViewCode pagTestCode;
        //internal PageViewData pagTestData;

        internal PageListScripts(UserControl prmPage, Control prmListView) : base(prmPage, prmListView)
        {
            //pagTestCode = new  PageViewCode();
            //pagTestData = new  PageViewData();
        }
    }

    internal class PageBuilder : PageControl
    {

        internal PageResources Resources;

        internal PageActions Actions;

        internal PageStructure Structure;

        internal PageElements Elements;

        internal PageBuilder(UserControl prmPage, Control prmListView)
        {
            Resources = new PageResources(this);

            Structure = new PageStructure(this);

            Elements = new PageElements(this);

            Actions = new PageActions(this);

            Resources.SetPage(prmPage, prmListView);
        }

        internal new void Setup(EditorCLI prmEditor)
        {

            base.Setup(prmEditor);

            Actions.Setup();

            Resources.Setup();

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
    internal class PageResources
    {
        private PageBuilder Builder;

        internal usrListScripts Page;

        internal ListView ListView;

        internal bool IsMultiSelected => (ListView.SelectedItems.Count > 1);

        internal ListView.ListViewItemCollection Itens => ListView.Items;
        internal ListView.SelectedListViewItemCollection Selecionados => ListView.SelectedItems;


        internal int qtde_colunas;

        internal PageResources(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void SetFocus()
        {
            ListView.Refresh();
        }

        internal void SetPage(UserControl prmPage, Control prmListView)
        {
            Page = (usrListScripts)prmPage;

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
    internal class PageActions : PageBase
    {
        internal PageActions(PageBuilder prmBuilder) : base(prmBuilder) { }

        internal void Setup()
        {
            App.Events.ViewScriptChanged += ViewScriptChanged;
        }

        internal void DoubleClick(int prmMouseX, int prmMouseY)
        {
            ListViewItem item = GetListItem(prmMouseX, prmMouseY);

            if (item != null)
                SelectScript(prmScript: GetTag(item));
        }

        private void SelectScript(string prmScript)
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
            foreach (ListViewItem item in Resources.Itens)
                if (prmScript.IsMatch(GetTag(item)))
                { item.Focused = true; item.Selected = true; return true; }

            return false;
        }

        internal void GetSelected()
        {
            foreach (ListViewItem item in Resources.Selecionados)
                Editor.Batch.Add(prmKey: GetTag(item));

            Resources.ListView.SelectedItems.Clear();
        }

        private void ViewScriptChanged()
        {
            Builder.Structure.ChangeSkin();
        }

        internal void ViewSelections()
        {
            foreach (ScriptCLI Script in Editor.Batch.Select)
                Builder.ViewScript(Script);
        }
        internal string GetTag(ListViewItem prmItem) => prmItem.Tag.ToString();

        private ListViewItem GetListItem(int prmMouseX, int prmMouseY)
        {
            ListViewHitTestInfo info = Resources.ListView.HitTest(prmMouseX, prmMouseY);
            ListViewItem item = info.Item;

            return (item);
        }

    }
    internal class PageStructure : PageBase
    {
        private AppRegisterScript Bag => Editor.App.Register.Script;

        internal PageStructure(PageBuilder prmBuilder) : base(prmBuilder) { }

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

            Resources.qtde_colunas = ListView.Columns.Count;

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
        internal PageElements(PageBuilder prmBuilder) : base(prmBuilder) { }

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
                IsTimeColumn = (x >= qtde_colunas - 3);  // Time: Bigger + Average + Seconds

                prmLinha.SubItems[x].ForeColor = prmScript.Cor.GetCorFrente(IsTimeColumn);
                prmLinha.SubItems[x].BackColor = prmScript.Cor.GetCorFundo();
            }

            ViewIcon(prmScript, prmLinha);

        }

        private void ViewIcon(ScriptCLI prmScript, ListViewItem prmLinha) => prmLinha.ImageIndex = (int)prmScript.Status.id;
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

        internal AppCLI App => Builder.App;
        internal EditorCLI Editor => Builder.Editor;

        internal PageBuilder Builder;
        internal PageResources Resources => Builder.Resources;

        internal ListView ListView => Resources.ListView;
        internal int qtde_colunas => Resources.qtde_colunas;

        internal PageBase(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }
    }
}
