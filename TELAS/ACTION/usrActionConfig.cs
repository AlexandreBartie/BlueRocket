using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DooggyCLI.Telas
{
    public partial class usrActionConfig : UserControl
    {

        Thread td;

        private PainelCLI Painel;

        public usrActionConfig()
        {
            InitializeComponent();
        }
        private void cmdPath_Click(object sender, EventArgs e)
        {
            SelecionarArquivoCFG();
        }

        public void Setup(PainelCLI prmPainel)
        {
            Painel = prmPainel;

            Painel.Format.SetPadrao(txtPath, prmEditavel: false);
            Painel.Format.SetPadrao(cmdPath);

        }

        public new void Refresh()
        {

            txtPath.Text = Painel.Console.Config.Input.arquivoCFG;

        }

        private void TreadSelecionarArquivoCFG()
        {

            td = new Thread(new ThreadStart(this.SelecionarArquivoCFG));
            td.IsBackground = true;
            td.Start();

        }

        [STAThread]
        private void SelecionarArquivoCFG()
        {

            //OpenFileDialog painel = new OpenFileDialog();

            Invoker I = new Invoker();

            I.Dialog.Filter = "Config files (*.cfg)|*.cfg";

            if (I.Invoke() == DialogResult.OK)
            {
                Painel.OnProjectSelected(prmArquivoCFG: I.Dialog.FileName);
            }

        }

    }
    public class Invoker
    {
        
        public OpenFileDialog Dialog;

        private Thread Thread;
        private DialogResult Result;

        public Invoker()
        {
            Dialog = new OpenFileDialog();
            Thread = new Thread(new ThreadStart(InvokeMethod));
            Thread.SetApartmentState(ApartmentState.STA);
            Result = DialogResult.None;
        }

        public DialogResult Invoke()
        {
            Thread.Start();
            Thread.Join();
            return Result;
        }

        private void InvokeMethod()
        {
            Result = Dialog.ShowDialog();
        }
    }

}
