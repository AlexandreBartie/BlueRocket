using Dooggy.LIBRARY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueRocket
{
    public class ColorEditorCLI : ColorBaseEditorCLI
    {
        public ColorTagCLI Tag;
        public ColorOptionCLI Option;

        public Color cor_frente_consulta => Color.Black;
        public Color cor_frente_edicao => Color.DarkGreen;
        public Color cor_frente_modificado => Color.DarkBlue;
        public Color cor_frente_erro => Color.DarkRed;

        public Color cor_fundo_padrao => Color.White;
        public Color cor_fundo_empty => Color.SeaShell;
        public Color cor_fundo_erro => Color.LightYellow;
        public Color cor_fundo_destaque => Color.LightGray;

        public ColorEditorCLI(EditorCLI prmEditor) : base(prmEditor)
        {

            Tag = new ColorTagCLI(prmEditor);
            Option = new ColorOptionCLI(prmEditor);
        }

        public myColor GetPadrao()
        {
            return new myColor(cor_frente_consulta, cor_fundo_padrao);
        }
    }

    public class ColorBaseEditorCLI
    {

        public EditorCLI Editor;

        public ColorEditorCLI Padrao => Editor.Cor;

        public ColorBaseEditorCLI(EditorCLI prmEditor)
        {
            Editor = prmEditor;
        }

    }
}
