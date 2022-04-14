using BlueRocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class AppPage : AppPageBase //AppPageView
    {
        
        private AppPageMain pagMain;

        private AppPageAbout pagAbout;

        private AppPageStart pagStart;

        public AppPage(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            pagMain = new AppPageMain();

            pagAbout = new AppPageAbout();

            pagStart = new AppPageStart();

        }

        public void MainShow() => MainShow(prmPinned: false);
        public void MainShow(bool prmPinned) => pagMain.Show(prmPinned);

        public void MainHide() => pagMain.Hide();

        public void AboutShow() => pagAbout.Show();

        public void StartShow() => pagStart.Show();
        public void StartShow(string prmArquivoCFG) => pagStart.Show(prmArquivoCFG);

        public void SetAction(string prmTexto) => pagMain.SetAction(prmTexto);

    }

    //public class AppPageView : AppPageBase
    //{

    //    public bool IsPainting;

    //    public void Start() => IsPainting = true;
    //    public void End() => IsPainting = false;
    //}
    public class AppPageStart : AppPageBase
    {

        private frmSplash FormSplash;

        private frmStart FormStart;

        public void Show(string prmArquivoCFG)
        {
            FormStart = new frmStart(); FormStart.Setup(Editor);

            FormStart.OpenProject(prmArquivoCFG);
        }

        public void Show()
        {
            if (FormStart == null) // It´s first time
            {
                FormSplash = new frmSplash(); FormSplash.ShowDialog();

                FormStart = new frmStart(); FormStart.Setup(Editor);
            }
            else
                FormStart.Show();
        }

    }

    public class AppPageMain : AppPageBase
    {

        static frmMainCLI FormMain;

        public void Show(bool prmPinned)
        {
            if (prmPinned)
                FormMain.ShowDialog();
            else if (FormMain == null)
                { FormMain = new frmMainCLI(); FormMain.Setup(Editor); }
            else
                FormMain.Show();
        }

        public void Hide() => FormMain.Hide();

        public void SetAction(string prmTexto) => FormMain.SetAction(prmTexto);

    }

    public class AppPageAbout : AppPageBase
    {

        private frmAboutBox FormLocal;

        public void Show() { FormLocal = new frmAboutBox(); FormLocal.Setup(Editor); }

    }

    public class AppPageBase
    {
        public static EditorCLI Editor;
    }

}
