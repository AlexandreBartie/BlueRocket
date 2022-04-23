using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{
    public class PainelCLI
    {
        public EditorCLI Editor;

        public ProjectCLI Project;

        public SelectCLI Select;

        public FilterCLI Filter;

        public BatchCLI Batch;

        public ViewCLI View;

        public PainelCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            View = new ViewCLI(prmEditor);

            Project = new ProjectCLI(prmEditor);

            Filter = new FilterCLI(prmEditor);

            Batch = new BatchCLI(prmEditor);
        }

        public void Show() => View.Show();
        public void Hide() => View.Hide();


        public bool FindScript(ScriptCLI prmScript) => View.FindScript(prmScript);

        public void SetAction(string prmTexto) => View.SetAction(prmTexto);

    }

    public class ViewCLI
    {
        public EditorCLI Editor;

        private frmMainCLI FormMain;

        public string script_name => GetScriptName();

        private string GetScriptName()
        {
            if (Editor.HasScript)
                return Editor.Script.title;

            return "Script INI";
        }

        private bool IsFormNull => (FormMain == null);

        public bool ICanBatch
        {
            get
            {
                if (IsFormNull)
                    return false;

                return FormMain.IsMultiSelected;
            }
        }

        public ViewCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void Show()
        {
            FormMain.Show();
        }

        public void Hide()
        {
            if (IsFormNull)
                CreateFormMain();
            else
                FormMain.Hide();
        }

        public void SetAction(string prmTexto) => FormMain.SetAction(prmTexto);

        public bool FindScript(ScriptCLI prmScript) => FormMain.FindScript(prmScript);

        public void GetSelected() => FormMain.GetSelected();

        private void CreateFormMain() => FormMain = new frmMainCLI(Editor);

    }

    public class FilterCLI : DataTagOptions
    {
        public EditorCLI Editor;

        public DataTags Tags => Editor.Project.Tags;

        private DataTagOption GetTagOption(string prmTag, string prmOption) => Editor.GetTagOption(prmTag, prmOption);

        public FilterCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }
        public void Setup()
        {
            Reset();

            foreach (myTagOption Option in Tags.GetAll())
                Add(new DataTagOption(Option));
        }

        public void Reset() => this.Clear();
        public void SetTagOption(string prmTag, string prmOption, bool prmChecked)
        {
            if (prmChecked)
                AddTagOption(prmTag, prmOption);
            else
                DelTagOption(prmTag, prmOption);
        }
        private void AddTagOption(string prmTag, string prmOption)
        {
            try
            {
                DataTagOption Option = Editor.GetTagOption(prmTag, prmOption);

                Add(Option);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };

        }
        private void DelTagOption(string prmTag, string prmOption)
        {
            try
            {
                DataTagOption Option = Editor.GetTagOption(prmTag, prmOption);

                Remove(Option);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); };
        }

        public bool IsMatch(string prmTag, string prmOption)
        {
            foreach (myTagOption Option in this)
                if (!Option.IsMatch(prmTag, prmOption))
                    return false;
            return true;
        }

    }

}
