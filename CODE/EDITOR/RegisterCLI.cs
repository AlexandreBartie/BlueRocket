using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class RegisterCLI
    {
        private AppCLI App;

        public RegisterHistoryCLI History;

        internal myRegisterUser root;

        public RegisterCLI(AppCLI prmApp)
        {
            App = prmApp;

            root = new myRegisterUser(prmRoot: "BlueRocket");

            History = new RegisterHistoryCLI(this);
        }

    }

    public class RegisterHistoryCLI
    {
        private RegisterCLI Register;
        private myRegisterKey History => Register.root.Node("History");

        public RegisterHistoryCLI(RegisterCLI prmRegister)
        {
            Register = prmRegister;
        }

        public void Clear() => History.Clear();

        public void Add(string prmName, object prmValue) => History.Data(prmName, prmValue);

        public string[] LastOpenedProject => History.GetNames;

        public DateTime GetDateTimeLoaded(string prmName) => DateTime.Parse(History.GetValue(prmName).ToString());

    }

    public class myRegisterUser
    {

        private myRegisterKey root;

        public myRegisterUser(string prmRoot)
        {
            root = new myRegisterKey(Registry.CurrentUser).Node(prmRoot);
        }

        public myRegisterKey Node(string prmName) => root.Node(prmName);

    }

    public class myRegisterKey : myRegisterClear
    {

        public string name => key.Name;

        public string[] GetNames => key.GetValueNames();

        public myRegisterKey(RegistryKey prmKey)
        {
            key = prmKey;
        }

        public myRegisterKey Node(string prmKey)
        {
            return new myRegisterKey(key.CreateSubKey(prmKey));
        }

        public void Data(string prmName, object prmValue)
        {
            key.SetValue(prmName, prmValue);
        }

        public object GetValue(string prmName) => key.GetValue(prmName);

    }

    public class myRegisterClear
    {

        internal RegistryKey key;

        public void Clear()
        {
            ClearKeys(); ClearValues();
        }

        private void ClearKeys()
        {
            foreach (string name in key.GetSubKeyNames())
                key.DeleteSubKey(name);
        }

        private void ClearValues()
        {
            foreach (string name in key.GetValueNames())
                key.DeleteValue(name);
        }
    }

    public class myRegisterValue
    {

        public string prmName;
        public object prmValue;


    }
}