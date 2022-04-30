using Katty;
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

        public myRegisterCheck AutoLoad => Checks.Get("AutoLoad");
        public myRegisterCheck AutoSave => Checks.Get("AutoSave");
        public myRegisterCheck DebugMode => Checks.Get("DebugMode");

        public AppRegisterHistory History;

        public AppRegisterProject(myRegisterKey prmNode) : base(prmKey: "Project", prmNode)
        {
            Checks.Add(AutoLoad);
            Checks.Add(AutoSave);
            Checks.Add(DebugMode);

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

        public myRegisterCheck DataCount => Checks.Get("DataCount");
        public myRegisterCheck TimeAnalisys => Checks.Get("TimeAnalisys");
        public myRegisterCheck AssociatedTags => Checks.Get("AssociatedTags");

        public AppRegisterScript(myRegisterKey prmNode) : base(prmKey: "Script", prmNode)
        {
            Checks.Add(DataCount);
            Checks.Add(TimeAnalisys);
            Checks.Add(AssociatedTags);
        }
    }

}