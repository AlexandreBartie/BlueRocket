using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class ColorScriptCLI
    {
        private ScriptCLI ScriptCLI;

        private EditorFormat Format => ScriptCLI.Editor.Format;

        public ColorScriptCLI(ScriptCLI prmScriptCLI)
        {
            ScriptCLI = prmScriptCLI;
        }

        public myColor GetCodeColor()
        {
            return new myColor(GetCodeForeColor(), GetCodeBackColor());
        }
        public Color GetCodeForeColor()
        {
            if (!ScriptCLI.IsLocked)

                if (ScriptCLI.IsChanged)
                    return Format.ColorCLI.cor_frente_modificado;
                else
                    return Format.ColorCLI.cor_frente_edicao;

            return Format.ColorCLI.cor_frente_consulta;
        }
        public Color GetCodeBackColor()
        {
            if (ScriptCLI.IsLogError)
                return Format.ColorCLI.cor_fundo_erro;

            return Format.ColorCLI.cor_fundo_padrao;
        }
        public Color GetLogForeColor()
        {
            if (ScriptCLI.IsLogError)
                return Format.ColorCLI.cor_frente_erro;

            return GetCodeForeColor();
        }
        public Color GetLogBackColor()
        {

            if (!ScriptCLI.IsResult)
                return Format.ColorCLI.cor_fundo_empty;

            return Format.ColorCLI.cor_fundo_padrao;
        }
        public Color GetItemLogForeColor(string prmTipo)
        {

            if (myString.IsEqual(prmTipo, "erro"))
                return Format.ColorCLI.cor_frente_erro;

            return GetCodeForeColor();
        }

    }

    public class ColorTagCLI
    {
        private TagCLI Tag;

        private EditorFormat Format => Tag.Editor.Format;

        public ColorTagCLI(TagCLI prmTag)
        {
            Tag = prmTag;
        }

        public myColor GetCodeColor()
        {
            return new myColor(GetFilterForeColor(), GetFilterBackColor());
        }
        public Color GetFilterForeColor()
        {
            return Format.ColorCLI.cor_frente_consulta;
        }
        public Color GetFilterBackColor()
        {
            return Format.ColorCLI.cor_fundo_padrao;
        }
    }

    public class ColorOptionTagCLI
    {
        private OptionTagCLI OptionTagCLI;

        private EditorFormat Format => OptionTagCLI.Format;

        public ColorOptionTagCLI(OptionTagCLI prmOptionTagCLI)
        {
            OptionTagCLI = prmOptionTagCLI;
        }

        public myColor GetCodeColor()
        {
            return new myColor(GetFilterForeColor(), GetFilterBackColor());
        }
        public Color GetFilterForeColor()
        {
            return Format.ColorCLI.cor_frente_consulta;
        }
        public Color GetFilterBackColor()
        {
            return Format.ColorCLI.cor_fundo_padrao;
        }
    }

}
