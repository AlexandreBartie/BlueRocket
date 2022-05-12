using Katty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.UX
{
    public class BaseBuilder
    {
        public PageElements Elements;

        public PageTab Tab;

        public PageTitle Title;

        public Control Parent;

        public BaseControl Base;

        internal PageControl GetElement(string prmKey) => Elements.FindKey(prmKey);

        public BaseBuilder()
        {

            Tab = new PageTab(this);

            Title = new PageTitle(this);

            Elements = new PageElements();
        }

        public void AddElement(string prmKey, PageControl prmElement) => AddElement(prmKey, prmElement, prmDockStyle: DockStyle.Fill);
        public void AddElement(string prmKey, PageControl prmElement, DockStyle prmDockStyle) => AddElement(prmKey, prmElement, prmDockStyle, prmSplitter: false);
        public void AddElement(string prmKey, PageControl prmElement, DockStyle prmDockStyle, bool prmSplitter)
        {
            prmElement.Parent = Parent;

            prmElement.BringToFront();

            prmElement.Dock = prmDockStyle;

            Elements.Add(prmKey, prmElement);

            if (prmSplitter)
                AddSplitter(prmDockStyle);

        }
        private void AddSplitter(DockStyle prmDockStyle)
        {

            Splitter Separator = new Splitter();

            Separator.Parent = Parent;

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

        public void AddCaption() { Title.Show(); AddSplitter(prmDockStyle: DockStyle.Top ); }

        public void SetText(string prmText) => Title.SetText(prmText);

        private void AddControl(string prmKey) => Tab.AddControl(prmKey, prmControl: GetElement(prmKey));

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
    public class PageTitle
    {
        private BaseBuilder Builder;

        private usrTitle Title;

        public PageTitle(BaseBuilder prmBuilder)
        {
            Builder = prmBuilder; 
        }

        public void Show()
        {
            Title = new usrTitle();

            Title.Parent = Builder.Parent;

            Title.BringToFront();

            //Moldura.SendToBack();

            Title.Dock = DockStyle.Top;
        }

        public void SetText(string prmText) => Title.SetText(prmText);

    }
    public class PageTab
    {
        private BaseBuilder Builder;

        private TabControl Tab;

        public PageTab(BaseBuilder prmBuilder)
        {
            Builder = prmBuilder; Tab = new TabControl();
        }

        public void Create(TabAlignment prmAligment, DockStyle prmDockStyle)
        {
            Tab.Parent = Builder.Parent;

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
}
