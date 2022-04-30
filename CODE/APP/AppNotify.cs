using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{

    public delegate void Notify_ViewScriptChanged();

    public class AppEvents
    {
        private AppCLI App;

        public event Notify_ViewScriptChanged ViewScriptChanged;

        public AppEvents(AppCLI prmApp)
        {
            App = prmApp;
        }

        public void OnViewScriptChanged()
        {
            ViewScriptChanged?.Invoke();
        }         
    }


}
