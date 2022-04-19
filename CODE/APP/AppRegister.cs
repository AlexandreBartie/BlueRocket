using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class AppRegister
    {
        private AppCLI App;

        public AppRegisterHistory History;

        internal myRegisterRoot root;

        public AppRegister(AppCLI prmApp)
        {
            App = prmApp;

            root = new myRegisterRoot(prmRoot: "BlueRocket");

            History = new AppRegisterHistory(this);
        }

    }

    public class AppRegisterHistory
    {
        private AppRegister Register;

        private myRegisterKey History => Register.root.Node("History");

        public AppRegisterHistory(AppRegister prmRegister)
        {
            Register = prmRegister;
        }

        public void Clear() => Register.root.Clear("History");

        public void Add(string prmName, object prmValue) => History.Data(prmName, prmValue);

        public string[] LastOpenedProject => History.SubNames;

        public DateTime GetDateTimeLoaded(string prmName) => DateTime.Parse(History.GetValue(prmName).ToString());

    }

}