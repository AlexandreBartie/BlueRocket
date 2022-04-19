using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class AppColorTag : AppColorBase
    {
        public AppColorTag(AppCLI prmApp) : base(prmApp)
        {
            App = prmApp;
        }

        public myColor GetCor(myTag prmTag)
        {
            return new myColor(GetCorFrente(prmTag), GetCorFundo(prmTag));
        }
        public Color GetCorFrente(myTag prmTag)
        {
            return Padrao.cor_frente_consulta;
        }
        public Color GetCorFundo(myTag prmTag)
        {
            if (prmTag.IsPadrao)
                return Color.Blue;
            
            return Padrao.cor_fundo_padrao;
        }
    }
    public class AppColorOption : AppColorBase
    {
        public AppColorOption(AppCLI prmApp) : base(prmApp)
        {
            App = prmApp;
        }

        public myColor GetCor(myTagOption prmTagOption)
        {
            return new myColor(GetCorFrente(prmTagOption), GetCorFundo(prmTagOption));
        }
        public Color GetCorFrente(myTagOption prmTagOption)
        {
            return Padrao.cor_frente_consulta;
        }
        public Color GetCorFundo(myTagOption prmTagOption)
        {

            if (prmTagOption.IsPadrao)
                return Padrao.cor_fundo_destaque;

            return Padrao.cor_fundo_padrao;
        }
    }
}
