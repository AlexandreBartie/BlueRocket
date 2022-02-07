using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DooggyCLI
{
    static class Program
    {

        static EditorCLI Editor;
        
        static string arquivoCFG = @"C:\MassaTestes\VICTOR\victuor.cfg";
        //static string arquivoCFG = @"C:\MassaTestes\POC\CLI\projeto-teste.cfg";

        [STAThread]
        static void Main(string[] args)
        {
          
            Console.WriteLine(string.Format("Programa: {0} - Versão: {1}", Application.ProductName, Application.ProductVersion));

            try
            {

                ModoExecucao(arquivoCFG);

            }
            catch
            {

                Console.WriteLine("Por favor, informe o arquivo de configuração (.cfg) ...");
                Console.WriteLine("Siga o exemplo abaixo ...");

                Console.WriteLine(Application.ProductName + @"C:\MassaTestes\projetoAlpha.cfg");

            }

        }

        static void ModoExecucao(string prmArquivoCFG)
        {

            try
            {

                Editor = new EditorCLI();

                Editor.Start(); // prmArquivoCFG);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };

        }

    }

}
