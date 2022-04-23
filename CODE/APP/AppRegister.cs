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

        public AppRegisterProject Project;

        public AppRegisterScript Script;
        public AppRegisterHistory History => Project.History;

        public AppRegister(AppCLI prmApp)
        {
            App = prmApp;

            root = new myRegisterRoot(prmRoot: "BlueRocket");

            Project = new AppRegisterProject(root.Get());

            Script = new AppRegisterScript(root.Get());

        }

    }

    public class AppRegisterProject : myRegisterBag
    {

        public AppRegisterHistory History;

        public bool IsAutoLoad
        {
            get { return Local.GetBoolean("AutoLoad"); }

            set { Local.SetData("AutoLoad", myBool.GetYesNo(value)); }
        }
        public bool IsAutoSave
        {
            get { return Local.GetBoolean("AutoSave"); }

            set { Local.SetData("AutoSave", myBool.GetYesNo(value)); }
        }
        public bool IsDebugMode
        {
            get { return Local.GetBoolean("DebugMode"); }

            set { Local.SetData("DebugMode", myBool.GetYesNo(value)); }
        }

        public AppRegisterProject(myRegisterKey prmNode) : base(prmKey: "Project", prmNode)
        {
            History = new AppRegisterHistory(Local);
        }
    }

    public class AppRegisterHistory : myRegisterBag
    {
    
        public AppRegisterHistory(myRegisterKey prmParent) : base(prmKey: "History", prmParent) { }

        public string[] LastOpenedProject => Local.SubNames;

        public DateTime GetDateTimeLoaded(string prmName) => DateTime.Parse(Local.GetString(prmName));

    }

    public class AppRegisterScript : myRegisterBag
    {

        public myRegisterCheck IsDataCount => Checks.Item("DataCount");
        public myRegisterCheck IsTimeAnalisys => Checks.Item("TimeAnalisys");
        public myRegisterCheck IsAssociatedTags => Checks.Item("AssociatedTags");

        public AppRegisterScript(myRegisterKey prmNode) : base(prmKey: "Script", prmNode)
        {
            Checks.Add("DataCount,TimeAnalisys,AssociatedTags");
        }
    }

}