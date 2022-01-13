using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using Dooggy.Factory;
using System.Windows.Forms;
using MassaTestes;
using System.Drawing;

namespace PainelTestes
{

    public delegate void Notify_ScriptSelecionado();

    public class TestPainelScript : TestPainelAssistent
    {

        public event Notify_ScriptSelecionado ScriptSelecionado;

        public void Setup(string prmPathINI, string prmPathDestino)
        {

            ConectarDataBase();

            Setup(prmPathINI, prmPathDestino, prmStart: false);

            ModoAssitente(this);

        }

        public void OnScriptSelecionado()
        {
            ScriptSelecionado?.Invoke();
        }

    }

    public class TestPainelAssistent : TestPainelConfig
    {

        private frmTestScriptPainel FormPainel;

        public void ModoAssitente(TestPainelScript prmPainel)
        {

            FormPainel = new frmTestScriptPainel();

            FormPainel.Setup(prmPainel);

        }

    } 

    public class TestPainelConfig : TestPainelConectDB
    {

        private Font FontPadrao;
        
        public TestPainelConfig()
        {

            FontPadrao = new Font("Consolas",12);

        }

        public void SetPadrao(TextBox prmTextBox) => SetPadrao(prmTextBox, prmEditavel: false);
        public void SetPadrao(TextBox prmTextBox, bool prmEditavel)
        {

            SetControl(prmTextBox);

            prmTextBox.WordWrap = false;
            prmTextBox.Multiline = true;

            prmTextBox.ScrollBars = ScrollBars.Both;

            prmTextBox.Enabled = false;

            prmTextBox.ReadOnly = !prmEditavel;

        }
        public void SetPadrao(TreeView prmTreeView)
        {

            SetControl(prmTreeView);

            prmTreeView.LabelEdit = true;

            prmTreeView.Scrollable = true;

        }
        private void SetControl(Control prmControle)
        {

            prmControle.Font = FontPadrao;

            prmControle.BackColor = Color.LightYellow;

        }

    }

    public class TestPainelConectDB : TestDataProject
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
