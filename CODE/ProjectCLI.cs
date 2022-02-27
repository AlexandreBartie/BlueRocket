using Dooggy;
using Dooggy.Factory.Console;
using Dooggy.Lib.Vars;
using Dooggy.Tools.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Rocket
{
    public class ProjectCLI
    {

        private EditorCLI Editor;

        public ScriptsCLI Scripts;

        public ScriptCLI Script => Scripts.Corrente;

        public bool TemScript => (Script != null);
        public bool TemScripts => (Scripts.Count > 0);

        public TestConfigImport Import => Editor.Config.Import;

        public bool IsLoad => Import.IsOK;
        public string nome => Import.nome;

        public ProjectCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void Reset() => Scripts = new ScriptsCLI(Editor);

        public bool SetScript(ScriptCLI prmScript) => Scripts.SetScript(prmScript);
        public bool SetScript(string prmName) => Scripts.SetScript(GetScript(prmName));

        public ScriptCLI GetScript(string prmName) => Scripts.GetScript(prmName);

    }

    public class ScriptCLI
    {
        private TestScript Script;

        public EditorCLI Editor;

        public ScriptCLIColor Cor;

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

            Cor = new ScriptCLIColor(this);
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
    public class ScriptCLIColor
    {
        private ScriptCLI ScriptCLI;

        private EditorFormat Format => ScriptCLI.Editor.Format;

        public ScriptCLIColor(ScriptCLI prmScriptCLI)
        {
            ScriptCLI = prmScriptCLI;
        }

        public myColor GetCodeColor()
        {
            return new myColor(GetCodeForeColor(), GetCodeBackColor());
        }
        public Color GetCodeForeColor()
        {
            if (!ScriptCLI.IsLocked)

                if (ScriptCLI.IsChanged)
                    return Format.ColorCLI.cor_frente_modificado;
                else
                    return Format.ColorCLI.cor_frente_edicao;

            return Format.ColorCLI.cor_frente_consulta;
        }
        public Color GetCodeBackColor()
        {
            if (ScriptCLI.IsLogError)
                return Format.ColorCLI.cor_fundo_erro;

            return Format.ColorCLI.cor_fundo_padrao;
        }
        public Color GetLogForeColor()
        {
            if (ScriptCLI.IsLogError)
                return Format.ColorCLI.cor_frente_erro;

            return GetCodeForeColor();
        }
        public Color GetLogBackColor()
        {

            if (!ScriptCLI.IsResult)
                return Format.ColorCLI.cor_fundo_empty;

            return Format.ColorCLI.cor_fundo_padrao;
        }
        public Color GetItemLogForeColor(string prmTipo)
        {

            if (myString.IsEqual(prmTipo, "erro"))
                return Format.ColorCLI.cor_frente_erro;

            return GetCodeForeColor();
        }

    }

    public class ScriptsCLI : List<ScriptCLI>
    {

        private EditorCLI Editor;

        public ScriptCLI Corrente;

        public ScriptsCLI(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Popular();

        }

        private void Popular()
        {

            Editor.Console.Load();

            foreach (TestScript Script in Editor.Console.Scripts)
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

        private bool Sincronizar() => Editor.Console.SetScript(prmKey: Corrente.name);

    }
}
