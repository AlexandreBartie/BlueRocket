using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class BatchCLI
    {
        public EditorCLI Editor;

        public SelectCLI Select;

        public bool IsRunning;

        public int cont;
        public int qtde => Select.Count;

        private string txt_progresso => String.Format("{0} de {1}", cont, qtde);

        public BatchCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Select = new SelectCLI(this);
        }

        public void Add(string prmKey) => Select.AddScript(prmKey);

        public void Start()
        {
            IsRunning = true; cont = 0;

            Select.Setup();

            Editor.OnBatchStart();

            Editor.SetAction("Batch started ...");

        }
        public bool Set(ScriptCLI prmScript)
        {

            if (Editor.Painel.SetScript(prmScript))
            {
                Editor.SetScript(prmScript); cont += 1;

                Editor.OnScriptCodeSelect();

                Editor.OnBatchSet(prmScript);

                return true;
            }

            return false;
        }
        public void End()
        {
            IsRunning = false;

            Editor.SetAction("Batch ended ...");

            Select.Reset();

            Editor.OnBatchEnd();
        }

    }
    public class SelectCLI : List<ScriptCLI>
    {
        private BatchCLI Batch;

        private EditorCLI Editor => Batch.Editor;

        public SelectCLI(BatchCLI prmBatch)
        {
            Batch = prmBatch;
        }
        public void Reset() => Clear();

        public void Setup() => Editor.View.SetSelected();

        public void AddScript(string prmKey)
        {
            Editor.SetScript(prmKey);

            Add(Editor.GetScript(prmKey));
        }
        public bool IsSelected(ScriptCLI prmScript)
        {
            foreach (ScriptCLI Script in this)
                if (Script.IsMatch(prmScript.name))
                    return true;

            return false;
        }

    }

}
