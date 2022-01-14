using System;
using System.Diagnostics;
using System.Collections.Generic;
using Dooggy.Factory;
using DooggyCLI.Telas;

namespace DooggyCLI
{

    public class PainelCLI : PainelAssistent
    {

        public EditorScripts Editor;

        public PainelCLI()
        {

            Editor = new EditorScripts(this);

        }

        public void Setup(string prmPathINI, string prmPathDestino)
        {

            ConectarDataBase();

            Setup(prmPathINI, prmPathDestino, prmStart: false);

            ModoAssitente(Editor);

        }

    }

    public class PainelAssistent : PainelConectDB
    {

        private frmTestScriptPainel FormPainel;

        public void ModoAssitente(EditorScripts prmEditor)
        {

            FormPainel = new frmTestScriptPainel();

            FormPainel.Setup(prmEditor);

        }

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
