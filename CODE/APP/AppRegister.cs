using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class AppRegister
    {
        private AppCLI App;

        internal myRegisterRoot root;

        public AppRegisterStart Start;
        public AppRegisterHistory History => Start.History;

        public AppRegister(AppCLI prmApp)
        {
            App = prmApp;

            root = new myRegisterRoot(prmRoot: "BlueRocket");

            Start = new AppRegisterStart(root.Get());
        }

    }

    public class AppRegisterStart : AppRegisterBase
    {

        public AppRegisterHistory History;

        public bool IsAutoLoad
        {
            get { return Local.GetBoolean("AutoLoad"); }

            set { Local.SetData("AutoLoad", myBool.GetYesNo(value)); }
        }

        public AppRegisterStart(myRegisterKey prmNode) : base(prmKey: "Start", prmNode)
        {
            History = new AppRegisterHistory(Local);
        }
    }

    public class AppRegisterHistory : AppRegisterBase
    {
    
        public AppRegisterHistory(myRegisterKey prmParent) : base(prmKey: "History", prmParent) { }

        public string[] LastOpenedProject => Local.SubNames;

        public DateTime GetDateTimeLoaded(string prmName) => DateTime.Parse(Local.GetString(prmName));

    }

    public class AppRegisterBase
    {
        public myRegisterKey Parent;

        public myRegisterKey Local => Parent.Node(key);

        private string key;

        public AppRegisterBase(string prmKey, myRegisterKey prmParent)
        {
            Parent = prmParent; key = prmKey;
        }
        public void Clear() => Local.Clear(key);

        public void Add(string prmName, object prmValue) => Local.SetData(prmName, prmValue);

    }

}