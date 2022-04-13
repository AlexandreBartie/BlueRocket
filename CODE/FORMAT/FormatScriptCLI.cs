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
        public ScriptCLI Script;
        public ColorEditorCLI Padrao => Script.Editor.Cor.Padrao;

        private ColorCodeCLI Code;
        public ColorLogCLI Log;
        public ColorMsgCLI Msg;

        public ColorScriptCLI(ScriptCLI prmScript)
        {
            Script = prmScript;

            Code = new ColorCodeCLI(this);
            Log = new ColorLogCLI(this);
            Msg = new ColorMsgCLI(this);
        }
        public myColor GetCor() => Code.GetCor();

        public Color GetCorFrente() => Code.GetCorFrente();

        public Color GetCorFundo() => Code.GetCorFundo();

        public Color GetCorSlowSQL()
        {
            if (Script.IsSlow)
                return Padrao.cor_frente_erro;

            return Padrao.cor_frente_consulta;
        }

    }
    public class ColorCodeCLI : ColorBaseScriptCLI
    {
        public ColorCodeCLI(ColorScriptCLI prmCor) : base(prmCor)
        {
            Cor = prmCor;
        }
        public myColor GetCor()
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
            if (Script.IsLogError || Script.IsSlow)
                return Padrao.cor_fundo_erro;

            return Padrao.cor_fundo_padrao;
        }

    }
    public class ColorLogCLI : ColorBaseScriptCLI
    {
        public ColorLogCLI(ColorScriptCLI prmCor) : base(prmCor)
        {
            Cor = prmCor;
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
    public class ColorMsgCLI : ColorBaseScriptCLI
    {
        public ColorMsgCLI(ColorScriptCLI prmCor) : base(prmCor)
        {
            Cor = prmCor;
        }

        public Color GetCorFrente(string prmTipo)
        {
            if (myString.IsMatch(prmTipo, "erro"))
                return Padrao.cor_frente_erro;

            return Cor.GetCorFrente();
        }
    }
    public class ColorBaseScriptCLI
    {

        public ColorScriptCLI Cor;

        public ScriptCLI Script => Cor.Script;
        public ColorEditorCLI Padrao => Cor.Padrao;

        public ColorBaseScriptCLI(ColorScriptCLI prmCor)
        {
            Cor = prmCor;
        }

    }

}
