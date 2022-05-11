using BlueRocket.PAGES.TestData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrViewData : PageControl
    {

        //internal PageViewData Page;
        public usrViewData()
        {
            InitializeComponent();

            //Page = new PageViewData(prmPage: this, prmDataGrid: grdDataFeed);
        }

        public new void Setup(EditorCLI prmEditor)
        {

            base.Setup(prmEditor);

            //Page.Format.se(grdDataFeed);

            //usrAction.Setup(prmEditor);

        }

    }
}
