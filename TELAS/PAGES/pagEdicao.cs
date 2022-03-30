using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public partial class pagEdicao : UserControl
    {

        private EditorCLI Editor;

        public pagEdicao()
        {
            InitializeComponent();
        }

        public void Setup(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Editor.Format.SetPadrao(splSeparadorH);
            Editor.Format.SetPadrao(splSeparadorV);

            usrProjetoTeste.Setup(Editor);

            usrScriptTeste.Setup(Editor);

            usrResultadoTeste.Setup(Editor);

        }
        public void View()
        {
            usrProjetoTeste.View();

            usrScriptTeste.View();

            usrResultadoTeste.View();

        }

        public new void Refresh()
        {
            usrProjetoTeste.Refresh();
        }

        public void MultiSelect(bool prmAtivar) => usrProjetoTeste.MultiSelect(prmAtivar);

        public void ViewResult(ePageResult prmPage) => usrResultadoTeste.ViewPage(prmPage);

        public bool FindNodeScript(ScriptCLI prmScript) => usrProjetoTeste.FindNodeScript(prmScript);

        public void UncheckedNodeScript(ScriptCLI prmScript) => usrProjetoTeste.UncheckedNodeScript(prmScript);

   }

}
