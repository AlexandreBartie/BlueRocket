using Dooggy;
using Dooggy.Factory.Console;
using Dooggy.Tools.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket.Telas
{
    public partial class frmMainCLI : Form
    {

        private EditorCLI Editor;

        private Thread thread;
        private Task task;

        public frmMainCLI()
        {
            InitializeComponent();
        }
        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Editor.Format.SetPadrao(splSeparadorH);
            Editor.Format.SetPadrao(splSeparadorV);

            Editor.MultiSelect += ProjectMultiSelect;

            Editor.SelectedLockedAll += SelectedLockedAll;
            Editor.SelectedUnlockedAll += SelectedUnlockedAll;

            Editor.SelectedPlayAll += SelectedPlayAll;
            Editor.SelectedSaveAll += SelectedSaveAll;

            Editor.BatchSet += BatchSet;
            Editor.BatchEnd += BatchEnd;

            Editor.ProjectOpen += ProjectOpen;
            Editor.ProjectClose += ProjectClose;
            Editor.ProjectReset += ProjectReset;
            Editor.ProjectExit += ProjectExit;

            Editor.ProjectDBConnect += ProjectDBConnect;

            Editor.ScriptCodeChecked += ScriptChecked;

            Editor.ScriptCodeLocked += ScriptLocked;
            Editor.ScriptCodeSelect += ScriptView;
            Editor.ScriptCodeChanged += ScriptView;

            Editor.ScriptCodePlay += ScriptPlay;
            Editor.ScriptPlayStop += ScriptPlayStop;

            Editor.ScriptCodeSave += ScriptSave;
            Editor.ScriptCodeUndo += ScriptUndo;

            Editor.ScriptLogOK += ScriptLogOK;
            Editor.ScriptLogError += ScriptLogError;

            Editor.ScriptLogClipBoard += ScriptLogClipBoard;

            usrMenu.Setup(prmEditor);

            Editor.Reset();

            this.ShowDialog();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e) => ProjectSetup();

        private void ProjectSetup()
        {
            usrProjetoTeste.Setup(Editor);

            usrScriptTeste.Setup(Editor);

            usrResultadoTeste.Setup(Editor);

            usrMenu.View();

        }
        private void ProjectMultiSelect(bool prmAtivar) { usrProjetoTeste.MultiSelect(prmAtivar); usrMenu.View(); }
        private void ProjectDBConnect()
        {
            Editor.DoConnect(); 
            
            ScriptView();
        }
        private void ProjectOpen(string prmArquivoCFG)
        {
            Editor.Open(prmArquivoCFG); ProjectReset();
        }
        private void ProjectClose()
        {
            Editor.Close(); ProjectReset();
        }
        private void ProjectReset()
        {
            Editor.Reset();

            usrProjetoTeste.Refresh();

            usrMenu.View();
        }
        private void ProjectExit()
        {
 
        }
        private void ScriptLocked() => Editor.CodeLocked();
        private void ScriptChecked(string prmScript, bool prmChecked) { Editor.Select.SetScript(prmScript, prmChecked); usrMenu.View(); }
        private void ScriptView()
        {
            usrProjetoTeste.View();

            usrScriptTeste.View();

            usrResultadoTeste.View();

            usrMenu.View();
        }

        private void ScriptLogOK() => usrResultadoTeste.ViewPage(prmPage: ePageResult.ePageMassaDados);
        private void ScriptLogError() => usrResultadoTeste.ViewPage(prmPage: ePageResult.ePageLogExecucao);

        private void ScriptLogClipBoard(string prmLog) => Clipboard.SetText(prmLog);

        private void ScriptSave() => Editor.CodeSave();
        private void ScriptUndo() => Editor.CodeUndo();

        private void SelectedLockedAll() => SelectedAll(prmLocked: true);
        private void SelectedUnlockedAll() => SelectedAll(prmLocked: false);

        private void SelectedAll(bool prmLocked)
        {

            Editor.CodeBatchStart();

            foreach (ScriptCLI Script in Editor.Select)
            {

                if (usrProjetoTeste.FindNodeScript(Script))
                {

                    Editor.CodeBatchSet(Script);

                    Editor.CodeLocked(prmLocked);

                }
            }

            Editor.CodeBatchEnd();

        }

        private void BatchSet(ScriptCLI prmScript) => usrProjetoTeste.UncheckedNodeScript(prmScript);
        private void BatchEnd() => usrMenu.Refresh();
        private void SelectedPlayAll() => SelectedPlaySaveAll(prmPlay: true, prmSave: false);
        private void SelectedSaveAll() => SelectedPlaySaveAll(prmPlay: false, prmSave: true);

        private void SelectedPlaySaveAll(bool prmPlay, bool prmSave)
        {

            Editor.CodeBatchStart();
            
            foreach (ScriptCLI Script in Editor.Select)
            {

                if (usrProjetoTeste.FindNodeScript(Script))
                {
                    
                    Editor.CodeBatchSet(Script);

                    if (prmPlay)
                        ScriptPlay();

                    if (prmSave)
                        ScriptSave();

                }
            }

            Editor.CodeBatchEnd();

        }

        private void ScriptPlay()
        {

            if (Editor.IsPlaying)
                return;

            Editor.PlayStart();

            ScriptPlay_ByTHREAD();

            Editor.OnScriptCodeChanged();

            if (Editor.Script.IsLogOK)
                ScriptLogOK();
            else
                ScriptLogError();
        }
        private void ScriptPlay_ByTHREAD()
        {

            thread = new Thread(new ThreadStart(ScriptPlay_THREAD));
            thread.Name = Editor.Script.title;
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);

            thread.Start();
            thread.Join();

        }

        private void ScriptPlay_THREAD()
        {
            Editor.CodePlayStart();

            Editor.CodePlayEnd();
        }
        private void ScriptPlayStop()
        {

            if (thread != null)
            {

                if (thread.IsAlive)
                {

                    thread.Interrupt();
                    //thread.Abort();

                }

            }

            //Editor.CodePlayStop();

        }
        public void SetAction(string prmTexto) => usrProjetoTeste.SetAction(prmTexto);

    }

    internal class TaskPlayScript
    {
        private EditorCLI Editor;

        public TaskPlayScript(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        internal void Work()
        {
            Editor.CodePlayStart();

            Editor.CodePlayEnd();
        }
    }

    internal class ThreadPlayScript : mySuperThread
    {
        private EditorCLI Editor;

        public ThreadPlayScript(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        protected override void Work()
        {
            Editor.CodePlayStart();

            Editor.CodePlayEnd();
        }
    }
}
