using Katty;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class AppLoad
    {
        public AppCLI App;

        public LoadDirect Direct;

        public LoadHistory History;

        public bool HasHistory => History.IsFull;

        public bool IsAutoLoad => History.IsAutoLoad;
        public bool IsDirect => Direct.IsFull;
        public bool IsWorking => Direct.IsWorking;

        public string project_name => History.actualAccess;

        public AppLoad(AppCLI prmApp)
        {
            App = prmApp;

            Direct = new LoadDirect(this);

            History = new LoadHistory(this);
        }

        public void FileFind()
        {
            if (Direct.FileCFG())
                FileOpen(Direct.project_file);
        }

        public void FileOpen(string prmFileCFG)
        {
            History.NewFile(prmFileCFG);

            App.Session.OnFileOpen(prmFileCFG);

            Direct.Start();

        }

        public void FileClose()
        {
            App.Session.OnFileClose();
        }

        public void FileExit()
        {
            Direct.Exit();
        }

    }

    public class LoadDirect
    {
        private AppLoad Load;

        public string project_file;

        public bool IsWorking;

        public bool IsFull => myString.IsFull(project_file);

        public LoadDirect(AppLoad prmLoad)
        {
            Load = prmLoad;
        }

        public void Start() { project_file = ""; IsWorking = true; }

        public void Exit() { IsWorking = false; }

        public void SetFileCFG(string prmFileCFG) => project_file = prmFileCFG;

        [STAThread]
        public bool FileCFG()
        {
            myFileDialog Selecao = new myFileDialog();

            Selecao.Dialog.Filter = "Config files (*.cfg)|*.cfg";

            if (Selecao.Open() == DialogResult.OK)
            {
                project_file = Selecao.Dialog.FileName;

                return true;
            }

            return false;
        }

    }

    public class LoadHistory : List<FileLoaded>
    {
        private AppLoad Load;

        private AppRegister Register => Load.App.Register;

        private FileLoaded Current;

        public bool IsFull => (this.Count > 0);
        public bool IsAutoLoad { get { if (IsFull) return Register.Project.AutoLoad.IsChecked; return false; } }

        public string actualAccess => Current.name;
        public string lastAccess => GetLastAcess();

        public LoadHistory(AppLoad prmLoad)
        {
            Load = prmLoad; Setup();
        }
       
        private void Setup()
        {
            Clear();

            foreach (string name in Register.History.LastOpenedProject)
                AddItem(new FileLoaded(prmFile: name, prmLoaded: Register.History.GetDateTimeLoaded(name)));              
        }

        public void NewFile(string prmFileCFG)
        {
            Current = new FileLoaded(prmFileCFG);

            Check();

            Save();
        }

        public void SetAutoLoad(bool prmChecked) => Register.Project.AutoLoad.Set(prmChecked);

        private void AddItem(FileLoaded prmFile)
        {
            if (prmFile.IsExists())
                Add(prmFile);
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

        private string GetLastAcess()
        {
            if (IsFull)
                return this[0].full_name;

            return "";
        }

    }

    public class FileLoaded
    {

        private string file;

        public string name => System.IO.Path.GetFileName(file);
        public string path => System.IO.Path.GetDirectoryName(file);

        public bool IsMatch(string prmFile) => myString.IsMatch(prmFile, file);
        public bool IsExists() => System.IO.File.Exists(file);

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
