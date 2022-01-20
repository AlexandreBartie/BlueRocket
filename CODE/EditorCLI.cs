using Dooggy;
using Dooggy.Factory.Console;
using Dooggy.Lib.Files;
using Dooggy.Lib.Generic;
using DooggyCLI.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI
{

    public delegate void Notify_MultiSelection();

    public delegate void Notify_ProjectPlayAll();
    public delegate void Notify_ProjectSaveAll();
    public delegate void Notify_ProjectRefresh();
    public delegate void Notify_ProjectExit();

    public delegate void Notify_ScriptLocked();
    public delegate void Notify_ScriptChanged();

    public delegate void Notify_CodePlay();
    public delegate void Notify_CodeSave();
    public delegate void Notify_CodeUndo();

    public class EditorCLI : EditorEvents
    {

        public TestConsoleResult Result => Scripts.Corrente.Result;

        public EditorCLI(PainelCLI prmPainel)
        {

            Painel = prmPainel;

        }

        public void Show() => Painel.Page.EditorShow();
        public void Refresh() => Scripts = new TestScripts(this);

    }
    public class EditorEvents : EditorMode
    {

        public event Notify_MultiSelection MultiSelection;

        public event Notify_ProjectRefresh ProjectRefresh;
        public event Notify_ProjectPlayAll ProjectPlayAll;
        public event Notify_ProjectSaveAll ProjectSaveAll;

        public event Notify_ScriptLocked ScriptLocked;
        public event Notify_ScriptChanged ScriptChanged;

        public event Notify_CodePlay CodePlay;
        public event Notify_CodeSave CodeSave;
        public event Notify_CodeUndo CodeUndo;

        public void OnMultiSelection(bool prmAtivar)
        {
            IsMultiSelection = prmAtivar;  MultiSelection?.Invoke();
        }

        public void OnProjectRefresh()
        {
            ProjectRefresh?.Invoke();
        }

        public void OnScriptLocked()
        {
            ScriptLocked?.Invoke();
        }

        public void OnScriptChanged()
        {
            ScriptChanged?.Invoke();
        }

        public void OnCodePlay()
        {
            CodePlay?.Invoke();
        }

        public void OnPlaySave()
        {
            OnCodePlay(); CodeSave?.Invoke();
        }

        public void OnCodeSave()
        {
            CodeSave?.Invoke();
        }
        public void OnCodeUndo()
        {
            CodeUndo?.Invoke();
        }

        public bool SetScript(string prmKey) => Scripts.Find(prmKey);

    }
    public class EditorMode
    {

        public PainelCLI Painel;

        public TestScripts Scripts;

        public PainelFormat Format => Painel.Format;

        public TestScript Script => Scripts.Corrente;

        public TestConsole Console => Painel.Console;

        public bool IsCodePlaying;

        public bool IsMultiSelection;

        public bool IsDbOk => Console.IsDbOK;

        public bool ICanPlay => IsDbOk && TemScripts && !IsCodePlaying;

        public bool ICanPlayAll => ICanPlay;
        public bool ICanSaveAll => ICanPlay;

        public bool TemScript => (Script != null);
        public bool TemScripts => (Scripts.Count > 0);

        public Color GetColorCode()
        {
            
            if (!Script.IsLocked)

                if (Script.IsChanged)
                    return Format.ColorCLI.cor_modificado;
                else
                    return Format.ColorCLI.cor_habilitada;

            return Format.ColorCLI.cor_consulta;
        }

        public Color GetColorLog()
        {

            if (Script.IsError && IsDbOk)
                return Format.ColorCLI.cor_erro;

            return GetColorCode();
        }

    }

    public class TestScript
    {
        private EditorCLI Editor;

        private TestConsoleScript Script;

        private TestConsole Console => Script.Console;
        public TestConsoleResult Result => Script.Result;

        public string name => Result.name_INI;
        public string code => Result.code;

        public string title => name + title_ext;
        private string title_ext { get { if (IsChanged) return "(*)"; return ""; } }


        public bool IsLocked = true;
        public bool IsChanged => (Result.IsChanged);
        public bool IsResult => (Result.IsData);
        public bool IsError => (Result.IsError);

        public bool ICanEdit => (!IsLocked);

        public bool ICanPlay => (Editor.ICanPlay && !Editor.IsCodePlaying && (IsChanged || !IsResult));
        public bool ICanPlaySave => ICanPlay;

        public bool ICanSave => IsChanged;
        public bool ICanUndo => IsChanged;

        public TestScript(TestConsoleScript prmScript, EditorCLI prmEditor)
        {

            Script = prmScript;

            Editor = prmEditor;

        }

        public void SetLocked() => IsLocked = !IsLocked;
        public void PlayCode() => Console.Play(code, name);
        public bool SaveCode() => Console.SaveCode(code);
        public void UndoCode() => Console.UndoCode();

    }
    public class TestScripts : List<TestScript>
    {

        private EditorCLI Editor;

        public TestScript Corrente;

        public TestScripts(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Popular();

        }

        private void Popular()
        {

            Editor.Console.Load();

            foreach (TestConsoleScript Script in Editor.Console.Scripts)
                Add(Script);

        }

        private void Add(TestConsoleScript prmScript) => base.Add(new TestScript(prmScript, Editor));

        public bool Find(string prmKey)
        {

            foreach (TestScript Script in this)
                
                if (xString.IsEqual(Script.name, prmKey))
                {

                    Corrente = Script;

                    return Sincronizar();

                }

            return false;

        }

        private bool Sincronizar() => Editor.Console.SetScript(prmKey: Corrente.name);

    }

}
