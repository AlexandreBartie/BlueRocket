using DooggyCLI.Telas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DooggyCLI
{
    public class EditorPageCLI : EditorPageBase
    {
        
        private EditorPageCLI_Main Main;

        private EditorPageCLI_About About;

        public EditorPageCLI(EditorCLI prmEditor)
        {

            Editor = prmEditor;

            Main = new EditorPageCLI_Main();

            About = new EditorPageCLI_About();

        }

        public void MainShow() => Main.Show();
        public void AboutShow() => About.Show();

        public void SetAction(string prmTexto) => Main.SetAction(prmTexto);

    }

    public class EditorPageCLI_Main : EditorPageBase
    {

        private frmMainCLI FormLocal;

        public void Show() { FormLocal = new frmMainCLI(); FormLocal.Setup(Editor); }

        public void SetAction(string prmTexto) => FormLocal.SetAction(prmTexto);

    }

    public class EditorPageCLI_About : EditorPageBase
    {

        private frmAboutBox FormLocal;

        public void Show() { FormLocal = new frmAboutBox(); FormLocal.Setup(Editor); }

    }

    public class EditorPageBase
    {
        public static EditorCLI Editor;
    }

}
