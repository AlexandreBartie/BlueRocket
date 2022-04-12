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

        private void cmdOpenProject_Click(object sender, EventArgs e) => OpenProject();

        private void cmdExit_Click(object sender, EventArgs e) => this.Close();

        public frmStart()
        {
            InitializeComponent();
        }
        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor; ShowDialog();
        }

        private void OpenProject()
        {
            Hide();
            
            if (Editor.SelectFileCFG())
                this.Close();

            Show();
        }

    }
}
