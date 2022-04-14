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

        private void frmMainCLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (ToConfirm("Do you really want to close this application?", "Exit Application"))
                    Editor.Load.Quit();
                else
                    e.Cancel = true;
            }
        }

        public frmMainCLI()
        {
            InitializeComponent();

            this.Text = String.Format("{0} ", myAssembly.AssemblyProduct);
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
            //Editor.PagePaintStart(); 
            
            Editor.Setup(prmArquivoCFG);

            ProjectBuild();

            //Editor.PagePaintEnd();
        }
        private void ProjectClose()
        {

            if (ToConfirm("Do you want to close your current project ?", "Exit Application"))
            {
                Editor.Close();

                ProjectReset();

                MenuStatusView();

            }
        }

        private void ProjectReset() => ProjectBuild();

        private void ProjectBuild()
        {
            Editor.Build();

            pagScripts.Build();

            pagEdition.View();

         }

        private void ViewRefresh() { MenuStatusView(); }
        private void ProjectExit() { Close(); }

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

            Editor.Batch.Start();

            foreach (ScriptCLI Script in Editor.Select)
            {

                if (pagScripts.FindScript(Script))
                {

                    Editor.Batch.Set(Script);

                    Editor.CodeLocked(prmLocked);

                }
            }

            Editor.Batch.End();

        }
        private void MenuStatusView() { usrStatus.View(); usrMenu.View(); }
        private void BatchSet(ScriptCLI prmScript) => pagEdition.UncheckedNodeScript(prmScript);
        private void BatchEnd() => usrMenu.Refresh();
        private void SelectedPlayAll() => SelectedPlaySaveAll(prmPlay: true, prmSave: false);
        private void SelectedSaveAll() => SelectedPlaySaveAll(prmPlay: false, prmSave: true);

        private void SelectedPlaySaveAll(bool prmPlay, bool prmSave)
        {

            Editor.Batch.Start();
            
            foreach (ScriptCLI Script in Editor.Select)
            {

                if (pagEdition.FindNodeScript(Script))
                {
                    Editor.Batch.Set(Script);

                    if (prmPlay)
                        ScriptPlay();

                    if (prmSave)
                        ScriptSave();
                }
            }

            Editor.Batch.End();

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

        public bool ToConfirm(string prmText, string prmLabel)
        {
            return MessageBox.Show(prmText, prmLabel, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        //MessageBox.Show("Do you really want to close ?", "Exit Application", MessageBoxButtons.YesNo) == DialogResult.No)
        

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
