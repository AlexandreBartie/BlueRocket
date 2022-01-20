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
    public partial class frmEditorCLI : Form
    {

        private EditorCLI Editor;

        public frmEditorCLI()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetPadrao(splSeparadorH);
            Editor.Format.SetPadrao(splSeparadorV);

            Editor.MultiSelection += MultiSelection;

            Editor.ProjectRefresh += ProjectRefresh;

            Editor.ScriptLocked += ScriptLocked;
            Editor.ScriptChanged += ScriptChanged;

            Editor.CodePlay += ScriptPlay;
            Editor.CodeSave += ScriptSave;
            Editor.CodeUndo += ScriptUndo;

            Editor.Refresh();

            this.ShowDialog();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e)
        {

            usrProjetoTeste.Setup(Editor);

            usrScriptTeste.Setup(Editor);

            usrResultadoTeste.Setup(Editor);

        }
        private void MultiSelection()
        {

            usrProjetoTeste.MultiSelection();

        }

        private void ProjectRefresh()
        {

            Editor.Refresh();

            usrProjetoTeste.Refresh();

            ScriptChanged();

        }

        private void ScriptChanged()
        {

            usrProjetoTeste.View();

            usrScriptTeste.View();

            usrResultadoTeste.View();

        }

        private void ScriptLocked()
        {

            Editor.Script.SetLocked();

            Editor.OnScriptChanged();

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
