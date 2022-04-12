using Dooggy.LIBRARY;
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

namespace BlueRocket
{

    public partial class frmMainCLI : Form
    {

        private EditorCLI Editor;

        private Thread thread;
        public frmMainCLI()
        {
            InitializeComponent();

            this.Text = String.Format("About: {0}", myAssembly.AssemblyTitle);
        }

        public void Setup(EditorCLI prmEditor)
        {

            Editor = prmEditor;

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

            //Editor.FilterTagChanged += FilterTagChanged;
            Editor.FilterTagChecked += FilterTagChecked;

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
            usrStatus.Setup(prmEditor);

            ProjectSetup();

        }

        private void frmTestDataFactoryConsole_Load(object sender, EventArgs e) => ProjectSetup();

        private void ProjectSetup()
        {

            pagScripts.Setup(Editor);
            pagEdition.Setup(Editor);

            Editor.Build();

            MenuStatusView();

        }
        private void ProjectMultiSelect(bool prmAtivar) { pagEdition.MultiSelect(prmAtivar); MenuStatusView(); }

        private void ProjectDBConnect()
        {
            Editor.DoConnect(); 
            
            ScriptView();
        }
        private void ProjectOpen(string prmArquivoCFG)
        {
            Editor.PagePaintStart(); 
            
            Editor.Open(prmArquivoCFG);

            ProjectBuild();

            Editor.PagePaintEnd();
        }
        private void ProjectClose()
        {
            Editor.PagePaintStart();

            Editor.Close(); ProjectReset();

            Editor.PagePaintEnd();
        }

        private void ProjectReset() => ProjectBuild();

        private void ProjectBuild()
        {
            Editor.Build();

            pagScripts.Build();

            pagEdition.View();

         }

        private void ViewRefresh() { MenuStatusView(); }
        private void ProjectExit() { }

        private void ScriptLocked() => Editor.CodeLocked();
        private void ScriptChecked(string prmScript, bool prmChecked) { Editor.Select.SetScript(prmScript, prmChecked); MenuStatusView(); }

        private void FilterTagChecked(string prmTag, string prmOption, bool prmChecked) { Editor.Filter.SetTagOption(prmTag, prmOption, prmChecked); FiltroView(); }

        private void ScriptView()
        {
            pagEdition.View();

            MenuStatusView();
        }

        private void FiltroView()
        {
            pagScripts.ViewAll(prmCleanup: true);

            MenuStatusView();
        }

        private void ScriptLogOK() => pagEdition.ViewResult(prmPage: ePageResult.ePageMassaDados);
        private void ScriptLogError() => pagEdition.ViewResult(prmPage: ePageResult.ePageLogErrors);

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

                if (pagEdition.FindNodeScript(Script))
                {

                    Editor.CodeBatchSet(Script);

                    Editor.CodeLocked(prmLocked);

                }
            }

            Editor.CodeBatchEnd();

        }
        private void MenuStatusView() { usrStatus.View(); usrMenu.View(); }
        private void BatchSet(ScriptCLI prmScript) => pagEdition.UncheckedNodeScript(prmScript);
        private void BatchEnd() => usrMenu.Refresh();
        private void SelectedPlayAll() => SelectedPlaySaveAll(prmPlay: true, prmSave: false);
        private void SelectedSaveAll() => SelectedPlaySaveAll(prmPlay: false, prmSave: true);

        private void SelectedPlaySaveAll(bool prmPlay, bool prmSave)
        {

            Editor.CodeBatchStart();
            
            foreach (ScriptCLI Script in Editor.Select)
            {

                if (pagEdition.FindNodeScript(Script))
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

        public void SetAction(string prmTexto) => usrStatus.SetAction(prmTexto);

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
