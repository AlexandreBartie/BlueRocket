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
        private AppCLI App => Editor.App;

        public usrActionMenu()
        {
            InitializeComponent();
        }

        //
        // File
        //
        private void mnuFileOpen_Click(object sender, EventArgs e) => App.Action.OnFileStart();
        private void mnuFileClose_Click(object sender, EventArgs e) => App.Action.OnFileClose();
        private void mnuFileRefresh_Click(object sender, EventArgs e) => App.Action.OnFileRefresh();
        private void mnuNewWindow_Click(object sender, EventArgs e) => App.Action.OnFileNewSession();
        private void mnuFileExit_Click(object sender, EventArgs e) => App.Action.OnFileExit();

        //
        // Script
        //
        private void mnuLockedAll_Click(object sender, EventArgs e) => Editor.OnSelectedLockedAll();
        private void mnuUnlockedAll_Click(object sender, EventArgs e) => Editor.OnSelectedUnlockedAll();
        private void mnuPlayAll_Click(object sender, EventArgs e) => Editor.OnSelectedPlayAll();
        private void mnuSaveAll_Click(object sender, EventArgs e) => Editor.OnSelectedSaveAll();

        //
        // View Project
        //
        private void mnuAutoLoad_Click(object sender, EventArgs e) => App.Action.OnViewProjectAutoLoad();
        private void mnuAutoSave_Click(object sender, EventArgs e) => App.Action.OnViewProjectAutoSave();
        private void mnuDebugMode_Click(object sender, EventArgs e) => App.Action.OnViewProjectDebugMode();
        
        //
        // View Script
        //
        private void mnuViewScriptCount_Click(object sender, EventArgs e) => App.Action.OnViewScriptDataCount();
        private void mnuViewScriptTime_Click(object sender, EventArgs e) => App.Action.OnViewScriptTimeAnalisys();
        private void mnuViewScriptTags_Click(object sender, EventArgs e) => App.Action.OnViewScriptAssociatedTags();

        //
        // Script About
        //
        private void mnuAbout_Click(object sender, EventArgs e) => Editor.Page.AboutShow();

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(mnuMain);

            App.Register.Project.AutoLoad.Link(mnuAutoLoad);
            App.Register.Project.AutoSave.Link(mnuAutoSave);
            App.Register.Project.DebugMode.Link(mnuDebugMode);

            App.Register.Script.DataCount.Link(mnuDataCount);
            App.Register.Script.TimeAnalisys.Link(mnuTimeAnalisys);
            App.Register.Script.AssociatedTags.Link(mnuAssociatedTags);

            SeparatorNew.Visible = false;
            mnuNewWindow.Visible = false;
        }

        private void usrActionProject_Load(object sender, EventArgs e)
        {
            this.Size = mnuMain.Size;
        }

        public void View()
        {
        
            mnuFileOpen.Enabled = Editor.ICanOpen;
            mnuFileClose.Enabled = Editor.ICanClose;

            mnuFileRefresh.Enabled = Editor.ICanRefresh;

            mnuScripts.Enabled = Editor.ICanBatch;

            mnuLockedAll.Visible = Editor.ICanBatch;
            mnuUnlockedAll.Visible = Editor.ICanBatch;

            mnuScripts.DropDownItems[2].Visible = Editor.ICanPlayAll;

            mnuPlayAll.Visible = Editor.ICanPlayAll;
            mnuSaveAll.Visible = Editor.ICanSaveAll;

            //if (Editor.ICanOpen)
            //   Editor.SetAction("Please, select CFG file to open a project ...");

        }

    }
}
