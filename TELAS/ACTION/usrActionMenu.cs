using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrActionMenu : UserControl
    {

        private EditorCLI Editor;

        public usrActionMenu()
        {
            InitializeComponent();
        }
        private void mnuProjectOpen_Click(object sender, EventArgs e) => Editor.OnProjectOpen();
        private void mnuProjectClose_Click(object sender, EventArgs e) => Editor.OnProjectClose();
        private void mnuProjectRefresh_Click(object sender, EventArgs e) => Editor.OnProjectReset();
        private void mnuProjectExit_Click(object sender, EventArgs e) => Editor.OnProjectExit();

        private void mnuLockedAll_Click(object sender, EventArgs e) => Editor.OnSelectedLockedAll();
        private void mnuUnlockedAll_Click(object sender, EventArgs e) => Editor.OnSelectedUnlockedAll();

        private void mnuPlayAll_Click(object sender, EventArgs e) => Editor.OnSelectedPlayAll();
        private void mnuSaveAll_Click(object sender, EventArgs e) => Editor.OnSelectedSaveAll();


        private void mnuAbout_Click(object sender, EventArgs e) => Editor.Page.AboutShow();

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(mnuMain);
        }

        private void usrActionProject_Load(object sender, EventArgs e)
        {
            this.Size = mnuMain.Size;
        }

        public void View()
        {
        
            mnuProjectOpen.Enabled = Editor.ICanOpen;
            mnuProjectClose.Enabled = Editor.ICanClose;

            mnuProjectRefresh.Enabled = Editor.ICanRefresh;

            mnuScripts.Enabled = Editor.ICanBatch;

            mnuLockedAll.Visible = Editor.ICanBatch;
            mnuUnlockedAll.Visible = Editor.ICanBatch;

            mnuScripts.DropDownItems[2].Visible = Editor.ICanPlayAll;

            mnuPlayAll.Visible = Editor.ICanPlayAll;
            mnuSaveAll.Visible = Editor.ICanSaveAll;

            if (Editor.ICanOpen)
                Editor.SetAction("Please, select CFG file to open a project ...");

        }

    }
}
