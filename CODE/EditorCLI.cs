using Dooggy;
using Dooggy.Factory;
using Dooggy.Factory.Console;
using Dooggy.Factory.Data;
using Dooggy.Lib.Files;
using Dooggy.Lib.Generic;
using Dooggy.Tools.Util;
using Rocket.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Rocket
{


    public delegate void Notify_ProjectDBConnect();

    public delegate void Notify_ProjectNew();

    public delegate void Notify_ProjectOpen(string prmArquivoCFG);
    public delegate void Notify_ProjectClose();
    public delegate void Notify_ProjectReset();
   
    public delegate void Notify_ProjectExit();

    public delegate void Notify_MultiSelect(bool prmAtivar);

    public delegate void Notify_BatchSet(ScriptCLI prmScript);
    public delegate void Notify_BatchEnd();

    public delegate void Notify_SelectedPlayAll();
    public delegate void Notify_SelectedSaveAll();

    public delegate void Notify_ScriptCodeChecked(string prmScript, bool prmChecked);

    public delegate void Notify_ScriptCodeLocked();
    public delegate void Notify_ScriptCodeSelect();
    public delegate void Notify_ScriptCodeChanged();

    public delegate void Notify_ScriptCodePlay();
    public delegate void Notify_ScriptCodeSave();
    public delegate void Notify_ScriptCodeUndo();

    public delegate void Notify_ScriptPlayEnd();
    public delegate void Notify_ScriptPlayStop();

    public delegate void Notify_ScriptLogOk();
    public delegate void Notify_ScriptLogError();

    public delegate void Notify_ScriptLogClipBoard(string prmLog);

    public class EditorCLI : EditorAction
    {
        public EditorCLI()
        {

            Project = new ProjectCLI(this);

            Select = new EditorSelect(this);

            Import = new EditorImport(this);

            Format = new EditorFormat(this);

            Page = new EditorPageCLI(this);

            Cor = new EditorColor();

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

        public void OnMultiSelect(bool prmAtivar)
        {
            MultiSelect?.Invoke(prmAtivar);
        }
        public void OnProjectOpen(string prmArquivoCFG)
        {

            SetAction(String.Format("Project loading: {0} ...", Import.file_name));

            ProjectOpen?.Invoke(prmArquivoCFG); 
            
            SetAction(String.Format("Project loaded: {0} ...", Import.file_name));

            OnProjectDBConnect();

        }
        public void OnProjectClose()
        {
            ProjectClose?.Invoke();

            SetAction(String.Format("Project closed: {0} ...", Import.file_name));
        }
        public void OnProjectReset()
        {
            ProjectReset?.Invoke();

            SetAction(String.Format("Project refresh: {0} ...", Project.nome));
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

        public bool Start() { Page.MainShow(); return true; }
        public bool Start(string prmArquivoCFG) => Console.Setup(prmArquivoCFG,prmPlay:true);

        public void Open(string prmArquivoCFG) 
        {
            Console.Setup(prmArquivoCFG); Reset();

        }
        public void Close() 
        { 
            Setup(); Reset();

            SetAction(String.Format("Project closed: {0} ...", Import.file_name));
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
        public void Reset() => Project.Reset();

        public void CodeBatchStart() => Batch.Start();
        public void CodeBatchSet(ScriptCLI prmScript) { Batch.Set(prmScript); OnBatchSet(prmScript); }
        public void CodeBatchEnd() { Batch.End(); Select.Reset(); OnBatchEnd(); }

        public void SelScript(string prmName, bool prmChecked) => Select.SetScript(prmName, prmChecked);

        public bool SetScript(ScriptCLI prmScript) => Project.SetScript(prmScript);
        public bool SetScript(string prmName) => Project.SetScript(prmName);

        public void CodeLocked(bool prmLocked) { Script.SetLocked(prmLocked); OnScriptCodeChanged(); }
        public void CodeLocked() { Script.SetLocked(); OnScriptCodeChanged(); }
        public void CodeSave() { Script.SaveCode(); OnScriptCodeChanged(); }
        public void CodeUndo() { Script.UndoCode(); OnScriptCodeChanged(); }

        public void CodePlayStart() { Script.PlayCode(); }
        public void CodePlayStop() { Script.PlayStop(); OnScriptCodeChanged(); }
        public void CodePlayEnd() { Script.PlayEnd(); }

        public void SetAction(string prmTexto) => Page.SetAction(prmTexto);

        public ScriptCLI GetScript(string prmName) => Project.GetScript(prmName);

    }

    public class EditorMode : EditorBase
    {
        public ScriptCLI Script => Project.Script;

        public TestConsole Console => Factory.Console;

        public TestResult Result => Console.Result;
        public TestDataLocal Dados => Console.Dados;
        public TestConsoleConfig Config => Console.Config;

        public bool IsDbOK => Console.IsDbOK;

        public bool IsMultiSelection => Select.IsMultiSelection;

        public bool TemProject => Project.IsLoad;
        public bool TemScript => Project.TemScript;

        public bool TemSelect => Select.IsFull;

        public bool IsMassaDados => TemScript && ICanPlay;

        public bool IsFree => !IsRunning;
        public bool IsRunning => Batch.IsRunning;

        public bool IsPlaying { get { if (TemScript) return Script.IsPlaying; return false; } }

        public bool ICanExit => !IsPlaying;

        public bool ICanBatch => TemSelect && IsMultiSelection;

        public bool ICanOpen => !TemProject && ICanExit;
        public bool ICanClose => TemProject && ICanExit;
        public bool ICanRefresh => ICanClose;

        public bool ICanMultiSelect => ICanClose;
        public bool ICanPlay => IsDbOK && Project.TemScripts;

        public bool ICanPlayAll => IsMultiSelection && ICanPlay && Select.IsFull;
        public bool ICanSaveAll => ICanPlayAll;

    }

    public class EditorBase
    {
        public TestDataProject Factory;

        public ProjectCLI Project;

        public EditorPageCLI Page;

        public EditorSelect Select;

        public EditorImport Import;

        public EditorFormat Format;

        public EditorColor Cor;

        public EditorBatch Batch => Select.Batch;

        public void Setup() => Factory = new TestDataProject();

    }
    public class EditorSelect : List<ScriptCLI>
    {
        public EditorCLI Editor;

        public EditorBatch Batch;

        public bool IsMultiSelection;

        public bool IsFull => (qtde > 0);
        private int qtde => Count;

        public EditorSelect(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Batch = new EditorBatch(this);
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

    public class EditorBatch
    {
        private EditorSelect Select;

        private EditorCLI Editor => Select.Editor;

        public ScriptCLI Script;

        public bool IsRunning;

        public int cont;
        public int qtde => Select.Count;
        private string txt_progresso => String.Format("{0} de {1}", cont, qtde);

        public EditorBatch(EditorSelect prmSelect)
        {
            Select = prmSelect;
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

        }
        public void End()
        {

            IsRunning = false;

            Editor.SetAction("Batch ended ...");

        }

    }
    public class EditorImport
    {
        private EditorCLI Editor;

        private string fileCFG;

        public string file_name => System.IO.Path.GetFileName(fileCFG);
        public string file_path => System.IO.Path.GetDirectoryName(fileCFG);

        public EditorImport(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        [STAThread]
        public void SelectFileCFG()
        {

            myFileDialog Selecao = new myFileDialog();

            Selecao.Dialog.Filter = "Config files (*.cfg)|*.cfg";

            if (Selecao.Open() == DialogResult.OK)
            {
                fileCFG = Selecao.Dialog.FileName;

                Editor.OnProjectOpen(prmArquivoCFG: fileCFG);
            }

        }

    }
    public class EditorFormat
    {

        private EditorCLI Editor;

        private Font FontPath;
        private Font FontPadrao;
        private Font FontTreeView;

        public EditorColor ColorCLI;

        public EditorFormat(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Setup();

        }

        private void Setup()
        {

            string nameFontDefault = "Consolas";

            FontPath = new Font(nameFontDefault, 8);

            FontPadrao = new Font(nameFontDefault, 12);

            FontTreeView = new Font(nameFontDefault, 11);

            ColorCLI = new EditorColor();

        }

        public void SetPadrao(Button prmBotao)
        {
            prmBotao.BackColor = Color.DimGray;
            prmBotao.ForeColor = Color.White;

            prmBotao.FlatStyle = FlatStyle.Flat;
        }
        public void SetPadrao(TextBox prmTextBox, bool prmEditavel)
        {
            prmTextBox.Font = FontPath;

            prmTextBox.ReadOnly = !prmEditavel;
        }
        public void SetMemo(TextBox prmTextBox)
        {
            SetControl(prmTextBox);

            prmTextBox.WordWrap = false;
            prmTextBox.Multiline = true;

            prmTextBox.ScrollBars = ScrollBars.Both;

            prmTextBox.ReadOnly = true;
        }
        public void SetPadrao(ListView prmListView)
        {
            SetControl(prmListView);

            prmListView.LabelEdit = false;

            prmListView.HideSelection = false;

            prmListView.FullRowSelect = true;

            prmListView.Scrollable = true;
        }
        public void SetPadrao(TreeView prmTreeView)
        {
            SetControl(prmTreeView, FontTreeView);

            prmTreeView.LabelEdit = false;

            prmTreeView.HideSelection = false;

            prmTreeView.FullRowSelect = true;

            prmTreeView.Scrollable = true;
        }

        public void SetPadrao(Splitter prmSeparador)
        {
            prmSeparador.BackColor = Color.DimGray;

            prmSeparador.Size = new Size(6, 6);
        }

        public void SetPadrao(ToolStrip prmStatus) => SetPadrao(prmStatus, prmVisible: true);
        public void SetPadrao(ToolStrip prmStatus, bool prmVisible)
        {
            prmStatus.Visible = prmVisible;

            prmStatus.Refresh();
        }

        public void SetPadrao(usrTitulo prmTitulo)
        {
            prmTitulo.BackColor = Color.Aquamarine;
            prmTitulo.ForeColor = Color.White;
        }

        private void SetControl(Control prmControle) => SetControl(prmControle, prmFont: FontPadrao);
        private void SetControl(Control prmControle, Font prmFont)
        {
            prmControle.Font = prmFont;

            prmControle.BackColor = Color.White;
        }

        public void SetTurnOnOff(bool prmON, ToolStripButton prmObjectA, ToolStripButton prmObjectB, ToolStripLabel prmObjectC) => SetTurnOnOff(prmON, prmObjectA, prmObjectB, prmAtive: prmObjectC.Visible);
        public void SetTurnOnOff(bool prmON, ToolStripButton prmObjectA, ToolStripButton prmObjectB) => SetTurnOnOff(prmON, prmObjectA, prmObjectB, prmAtive: true);
        public void SetTurnOnOff(bool prmON, ToolStripButton prmObjectA, ToolStripButton prmObjectB, bool prmAtive)
        {
            prmObjectA.Visible = prmON && prmAtive; prmObjectB.Visible = !prmON && prmAtive;
        }
    }
    public class EditorColor
    {
        public Color cor_frente_consulta => Color.Black;
        public Color cor_frente_edicao => Color.DarkGreen;
        public Color cor_frente_modificado => Color.DarkBlue;
        public Color cor_frente_erro => Color.DarkRed;

        public Color cor_fundo_padrao => Color.White;
        public Color cor_fundo_empty => Color.SeaShell;
        public Color cor_fundo_erro => Color.LightYellow;

    }

    public class TestTimeOut
    {

        private static System.Timers.Timer aTimer;

        private static void SetTimer(int prmSeconds)
        {
            // Create a timer with a two second interval.
            //x = new Timer(GetInterval(prmSeconds));

            aTimer = new System.Timers.Timer(GetInterval(prmSeconds));

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static int GetInterval(int prmSeconds) => (prmSeconds * 1000);

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }

    }

}
