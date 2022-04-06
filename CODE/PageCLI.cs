using BlueRocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class EditorPage : EditorPageView
    {

        private EditorPage_Main Main;

        private EditorPage_About About;

        public EditorPage(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Main = new EditorPage_Main();

            About = new EditorPage_About();

        }

        public void MainShow() => Main.Show();
        public void AboutShow() => About.Show();

        public void SetAction(string prmTexto) => Main.SetAction(prmTexto);

    }

    public class EditorPageView : EditorPageBase
    {

        public bool IsPainting;

        public void Start() => IsPainting = true;
        public void End() => IsPainting = false;
    }

    public class EditorPage_Main : EditorPageBase
    {

        private frmMainCLI FormLocal;

        public void Show() { FormLocal = new frmMainCLI(); FormLocal.Setup(Editor); }

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
