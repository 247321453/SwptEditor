using SwptSaveLib;
using System.Windows.Forms;

namespace SaveEditor.UI
{
    public interface IInputView
    {
        Control GetControl();

        void Init(SaveProperty value = null, Item item = null);

        void UpdateUI();

        void SaveValues();
    }
}
