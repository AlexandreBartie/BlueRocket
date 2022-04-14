using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueRocket
{

    public class EditorCLI : EditorAction
    {
        
        public EditorCLI(AppCLI prmApp) : base(prmApp)
        {

            App = prmApp;

            Project = new ProjectCLI(this);

            Filter = new FilterCLI(this);

            Select = new SelectCLI(this);

            View = new ViewCLI(this);

            Setup();
        }

    }
    public class EditorAction : EditorMode
    {
        public event Notify_MultiSelect MultiSelect;

        public event Notify_ProjectNew NewWindow;

        public event Notify_ProjectOpen ProjectOpen;
        public event Notify_ProjectClose ProjectClose;
        public event Notify_ProjectReset ProjectReset;
        public event Notify_ProjectExit ProjectExit;

        public event Notify_ProjectDBConnect ProjectDBConnect;

        public event Notify_FilterTagChanged FilterTagChanged;
        public event Notify_FilterTagChecked FilterTagChecked;

        public event Notify_SelectedPlayAll SelectedLockedAll;
        public event Notify_SelectedSaveAll SelectedUnlockedAll;

        public event Notify_SelectedPlayAll SelectedPlayAll;
        public event Notify_SelectedSaveAll SelectedSaveAll;

        public event Notify_BatchSet BatchSet;
        public event Notify_BatchEnd BatchEnd;

        public event Notify_ScriptCodeChecked ScriptCodeChecked;

        public event Notify_ScriptCodeLocked ScriptCodeLocked;
        public event Notify_ScriptCodeSelect ScriptCodeSelect;
        public event Notify_ScriptCodeChanged ScriptCodeChanged;

        public event Notify_ScriptCodePlay ScriptCodePlay;
        public event Notify_ScriptCodeSave ScriptCodeSave;
        public event Notify_ScriptCodeUndo ScriptCodeUndo;

        public event Notify_ScriptPlayEnd ScriptPlayEnd;
        public event Notify_ScriptPlayStop ScriptPlayStop;

        public event Notify_ScriptLogOk ScriptLogOK;
        public event Notify_ScriptLogError ScriptLogError;

        public event Notify_ScriptLogClipBoard ScriptLogClipBoard;

        public EditorAction(AppCLI prmApp) : base(prmApp)
        { }

        public void OnMultiSelect(bool prmAtivar)
        {
            MultiSelect?.Invoke(prmAtivar);
        }
        public void OnProjectOpen()
        {  
            Page.MainHide();
            
            Page.StartShow();
        }
        
        public void OnProjectOpen(string prmFileCFG)
        {

            Page.MainShow();

            SetAction(String.Format("Project loading: {0} ...", Load.project_file));

            ProjectOpen?.Invoke(prmFileCFG); 
            
            SetAction(String.Format("Project loaded: {0} ...", Load.project_file));

            OnProjectDBConnect();

            Page.MainShow(prmPinned: true);

        }
        public void OnProjectClose()
        {
            ProjectClose?.Invoke();

            SetAction(String.Format("Project closed: {0} ...", Load.project_file));
        }
        public void OnProjectReset()
        {
            ProjectReset?.Invoke();

            SetAction(String.Format("Project refresh: {0} ...", Load.project_file));
        }
        public void OneNewWindow()
        {
            NewWindow?.Invoke();
        }
        public void OnProjectExit()
        {
            ProjectExit?.Invoke();
        }
        public void OnProjectDBConnect()
        {
            ProjectDBConnect?.Invoke();
        }
        public void OnSelectedLockedAll()
        {
            SelectedLockedAll?.Invoke();
        }
        public void OnSelectedUnlockedAll()
        {
            SelectedUnlockedAll?.Invoke();
        }
        public void OnSelectedPlayAll()
        {
            SelectedPlayAll?.Invoke();
        }
        public void OnSelectedSaveAll()
        {
            SelectedSaveAll?.Invoke();
        }
        public void OnBatchSet(ScriptCLI prmScript)
        {
            BatchSet?.Invoke(prmScript);
        }
        public void OnBatchEnd()
        {
            BatchEnd?.Invoke();
        }
        public void OnScriptCodeChecked(string prmScript, bool prmChecked)
        {
            ScriptCodeChecked?.Invoke(prmScript, prmChecked);

         }
        public void OnFilterTagChecked(string prmTag, string prmOption, bool prmChecked)
        {
            FilterTagChecked?.Invoke(prmTag, prmOption, prmChecked); 
        }
        public void OnFilterTagChanged()
        {
            FilterTagChanged?.Invoke();
        }
        public void OnScriptCodeSelect()
        {
            ScriptCodeSelect?.Invoke();

            SetAction(String.Format("Script select: {0} ...", Script.title));
        }
        public void OnScriptCodeEditing()
        {
            SetAction(String.Format("Script editing: {0} ...", Script.title));
        }
        public void OnScriptCodeChanged()
        {
            ScriptCodeChanged?.Invoke();
        }
        public void OnScriptCodeLocked()
        {
            ScriptCodeLocked?.Invoke();
        }
        public void OnScriptCodePlay()
        {
            SetAction(String.Format("Script playing: {0} ...", Script.title));

            ScriptCodePlay?.Invoke();

            SetAction(String.Format("Script played: {0} ...", Script.title));
        }
        public void OnScriptCodeSave()
        {
            ScriptCodeSave?.Invoke();
        }
        public void OnScriptPlaySave()
        {
            OnScriptCodePlay(); ScriptCodeSave?.Invoke();
        }
        public void OnScriptCodeUndo()
        {
            ScriptCodeUndo?.Invoke();
        }
        public void OnScriptPlayStop()
        {
            ScriptPlayStop?.Invoke();
        }
        public void OnScriptPlayEnd()
        {
            ScriptPlayEnd?.Invoke();
        }
        public void OnScriptResultOK()
        {
            ScriptLogOK?.Invoke();
        }
        public void OnScriptResultError()
        {
            ScriptLogError?.Invoke();
        }
        public void OnScriptLogClipBoard(String prmLog)
        {
            ScriptLogClipBoard?.Invoke(prmLog);
        }

        public bool Show() { Page.StartShow(); return true; }
        public bool Show(string prmArquivoCFG) { Page.StartShow(prmArquivoCFG); return true; }
        public bool Start(string prmArquivoCFG) => Console.Setup(prmArquivoCFG, prmPlay: true);

        public bool Setup(string prmArquivoCFG) 
        {
            if (Console.Setup(prmArquivoCFG))
            {
                Build();

                return true;
            }

            return false;
        }
        public void Close() 
        { 
            Setup(); Build();

            SetAction(String.Format("Project closed: {0} ...", Load.project_file));
        }
        public void New() => Setup();

        public void DoConnect()
        {
            SetAction("DataBase Connecting ...");

            if (Dados.DoConnect())
                SetAction("DataBase Connected...");
            else
                SetAction("DataBase ERROR ...");
        }

        public void PlayStart()
        {
            Script.PlayStart();
            
            OnScriptCodeChanged();
        }
        
        public void Build() { Project.Setup(); Filter.Setup(); }

        //public void PagePaintStart() => Page.Start();
        //public void PagePaintEnd() => Page.End();

        public void SelScript(string prmName, bool prmChecked) => Select.SetScript(prmName, prmChecked);

        public bool SetScript(ScriptCLI prmScript) => Project.SetScript(prmScript);
        public bool SetScript(string prmName) => Project.SetScript(prmName);

        public void CodeLocked(bool prmLocked) { Script.SetLocked(prmLocked); OnScriptCodeChanged(); }
        public void CodeLocked() { Script.SetLocked(); OnScriptCodeChanged(); }

        public void CodeTagged(string prmName, string prmValue) { Script.SetLocked(); OnScriptCodeChanged(); }

        public void CodeSave() { Script.SaveCode(); OnScriptCodeChanged(); }
        public void CodeUndo() { Script.UndoCode(); OnScriptCodeChanged(); }

        public void CodePlayStart() { Script.PlayCode(); }
        public void CodePlayStop() { Script.PlayStop(); OnScriptCodeChanged(); }
        public void CodePlayEnd() { Script.PlayEnd(); }

        public void SetAction(string prmTexto) => Page.SetAction(prmTexto);
        public ScriptCLI GetScript(string prmName) => Project.GetScript(prmName);
        public DataTagOption GetTagOption(string prmTag, string prmOption) => Project.GetTagOption(prmTag, prmOption);

    }
    public class EditorMode : EditorBase
    {
        public ScriptCLI Script => Project.Script;

        public TestConsole Console => Factory.Console;

        public TestResult Result => Console.Result;
        public DataSource Dados => Console.Dados;
        public TestConsoleConfig Config => Console.Config;

        public DataTags MainTAGs => Config.Global.Tags;

        public EditorMode(AppCLI prmApp) : base(prmApp)
        { }

        public bool IsDbOK => Console.IsDbOK;

        public bool IsMultiSelection => Select.IsMultiSelection;

        public bool TemProject => Project.IsLoad;
        public bool TemScript => Project.TemScript;

        public bool TemAtivos => Project.TemAtivos;
        public bool TemSelect => Select.IsFull;

        public bool IsMassaDados => TemScript && ICanPlay;

        public bool IsFree => !(IsRunning); // || IsPainting);
        //public bool IsPainting => Page.IsPainting;
        public bool IsRunning => Batch.IsRunning;
        public bool IsWorking => Load.IsWorking;
        public bool IsPlaying { get { if (TemScript) return Script.IsPlaying; return false; } }

        public bool ICanExit => !IsPlaying;

        public bool ICanBatch => TemSelect && IsMultiSelection;

        public bool ICanOpen => !TemProject && ICanExit;
        public bool ICanClose => TemProject && ICanExit;
        public bool ICanRefresh => ICanClose;

        public bool ICanMultiSelect => ICanClose;
        public bool ICanPlay => IsDbOK && Project.TemAtivos;

        public bool ICanPlayAll => IsMultiSelection && ICanPlay && Select.IsFull;
        public bool ICanSaveAll => ICanPlayAll;

    }
    public class EditorBase
    {
        public TestDataProject Factory;

        public AppCLI App;
        public AppPage Page => App.Page;
        public LoadCLI Load => App.Load;

        public AppFormat Format => App.Format;
        public AppColor Cor => App.Cor;

        public ProjectCLI Project;

        public SelectCLI Select;

        public FilterCLI Filter;

        public ViewCLI View;

        public BatchCLI Batch;

        public EditorBase(AppCLI prmApp)
        {
            App = prmApp;
        }

         public void Setup() => Factory = new TestDataProject();

    }

    public class FilterCLI : DataTagOptions
    {
        public EditorCLI Editor;

        public DataTags Tags => Editor.Project.Tags;

        private DataTagOption GetTagOption(string prmTag, string prmOption) => Editor.GetTagOption(prmTag, prmOption);

        public FilterCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }
        public void Setup()
        {
            Reset();

            foreach (myTagOption Option in Tags.GetAll())
                Add(new DataTagOption(Option));
        }

        public void Reset() => this.Clear();
        public void SetTagOption(string prmTag, string prmOption, bool prmChecked)
        {
            if (prmChecked)
                AddTagOption(prmTag, prmOption);
            else
                DelTagOption(prmTag, prmOption);
        }
        private void AddTagOption(string prmTag, string prmOption)
        {
            try
            { 
                DataTagOption Option = Editor.GetTagOption(prmTag, prmOption);

                Add(Option);
                
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };

        }
        private void DelTagOption(string prmTag, string prmOption)
        {
            try
            {
                DataTagOption Option = Editor.GetTagOption(prmTag, prmOption);

                Remove(Option);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };
        }

        public bool IsMatch(string prmTag, string prmOption)
        {
            foreach (myTagOption Option in this)
                if (!Option.IsMatch(prmTag, prmOption))
                   return false;
            return true;
        }

    }
    public class SelectCLI : List<ScriptCLI>
    {
        public EditorCLI Editor;

        public bool IsMultiSelection;

        public bool IsFull => (qtde > 0);
        private int qtde => Count;

        public SelectCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void Reset() { IsMultiSelection = false; Clear(); }

        public bool SetMultiSelection(bool prmAtivar) { IsMultiSelection = prmAtivar; Clear(); return prmAtivar; }

        public void SetScript(string prmKey, bool prmChecked)
        {

            Editor.SetScript(prmKey);
            
            if (prmChecked)
                AddScript(prmKey);
            else
                DelScript(prmKey);
        }
        private void AddScript(string prmKey) => Add(Editor.GetScript(prmKey));
        private void DelScript(string prmKey) => Remove(Editor.GetScript(prmKey));
        private new void Clear() { if (!IsMultiSelection) base.Clear(); }

    }
    public class ViewCLI
    {
        public EditorCLI Editor;

        public enum eViewMain : int
        {
            eViewEdition = 0,
            eViewProcess = 1,
        }


        private eViewMain view = eViewMain.eViewEdition;

        public bool IsEdition => view == eViewMain.eViewEdition;
        public bool IsProcess => view == eViewMain.eViewProcess;

        public ViewCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public bool SetView(TabControl prmTabs)
        {

            view = (eViewMain)prmTabs.SelectedIndex;

            string text;

            if (Editor.TemProject)
                text = "Process";
            else
                text = "...";

            prmTabs.TabPages[(int)eViewMain.eViewProcess].Text = text;

            return (IsProcess);
        }

    }
    public class BatchCLI
    {
        private EditorCLI Editor;

        private SelectCLI Select => Editor.Select;

        public ScriptCLI Script;

        public bool IsRunning;

        public int cont;
        public int qtde => Select.Count;
        private string txt_progresso => String.Format("{0} de {1}", cont, qtde);

        public BatchCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void Start()
        {
            IsRunning = true; cont = 0;

            Editor.SetAction("Batch started ...");
        }
        public void Set(ScriptCLI prmScript)
        {
            cont += 1; Script = prmScript;

            Editor.OnScriptCodeSelect();

            Editor.OnBatchSet(prmScript);
        }
        public void End()
        {
            IsRunning = false;

            Editor.SetAction("Batch ended ...");

            Select.Reset();

            Editor.OnBatchEnd();
        }

    }

}
