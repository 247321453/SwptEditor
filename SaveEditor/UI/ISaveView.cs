using SwptSaveLib;
using System.Windows.Forms;

namespace SaveEditor.UI
{
    public delegate bool CheckShow(SaveFile save, Item item);
    public interface ISaveView
    {
        SaveFile GetGameSave();
        //public bool HideUnkown;
        // public bool ReverseItem = true;
        // public bool HidePotions = true;
        void Init(bool hideUnkown, bool reverseItem);

        void SetCheckShow(CheckShow checkShow);

        Control GetControl();

        void Init(SaveFile value = null);

        void UpdateUI();

        void FillValues();
    }
}
