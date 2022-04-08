using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class pagEdition : UserControl
    {

        private EditorCLI Editor;

        public pagEdition()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(splSeparadorV);

           // usrProjetoTeste.Setup(Editor);

            usrTestCode.Setup(Editor);

            usrTestResult.Setup(Editor);

        }
        public void View()
        {
            //usrProjetoTeste.View();

            usrTestCode.View();

            usrTestResult.View();

        }

        public void MultiSelect(bool prmAtivar) { } // => usrProjetoTeste.MultiSelect(prmAtivar);

        public void ViewResult(ePageResult prmPage) => usrTestResult.ViewPage(prmPage);

        public bool FindNodeScript(ScriptCLI prmScript) => false;// usrProjetoTeste.FindNodeScript(prmScript);

        public void UncheckedNodeScript(ScriptCLI prmScript) { }// => usrProjetoTeste.UncheckedNodeScript(prmScript);

   }

}
