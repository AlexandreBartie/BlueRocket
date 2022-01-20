using DooggyCLI.Telas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DooggyCLI
{
    public class PageCLI : FormBase
    {
        
        private PageCLI_Painel Main;

        private PageCLI_Editor Editor;

        private PageCLI_About About;

        public PageCLI(PainelCLI prmPainel)
        {

            Painel = prmPainel;

            Main = new PageCLI_Painel();

            Editor = new PageCLI_Editor();

            About = new PageCLI_About();

        }

        public void PainelShow() => Main.Show();
        public void EditorShow() => Editor.Show();
        public void AboutShow() => About.Show();

    }
    
    
    public class PageCLI_Painel : FormBase
    {

        private frmPainelCLI FormLocal;

        public void Show()
        {

            FormLocal = new frmPainelCLI();

            FormLocal.Setup(Painel);

        }

    }

    public class PageCLI_Editor : FormBase
    {

        private frmEditorCLI FormLocal;

        public void Show()
        {

            FormLocal = new frmEditorCLI();

            FormLocal.Setup(Painel.Editor);

        }

    }


    public class PageCLI_About : FormBase
    {

        private frmAboutBox FormLocal;

        public void Show()
        {

            FormLocal = new frmAboutBox();

            FormLocal.Setup(Painel);

        }

    }

    public class FormBase
    {
        public static PainelCLI Painel;
    }

}
