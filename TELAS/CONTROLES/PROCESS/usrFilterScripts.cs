using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class usrFilterScripts : usrMoldura
    {
        private EditorCLI Editor; int qtde_colunas;

        public usrFilterScripts()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "SCRIPTS Filtrados");
        }
        private void lstScripts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ScriptFocus(prmScript: e.Item.Tag.ToString());
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(lstScripts);

            MontarListScripts();

        }

        public new void Refresh()
        {
            MontarListScripts();
        }

        public void View() => View(prmRefresh: true);
        public void View(bool prmRefresh)
        {
            if (prmRefresh)
                lstScripts.Items.Clear();

            if (Editor.TemAtivos)
                ViewScripts(prmRefresh);
        }

        private void ViewScripts(bool prmRefresh)
        {

            ListViewItem linha; int cont = 0;

            foreach (ScriptCLI Script in Editor.Project.Scripts.Ativos)
            {
                if (prmRefresh)
                {
                    linha = lstScripts.Items.Add("x");

                    for (int x = 1; x < qtde_colunas; x++)
                        linha.SubItems.Add("");

                }

                linha = lstScripts.Items[cont];

                linha.Tag = Script.name;

                linha.SubItems[1].Text = Script.name;
                linha.SubItems[2].Text = Script.status;
                linha.SubItems[3].Text = Script.filtro;
                linha.SubItems[4].Text = Script.qtdTests;
                linha.SubItems[5].Text = Script.timeBigger;
                linha.SubItems[6].Text = Script.timeAverage;
                linha.SubItems[7].Text = Script.timeSeconds;

                for (int x = 1; x < qtde_colunas; x++)
                {
                    if (x < 5)
                        linha.SubItems[x].ForeColor = Script.Cor.GetCorFrente();
                    else
                        linha.SubItems[x].ForeColor = Script.Cor.GetCorSlowSQL();
                }

                // linha.BackColor = Script.Cor.GetCorFundo();

                ViewTAGS(Script, linha, prmRefresh);

                cont++;
            }

        }

        private void ViewTAGS(ScriptCLI prmScript, ListViewItem prmLinha, bool prmRefresh)
        {

            ListViewItem.ListViewSubItem celula; int cont = qtde_colunas;

            foreach (myTag Tag in prmScript.Tags)
            {
                if (prmRefresh)
                    celula = prmLinha.SubItems.Add("") ;

                celula = prmLinha.SubItems[cont];

                celula.Text = Tag.value;

                celula.ForeColor = Editor.Cor.Tag.GetCorFrente(Tag);
                celula.BackColor = Editor.Cor.Tag.GetCorFundo(Tag);

                cont++;

            }

        }
        private void MontarListScripts()
        {
            CabecalhoListScripts(); View();
        }

        private void CabecalhoListScripts()
        {

            lstScripts.Columns.Clear();

            lstScripts.Columns.Add("#",0);
            lstScripts.Columns.Add("Nome Script",300);
            lstScripts.Columns.Add("Status", 80, textAlign: HorizontalAlignment.Center);
            lstScripts.Columns.Add("Filtro", 80, textAlign: HorizontalAlignment.Center);
            lstScripts.Columns.Add("Testes", 80, textAlign: HorizontalAlignment.Center);
            lstScripts.Columns.Add("Maior", 80, textAlign: HorizontalAlignment.Center);
            lstScripts.Columns.Add("Média", 80, textAlign: HorizontalAlignment.Center);
            lstScripts.Columns.Add("Total", 80, textAlign: HorizontalAlignment.Center);

            qtde_colunas = lstScripts.Columns.Count;

            CabecalhoListTags();

        }

        private void CabecalhoListTags()
        {
            if (Editor.TemProject)
            {
                foreach (myTag Tag in Editor.Project.Tags)
                      lstScripts.Columns.Add(Tag.name, -2, textAlign: HorizontalAlignment.Center);
            }
        }

        private void ScriptFocus(string prmScript)
        {
            Editor.SetScript(prmName: prmScript);

            Editor.OnScriptCodeSelect();
        }

    }
}
