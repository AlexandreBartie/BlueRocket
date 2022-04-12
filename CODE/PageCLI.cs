using BlueRocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class EditorPage : EditorPageView
    {
        
        private EditorPage_Main pagMain;

        private EditorPage_About pagAbout;

        private EditorPage_Start pagStart;

        public EditorPage(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            pagMain = new EditorPage_Main();

            pagAbout = new EditorPage_About();

            pagStart = new EditorPage_Start();

        }

        public void MainShow() => MainShow(prmPinned: false);
        public void MainShow(bool prmPinned) => pagMain.Show(prmPinned);

        public void AboutShow() => pagAbout.Show();

        public void StartShow() => pagStart.Show();

        public void SetAction(string prmTexto) => pagMain.SetAction(prmTexto);

    }

    public class EditorPageView : EditorPageBase
    {

        public bool IsPainting;

        public void Start() => IsPainting = true;
        public void End() => IsPainting = false;
    }
    public class EditorPage_Start : EditorPageBase
    {

        private frmSplash FormSplash;

        private frmStart FormLocal;

        public void Show()
        {
            FormSplash = new frmSplash(); FormSplash.ShowDialog();

            FormLocal = new frmStart(); FormLocal.Setup(Editor); 
        }

    }

    public class EditorPage_Main : EditorPageBase
    {

        static frmMainCLI FormLocal;

        public void Show(bool prmPinned)
        {
            if (!prmPinned)
            { FormLocal = new frmMainCLI(); FormLocal.Setup(Editor); }
            else
                FormLocal.ShowDialog();
        }

        public void SetAction(string prmTexto) => FormLocal.SetAction(prmTexto);

    }

    public class EditorPage_About : EditorPageBase
    {

        private frmAboutBox FormLocal;

        public void Show() { FormLocal = new frmAboutBox(); FormLocal.Setup(Editor); }


        // private frmAbout Window;

        //public void Show() { Window = new frmAbout(); Window.ShowDialog(); }

    }

    public class EditorPageBase
    {
        public static EditorCLI Editor;
    }

}
