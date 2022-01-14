using Dooggy;
using Dooggy.Factory.Console;
using DooggyCLI.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DooggyCLI
{
    public delegate void Notify_EditorExit();
    public delegate void Notify_EditorRefresh();
    public delegate void Notify_EditorSaveAll();

    public delegate void Notify_RootINISelected();

    public delegate void Notify_ScriptSelected();
    public delegate void Notify_ScriptCodeChanged();
    public delegate void Notify_ScriptCodeSave();
    public delegate void Notify_ScriptCodeUndo();

    public class EditorScripts : EditorEvents
    {

        public TestConsoleLog Log => Scripts.Corrente.Log;

        public EditorScripts(PainelCLI prmPainel)
        {

            Painel = prmPainel;

        }

        private void Setup() => Scripts = new TestScripts(this);

        public void Refresh() => Setup();

        public void SetCode(string prmCode) => Script.SetCode(prmCode);

        public bool SetScript(string prmKey) => Scripts.Find(prmKey);

    }
    public class EditorEvents : EditorMode
    {

        public event Notify_RootINISelected RootINISelected;

        public event Notify_ScriptSelected ScriptSelected;
        public event Notify_ScriptCodeChanged ScriptCodeChanged;
        public event Notify_ScriptCodeSave ScriptCodeSave;
        public event Notify_ScriptCodeUndo ScriptCodeUndo;

        public void OnRootINISelected()
        {
            RootINISelected?.Invoke();
        }

        public void OnScriptSelected()
        {
            ScriptSelected?.Invoke();
        }

        public void OnScriptCodeChanged()
        {

            //SetModoEdicao(prmON: true);

            ScriptCodeChanged?.Invoke();
        }

        public void OnScriptCodeSave()
        {
            ScriptCodeSave?.Invoke();
        }

        public void OnScriptCodeUndo()
        {
            ScriptCodeUndo?.Invoke();
        }
    }
    public class EditorMode
    {

        public PainelCLI Painel;

        public TestScripts Scripts;

        public EditorConfig Config;

        public TestScript Script => Scripts.Corrente;

        public TestConsole Console => Painel.Console;

        //public bool IsEdicao;

        //public void SetModoEdicao(bool prmON) => IsEdicao = IsEdicao || prmON;

        public EditorMode()
        {

            Config = new EditorConfig();

        }

        public Color GetForeColor()
        {
            if (Script.IsChanged)
                return Config.ColorCode.cor_modificado;
            else
                return Config.ColorCode.cor_consulta;
        }
    }
    public class EditorConfig
    {

        private Font FontPadrao;

        public EditorConfigColor ColorCode;

        public EditorConfig()
        {

            FontPadrao = new Font("Consolas", 12);

            ColorCode = new EditorConfigColor();

        }

        public void SetPadrao(TextBox prmTextBox) => SetPadrao(prmTextBox, prmEditavel: false);
        public void SetPadrao(TextBox prmTextBox, bool prmEditavel)
        {

            SetControl(prmTextBox);

            prmTextBox.WordWrap = false;
            prmTextBox.Multiline = true;

            prmTextBox.ScrollBars = ScrollBars.Both;

            prmTextBox.Enabled = true;

            prmTextBox.ReadOnly = !prmEditavel;

        }
        public void SetPadrao(TreeView prmTreeView)
        {

            SetControl(prmTreeView);

            prmTreeView.LabelEdit = false;

            prmTreeView.FullRowSelect = true;

            prmTreeView.Scrollable = true;

        }

        public void SetPadrao(Splitter prmSeparador)
        {

            prmSeparador.BackColor = Color.Gray;

            prmSeparador.Size = new Size(6, 6);

        }

        public void SetPadrao(usrTitulo prmTitulo)
        {

            prmTitulo.BackColor = Color.Aquamarine;
            prmTitulo.ForeColor = Color.White;

        }
        private void SetControl(Control prmControle)
        {

            prmControle.Font = FontPadrao;

            prmControle.BackColor = Color.LightYellow;

        }

    }
    public class EditorConfigColor
    {
        public Color cor_consulta => Color.Black;
        public Color cor_modificado => Color.Blue;
        public Color cor_erro => Color.Red;

    }
    public class TestScript
    {

        private TestConsoleScript Script;

        public string name => Log.nome_INI;

        public string code;

        public TestConsoleLog Log => Script.Log;

        public bool IsChanged => (code != Log.code);

        public TestScript(TestConsoleScript prmScript)
        {

            Script = prmScript;

            SetCode(Log.code);

        }

        public void SetCode(string prmCode) => code = prmCode;

    }

    public class TestScripts : List<TestScript>
    {

        private EditorScripts Editor;

        public TestScript Corrente;

        public TestScripts(EditorScripts prmEditor)
        {

            Editor = prmEditor;

            Popular();

        }

        private void Popular()
        {

            foreach (TestConsoleScript Script in Editor.Console.GetScripts())
                Add(Script);

        }

        private void Add(TestConsoleScript prmScript) => base.Add(new TestScript(prmScript));

        public bool Find(string prmName)
        {

            foreach (TestScript Script in this)
                
                if (xString.IsEqual(Script.name, prmName))
                {

                    Corrente = Script;

                    return true;

                }

            return false;

        }


    }

}
