using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket.UX
{
    public class PanelEdition : PageControl
    {

        private UXBuilder Builder;

        private usrViewCode pagViewCode => (usrViewCode)Builder.GetElement("Code");
        private usrViewData pagViewData => (usrViewData)Builder.GetElement("Data");
        private usrViewResult pagViewResult => (usrViewResult)Builder.GetElement("Result");

        public PanelEdition()
        {
            Builder = new UXBuilder(this, prmTitle: true);

            Builder.AddElement("Code", new usrViewCode());
            Builder.AddElement("Data", new usrViewData());

            Builder.AddElement("Result", new usrViewResult(), DockStyle.Bottom, prmSplitter: true);

            Builder.AddTab(prmPages: "Code,Data", prmAligment: TabAlignment.Top); ;
        }

        public new void Setup(EditorCLI prmEditor)
        {
            base.Setup(prmEditor);
            
            Builder.Setup(prmEditor);

            pagViewCode.Setup(prmEditor);
            pagViewData.Setup(prmEditor);
            pagViewResult.Setup(prmEditor);
        }
        public void View()
        {
            Builder.SetText(Editor.View.script_name);

            pagViewCode.View();

            pagViewResult.View();
        }

        public void ViewResult(ePageResult prmPage) => pagViewResult.ViewPage(prmPage);


        //public void MultiSelect(bool prmAtivar) { } // => usrProjetoTeste.MultiSelect(prmAtivar);



        //public bool FindNodeScript(ScriptCLI prmScript) => false;// usrProjetoTeste.FindNodeScript(prmScript);

        //public void UncheckedNodeScript(ScriptCLI prmScript) { }// => usrProjetoTeste.UncheckedNodeScript(prmScript);

    }
}
