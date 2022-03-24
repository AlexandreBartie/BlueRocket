using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class ProjectCLI
    {

        private EditorCLI Editor;

        public ScriptsCLI Scripts;

        public TagsCLI Tags;

        public ScriptCLI Script => Scripts.Corrente;

        public bool TemScript => (Script != null);
        public bool TemScripts => (Scripts.Count > 0);

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

        public void Reset()
        {
            Scripts = new ScriptsCLI(Editor);

            Tags = new TagsCLI(Editor);

        }

        public bool SetScript(ScriptCLI prmScript) => Scripts.SetScript(prmScript);
        public bool SetScript(string prmName) => Scripts.SetScript(GetScript(prmName));

        public ScriptCLI GetScript(string prmName) => Scripts.GetScript(prmName);

    }

    public class ScriptCLI
    {
        private TestScript Script;

        public EditorCLI Editor;

        public ColorScriptCLI Cor;

        private TestConsole Console => Script.Console;
        public TestResult Result => Script.Result;

        public string name => Result.name_INI;
        public string code => Result.code;

        public string title => name + GetTitleExt();

        public bool IsMatch(string prmTexto) => myString.IsEqual(name, prmTexto);

        public bool IsPlaying = false;

        public bool IsLocked = true;
        public bool IsChanged => (Result.IsChanged);
        public bool IsResult => (Result.IsData);

        public bool IsLogOK => IsResult && !Result.IsError;
        public bool IsLogError => (Result.IsError);

        public bool ICanEdit => (!IsLocked);

        public bool ICanPlay => (Editor.ICanPlay && !IsPlaying);
        public bool ICanPlaySave => ICanPlay && IsChanged;

        public bool ICanSave => IsChanged;
        public bool ICanUndo => IsChanged;

        public ScriptCLI(TestScript prmScript, EditorCLI prmEditor)
        {
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

    }
    public class ScriptsCLI : List<ScriptCLI>
    {

        private EditorCLI Editor;

        private TestConsole Console => Editor.Console;

        public ScriptCLI Corrente;

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

        private void Add(TestScript prmScript) => base.Add(new ScriptCLI(prmScript, Editor));

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

                if (myString.IsEqual(Script.name, prmKey))
                    return Script;

            return null;
        }

        private bool Sincronizar() => Console.SetScript(prmKey: Corrente.name);

    }
    public class TagCLI
    {
        private myDominio Tag;

        public EditorCLI Editor;

        public string name => Tag.key;

        public OptionsTagCLI Options;

        public ColorTagCLI Cor;

        public bool IsAtivo => GetAtivo();
        public bool IsEqual(string prmName) => Tag.IsEqual(prmName);

        public TagCLI(myDominio prmTAG, EditorCLI prmEditor)
        {
            Tag = prmTAG;

            Editor = prmEditor;

            Options = new OptionsTagCLI(this, prmTAG.Opcoes);

            Cor = new ColorTagCLI(this);
        }

        public void SetAtivo(string prmOption, bool prmAtivo) => Options.SetAtivo(prmOption, prmAtivo);

        private bool GetAtivo()
        {
            foreach (OptionTagCLI Option in Options)
                if (Option.ativo)
                    return true;

            return false;
        }

    }

    public class TagsCLI : List<TagCLI>
    {

        private EditorCLI Editor;

        public OptionsTagCLI Todos => GetTodos();
        public OptionsTagCLI Ativos => GetTodos(prmFiltrar: true);

        public TagsCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Popular();
        }
        private void Popular()
        {
            foreach (myDominio Tag in Editor.Config.Global.Tags)
                AddItem(Tag);
        }

        private void AddItem(myDominio prmTag) => base.Add(new TagCLI(prmTag, Editor));

        public void SetAtivo(string prmName, string prmOption, bool prmAtivo)
        {
            foreach (TagCLI Tag in this)

                if (Tag.IsEqual(prmName))
                    { Tag.SetAtivo(prmOption, prmAtivo); break; }
        }

        private OptionsTagCLI GetTodos() => GetTodos(prmFiltrar: false);
        private OptionsTagCLI GetTodos(bool prmFiltrar)
        {
            OptionsTagCLI itens = new OptionsTagCLI();

            foreach (TagCLI Tag in this)
            {
                foreach (OptionTagCLI item in Tag.Options)
                    if (item.ativo || !prmFiltrar)
                        itens.Add(item);
            }
            return itens;
        }
    }

    public class OptionTagCLI
    {

        private TagCLI Tag;

        public EditorCLI Editor => Tag.Editor;

        public string value;

        public bool ativo;
        public string log => String.Format("{0}: {1}", Tag.name, value);

        public bool IsEqual(string prmValue) => myString.IsEqual(value, prmValue);

        public ColorOptionTagCLI Cor;

        public OptionTagCLI(TagCLI prmTag, string prmValue)
        {
            Parse(prmTag, prmValue);

            Cor = new ColorOptionTagCLI(this);
        }

        public void Parse(TagCLI prmTag, string prmValue)
        {
            Tag = prmTag;

            value = prmValue;
        }
        public void SetAtivo(bool prmAtivo) => ativo = prmAtivo;

    }

    public class OptionsTagCLI : List<OptionTagCLI>
    {
        
        private TagCLI Tag;

        public string log => GetLOG();

        public OptionsTagCLI() { }

        public OptionsTagCLI(TagCLI prmTag, xLista prmOptions)
        {
            Parse(prmTag, prmOptions);
        }

        private void Parse(TagCLI prmTag, xLista prmOptions)
        {
            Tag = prmTag;

            Popular(prmOptions);
        }
        private void Popular(xLista prmOptions)
        {
            foreach (string item in prmOptions)
                Add(new OptionTagCLI(Tag, prmValue: item));

        }
        public void SetAtivo(string prmOption, bool prmAtivo)
        {
            foreach (OptionTagCLI Option in this)
                if (Option.IsEqual(prmOption))
                    { Option.SetAtivo(prmAtivo); break; }
        }

        private string GetLOG()
        {
            xLinhas txt = new xLinhas();

            foreach (OptionTagCLI Option in this)
                txt.Add(Option.log);

            return txt.memo;

        }

    }

}
