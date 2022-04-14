using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class AppCLI
    {

        private EditorCLI Editor;

        public RegisterCLI Register;

        public LoadCLI Load;

        public AppPage Page;

        public AppFormat Format;

        public AppColor Cor;


        public AppCLI()
        {
            Editor = new EditorCLI(this);

            Register = new RegisterCLI(this);

            Load = new LoadCLI(this);

            Format = new AppFormat(Editor);

            Cor = new AppColor(Editor);

            Page = new AppPage(Editor);

        }

        public void Start() => Editor.Show();
        public void Start(string prmArquivoCFG) => Editor.Show(prmArquivoCFG);

        public void Batch(string prmArquivoCFG) => Editor.Start(prmArquivoCFG);

    }

    public class AppFormat
    {

        private EditorCLI Editor;

        private Font FontPadrao;
        private Font FontTreeView;

        public AppFormat(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            SetFontes();

        }

        private void SetFontes()
        {

            string nameFontDefault = "Cascadia Code";

            FontPadrao = new Font(nameFontDefault, 12);

            FontTreeView = new Font(nameFontDefault, 11);

        }

        public void SetPadrao(Button prmBotao)
        {
            prmBotao.BackColor = Color.DimGray;
            prmBotao.ForeColor = Color.Black;

            prmBotao.FlatStyle = FlatStyle.Flat;
        }
        public void SetPadrao(TextBox prmTextBox, bool prmEditavel)
        {
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

            prmListView.View = View.Details;

            prmListView.HideSelection = false;

            prmListView.FullRowSelect = true;

            prmListView.Scrollable = true;

        }

        public void SetPadrao(TreeView prmTreeView) => SetPadrao(prmTreeView, prmCheckBoxes: false);
        public void SetPadrao(TreeView prmTreeView, bool prmCheckBoxes)
        {
            SetControl(prmTreeView, FontTreeView);

            prmTreeView.CheckBoxes = prmCheckBoxes;

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
            prmTitulo.BackColor = Color.Yellow;
            prmTitulo.ForeColor = Color.Black;
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

    public class AppColor : ColorEditorCLI
    {
        public AppColor(EditorCLI prmEditor) : base(prmEditor)
        {
            Editor = prmEditor;
        }
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
            //Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }

    }



}
