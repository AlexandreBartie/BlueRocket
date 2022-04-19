using BlueRocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class AppPage : AppPageBase
    {
         
        private AppPageAbout pagAbout;

        private AppPageStart pagStart;

        private PainelCLI Painel => App.Session.Painel;

        public Form GetFormStart() => pagStart.FormStart;

        public AppPage(AppCLI prmApp)
        {
            App = prmApp;

            pagAbout = new AppPageAbout();

            pagStart = new AppPageStart();
        }

        public void AboutShow() => pagAbout.Show();

        public void StartOpen(string prmArquivoCFG) => pagStart.Open(prmArquivoCFG);

        public void StartShow() => pagStart.Show();
        public void StartHide() => pagStart.Hide();
        public void StartClose() => pagStart.Close();

        public void PainelHide() => Painel.Hide();


    }
    public class AppPageStart : AppPageBase
    {

        private frmSplash FormSplash;

        internal frmStart FormStart;
        private bool IsStarting => (FormStart == null);

        public void Show()
        {
            if (IsStarting)
            {
                CreateFormSplash();

                CreateFormStart();
             }
            else
                FormStart.Show();
        }

        public void Open(string prmArquivoCFG)
        {
            App.Load.Direct.SetFileCFG(prmArquivoCFG);

            Show();
        }

        public void Hide() => FormStart.Hide();
        public void Close() => FormStart.Close();

        private void CreateFormSplash() => FormSplash = new frmSplash(App);
        private void CreateFormStart() 
        { 
            FormStart = new frmStart(App);

            Application.Run(FormStart);
        }

    }
    public class AppPageAbout : AppPageBase
    {

        private frmAboutBox FormLocal;

        public void Show() => FormLocal = new frmAboutBox(App);

    }

    public class AppPageBase
    {
        public static AppCLI App;
    }

}
