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

        private EditorCLI Editor;

        public usrTestResult()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Resultado Gerado");

        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetMemo(txtMassaDados);
            Editor.Format.SetMemo(txtLogExecucao);

        }

        public void View()
        {

            if (Editor.TemScript)
            {

                txtMassaDados.Text = Editor.Result.data;
                txtLogExecucao.Text = Editor.Result.log;

                txtMassaDados.ForeColor = Editor.GetColorLog();
                txtLogExecucao.ForeColor = Editor.GetColorLog();

            }
            else
            {

                txtMassaDados.Text = "";
                txtLogExecucao.Text = "";

            }


        }

    }
}
