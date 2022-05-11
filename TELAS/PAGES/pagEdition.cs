using Katty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class pagEdition : usrMoldura
    {
        
        private PageBuilder Builder;

        private usrViewCode pagViewCode => (usrViewCode)Builder.GetElement("Code"); 
        private usrViewData pagViewData => (usrViewData)Builder.GetElement("Data");
        private usrViewResult pagViewResult => (usrViewResult)Builder.GetElement("Result");

        public pagEdition()
        {
            
            InitializeComponent();

            Builder = new PageBuilder(this);

            Builder.AddElement("Code", new usrViewCode());
            Builder.AddElement("Data", new usrViewData());
            Builder.AddElement("Result", new usrViewResult(), DockStyle.Bottom);

            Builder.AddSplitter(DockStyle.Bottom);

            Builder.AddTab(prmPages: "Code,Data", prmAligment: TabAlignment.Top);  ;

        }

        public new void Setup(EditorCLI prmEditor)
        {
            Builder.Setup(prmEditor);

            pagViewCode.Setup(prmEditor);
            pagViewData.Setup(prmEditor);
            pagViewResult.Setup(prmEditor);
        }
        public void View()
        {

            SetTitle(Editor.View.script_name);

            pagViewCode.View();

            pagViewResult.View();

        }

        public void ViewResult(ePageResult prmPage) => pagViewResult.ViewPage(prmPage);


        //public void MultiSelect(bool prmAtivar) { } // => usrProjetoTeste.MultiSelect(prmAtivar);



        //public bool FindNodeScript(ScriptCLI prmScript) => false;// usrProjetoTeste.FindNodeScript(prmScript);

        //public void UncheckedNodeScript(ScriptCLI prmScript) { }// => usrProjetoTeste.UncheckedNodeScript(prmScript);

    }

}

