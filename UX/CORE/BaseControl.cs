using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueRocket
{

    public class PageControl : UserControl
    {

        private BaseControl _Base;

        private Control _Control;

        public EditorCLI Editor => _Base.Editor;

        public AppCLI App => _Base.App;

        public AppFormat Format => Editor.Format;

        public BaseControl GetBase() => _Base;

        public Control GetControl() => _Control;

        public PageControl() { }

        public PageControl(Control prmControl)
        {
            GetAttach(prmControl);
        }

        public void Setup(EditorCLI prmEditor)
        {
            _Base = new BaseControl(prmEditor);
        }

        private void GetAttach(Control prmControl)
        {
            prmControl.Parent = this; prmControl.Dock = DockStyle.Fill; _Control = prmControl;
        }
    }

    public class FormControl : Form
    {

        private BaseControl _Base;

        public EditorCLI Editor => _Base.Editor;
        public AppCLI App => _Base.App;

        public BaseControl GetBase() => _Base;

        public void Setup(EditorCLI prmEditor)
        {
            _Base = new BaseControl(prmEditor);
        }

    }

    public class BaseControl
    {
        private EditorCLI _Editor;

        public EditorCLI Editor { get => _Editor; }
        public AppCLI App => Editor.App;

        public BaseControl(EditorCLI prmEditor)
        {
            _Editor = prmEditor;
        }

    }

}
