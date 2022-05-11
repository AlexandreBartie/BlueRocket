using Katty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class PageControl : UserControl
    {

        private EditorCLI _Editor;

        public EditorCLI Editor { get => _Editor; }

        public AppCLI App => Editor.App;

        public void Setup(EditorCLI prmEditor)
        {
            _Editor = prmEditor;
        }
    }

    public class PageBuilder : BaseBuilder
    {
        public PageElements Elements;

        public TabBuilder Tab;

        public PageControl GetParent() => Page;
        public PageControl GetElement(string prmKey) => Elements.FindKey(prmKey);

        public PageBuilder(PageControl prmPage)
        {

            Page = prmPage;

            Tab = new TabBuilder(this);

            Elements = new PageElements();
        }
        public void Setup(EditorCLI prmEditor)
        {
            Page.Setup(prmEditor);
        }

        public void AddElement(string prmKey, PageControl prmElement) => AddElement(prmKey, prmElement, prmDockStyle: DockStyle.Fill);
        public void AddElement(string prmKey, PageControl prmElement, DockStyle prmDockStyle)
        {
            prmElement.Parent = Page;

            prmElement.BringToFront();

            prmElement.Dock = prmDockStyle;

            Elements.Add(prmKey, prmElement);
        }

        public void AddSplitter(DockStyle prmDockStyle)
        {

            Splitter Separator = new Splitter();

            Separator.Parent = Page;

            Separator.BringToFront();

            Separator.Dock = prmDockStyle;
        }

        public void AddTab(string prmPages, TabAlignment prmAligment) => AddTab(prmPages, prmAligment, prmDockStyle: DockStyle.Fill);
        public void AddTab(string prmPages, TabAlignment prmAligment, DockStyle prmDockStyle)
        {
            Tab.Create(prmAligment, prmDockStyle);

            foreach (string key in new xLista(prmPages))
                AddControl(key);
        }

        private void AddControl(string prmKey)
        {
            Tab.AddControl(prmKey, prmControl: GetElement(prmKey));
        }

    }
    public class PageElements : List<PageElement>
    {
        public void Add(string prmKey, PageControl prmElement)
        {
            base.Add(new PageElement(prmKey, prmElement));
        }

        public PageControl FindKey(string prmKey)
        {
            foreach (PageElement Element in this)
                if (Element.IsMatch(prmKey))
                    return Element.Control;
            return null;
        }

    }
    public class PageElement
    {
        public string key;

        public PageControl Control;

        public bool IsMatch(string prmKey) => myString.IsMatch(key, prmKey);

        public PageElement(string prmKey, PageControl prmControl)
        {
            key = prmKey; Control = prmControl;
        }

    }
    public class TabBuilder
    {
        private PageBuilder Builder;

        private TabControl Tab;

        public TabBuilder(PageBuilder prmBuilder)
        {
            Builder = prmBuilder; Tab = new TabControl();
        }

        public void Create(TabAlignment prmAligment, DockStyle prmDockStyle)
        {
            Tab.Parent = Builder.GetParent();

            Tab.Alignment = prmAligment;

            Tab.BringToFront();

            Tab.Dock = prmDockStyle;
        }

        public void AddControl(string prmLabel, UserControl prmControl)
        {
            TabPage Item = new TabPage(prmLabel);

            Item.Controls.Add(prmControl);

            Tab.TabPages.Add(Item);
        }


    }

    public class BaseBuilder
    {
        public AppCLI App => Page.App;
        public EditorCLI Editor => Page.Editor;

        internal PageControl Page;

    }
}
