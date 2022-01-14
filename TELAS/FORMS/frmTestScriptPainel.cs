using Dooggy;
using Dooggy.Factory.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class frmTestScriptPainel : Form
    {

        private EditorScripts Editor;

        public frmTestScriptPainel()
        {
            InitializeComponent();
        }

        public void Setup(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Editor.Config.SetPadrao(splSeparadorH);
            Editor.Config.SetPadrao(splSeparadorV);

            Editor.ScriptSelected += ScriptSelected;
            Editor.ScriptCodeChanged += ScriptCodeChanged;

            Editor.Refresh();

            this.ShowDialog();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e)
        {

            IniciarSetup();

        }

        private void IniciarSetup()
        {

            usrProjetoTeste.Setup(Editor);

            usrScriptTeste.Setup(Editor);

            usrResultadoTeste.Setup(Editor);

        }

        private void ScriptSelected()
        {

            usrScriptTeste.Exibir();

            usrResultadoTeste.Exibir();

        }

        private void ScriptCodeChanged()
        {

            usrProjetoTeste.Formatar();

            usrScriptTeste.Formatar();

            usrResultadoTeste.Formatar();


        }

    }

}
