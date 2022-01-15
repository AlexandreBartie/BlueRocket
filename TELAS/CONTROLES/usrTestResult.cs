using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DooggyCLI;

namespace DooggyCLI.Telas
{
    public partial class usrTestResult : usrMoldura
    {

        private EditorScripts Editor;

        public usrTestResult()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Resultado Gerado");

        }

        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(txtMassaDados);
            Editor.Config.SetPadrao(txtLogExecucao);

        }

        public void View()
        {

            if (Editor.TemScript)
            {

                txtMassaDados.Text = Editor.Log.data;
                txtLogExecucao.Text = Editor.Log.txt;

                txtMassaDados.ForeColor = Editor.GetForeColor();
                txtLogExecucao.ForeColor = Editor.GetForeColor();

            }
            else
            {

                txtMassaDados.Text = "";
                txtLogExecucao.Text = "";

            }


        }

    }
}
