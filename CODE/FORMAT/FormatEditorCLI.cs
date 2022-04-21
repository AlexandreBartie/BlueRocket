using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class AppColor : AppColorBase
    {
        public AppColorTag Tag;
        public AppColorOption Option;

        public Color cor_frente_consulta => Color.Black;
        public Color cor_frente_edicao => Color.DarkGreen;
        public Color cor_frente_modificado => Color.DarkBlue;

        public Color cor_fundo_padrao => Color.White;
        public Color cor_fundo_empty => Color.SeaShell;


        public Color cor_frente_erro => Color.DarkRed;
        public Color cor_fundo_erro => Color.LightYellow;

        public Color cor_frente_destaque => Color.DarkSalmon;
        public Color cor_fundo_destaque => Color.GhostWhite;

        public AppColor(AppCLI prmApp) : base(prmApp)
        {

            Tag = new AppColorTag(prmApp);
            Option = new AppColorOption(prmApp);
        }

        public myColor GetPadrao()
        {
            return new myColor(cor_frente_consulta, cor_fundo_padrao);
        }
    }

    public class AppColorBase
    {

        public AppCLI App;

        public AppColor Padrao => App.Cor;

        public AppColorBase(AppCLI prmApp)
        {
            App = prmApp;
        }

    }
}
