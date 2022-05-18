﻿using Dooggy;
using Katty;
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

            Painel = new PainelCLI(this);

            Setup();
        }

    }
    public class EditorAction : EditorMode
    {
        public event Notify_MultiSelect MultiSelect;

        public event Notify_FileNewWindow FileNewWindow;

        public event Notify_FileOpen FileOpen;
        public event Notify_FileClose FileClose;
        public event Notify_FileRefresh FileRefresh;
       // public event Notify_FileExit FileExit;

        public event Notify_ProjectDBConnect ProjectDBConnect;

        public event Notify_FilterTagChanged FilterTagChanged;
        public event Notify_FilterTagChecked FilterTagChecked;

        public event Notify_SelectedPlayAll SelectedLockedAll;
        public event Notify_SelectedSaveAll SelectedUnlockedAll;

        public event Notify_SelectedPlayAll SelectedPlayAll;
        public event Notify_SelectedSaveAll SelectedSaveAll;

        public event Notify_BatchStart BatchStart;
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
        
        public void OnFileOpen(string prmFileCFG)
        {

            Painel.Hide();

            SetAction(String.Format("Project loading: {0} ...", Load.project_name));

            FileOpen?.Invoke(prmFileCFG);

            SetAction(String.Format("Project loaded: {0} ...", Load.project_name));

            OnProjectDBConnect();

            Painel.Show();

        }
        public void OnFileClose()
        {
            FileClose?.Invoke();

            SetAction(String.Format("Project closed: {0} ...", Load.project_name));
        }
        public void OnFileRefresh()
        {
            FileRefresh?.Invoke();

            SetAction(String.Format("Project refresh: {0} ...", Load.project_name));
        }
        public void OnFileNewWindow()
        {
            FileNewWindow?.Invoke();
        }
        //public void OnFileExit()
        //{
        //    FileExit?.Invoke();
        //}
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
        public void OnBatchStart()
        {
            BatchStart?.Invoke();
        }

        public void OnBatchSet()
        {
            BatchSet?.Invoke();
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
            OnScriptCodeSave(); OnScriptCodePlay();
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
        public bool Open(string prmArquivoCFG) { Page.StartOpen(prmArquivoCFG); return true; }
        public bool Play(string prmArquivoCFG) => Console.Setup(prmArquivoCFG, prmPlay: true);

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

            SetAction(String.Format("Project closed: {0} ...", Load.project_name));
        }

        public void New() => Setup();
        //public void Exit() => App.Action.OnFileExit();

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

        public bool FindScript(ScriptCLI prmScript) => Painel.FindScript(prmScript);


        public bool SetScript(string prmName) => Project.SetScript(prmName);
        public bool SetScript(ScriptCLI prmScript) => Project.SetScript(prmScript);

        public bool SetFocus(ScriptCLI prmScript) => Project.SetScript(prmScript);

        public void CodeLocked(bool prmLocked) { Script.SetLocked(prmLocked); OnScriptCodeChanged(); }
        public void CodeLocked() { Script.SetLocked(); OnScriptCodeChanged(); }

        public void CodeTagged(string prmName, string prmValue) { Script.SetLocked(); OnScriptCodeChanged(); }

        public void CodeSave() { Script.SaveCode(); OnScriptCodeChanged(); }
        public void CodeUndo() { Script.UndoCode(); OnScriptCodeChanged(); }

        public void CodePlayStart() { Script.PlayCode(); }
        public void CodePlayStop() { Script.PlayStop(); OnScriptCodeChanged(); }
        public void CodePlayEnd() { Script.PlayEnd(); }

        public void SetAction(string prmTexto) => Painel.SetAction(prmTexto);
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

        public bool HasProject => Project.IsLoad;
        public bool HasScript => Project.HasScript;

        public bool HasAtivos => Project.HasAtivos;

        public bool IsMassaDados => HasScript && ICanPlay;

        public bool IsFree => !(IsRunning) && IsWorking;
        public bool IsRunning => Batch.IsRunning;
        public bool IsWorking => Load.IsWorking;
        public bool IsPlaying { get { if (HasScript) return Script.IsPlaying; return false; } }

        public bool ICanExit => !IsPlaying;

        public bool ICanBatch => View.ICanBatch;

        public bool ICanOpen => !HasProject && ICanExit;
        public bool ICanClose => HasProject && ICanExit;
        public bool ICanRefresh => ICanClose;

        public bool ICanMultiSelect => ICanClose;
        public bool ICanPlay => IsDbOK && Project.HasAtivos;

        public bool ICanPlayAll => ICanPlay && ICanBatch;
        public bool ICanSaveAll => ICanPlayAll;

    }
    public class EditorBase
    {
        public TestDataProject Factory;

        public AppCLI App;
        public AppPage Page => App.Page;
        public AppLoad Load => App.Load;

        public AppFormat Format => App.Format;
        public AppColor Cor => App.Cor;


        public PainelCLI Painel;

        public ProjectCLI Project => Painel.Project;
        public FilterCLI Filter => Painel.Filter;
        public BatchCLI Batch => Painel.Batch;
        public ViewCLI View => Painel.View;

        public EditorBase(AppCLI prmApp)
        {
            App = prmApp;
        }

         public void Setup() => Factory = new TestDataProject();

    }

}
