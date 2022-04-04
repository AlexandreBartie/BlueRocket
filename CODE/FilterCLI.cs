using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class EditorFilter
    {
        public EditorCLI Editor;

        public DataTags Tags => Editor.Project.Tags;

        public EditorFilter(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void SetChecked(string prmTag, string prmOption, bool prmChecked) => Tags.SetAtivado(prmTag, prmOption, prmChecked);

    }

    //public class TagCLI
    //{
    //    public EditorCLI Editor;

    //    private myDominio Dominio;

    //    public EditorFormat Format => Editor.Format;

    //    public string name => Dominio.name;

    //    public string value;
    //    public string padrao => Dominio.padrao;

    //    public bool IsMatch(string prmName) => myString.IsMatch(name, prmName);
    //    public bool IsPadrao(string prmValue) => myString.IsMatch(padrao, prmValue);

    //    public DataTagOptionsCLI Options;

    //    public ColorTagCLI Cor;

    //    public TagCLI(myDominio prmDominio, EditorCLI prmEditor)
    //    {
    //        Editor = prmEditor;

    //        Options = new DataTagOptionsCLI(this, prmDominio);

    //        Cor = new ColorTagCLI(this);
    //    }

    //    public void SetAtivado(string prmOption, bool prmAtivo) => Options.SetAtivado(prmOption, prmAtivo);
    //}

    //public class TagsCLI : List<TagCLI>
    //{

    //    private EditorCLI Editor;

    //    public DataTagOptionsCLI Todos => GetTodos();
    //    public DataTagOptionsCLI Ativos => GetTodos(prmFiltrar: true);

    //    public TagsCLI(EditorCLI prmEditor)
    //    {
    //        Editor = prmEditor;

    //        foreach (DataTag Tag in prmEditor.MainTAGs)
    //            AddItem(Tag);
    //    }

    //    public TagsCLI(EditorCLI prmEditor, prmS)
    //    {
    //        Editor = prmEditor;

    //        foreach (myDominio Tag in prmEditor.MainTAGs)
    //            AddItem(Tag);
    //    }

    //    public void SetAtivado(string prmName, string prmOption, bool prmAtivo)
    //    {
    //        foreach (TagCLI Tag in this)

    //            if (Tag.IsMatch(prmName))
    //            { Tag.SetAtivado(prmOption, prmAtivo); break; }
    //    }

    //    private DataTagOptionsCLI GetTodos() => GetTodos(prmFiltrar: false);
    //    private DataTagOptionsCLI GetTodos(bool prmFiltrar)
    //    {
    //        DataTagOptionsCLI itens = new DataTagOptionsCLI();

    //        foreach (TagCLI Tag in this)
    //        {
    //            foreach (OptionTagCLI item in Tag.Options)
    //                if (item.ativo || !prmFiltrar)
    //                    itens.Add(item);
    //        }
    //        return itens;
    //    }

    //}

    //public class OptionTagCLI
    //{

    //    public TagCLI Tag;

    //    public string name => Tag.name;

    //    public string value;

    //    public bool ativo;
    //    public string log => String.Format("{0}: {1}", Tag.name, value);

    //    public bool IsPadrao => Tag.IsPadrao(value);

    //    public bool IsMatch(string prmName, string prmValue) => IsMatchName(prmName) && IsMatchValue(prmValue);
    //    public bool IsMatch(string prmValue) => IsMatchValue(prmValue);

    //    private bool IsMatchName(string prmName) => myString.IsMatch(name, prmName);
    //    private bool IsMatchValue(string prmValue) => myString.IsMatch(value, prmValue);

    //    public ColorOptionTagCLI Cor;

    //    public OptionTagCLI(TagCLI prmTag, string prmValue)
    //    {
    //        Parse(prmTag, prmValue);

    //        Cor = new ColorOptionTagCLI(this);
    //    }

    //    private void Parse(TagCLI prmTag, string prmValue)
    //    {
    //        Tag = prmTag;

    //        value = prmValue;
    //    }
    //    public void SetAtivo(bool prmAtivo) => ativo = prmAtivo;

    //}

    //public class DataTagOptionsCLI : List<OptionTagCLI>
    //{

    //    private TagCLI Tag;

    //    private myDominio Dominio;

    //    public string log => GetLOG();

    //    public DataTagOptionsCLI()
    //    {
    //    }

    //    public DataTagOptionsCLI(TagCLI prmTag, myDominio prmDominio)
    //    {
    //        Tag = prmTag; Dominio = prmDominio;
            
    //        Popular(prmTag, prmDominio);
    //    }

    //    private void Popular(TagCLI prmTag, myDominio prmDominio)
    //    {
    //        foreach (string item in prmDominio.Opcoes)
    //            Add(new OptionTagCLI(prmTag, prmValue: item));

    //    }
    //    public void SetAtivado(string prmOption, bool prmAtivo)
    //    {
    //        foreach (OptionTagCLI Option in this)
    //            if (Option.IsMatch(prmOption))
    //            { Option.SetAtivo(prmAtivo); break; }
    //    }

    //    public bool GetAtivado(string prmTag, string prmOption)
    //    {
    //        foreach (OptionTagCLI Option in this)
    //            if (Option.IsMatch(prmTag, prmOption))
    //                return true;
    //        return false;
    //    }

    //    private string GetLOG()
    //    {
    //        xLinhas txt = new xLinhas();

    //        foreach (OptionTagCLI Option in this)
    //            txt.Add(Option.log);

    //        return txt.memo;

    //    }

    //}

}
