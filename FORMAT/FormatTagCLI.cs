using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class ColorTagCLI : ColorBaseEditorCLI
    {
        public ColorTagCLI(EditorCLI prmEditor) : base(prmEditor)
        {
            Editor = prmEditor;
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
            return Padrao.cor_fundo_padrao;
        }
    }
    public class ColorOptionCLI : ColorBaseEditorCLI
    {
        public ColorOptionCLI(EditorCLI prmEditor) : base(prmEditor)
        {
            Editor = prmEditor;
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
                return Color.LightGray;

            return Padrao.cor_fundo_padrao;
        }
    }
}
