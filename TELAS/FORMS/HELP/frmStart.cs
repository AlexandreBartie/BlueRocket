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
    public partial class frmStart : Form
    {

        public AppCLI App;

        private void frmStart_Activated(object sender, EventArgs e) => App.Action.OnFileDirect();

        private void chkLoadAutomatic_CheckedChanged(object sender, EventArgs e) => App.Load.History.SetAutoLoad(chkAutoLoad.Checked);

        private void lstHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                App.Action.OnFileOpen(prmProject: item.Tag.ToString());
        }
        private void cmdFindProject_Click(object sender, EventArgs e) => App.Action.OnFileFind();

        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (App.IsWorking)
                { Hide(); e.Cancel = true; }
            else
                e.Cancel = false;
        }

        private void cmdExit_Click(object sender, EventArgs e) => this.Close();

        public frmStart(AppCLI prmApp)
        {
            InitializeComponent(); App = prmApp;

            App.Format.SetPadrao(lstHistory);
            
            View();
        }
        private void View()
        {
            CreateHeader();

            foreach (FileLoaded File in App.Load.History)
                ViewDetails(File);

            chkAutoLoad.Visible = App.Load.HasHistory;

            chkAutoLoad.Checked = App.Load.History.IsAutoLoad;
        }

        private void ViewDetails(FileLoaded prmFile)
        {
            ListViewItem linha;

            linha = lstHistory.Items.Add("");

            linha.Tag = prmFile.full_name;

            linha.SubItems.Add(prmFile.name);
            linha.SubItems.Add(prmFile.loaded_txt);
            linha.SubItems.Add(prmFile.path);
        }
        private void CreateHeader()
        {
            lstHistory.Columns.Add("", 0);
            lstHistory.Columns.Add("Project Name", 200, textAlign: HorizontalAlignment.Left);
            lstHistory.Columns.Add("Date Loaded", 200, textAlign: HorizontalAlignment.Center);
            lstHistory.Columns.Add("Path", -2, textAlign: HorizontalAlignment.Left);
        }
        private ListViewItem GetListItem(int prmMouseX, int prmMouseY)
        {

            ListViewHitTestInfo info = lstHistory.HitTest(prmMouseX, prmMouseY);
            ListViewItem item = info.Item;

            return (item);
        }

    }
}
