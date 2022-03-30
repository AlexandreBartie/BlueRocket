using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRocket
{
    public class EditorFilter
    {
        public EditorCLI Editor;

        private TagsCLI Tags => Editor.Project.Tags;

        public OptionsTagCLI Todos => Tags.Todos;
        public OptionsTagCLI Ativos => Tags.Ativos;

        public EditorFilter(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

        public void SetTag(string prmTag, string prmOption, bool prmChecked) => Tags.SetAtivo(prmTag, prmOption, prmChecked);

    }

    public class TagCLI
    {
        public EditorCLI Editor;

        private myDominio Dominio;

        public EditorFormat Format => Editor.Format;

        public string name => Dominio.name;

        public bool IsMatch(string prmName) => myString.IsEqual(name, prmName);

        public OptionsTagCLI Options;

        public ColorTagCLI Cor;

        public TagCLI(myDominio prmDominio, EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Dominio = prmDominio;

            Options = new OptionsTagCLI(this, prmDominio.Opcoes);

            Cor = new ColorTagCLI(this);
        }

        public void SetAtivo(string prmOption, bool prmAtivo) => Options.SetAtivo(prmOption, prmAtivo);
    }

    public class TagsCLI : List<TagCLI>
    {

        private EditorCLI Editor;

        private Dooggy.CORE.DataTags MasterTAGs => Editor.Config.Global.Tags;

        public OptionsTagCLI Todos => GetTodos();
        public OptionsTagCLI Ativos => GetTodos(prmFiltrar: true);

        public TagsCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;

            Popular();
        }
        private void Popular()
        {
            foreach (myDominio Tag in MasterTAGs)
                AddItem(Tag);
        }

        private void AddItem(myDominio prmTag) => base.Add(new TagCLI(prmTag, Editor));

        public void SetAtivo(string prmName, string prmOption, bool prmAtivo)
        {
            foreach (TagCLI Tag in this)

                if (Tag.IsMatch(prmName))
                { Tag.SetAtivo(prmOption, prmAtivo); break; }
        }

        private OptionsTagCLI GetTodos() => GetTodos(prmFiltrar: false);
        private OptionsTagCLI GetTodos(bool prmFiltrar)
        {
            OptionsTagCLI itens = new OptionsTagCLI();

            foreach (TagCLI Tag in this)
            {
                foreach (OptionTagCLI item in Tag.Options)
                    if (item.ativo || !prmFiltrar)
                        itens.Add(item);
            }
            return itens;
        }

    }

    public class OptionTagCLI
    {

        private TagCLI Tag;

        public EditorFormat Format => Tag.Editor.Format;

        public string name => Tag.name;

        public string value;

        public bool ativo;
        public string log => String.Format("{0}: {1}", Tag.name, value);

        public bool IsMatch(string prmName, string prmValue) => IsMatchName(prmName) && IsMatchValue(prmValue);
        public bool IsMatch(string prmValue) => IsMatchValue(prmValue);

        private bool IsMatchName(string prmName) => myString.IsEqual(name, prmName);
        private bool IsMatchValue(string prmValue) => myString.IsEqual(value, prmValue);

        public ColorOptionTagCLI Cor;

        public OptionTagCLI(TagCLI prmTag, string prmValue)
        {
            Parse(prmTag, prmValue);

            Cor = new ColorOptionTagCLI(this);
        }

        private void Parse(TagCLI prmTag, string prmValue)
        {
            Tag = prmTag;

            value = prmValue;
        }
        public void SetAtivo(bool prmAtivo) => ativo = prmAtivo;

    }

    public class OptionsTagCLI : List<OptionTagCLI>
    {

        private TagCLI Tag;

        public string log => GetLOG();

        public OptionsTagCLI()
        {
        }

        public OptionsTagCLI(TagCLI prmTag, xLista prmOptions)
        {
            Tag = prmTag; Popular(prmTag, prmOptions);
        }

        private void Popular(TagCLI prmTag, xLista prmOptions)
        {
            foreach (string item in prmOptions)
                Add(new OptionTagCLI(prmTag, prmValue: item));

        }
        public void SetAtivo(string prmOption, bool prmAtivo)
        {
            foreach (OptionTagCLI Option in this)
                if (Option.IsMatch(prmOption))
                { Option.SetAtivo(prmAtivo); break; }
        }

        public bool GetAtivo(string prmTag, string prmOption)
        {
            foreach (OptionTagCLI Option in this)
                if (Option.IsMatch(prmTag, prmOption))
                    return true;
            return false;
        }

        private string GetLOG()
        {
            xLinhas txt = new xLinhas();

            foreach (OptionTagCLI Option in this)
                txt.Add(Option.log);

            return txt.memo;

        }

    }

}
