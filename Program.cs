using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsoleTestes
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("Programa: {0} - Versão: {1}", Application.ProductName, Application.ProductVersion));

            ArgsGerador Args = new ArgsGerador();

            try
            {

                Args.path_ini = @"c:\MassaTestes\POC\Console\INI\";
                Args.path_out = @"C:\MassaTestes\POC\Console\OUT\ConsoleTestes\";
                Args.db = @"{ 'branch': '1085', 'port': '1521', 'service': 'INTEGRATION.Prod01.redelocal.oraclevcn.com' }";

                ConsoleTestes(Args);

            }
            catch
            {

                Console.WriteLine("Por favor, informe o modo + path_INI + path_OUT + parâmetros do banco de dados (formato json) ...");
                Console.WriteLine("Siga o exemplo abaixo ...");

                Console.WriteLine(Application.ProductName + "<modo> <path_ini> <path_out> " + @"{ 'branch': '1085', 'port': '1521' }");

            }

        }

        static void ConsoleTestes(ArgsGerador prmArgs)
        {

            string formato = "-ini: {0} -out: {1} -db: {2}";


            Console.WriteLine(string.Format(formato, prmArgs.path_ini, prmArgs.path_out, prmArgs.db));

            try
            {

                ConsoleScriptTestes Projeto = new ConsoleScriptTestes();

                Projeto.SetApp(prmArgs.db, prmNomeApp: Application.ProductName, prmVersaoApp: Application.ProductVersion);

                Projeto.ModoExecucao(prmArgs.path_ini, prmArgs.path_out);

            }
            catch
            { }

        }

    }

    public class ArgsGerador
    {

        public string path_ini;
        public string path_out;
        public string db;

    }

}
