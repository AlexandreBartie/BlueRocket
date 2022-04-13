using Dooggy.LIBRARY;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class LoadCLI
    {
        public EditorCLI Editor;

        public LoadFile File;

        public LoadHistory History;

        private EditorPage Page => Editor.Page;

        public bool IsWorking = true;

        public string project_file => History.name;

        public LoadCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            File = new LoadFile(this);

            History = new LoadHistory(this);
        }

        public void FindProject()
        {
            if (File.SelectCFG())
                OpenProject(File.project_name);
        }

        public void OpenProject(string prmFileCFG)
        {
            History.NewFile(prmFileCFG);

            Editor.OnProjectOpen(prmFileCFG);
        }

        public void Quit() => IsWorking = false;

    }

    public class LoadFile
    {
        private LoadCLI Load;

        public string project_name;

        private LoadHistory History => Load.History;

        public LoadFile(LoadCLI prmLoad)
        {
            Load = prmLoad;
        }

        [STAThread]
        public bool SelectCFG()
        {
            myFileDialog Selecao = new myFileDialog();

            Selecao.Dialog.Filter = "Config files (*.cfg)|*.cfg";

            if (Selecao.Open() == DialogResult.OK)
            {
                project_name = Selecao.Dialog.FileName;

                return true;
            }

            return false;
        }

    }

    public class LoadHistory : List<FileLoaded>
    {
        private LoadCLI Load;

        private EditorCLI Editor => Load.Editor;

        private RegisterCLI Register => Editor.Register;

        private FileLoaded Current;

        public string name => Current.name;

        public LoadHistory(LoadCLI prmLoad)
        {
            Load = prmLoad; Setup();
        }
       
        private void Setup()
        {
            Clear();

            foreach (string name in Register.History.LastOpenedProject)
                Add(new FileLoaded(prmFile: name, prmLoaded: Register.History.GetDateTimeLoaded(name)));
        }

        public void NewFile(string prmFileCFG)
        {
            Current = new FileLoaded(prmFileCFG);

            Check();

            Save();          
        }

        private void Check()
        {
            foreach (FileLoaded File in this)
                if (Current.IsMatch(File.full_name))
                { Remove(File); break;  }

            Insert(0, Current);

        }

        private void Save()
        {
            Register.History.Clear();

            foreach (FileLoaded File in this)
                Register.History.Add(prmName: File.full_name, prmValue: File.loaded);
        }

    }

    public class FileLoaded
    {

        private string file;

        public string name => System.IO.Path.GetFileName(file);
        public string path => System.IO.Path.GetDirectoryName(file);

        public bool IsMatch(string prmFile) => myString.IsMatch(prmFile, file);

        public string full_name => path + @"\" + name;

        public DateTime loaded;

        public string loaded_txt => myFormat.DateToString(loaded, "dd/mmm/aaaa") + " " + myFormat.TimeToString(loaded, "hh:mm:ss");

        public FileLoaded(string prmFile)
        {
            file = prmFile; loaded = DateTime.Now;
        }
        public FileLoaded(string prmFile, DateTime prmLoaded)
        {
            file = prmFile; loaded = prmLoaded;
        }
    }


}
