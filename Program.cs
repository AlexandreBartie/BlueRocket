using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace BlueRocket
{
    static class Program
    {

        static AppCLI App;
        
        //static string arquivoCFG = @"C:\MassaTestes\VICTOR\victor.cfg";
        //static string arquivoCFG = @"C:\MassaTestes\POC\CLI\projeto-teste.cfg";

       [STAThread]
        static void Main(string[] args)
        {

            App = new AppCLI();

            Console.WriteLine(string.Format("Programa: {0} - Versão: {1}", Application.ProductName, Application.ProductVersion));

            try
            {
                if (args.Length == 0)
                    ModoApp();
                else
                    ModoGerador(prmArquivoCFG: args[0]);
            }
            catch
            {

                Console.WriteLine("Por favor, informe o arquivo de configuração (.cfg) ...");
                Console.WriteLine("Siga o exemplo abaixo ...");

                Console.WriteLine(Application.ProductName + @"C:\MassaTestes\projetoAlpha.cfg");

            }

        }

        static void ModoApp()
        {
            try
            {
                if (false)
                    App.Start();
                else
                    App.Open(@"C:\MassaTestes\TestQA.cfg");
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };
        }

        static void ModoGerador(string prmArquivoCFG)
        {
            try
            {
                App.Play(prmArquivoCFG);
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };
        }

    }

}
