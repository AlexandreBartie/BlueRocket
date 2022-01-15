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

    public delegate void Notify_ProjectPlayAll();
    public delegate void Notify_ProjectSaveAll();
    public delegate void Notify_ProjectRefresh();
    public delegate void Notify_ProjectExit();

    public delegate void Notify_RootSelected();

    public delegate void Notify_ScriptChanged();

    public delegate void Notify_ScriptPlay();
    public delegate void Notify_ScriptSave();
    public delegate void Notify_ScriptUndo();

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


    }
    public class EditorEvents : EditorMode
    {

        public event Notify_ProjectRefresh ProjectRefresh;

        public event Notify_RootSelected RootSelected;

        public event Notify_ScriptChanged ScriptChanged;

        public event Notify_ScriptPlay ScriptPlay;
        public event Notify_ScriptSave ScriptSave;
        public event Notify_ScriptUndo ScriptUndo;

        public void OnProjectRefresh()
        {
            ProjectRefresh?.Invoke();
        }

        public void OnRootSelected()
        {
            RootSelected?.Invoke();
        }

        public void OnScriptChecked(bool prmHabilitar)
        {
            SetEnabled(prmHabilitar); OnScriptChanged();
        }

        public void OnScriptChanged()
        {
            ScriptChanged?.Invoke();
        }

        public void OnScriptPlay()
        {
            ScriptPlay?.Invoke();
        }

        public void OnScriptSave()
        {
            ScriptSave?.Invoke();
        }

        public void OnScriptUndo()
        {
            ScriptUndo?.Invoke();
        }

        public bool SetScript(string prmKey) => Scripts.Find(prmKey);

        public void SetEnabled(bool prmHabilitar) => Script.SetEnabled(prmHabilitar);

    }
    public class EditorMode
    {

        public PainelCLI Painel;

        public TestScripts Scripts;

        public EditorConfig Config;

        public TestScript Script => Scripts.Corrente;

        public TestConsole Console => Painel.Console;

        public bool TemScript => (Script != null);
        public bool TemScripts => (Scripts.Count > 0);

        public EditorMode()
        {

            Config = new EditorConfig();

        }

        public Color GetForeColor()
        {
            
            if (Script.IsEnabled)
                if (Script.IsChanged)
                    return Config.ColorCode.cor_modificado;
                else
                    return Config.ColorCode.cor_habilitada;

            return Config.ColorCode.cor_consulta;
        }
    }
    public class EditorConfig
    {

        private Font FontPadrao;
        private Font FontTreeView;

        public EditorConfigColor ColorCode;

        public EditorConfig()
        {

            FontPadrao = new Font("Consolas", 12);

            FontTreeView= new Font("Consolas", 10);

            ColorCode = new EditorConfigColor();

        }

        public void SetPadrao(TextBox prmTextBox) => SetPadrao(prmTextBox, prmEditavel: false);
        public void SetPadrao(Button prmBotao)
        {

            prmBotao.BackColor = Color.Black;
            prmBotao.ForeColor = Color.White;

            prmBotao.FlatStyle = FlatStyle.Flat;

        }
        public void SetPadrao(TextBox prmTextBox, bool prmEditavel)
        {

            SetControl(prmTextBox);

            prmTextBox.WordWrap = false;
            prmTextBox.Multiline = true;

            prmTextBox.ScrollBars = ScrollBars.Both;

            prmTextBox.ReadOnly = !prmEditavel;

        }
        public void SetPadrao(TreeView prmTreeView)
        {

            SetControl(prmTreeView, FontTreeView);

            prmTreeView.LabelEdit = false;

            prmTreeView.FullRowSelect = true;

            prmTreeView.CheckBoxes = true;

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
        public void SetPadrao(usrActionScript prmAction)
        {

            prmAction.BackColor = Color.Aquamarine;

        }

        private void SetControl(Control prmControle) => SetControl(prmControle, prmFont: FontPadrao);
        private void SetControl(Control prmControle, Font prmFont)
        {

            prmControle.Font = prmFont;

            prmControle.BackColor = Color.LightYellow;

        }

    }
    public class EditorConfigColor
    {
        public Color cor_consulta => Color.Black;
        public Color cor_habilitada => Color.Green;
        public Color cor_modificado => Color.Blue;
        public Color cor_erro => Color.Red;

    }
    public class TestScript
    {

        private TestConsoleScript Script;

        private TestConsole Console => Script.Console;
        public TestConsoleLog Log => Script.Log;


        public string name => Log.name_INI;

        public string code;

        public string title => Log.name_INI + title_ext;
        private string title_ext { get { if (IsChanged) return "(*)"; return ""; } }

        public bool IsEnabled = false;
        public bool IsCanPlay => (IsChanged && IsDBOk);
        public bool IsChanged => (code != Log.code);

        private bool IsDBOk => Console.IsDbOK;

        public TestScript(TestConsoleScript prmScript)
        {

            Script = prmScript;

            SetCode(Log.code);

        }

        public void SetCode(string prmCode) => code = prmCode;
        public void SetEnabled(bool prmHabilitar) => IsEnabled = prmHabilitar;

        public void PlayCode() => Console.Play(code);
        public bool SaveCode() => Console.SaveCode(prmCode: code);
        public void UndoCode() => SetCode(prmCode: Log.code);

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

            Editor.Console.Load();

            foreach (TestConsoleScript Script in Editor.Console.Scripts)
                Add(Script);

        }

        private void Add(TestConsoleScript prmScript) => base.Add(new TestScript(prmScript));

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
