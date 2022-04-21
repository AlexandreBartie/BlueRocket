using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public enum eScriptStatus
    {
        Locked = 0,
        Edit = 1,
        Changed = 2,
        Outdated = 3,
        Running = 4,
        ResultOk = 5,
        ResultError = 6
    };
    public class ScriptStatusCLI
    {
        private ScriptCLI Script;

        private EditorCLI Editor => Script.Editor;

        public string name => GetStatus();
        public eScriptStatus id => GetIdStatus();

        public ScriptStatusCLI(ScriptCLI prmScript)
        {
            Script = prmScript;
        }

        private string GetStatus()
        {
            switch (id)
            {
                case eScriptStatus.Locked:
                    return "-";

                case eScriptStatus.Edit:
                    return "+";

                case eScriptStatus.Changed:
                    return "*";

                case eScriptStatus.Outdated:
                    return "!";

                case eScriptStatus.Running:
                    return "=";

                case eScriptStatus.ResultOk:
                    return "Ok";

                case eScriptStatus.ResultError:
                    return "Error";
            }

            return "X";
        }

        private eScriptStatus GetIdStatus()
        {

            if (Editor.IsRunning)
                if (Script.IsSelected)
                    return eScriptStatus.Running;

            if (Script.IsChanged)
                return eScriptStatus.Changed;

            if (Script.IsResult)
            {
                if (Script.IsOutdated)
                    return eScriptStatus.Outdated;

                if (Script.IsLogError)
                    return eScriptStatus.ResultError;
                else
                    return eScriptStatus.ResultOk;
            }

            if (Script.IsLocked)
                return eScriptStatus.Locked;

            return eScriptStatus.Edit;
        }

    }
}
