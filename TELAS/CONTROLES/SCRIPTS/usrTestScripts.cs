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
        private PageBuilder Builder;

        public usrTestScripts()
        {
            InitializeComponent();

            Builder = new PageBuilder(prmPage: this, prmListView: lstScripts);

        }
        private void lstScripts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Builder.SetFocus(prmScript: e.Item.Tag.ToString());
        }

        private void lstScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewHitTestInfo info = lstScripts.HitTest(e.X, e.Y);
            ListViewItem item = GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                Builder.DoubleClick(prmScript: item.Tag.ToString());
        }

        public void Setup(EditorCLI prmEditor) => Builder.Setup(prmEditor);

        public void Build() => Builder.Build();

        public void ViewAll(bool prmCleanup) => Builder.ViewAll(prmCleanup);

        private ListViewItem GetListItem(int prmMouseX, int prmMouseY)
        {

            ListViewHitTestInfo info = lstScripts.HitTest(prmMouseX, prmMouseY);
            ListViewItem item = info.Item;

            return (item);
        }

    }

    internal class PageBuilder
    {
        internal PageResource Resource;

        internal PageStructure Structure;

        internal PageElements Elements;

        private EditorCLI Editor => Resource.Editor;

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

            Elements.ViewAll(prmCleanup: true);
        }

        internal void Reset()
        {           
            Structure.Build();
        }
        
        internal void Build()
        {
            Reset(); ViewAll(prmCleanup: true);
        }
        internal void ViewAll(bool prmCleanup)
        {
            Elements.ViewAll(prmCleanup);
        }
        internal void DoubleClick(string prmScript)
        {
            SetFocus(prmScript);

            if (Editor.Script.IsLocked)
                Editor.OnScriptCodeLocked();

            if (Editor.Script.ICanPlay)
            { Editor.OnScriptCodePlay(); Elements.View(prmScript: Editor.Script); }
        }

        internal void SetFocus(string prmScript)
        {
            Editor.SetScript(prmName: prmScript);

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

            ListView.Columns.Add("", 40, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Script", 400);
            ListView.Columns.Add("Status", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Filtro", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Testes", 80, textAlign: HorizontalAlignment.Center);
            ListView.Columns.Add("Maior", 80, textAlign: HorizontalAlignment.Right);
            ListView.Columns.Add("Média", 80, textAlign: HorizontalAlignment.Right);
            ListView.Columns.Add("Total", 80, textAlign: HorizontalAlignment.Right);

            Resource.qtde_colunas = ListView.Columns.Count;

            CabecalhoTags();

        }

        private void CabecalhoTags()
        {
            if (Editor.TemProject)
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

        internal void View(ScriptCLI prmScript)
        {
            ListViewItem linha = GetListItem();
            
            if (linha != null)
                ViewScript(prmLinha: GetListItem(), prmScript);
        }
        internal void ViewAll(bool prmCleanup) 
        {
            if (prmCleanup)
                ListView.Items.Clear();

            if (Editor.TemAtivos)
                ViewScripts(prmCleanup);
        }

        private void ViewScripts(bool prmCleanup)
        {

            ListViewItem linha; int cont = 0; string index;

            foreach (ScriptCLI Script in Editor.Project.Scripts.Ativos)
            {

                cont++;

                if (prmCleanup)
                {

                    index = myFormat.GetKey(cont, 3);

                    linha = ListView.Items.Add(index);

                    for (int x = 1; x < qtde_colunas; x++)
                        linha.SubItems.Add("");
                }

                linha = ViewScript(prmIndice: cont, Script);

                ViewTAGS(Script, linha, prmCleanup);

            }

        }

        internal ListViewItem ViewScript(int prmIndice, ScriptCLI prmScript) => ViewScript(ListView.Items[prmIndice-1], prmScript);
        internal ListViewItem ViewScript(ListViewItem prmLinha, ScriptCLI prmScript)
        {
        
            prmLinha.Tag = prmScript.name;

            prmLinha.SubItems[1].Text = prmScript.name;
            prmLinha.SubItems[2].Text = prmScript.status;
            prmLinha.SubItems[3].Text = prmScript.filtro;
            prmLinha.SubItems[4].Text = prmScript.qtdTests;
            prmLinha.SubItems[5].Text = prmScript.timeBigger;
            prmLinha.SubItems[6].Text = prmScript.timeAverage;
            prmLinha.SubItems[7].Text = prmScript.timeSeconds;

            prmLinha.UseItemStyleForSubItems = false;

            for (int x = 1; x < qtde_colunas; x++)
            {
                if (x < 5)
                    prmLinha.SubItems[x].ForeColor = prmScript.Cor.GetCorFrente();
                else
                    prmLinha.SubItems[x].ForeColor = prmScript.Cor.GetCorSlowSQL();

                prmLinha.SubItems[x].BackColor = prmScript.Cor.GetCorFundo();
            }

            return prmLinha;

        }

        private void ViewTAGS(ScriptCLI prmScript, ListViewItem prmLinha, bool prmCleanup)
        {

            ListViewItem.ListViewSubItem celula; int cont = qtde_colunas;

            foreach (myTag Tag in prmScript.Tags)
            {
                if (prmCleanup)
                    prmLinha.SubItems.Add("");

                celula = prmLinha.SubItems[cont];

                celula.Text = Tag.value;

                celula.ForeColor = Editor.Cor.Tag.GetCorFrente(Tag);
                celula.ForeColor = Editor.Cor.Tag.GetCorFundo(Tag);

                cont++;

            }

        }
        private ListViewItem GetListItem() => ListView.SelectedItems[0];
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

        internal int qtde_colunas;

        internal PageResource(PageBuilder prmBuilder)
        {
            Builder = prmBuilder;
        }

        internal void SetPage(UserControl prmPage, Control prmListView)
        {
            Page = (usrTestScripts)prmPage;

            ListView = (ListView)prmListView;
        }

        internal void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

    }

}