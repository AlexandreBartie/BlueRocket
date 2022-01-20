using System;
using System.Diagnostics;
using System.Collections.Generic;
using Dooggy.Factory;
using DooggyCLI.Telas;
using System.Drawing;
using System.Windows.Forms;

namespace DooggyCLI
{

    public delegate void Notify_ProjectSelected();

    public class PainelCLI : TestDataProject
    {

        public event Notify_ProjectSelected ProjectSelected;


        public EditorCLI Editor;

        public PainelFormat Format;

        public PageCLI Page;

        public bool SetProject(string prmArquivoCFG) => Console.Setup(prmArquivoCFG);


        public PainelCLI()
        {

            Editor = new EditorCLI(this);

            Format = new PainelFormat(this);

            Page = new PageCLI(this);

        }

        public void Start() => Page.PainelShow();
        public void Start(string prmArquivoCFG)
        {

            if (SetProject(prmArquivoCFG))
                Editor.Show();
            else
                Start();

        }

        public void OnProjectSelected(string prmArquivoCFG)
        {
            if (SetProject(prmArquivoCFG))
                ProjectSelected?.Invoke();

        }

    }

    public class PainelFormat
    {

        private PainelCLI Painel;

        private Font FontPath;
        private Font FontPadrao;
        private Font FontTreeView;

        public PainelColor ColorCLI;

        public PainelFormat(PainelCLI prmPainel)
        {

            Painel = prmPainel;

            Setup();

        }

        private void Setup()
        {

            string nameFontDefault = "Consolas";

            FontPath = new Font(nameFontDefault, 8);

            FontPadrao = new Font(nameFontDefault, 12);

            FontTreeView = new Font(nameFontDefault, 11);

            ColorCLI = new PainelColor();

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
        public void SetMemo(TextBox prmTextBox) => SetMemo(prmTextBox, prmEditavel: false);
        public void SetMemo(TextBox prmTextBox, bool prmEditavel)
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

            //prmStatus.BackColor = Color.Aquamarine;

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

        public void SetTurnOnOff(bool prmON, ToolStripButton prmObjectA, ToolStripButton prmObjectB)
        {
            prmObjectA.Visible = prmON; prmObjectB.Visible = !prmON;
        }

    }
    public class PainelColor
    {
        public Color cor_consulta => Color.Black;
        public Color cor_habilitada => Color.DarkGreen;
        public Color cor_modificado => Color.DarkBlue;// Color.Blue;
        public Color cor_erro => Color.DarkRed;

    }

    public class PainelConectDB : TestDataProject
    {

        public void ConectarDataBase()
        {

            Connect.Oracle.user = args.GetValor("user", prmPadrao: "desenvolvedor_sia");
            Connect.Oracle.password = args.GetValor("password", prmPadrao: "asdfg");

            Connect.Oracle.host = args.GetValor("host", prmPadrao: "10.250.1.35");
            Connect.Oracle.port = args.GetValor("port", prmPadrao: "1521");

            string service = args.GetValor("service", prmPadrao: "");
            string stage = args.GetValor("stage", prmPadrao: "");

            if (service != "")
                Connect.Oracle.service = args.GetValor("service");

            else if (stage != "")
                Connect.Oracle.service = GetStage(prmStage: args.GetValor("stage"));

            else
                Connect.Oracle.service = GetBranch(prmBranch: args.GetValor("branch", prmPadrao: "1085"));

            Connect.Oracle.Add(prmTag: args.GetValor("tag", prmPadrao: "SIA"));

        }
        private string GetBranch(string prmBranch) => GetStage(prmStage: string.Format("branch_{0}", prmBranch));
        private string GetStage(string prmStage) => prmStage + ".prod01.redelocal.oraclevcn.com";


    }

}
