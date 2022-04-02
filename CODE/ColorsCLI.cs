using Dooggy.CORE;
using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{

    public class ColorEditorCLI
    {
        public Color cor_frente_consulta => Color.Black;
        public Color cor_frente_edicao => Color.DarkGreen;
        public Color cor_frente_modificado => Color.DarkBlue;
        public Color cor_frente_erro => Color.DarkRed;

        public Color cor_fundo_padrao => Color.White;
        public Color cor_fundo_empty => Color.SeaShell;
        public Color cor_fundo_erro => Color.LightYellow;

        public myColor GetPadrao()
        {
            return new myColor(cor_frente_consulta, cor_fundo_padrao);
        }

    }

    public class ColorScriptCLI
    {
        private ScriptCLI ScriptCLI;

        public ColorCodeCLI Code;
        public ColorLogCLI Log;
        public ColorItemLogCLI ItemLog;

        public ColorEditorCLI Padrao => ScriptCLI.Editor.Format.Cor;

        public myColor GetPadrao() => Code.Get();

        public ColorScriptCLI(ScriptCLI prmScriptCLI)
        {
            ScriptCLI = prmScriptCLI;

            Code = new ColorCodeCLI(prmScriptCLI);
            Log = new ColorLogCLI(prmScriptCLI);
            ItemLog = new ColorItemLogCLI(prmScriptCLI);
        }

    }
    public class ColorCodeCLI
    {
        private ScriptCLI Script;

        private ColorEditorCLI Padrao => Script.Cor.Padrao;

        public ColorCodeCLI(ScriptCLI prmScript)
        {
            Script = prmScript;
        }
        public myColor Get()
        {
            return new myColor(GetCorFrente(), GetCorFundo());
        }
        public Color GetCorFrente()
        {
            if (!Script.IsLocked)

                if (Script.IsChanged)
                    return Padrao.cor_frente_modificado;
                else
                    return Padrao.cor_frente_edicao;

            return Padrao.cor_frente_consulta;
        }
        public Color GetCorFundo()
        {
            if (Script.IsLogError)
                return Padrao.cor_fundo_erro;

            return Padrao.cor_fundo_padrao;
        }

    }
    public class ColorLogCLI
    {
        private ScriptCLI Script;

        private ColorEditorCLI Padrao => Script.Cor.Padrao;
        private ColorCodeCLI Cor => Script.Cor.Code;

        public ColorLogCLI(ScriptCLI prmScript)
        {
            Script = prmScript;
        }
        public Color GetCorFrente()
        {
            if (Script.IsLogError)
                return Padrao.cor_frente_erro;

            return Cor.GetCorFrente();
        }
        public Color GetCorFundo()
        {

            if (!Script.IsResult)
                return Padrao.cor_fundo_empty;

            return Padrao.cor_fundo_padrao;
        }
    }
    public class ColorItemLogCLI
    {
        private ScriptCLI Script;

        private ColorEditorCLI Padrao => Script.Cor.Padrao;
        private ColorCodeCLI Cor => Script.Cor.Code;

        public ColorItemLogCLI(ScriptCLI prmScript)
        {
            Script = prmScript;
        }

        public Color GetCorFrente(string prmTipo)
        {
            if (myString.IsEqual(prmTipo, "erro"))
                return Padrao.cor_frente_erro;

            return Cor.GetCorFrente();
        }
    }
    public class ColorTagCLI
    {
        private DataTag Tag;

        private ColorEditorCLI Padrao;// => Tag.Editor.Format.Cor;

        public ColorTagCLI(DataTag prmTag)
        {
            Tag = prmTag;
        }

        public myColor Get()
        {
            return new myColor(GetCorFrente(), GetCorFundo());
        }
        public Color GetCorFrente()
        {
            return Padrao.cor_frente_consulta;
        }
        public Color GetCorFundo()
        {
            return Padrao.cor_fundo_padrao;
        }
    }

    public class ColorOptionTagCLI
    {
        private OptionTag Option;

        private ColorEditorCLI Padrao;// => Option.Tag.Format.Cor;

        public ColorOptionTagCLI(OptionTag prmOptionTag)
        {
            Option = prmOptionTag;
        }

        public myColor Get()
        {
            return new myColor(GetCorFrente(), GetCorFundo());
        }
        public Color GetCorFrente()
        {
            return Padrao.cor_frente_consulta;
        }
        public Color GetCorFundo()
        {
            
            if (Option.IsPadrao)
                return Color.LightGray;

            return Padrao.cor_fundo_padrao;
        }
    }

}
