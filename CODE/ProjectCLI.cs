﻿using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class ProjectCLI
    {

        public EditorCLI Editor;

        public ScriptsCLI Scripts;

        public TagsCLI Tags;

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
        public TestScriptTags Tags => Script.Tags;

        public string name => Result.name_INI;
        public string timeSeconds => Result.SQL.timeSecondsTXT;

        public string code => Result.code;

        public string title => name + GetTitleExt();

        public bool IsMatch(string prmTexto) => myString.IsEqual(name, prmTexto);

        public bool IsAtivo => GetAtivo();

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

        private bool GetAtivo()
        {
            foreach (TestScriptTag Tag in Script.Tags)
                if (!Editor.Filter.Ativos.GetAtivo(Tag.name,Tag.valor))
                        return false;

            return true;
        }

    }
    public class ScriptsCLI : List<ScriptCLI>
    {

        private EditorCLI Editor;

        private TestConsole Console => Editor.Console;

        public ScriptCLI Corrente;

        public bool TemScripts => (Count > 0);

        public bool TemAtivos => Ativos.TemScripts;

        public ScriptsCLI Todos => GetTodos();
        public ScriptsCLI Ativos => GetTodos(prmFiltrar: true);

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

                if (Script.IsMatch(prmKey))
                    return Script;

            return null;
        }

        private bool Sincronizar() => Console.SetScript(prmKey: Corrente.name);

        private ScriptsCLI GetTodos() => GetTodos(prmFiltrar: false);
        private ScriptsCLI GetTodos(bool prmFiltrar)
        {
            ScriptsCLI itens = new ScriptsCLI(Editor);

            foreach (ScriptCLI Tag in this)
            {
                foreach (ScriptCLI item in this)
                    if (item.IsAtivo || !prmFiltrar)
                        itens.Add(item);
            }
            return itens;
        }

    }

}
