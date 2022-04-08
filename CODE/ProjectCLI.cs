using Dooggy.CORE;
using Dooggy.LIBRARY;
using System.Collections.Generic;

namespace BlueRocket
{
    public class ProjectCLI
    {

        public EditorCLI Editor;

        public ScriptsCLI Scripts;

        public DataTags Tags => Editor.Config.Global.Tags;

        public ScriptCLI Script => Scripts.Corrente;

        public bool TemScript => (Script != null);
        public bool TemScripts => (Scripts.TemScripts);
        public bool TemAtivos => (IsLoad && Scripts.TemAtivos);

        public TestConsole Console => Editor.Console;
        public TestConsoleConfig Config => Editor.Config;
        public TestConfigImport Import => Config.Import;

        public bool ICanPlay => Editor.ICanPlay;
        public bool IsLoad => Import.IsOK;
        public string nome => Import.FileCFG.nome;

        public ProjectCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void Setup()
        {
            Scripts = new ScriptsCLI(Editor);
        }

        public bool SetScript(ScriptCLI prmScript) => Scripts.SetScript(prmScript);
        public bool SetScript(string prmName) => Scripts.SetScript(GetScript(prmName));

        public ScriptCLI GetScript(string prmName) => Scripts.GetScript(prmName);

        public DataTagOption GetTagOption(string prmTag, string prmOption) => (DataTagOption)Tags.Options.Find(prmTag, prmOption);

        public string GetConsoleTitle()
        {
            if (IsLoad)
                return nome;

            return "Selecionar Projeto (*.cfg)";
        }

    }

    public class ScriptCLI
    {
        private TestScript Script;

        public EditorCLI Editor;

        public DataTags Tags => Script.Tags;

        public ColorScriptCLI Cor;

        private TestConsole Console => Script.Console;

        public TestResult Result => Script.Result;

        private int id;

        public string key => myFormat.GetKey(id, 3);

        public string name => Result.name_INI;

        public int qtdSql => Result.SQL.qtde;

        public string qtdTests => Result.SQL.qtdTestsTXT;
        public string timeSeconds => Result.SQL.timeSecondsTXT;
        public string timeAverage => Result.SQL.timeAverageTXT;
        public string timeBigger => Result.SQL.timeBiggerTXT;

        public string code => Result.code;

        public string title => name + GetTitleExt();

        public string status => GetStatus();

        public string filtro => myBool.GetYesNo(IsAtived);

        public bool IsMatch(string prmTexto) => myString.IsMatch(name, prmTexto);

        public bool IsAtived => GetActived();

        public bool IsPlaying = false;

        public bool IsLocked = true;
        public bool IsChanged => (Result.IsChanged);
        public bool IsResult => (Result.IsData);

        public bool IsLogOK => IsResult && !Result.IsError;
        public bool IsLogError => (Result.IsError);

        public bool IsSlow => (Result.IsSlow);
        public bool ICanEdit => (!IsLocked);

        public bool ICanPlay => (Editor.ICanPlay && !IsPlaying);
        public bool ICanPlaySave => ICanPlay && IsChanged;

        public bool ICanSave => IsChanged;
        public bool ICanUndo => IsChanged;

        public ScriptCLI(int prmId, TestScript prmScript, EditorCLI prmEditor)
        {

            id = prmId;
            
            Script = prmScript;

            Editor = prmEditor;

            Cor = new ColorScriptCLI(this);
        }

        public void SetLocked(bool prmLocked) { IsLocked = prmLocked; }
        public void SetLocked() { IsLocked = !IsLocked; }

        public void PlayCode() { Console.Play(code, name); }
        public bool SaveCode() => Console.SaveCode(code);
        public void UndoCode() => Console.UndoCode();

        public void PlayStart() => SetPlaying(prmStart: true);
        public void PlayStop() => SetPlaying(prmStart: false);
        public void PlayEnd() => SetPlaying(prmStart: false);

        private void SetPlaying(bool prmStart) => IsPlaying = prmStart;

        private string GetTitleExt()
        {

            if (IsPlaying) return "(!)";

            if (IsChanged) return "(*)";

            return "";

        }

        private bool GetActived()
        {
            foreach (myTag Tag in Script.Tags)
                if (!Editor.Filter.IsMatch(Tag.name, Tag.value))
                    return false;

            return true;
        }

        private string GetStatus()
        {
            if (IsLogError)
                return "Erro";
            else if (IsResult)
                return "OK";

            return "-";
        }
    }
    public class ScriptsCLI : List<ScriptCLI>
    {

        private EditorCLI Editor;

        private TestConsole Console => Editor.Console;

        public ScriptCLI Corrente;

        public bool TemScripts => (Count > 0);

        private int idNext => Count + 1;

        public bool TemAtivos => Ativos.TemScripts;

        public ScriptsCLI Ativos => GetAtivos();

        public ScriptsCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Popular();
        }

        private void Popular()
        {
            foreach (TestScript Script in Console.Scripts)
                Add(Script);
        }

        private void Add(TestScript prmScript) => base.Add(new ScriptCLI(prmId: idNext, prmScript, Editor));

        public bool SetScript(ScriptCLI prmScript)
        {
            if (prmScript != null)
            {
                Corrente = prmScript;

                return Sincronizar();
            }

            return false;
        }

        public ScriptCLI GetScript(string prmKey)
        {
            foreach (ScriptCLI Script in this)

                if (Script.IsMatch(prmKey))
                    return Script;

            return null;
        }

        private bool Sincronizar() => Console.SetScript(prmKey: Corrente.name);

        private ScriptsCLI GetAtivos()
        {
            ScriptsCLI itens = new ScriptsCLI(Editor);

            foreach (ScriptCLI item in this)
                if (item.IsAtived)
                    itens.Add(item);
            return itens;
        }

    }

}
