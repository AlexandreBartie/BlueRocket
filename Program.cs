using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DooggyCLI
{
    static class Program
    {

        static PainelCLI Painel;

        [STAThread]
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("Programa: {0} - Versão: {1}", Application.ProductName, Application.ProductVersion));

            ArgsGerador Args = new ArgsGerador();

            try
            {

                Args.path_ini = @"c:\MassaTestes\POC\CLI\INI\";
                Args.path_out = @"C:\MassaTestes\POC\CLI\OUT\";
                Args.db = @"{ 'branch': '1085', 'port': '1521', 'service': 'INTEGRATION.Prod01.redelocal.oraclevcn.com' }";

                ModoExecucao(Args);

            }
            catch
            {

                Console.WriteLine("Por favor, informe o modo + path_INI + path_OUT + parâmetros do banco de dados (formato json) ...");
                Console.WriteLine("Siga o exemplo abaixo ...");

                Console.WriteLine(Application.ProductName + "<modo> <path_ini> <path_out> " + @"{ 'branch': '1085', 'port': '1521' }");

            }

        }

        static void ModoExecucao(ArgsGerador prmArgs)
        {

            string formato = "-ini: {0} -out: {1} -db: {2}";


            Console.WriteLine(string.Format(formato, prmArgs.path_ini, prmArgs.path_out, prmArgs.db));

            try
            {

                string arquivoCFG = @"C:\MassaTestes\POC\CLI\Integracao-SIA.cfg";

                Painel = new PainelCLI();

                Painel.SetApp(prmArgs.db, prmNomeApp: Application.ProductName, prmVersaoApp: Application.ProductVersion);

                Painel.Start(arquivoCFG);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };

        }

    }

    internal class ArgsGerador
    {

        public string path_ini;
        public string path_out;
        public string db;

    }

}
