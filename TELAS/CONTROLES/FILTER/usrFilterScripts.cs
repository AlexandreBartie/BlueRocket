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
        private EditorCLI Editor;

        public usrFilterScripts()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "SCRIPTS Filtrados");
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

        public void View()
        {
            lstScripts.Items.Clear();

            if (Editor.TemAtivos)
                ViewScripts();
        }

        private void ViewScripts()
        {

            ListViewItem linha;

            foreach (ScriptCLI Script in Editor.Project.Scripts.Ativos)
            {
                linha = lstScripts.Items.Add("x");

                linha.SubItems.Add(Script.name);
                linha.SubItems.Add(Script.timeSeconds);

                linha.ForeColor = Script.Cor.GetPadrao().frente;
                linha.BackColor = Script.Cor.GetPadrao().fundo;

                ViewTAGS(Script, linha);
            }

        }

        private void ViewTAGS(ScriptCLI prmScript, ListViewItem prmLinha)
        {

            ListViewItem.ListViewSubItem celula;

            foreach (DataTag Tag in prmScript.Tags)
            {

                celula = prmLinha.SubItems.Add(Tag.name) ;

                //qcelula.ForeColor = Tag..frente;
                //celula.BackColor = Tag.Cor.GetPadrao().fundo;

            }


        }
        private void MontarListScripts()
        {
            CabecalhoListScripts(); View();
        }

        private void CabecalhoListScripts()
        {

            lstScripts.Columns.Clear();

            lstScripts.Columns.Add("x",0);
            lstScripts.Columns.Add("Nome Script",400);
            lstScripts.Columns.Add("Duração",100, textAlign: HorizontalAlignment.Center);

            CabecalhoListTags();

        }

        private void CabecalhoListTags()
        {
           
            if (Editor.TemProject)
            {
                foreach (DataTag Tag in Editor.Project.Tags)
                {
                    lstScripts.Columns.Add(Tag.name, -2, textAlign: HorizontalAlignment.Center);

                }

            }
        }
    }
}
