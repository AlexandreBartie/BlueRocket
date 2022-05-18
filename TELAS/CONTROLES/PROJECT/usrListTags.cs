using BlueRocket.PAGES.ListTags;
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
    public partial class usrListTags : PageControl
    {

       // internal PageListTags Page;


        public usrListTags()
        {
            InitializeComponent();

            //Page = new PageListTags(prmPage: this, prmTreeView: this.trvTags);
        }

        public new void Setup(EditorCLI prmEditor)
        {
            //Page.Setup(prmEditor);
        }

        public void Build()
        {
           // Page.Build();
        }
    }
}
