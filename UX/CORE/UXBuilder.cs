using Katty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.UX
{
    public class UXBuilder : BaseUXBuilder
    {

        public UXBuilder(PageControl prmPage)
        {
            CreatePage(prmPage, prmTitle: false); 
        }
        public UXBuilder(PageControl prmPage, bool prmTitle)
        {
            CreatePage(prmPage, prmTitle);
        }
        public UXBuilder(FormControl prmForm)
        {
            CreateBase(prmParent: prmForm, prmBase: prmForm.GetBase());
        }
        private void CreatePage(PageControl prmPage, bool prmTitle)
        {
            CreateBase(prmParent: prmPage, prmBase: prmPage.GetBase());

            if (prmTitle)
                AddCaption();
        }
        private void CreateBase(Control prmParent, BaseControl prmBase)
        {
             Parent = prmParent; Base = prmBase; 
        }

        public void Setup(EditorCLI prmEditor)
        {
            Base = new BaseControl(prmEditor);
        }
    }
    public class BaseUXBuilder : UXPage
    {
        public AppCLI App => Base.App;
        public EditorCLI Editor => Base.Editor;

    }
}
