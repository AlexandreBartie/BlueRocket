using BlueRocket;
using BlueRocket.UX;
using Katty;
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

    public partial class frmMainCLI : FormControl
    {

        private PanelMain Panel;

        private MainProject Project;

        private MainProcess Process;

        private MainThread Thread;

        internal PanelProject pagProject => Panel.pagProject;
        internal PanelEdition pagEdition => Panel.pagEdition;

        private void frmMainCLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = Project.AskForExit();
        }

        public bool IsMultiSelected => pagProject.IsMultiSelected;

        public bool FindScript(ScriptCLI prmScript) => pagProject.FindScript(prmScript);

        public void GetSelected() => pagProject.GetSelected();

        public frmMainCLI(EditorCLI prmEditor)
        {
            InitializeComponent();
            
            Panel = new PanelMain(this, prmEditor);

            Project = new MainProject(this);

            Process = new MainProcess(this);

            Thread = new MainThread(this);

            Editor.SelectedLockedAll += OnSelectedLockedAll;
            Editor.SelectedUnlockedAll += OnSelectedUnlockedAll;

            Editor.SelectedPlayAll += OnSelectedPlayAll;
            Editor.SelectedSaveAll += OnSelectedSaveAll;

            Editor.BatchStart += OnBatchStart;
            Editor.BatchSet += OnBatchSet;
            Editor.BatchEnd += OnBatchEnd;

            Editor.FileOpen += OnFileOpen;
            Editor.FileClose += OnFileClose;
            Editor.FileRefresh += OnFileRefresh;
            //Editor.FileExit += OnFileExit;

            Editor.ProjectDBConnect += OnProjectDBConnect;

            //Editor.FilterTagChanged += FilterTagChanged;
            Editor.FilterTagChecked += OnFilterTagChecked;

            //Editor.ScriptCodeChecked += ScriptChecked;

            Editor.ScriptCodeLocked += OnScriptLocked;
            Editor.ScriptCodeSelect += OnScriptView;
            Editor.ScriptCodeChanged += OnScriptView;

            Editor.ScriptCodePlay += OnScriptPlay;
           // Editor.ScriptPlayStop += OnScriptPlayStop;

            Editor.ScriptCodeSave += OnScriptSave;
            Editor.ScriptCodeUndo += OnScriptUndo;

            Editor.ScriptLogOK += OnScriptLogOK;
            Editor.ScriptLogError += OnScriptLogError;

            Editor.ScriptLogClipBoard += OnScriptLogClipBoard;

            usrMenu.Setup(prmEditor);
            usrStatus.Setup(prmEditor);

            Project.Setup();

        }

        private void OnProjectDBConnect() => Project.DBConnect();
        private void OnFileOpen(string prmArquivoCFG) => Project.Open(prmArquivoCFG);

        internal void OnFileClose() => Project.Close();
        internal void OnFileRefresh() { Project.Build(); MenuStatusView(); }
        internal void OnFileExit() { Close(); }

        internal void OnScriptLocked() => Editor.CodeLocked();
        private void OnFilterTagChecked(string prmTag, string prmOption, bool prmChecked) => Project.SetFilter(prmTag, prmOption, prmChecked);

        internal void OnScriptView() { pagProject.ViewCurrent(); pagEdition.View(); MenuStatusView(); }

        internal void OnScriptLogOK() => pagEdition.ViewResult(prmPage: ePageResult.ePageMassaDados);
        internal void OnScriptLogError() => pagEdition.ViewResult(prmPage: ePageResult.ePageLogErrors);

        private void OnScriptLogClipBoard(string prmLog) => Clipboard.SetText(prmLog);

        internal void OnScriptLocked(bool prmLocked) => Editor.CodeLocked(prmLocked);

        internal void OnScriptPlay() => Thread.Go();
        internal void OnScriptSave() => Editor.CodeSave();
        private void OnScriptUndo() => Editor.CodeUndo();

        private void OnSelectedLockedAll() => Process.SelectedAll(prmLocked: true);
        private void OnSelectedUnlockedAll() => Process.SelectedAll(prmLocked: false);

        private void OnSelectedPlayAll() => Process.SelectedPlaySaveAll(prmPlay: true, prmSave: false);
        private void OnSelectedSaveAll() => Process.SelectedPlaySaveAll(prmPlay: false, prmSave: true);

        private void OnBatchStart() => pagProject.ViewSelections();
        private void OnBatchSet() => pagProject.ViewCurrent();  

        private void OnBatchEnd() => usrMenu.Refresh();

        internal void MenuStatusView() { usrStatus.View(); usrMenu.View(); }

        public void SetAction(string prmTexto) => usrStatus.SetAction(prmTexto);

    }

    internal class MainProject : MainBase
    {

        public MainProject(frmMainCLI prmMain) : base(prmMain) { }

        internal void Setup()
        {

            Main.Text = Editor.App.Info.productName;

            Main.pagProject.Setup(Editor);
            Main.pagEdition.Setup(Editor);

            Editor.Build();

            Main.MenuStatusView();

        }

        internal void DBConnect()
        {
            Editor.DoConnect();

            Main.pagEdition.View();

            Main.MenuStatusView();
        }
        internal void Open(string prmArquivoCFG)
        {
            Editor.Setup(prmArquivoCFG);

            Build();
        }

        internal void Build()
        {
            Editor.Build();

            Main.pagProject.Build();

            Main.pagEdition.View();

        }

        internal void SetFilter(string prmTag, string prmOption, bool prmChecked)
        {
            Editor.Filter.SetTagOption(prmTag, prmOption, prmChecked);

            Main.pagProject.ViewAll(prmSetup: true);

            Main.MenuStatusView();
        }

        internal void Close()
        {

            if (Message.ToConfirm("Do you want to close your current project ?", "Close Project"))
            {
                Editor.Close();

                Main.OnFileRefresh();
            }
        }

        internal bool AskForExit()
        {
            if (Editor.HasProject)
                if (Message.ToConfirm("Do you really want to close this application?", "Exit Application"))
                    App.Action.OnFileExit();
                else
                    return true;
            return false;
        }
    }

    internal class MainProcess : MainBase
    {
        public MainProcess(frmMainCLI prmMain) : base(prmMain) { }

        internal void SelectedAll(bool prmLocked)
        {
            Editor.Batch.Start();

            foreach (ScriptCLI Script in Editor.Batch.Select)
                if (Editor.Batch.Set(Script))
                    Main.OnScriptLocked(prmLocked);

            Editor.Batch.End();
        }

        internal void SelectedPlaySaveAll(bool prmPlay, bool prmSave)
        {
            Editor.Batch.Start();

            foreach (ScriptCLI Script in Editor.Batch.Select)

                if (Editor.Batch.Set(Script))
                { 
                    if (prmPlay)
                        Main.OnScriptPlay();

                    if (prmSave)
                        Main.OnScriptSave();

                    Main.OnScriptView();

                }

            Editor.Batch.End();
        }

    }

    internal class MainThread : MainBase
    {

        private Thread thread;

        public MainThread(frmMainCLI prmMain) : base(prmMain) { }

        internal void Go()
        {
            if (!Editor.IsPlaying)
            {
                Editor.PlayStart();

                ScriptPlay_ByTHREAD();

                Editor.OnScriptCodeChanged();

                if (Editor.Script.IsLogOK)
                    Main.OnScriptLogOK();
                else
                    Main.OnScriptLogError();
            }

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

    }

    internal class MainBase
    {
        internal frmMainCLI Main;
        internal EditorCLI Editor => Main.Editor;

        internal AppCLI App => Editor.App;

        internal MainBase(frmMainCLI prmMain)
        {
            Main = prmMain;
        }
    
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
