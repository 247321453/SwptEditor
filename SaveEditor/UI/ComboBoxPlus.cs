using System;

namespace SaveEditor.UI
{
    class ComboBoxPlus : System.Windows.Forms.ComboBox
    {
        public ComboBoxPlus() : base()
        {
        }
        public bool isWheel = false;
        public string strComB = null;
        protected override void OnMouseWheel(System.Windows.Forms.MouseEventArgs e)
        {
            strComB = Text;
            isWheel = true;
        }
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isWheel = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (isWheel)
            {
                Text = strComB;
            }
        }
    }
}
