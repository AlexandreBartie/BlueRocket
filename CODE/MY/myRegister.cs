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

        public myRegisterKey Node(string prmKey) => root.Node(prmKey);

        public void Clear(string prmKey)
        {
            root.Clear(prmKey);
        }

        private RegistryKey GetTypeRoot() => Registry.CurrentUser;

    }
    public class myRegisterKey
    {

        internal RegistryKey key;

        public string name => key.Name;

        public string[] SubKeys => key.GetSubKeyNames();
        public string[] SubNames => key.GetValueNames();

        public myRegisterKey(RegistryKey prmKey)
        {
            key = prmKey;
        }

        public myRegisterKey Node(string prmKey)
        {
            return new myRegisterKey(GetSubKey(prmKey));
        }

        public void Data(string prmName, object prmValue)
        {
            key.SetValue(prmName, prmValue);
        }

        public object GetValue(string prmName) => key.GetValue(prmName);

        public RegistryKey GetSubKey(string prmName) => key.CreateSubKey(prmName);

        public void Clear(string prmSubKey)
        {
            key.DeleteSubKey(prmSubKey);
            
            
            //ClearValues();
        }

        private void ClearKeys()
        {
            //foreach (string name in SubKeys)
                //key.DeleteSubKey(name);
        }

        private void ClearValues()
        {
            //foreach (string name in SubNames)
                //key.DeleteValue(name);
        }

    }

    public class myRegisterClear
    {




    }

    public class myRegisterValue
    {
        public string prmName;
        public object prmValue;
    }
}
