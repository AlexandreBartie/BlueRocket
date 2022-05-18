using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{

    public delegate void Notify_ScriptChanged();

    public delegate void Notify_TagChecked();

    public class AppEvents
    {
        private AppCLI App;

        public event Notify_ScriptChanged ScriptChanged;

        public event Notify_TagChecked TagChecked;

        public AppEvents(AppCLI prmApp)
        {
            App = prmApp;
        }

        public void OnScriptChanged()
        {
            ScriptChanged?.Invoke();
        }

        public void OnTagChecked()
        {
            TagChecked?.Invoke();
        }

    }

}
