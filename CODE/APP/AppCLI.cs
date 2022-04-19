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

        public AppSession Session;

        public AppRegister Register;

        public AppAction Action;

        public AppLoad Load;

        public AppPage Page;

        public AppFormat Format;

        public AppColor Cor;

        public AppInfo Info;
        public AppCLI()
        {

            Register = new AppRegister(this);

            Session = new AppSession(this);

            Action = new AppAction(this);
 
            Load = new AppLoad(this);

            Page = new AppPage(this);

            Format = new AppFormat(this);

            Cor = new AppColor(this);

            Info = new AppInfo();

        }

        public bool IsWorking => Session.IsWorking;

        public void Start() => Session.Start();
        public void Open(string prmArquivoCFG) => Session.Open(prmArquivoCFG);
        public void Play(string prmArquivoCFG) => Session.Play(prmArquivoCFG);

    }

    public class AppAction
    {

        private AppCLI App;

        public AppAction(AppCLI prmApp)
        {
            App = prmApp;
        }
        public void OnProjectStart()
        {
            App.Page.PainelHide();

            App.Page.StartShow();

        }

        public void OnProjectFind()
        {
            App.Page.StartHide();

            App.Load.ProjectFind();

            Reset();
        }
        public void OnProjectDirect()
        {
            if (App.Load.IsDirect)
                OnProjectOpen(App.Load.Direct.project_file);
        }
        public void OnProjectOpen(string prmProject)
        {
            App.Page.StartHide();

            App.Load.ProjectOpen(prmProject);

        }
        public void OnProjectClose()
        {
            App.Load.ProjectClose();
        }

        public void OnProjectNew()
        {
            App.Session.NewSession();
        }

        public void OnProjectExit()
        {
            App.Load.ProjectExit();
            
            App.Page.StartClose();
        }

        private void Reset()
        {
            if (App.IsWorking)
                App.Page.StartShow();
            else
                App.Page.StartClose();
        }

    }

    public class AppSession : List<EditorCLI>
    {

        private AppCLI App;

        public EditorCLI Current;

        public PainelCLI Painel => Current.Painel;

        public AppSession(AppCLI prmApp)
        {
            App = prmApp; New();
        }

        public bool IsWorking => Current.IsWorking;

        private void New() => Current = new EditorCLI(App);

        public void Start()
        {
            //if (App.Load.TemHistory)
              //  Open(prmArquivoCFG: App.Load.project_lastAcess);
            //else
                Current.Show();
        }
        public void Open(string prmArquivoCFG) => Current.Open(prmArquivoCFG);
        public void Play(string prmArquivoCFG) => Current.Play(prmArquivoCFG);

        public void NewSession()
        {
            New(); Start();
        }

        public void EndSession()
        { 
            Remove(Current);

            if (Count != 0)
                Current = this[Count - 1];

        
        }

        public void OnProjectOpen(string prmArquivoCFG)
        {
            Current.OnProjectOpen(prmArquivoCFG);
        }

        public void OnProjectClose()
        {
            Current.OnProjectClose();
        }

    }
    public class AppFormat
    {

        private AppCLI App;

        private Font FontPadrao;
        private Font FontTreeView;

        public AppFormat(AppCLI prmApp)
        {
            App = prmApp;

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

    public class AppInfo
    {

        public string productName => Application.ProductName;
        public string productSplash => "blue rocket";
        public string productAbout => String.Format("About: {0}", productName);

        public string productVersion =>  Application.ProductVersion;
        public string productRelease => String.Format("release: {0}", productVersion);
        public string productYearRelease => "2022";

    }

}
