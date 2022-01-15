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

            Editor.ProjectRefresh += ProjectRefresh;

            Editor.ScriptChanged += ScriptView;

            Editor.ScriptPlay += ScriptPlay;
            Editor.ScriptSave += ScriptSave;
            Editor.ScriptUndo += ScriptUndo;

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

        private void ProjectRefresh()
        {

            Editor.Refresh();

            usrProjetoTeste.Refresh();

            ScriptView();

        }

        private void ScriptView()
        {

            usrProjetoTeste.View();

            usrScriptTeste.View();

            usrResultadoTeste.View();

        }

        private void ScriptPlay()
        {

            Editor.Script.PlayCode();

            Editor.OnScriptChanged();

        }

        private void ScriptSave()
        {

            Editor.Script.SaveCode();

            Editor.OnScriptChanged();

        }

        private void ScriptUndo()
        {

            Editor.Script.UndoCode();

            Editor.OnScriptChanged();

        }

     }

}
