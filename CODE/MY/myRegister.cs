using Dooggy.LIBRARY;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    
    public class myRegisterRoot
    {

        private myRegisterKey root;

        public myRegisterRoot(string prmRoot)
        {
            root = new myRegisterKey(GetTypeRoot()).Node(prmRoot);
        }

        public myRegisterKey Get() => root;

        public myRegisterKey Node(string prmKey) => root.Node(prmKey);

        public void Clear(string prmKey) => root.Clear(prmKey);

        private RegistryKey GetTypeRoot() => Registry.CurrentUser;

    }
    public class myRegisterKey : myRegisterKeyFormats
    {

        public string name => key.Name;

        public myRegisterKey(RegistryKey prmKey) : base(prmKey) { }

        public myRegisterKey Node(string prmKey)
        {
            return new myRegisterKey(GetSubKey(prmKey));
        }

        public void SetData(string prmName, object prmValue)
        {
            key.SetValue(prmName, prmValue);
        }

        public RegistryKey GetSubKey(string prmName) => key.CreateSubKey(prmName);

        public object GetValue(string prmName) => key.GetValue(prmName);

        public void Clear(string prmSubKey)
        {
            if (key.OpenSubKey(prmSubKey) != null)
                key.DeleteSubKeyTree(prmSubKey);
        }
    }

    public class myRegisterKeyFormats
    {
        internal RegistryKey key;

        public string[] SubKeys => key.GetSubKeyNames();
        public string[] SubNames => key.GetValueNames();

        public myRegisterKeyFormats(RegistryKey prmKey)
        {
            key = prmKey;
        }

        public string GetString(string prmName) => (string)key.GetValue(prmName);
        public bool GetBoolean(string prmName) => myString.IsMatch(GetString(prmName), "sim");

    }

    public class myRegisterValue
    {
        public string prmName;
        public object prmValue;
    }
}
