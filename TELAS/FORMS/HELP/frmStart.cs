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

        public EditorCLI Editor;

        private void lstHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = GetListItem(prmMouseX: e.X, prmMouseY: e.Y);

            if (item != null)
                OpenProject(prmProject: item.Tag.ToString());
        }
        private void cmdFindProject_Click(object sender, EventArgs e) => FindProject();

        private void cmdExit_Click(object sender, EventArgs e) => this.Close();

        public frmStart()
        {
            InitializeComponent();
        }
        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(lstHistory);
            
            View(); ShowDialog();
        }
        private void View()
        {
            CreateHeader();

            foreach (FileLoaded File in Editor.Load.History)
                ViewDetails(File);
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
        public void OpenProject(string prmProject)
        {
            Hide();

            Editor.Load.OpenProject(prmProject);

            Reset();
        }
        private void FindProject()
        {
            Hide();

            Editor.Load.FindProject();

            Reset();
        }

        private void Reset()
        {
            if (Editor.IsWorking)
                Show();
            else
                Close();

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
