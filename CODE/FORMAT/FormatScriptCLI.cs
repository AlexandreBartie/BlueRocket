using Dooggy;
using Katty;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{

    public class AppColorScript
    {
        public ScriptCLI Script;
        public AppColor Padrao => Script.Editor.Cor.Padrao;

        private AppColorCode Code;
        public AppColorLog Log;
        public AppColorMsg Msg;

        public AppColorScript(ScriptCLI prmScript)
        {
            Script = prmScript;

            Code = new AppColorCode(this);
            Log = new AppColorLog(this);
            Msg = new AppColorMsg(this);
        }
        public myColor GetCor() => Code.GetCor();

        public Color GetCorFundo() => Code.GetCorFundo();
        public Color GetCorFrente() => Code.GetCorFrente();

        public Color GetCorFrente(bool prmIsTimeColor)
        {
            if (prmIsTimeColor)
                return GetCorSlowSQL();

            return GetCorFrente();
        }

        private Color GetCorSlowSQL()
        {
            if (Script.IsSlow)
                return Padrao.cor_frente_erro;

            return Padrao.cor_frente_consulta;
        }

    }
    public class AppColorCode : AppColorScriptBase
    {
        public AppColorCode(AppColorScript prmCor) : base(prmCor)
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
    public class AppColorLog : AppColorScriptBase
    {
        public AppColorLog(AppColorScript prmCor) : base(prmCor)
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
    public class AppColorMsg : AppColorScriptBase
    {
        public AppColorMsg(AppColorScript prmCor) : base(prmCor)
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
    public class AppColorScriptBase
    {

        public AppColorScript Cor;

        public ScriptCLI Script => Cor.Script;
        public AppColor Padrao => Cor.Padrao;

        public AppColorScriptBase(AppColorScript prmCor)
        {
            Cor = prmCor;
        }

    }

}
