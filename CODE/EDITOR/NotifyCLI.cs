using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{

    public delegate void Notify_ProjectDBConnect();

    public delegate void Notify_ProjectNew();

    public delegate void Notify_ProjectHistory(string prmArquivoCFG);

    public delegate void Notify_ProjectOpen(string prmArquivoCFG);
    public delegate void Notify_ProjectClose();
    public delegate void Notify_ProjectReset();

    public delegate void Notify_ProjectExit();

    public delegate void Notify_FilterTagChanged();
    public delegate void Notify_FilterTagChecked(string prmTag, string prmOption, bool prmChecked);

    public delegate void Notify_MultiSelect(bool prmAtivar);

    public delegate void Notify_BatchSet(ScriptCLI prmScript);
    public delegate void Notify_BatchEnd();

    public delegate void Notify_SelectedPlayAll();
    public delegate void Notify_SelectedSaveAll();

    public delegate void Notify_ScriptCodeChecked(string prmScript, bool prmChecked);

    public delegate void Notify_ScriptCodeLocked();
    public delegate void Notify_ScriptCodeSelect();
    public delegate void Notify_ScriptCodeChanged();

    public delegate void Notify_ScriptCodePlay();
    public delegate void Notify_ScriptCodeSave();
    public delegate void Notify_ScriptCodeUndo();

    public delegate void Notify_ScriptPlayEnd();
    public delegate void Notify_ScriptPlayStop();

    public delegate void Notify_ScriptLogOk();
    public delegate void Notify_ScriptLogError();

    public delegate void Notify_ScriptLogClipBoard(string prmLog);

}
