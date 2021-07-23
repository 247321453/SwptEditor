using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class FlowLayoutPanelPlus : System.Windows.Forms.FlowLayoutPanel
    {
        public FlowLayoutPanelPlus() : base()
        {
            SetStyle(ControlStyles.DoubleBuffer |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
