using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlueRocket
{

    public enum ePageResult : int
    {
        ePageMassaDados = 1,
        ePageLogExecucao = 2,
        ePageLogErrors = 3,
        ePageSqlCommands = 4,
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

        private void lstSqlCommands_DoubleClick(object sender, EventArgs e) => Editor.OnScriptLogClipBoard(prmLog: GetSqlSelected(prmColumn: eLogColumn.eLogDescription));
        
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
            Editor.Format.SetPadrao(lstLogErrors);
            Editor.Format.SetPadrao(lstSqlCommands);
        }

        public void View()
        {
            lstLogExecucao.Items.Clear();
            lstLogErrors.Items.Clear();
            lstSqlCommands.Items.Clear();

            if (Editor.IsMassaDados)
            {
                txtMassaDados.Text = Editor.Result.data;

                txtMassaDados.ForeColor = Editor.Script.Cor.GetCodeForeColor();
                txtMassaDados.BackColor = Editor.Script.Cor.GetLogBackColor();

                lstLogExecucao.ForeColor = Editor.Script.Cor.GetLogForeColor();
                lstLogExecucao.BackColor = Editor.Script.Cor.GetLogBackColor();

                lstLogErrors.ForeColor = Editor.Script.Cor.GetLogForeColor();
                lstLogErrors.BackColor = Editor.Script.Cor.GetLogBackColor();

                lstSqlCommands.ForeColor = Editor.Script.Cor.GetLogForeColor();
                lstSqlCommands.BackColor = Editor.Script.Cor.GetLogBackColor();

                ViewListas();
            }
            else
            {
                txtMassaDados.Text = "";
            }
        }

        private void ViewListas()
        {
            ViewListaDados(prmResult: Editor.Result.Log.Main, prmLista: lstLogExecucao, prmSQL: false);
            ViewListaDados(prmResult: Editor.Result.Log.Err, prmLista: lstLogErrors, prmSQL: false);
            ViewListaDados(prmResult: Editor.Result.Log.SQL, prmLista: lstSqlCommands, prmSQL: true);
        }

        private void ViewListaDados(TestResultBase prmResult, ListView prmLista, bool prmSQL)
        {

            ListViewItem linha;

            foreach (TraceMSG Item in prmResult)
            {
                linha = prmLista.Items.Add("x");

                if (prmSQL)
                {
                    linha.SubItems.Add(Item.elapsed_seconds);
                    linha.SubItems.Add(Item.sql);
                }
                else
                {
                    linha.SubItems.Add(Item.tipo);
                    linha.SubItems.Add(Item.txt);
                }

                linha.Text = "...";

                linha.ForeColor = Editor.Script.Cor.GetItemLogForeColor(Item.tipo);

            }

        }

        public void ViewPage(ePageResult prmPage) => this.tabControl.SelectedIndex = Convert.ToInt16(prmPage) - 1;

        private string GetSqlSelected(eLogColumn prmColumn) => lstSqlCommands.SelectedItems[0].SubItems[Convert.ToInt16(prmColumn)].Text;

    }
 
}
