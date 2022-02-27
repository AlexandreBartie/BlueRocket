using Dooggy.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rocket.Telas
{

    public enum ePageResult : int
    {
        ePageMassaDados = 0,
        ePageLogExecucao = 1,
    }

    public enum eLogColumn : int
    {
        eLogType = 1,
        eLogDescription = 2,
    }

    public partial class usrTestResult : usrMoldura
    {

        private EditorCLI Editor;

        private void tabControl_Click(object sender, EventArgs e) => Editor.OnScriptCodeChanged();

        private void lstLogExecucao_DoubleClick(object sender, EventArgs e) => Editor.OnScriptLogClipBoard(prmLog: GetLogSelected(prmColumn: eLogColumn.eLogDescription));
        
        public usrTestResult()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Resultado Gerado");

        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetMemo(txtMassaDados);
            Editor.Format.SetPadrao(lstLogExecucao);

        }

        public void View()
        {

            lstLogExecucao.Items.Clear();

            if (Editor.IsMassaDados)
            {
                txtMassaDados.Text = Editor.Result.data;

                txtMassaDados.ForeColor = Editor.Script.Cor.GetCodeForeColor();
                txtMassaDados.BackColor = Editor.Script.Cor.GetLogBackColor();

                lstLogExecucao.ForeColor = Editor.Script.Cor.GetLogForeColor();
                lstLogExecucao.BackColor = Editor.Script.Cor.GetLogBackColor();

                ViewLogExecucao();
            }
            else
            {
                txtMassaDados.Text = "";
            }
        }

        private void ViewLogExecucao()
        {

            ListViewItem linha;

            foreach (TestItemLog Item in Editor.Result.Log)
            {
                linha = lstLogExecucao.Items.Add("x");

                linha.SubItems.Add(Item.tipo);
                linha.SubItems.Add(Item.texto);

                linha.Text = "...";

                linha.ForeColor = Editor.Script.Cor.GetItemLogForeColor(Item.tipo);

            }

        }

        private string GetLogSelected(eLogColumn prmColumn) => lstLogExecucao.SelectedItems[0].SubItems[Convert.ToInt16(prmColumn)].Text;
        public void ViewPage(ePageResult prmPage) => this.tabControl.SelectedIndex = Convert.ToInt16(prmPage);

    }
 
}
