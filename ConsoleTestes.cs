using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using Dooggy.Factory;
using System.Windows.Forms;
using MassaTestes;

namespace ConsoleTestes
{
    public class ConsoleScriptTestes : TestDataProject
    {
        public void ModoExecucao(string prmPathINI, string prmPathDestino)
        {

            ConectarDataBase();

            Setup(prmPathINI, prmPathDestino, prmStart: false);

            ModoAssitente();

        }

        private void ModoAssitente()
        {

            frmTestDataFactoryConsole Assistente = new frmTestDataFactoryConsole();

            Assistente.Iniciar(Console);

        }

        
        private void ConectarDataBase()
        {

            Connect.Oracle.user = args.GetValor("user", prmPadrao: "desenvolvedor_sia");
            Connect.Oracle.password = args.GetValor("password", prmPadrao: "asdfg");

            Connect.Oracle.host = args.GetValor("host", prmPadrao: "10.250.1.35");
            Connect.Oracle.port = args.GetValor("port", prmPadrao: "1521");

            string service = args.GetValor("service", prmPadrao: "");
            string stage = args.GetValor("stage", prmPadrao: "");

            if (service != "")
                Connect.Oracle.service = args.GetValor("service");

            else if(stage != "")
                Connect.Oracle.service = GetStage(prmStage: args.GetValor("stage"));

            else
                Connect.Oracle.service = GetBranch(prmBranch: args.GetValor("branch", prmPadrao: "1085"));

            Connect.Oracle.Add(prmTag: args.GetValor("tag", prmPadrao: "SIA"));

        }

        private string GetBranch(string prmBranch) => GetStage(prmStage: string.Format("branch_{0}", prmBranch));
        private string GetStage(string prmStage) => prmStage + ".prod01.redelocal.oraclevcn.com";

    }

}
