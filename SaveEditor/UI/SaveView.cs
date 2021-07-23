using SwptSaveLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveEditor.UI
{
    public partial class SaveView : UserControl, ISaveView
    {
        private SaveFile GameSave;
        private bool HideUnkown;
        private bool ReverseItem = true;
        private CheckShow CheckShow;
        private Control[] mWait = null;

        public SaveView()
        {
            InitializeComponent();
        }

        public virtual SaveFile GetGameSave()
        {
            return GameSave;
        }

        public virtual void Init(bool hideUnkown, bool reverseItem)
        {
            HideUnkown = hideUnkown;
            ReverseItem = reverseItem;
        }

        public virtual Control GetControl()
        {
            return this;
        }

        public virtual void UpdateUI()
        {
#if DEBUG
            long time1 = DateTime.Now.Ticks / 1000;
#endif
            if (mWait != null)
            {
                panel1.SuspendLayout();
                panel1.Controls.Clear();
                panel1.Controls.AddRange(mWait);
                mWait = null;
                panel1.ResumeLayout(false);
                panel1.PerformLayout();
            }
#if DEBUG
            long time2 = DateTime.Now.Ticks / 1000;
            Console.WriteLine("add views time=" + (time2 - time1));
#endif
            foreach (var c in panel1.Controls)
            {
                IInputView inputView = c as IInputView;
                if (inputView != null)
                {
                    inputView.UpdateUI();
                }
            }

#if DEBUG
            long time3 = DateTime.Now.Ticks / 1000;
            Console.WriteLine("update views time=" + (time3 - time2));
#endif
        }

        public virtual void Init(SaveFile save = null)
        {
            if (save != null)
            {
                this.GameSave = save;
            }
            if (this.GameSave != null)
            {
                var gs = this.GameSave;
                List<Control> list = new List<Control>();
                if (gs.IsItemMode())
                {
                    var items = gs.MakeItems();
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];
                        if (CheckShow != null && !CheckShow.Invoke(gs, item))
                        {
                            continue;
                        }
                        IInputView inputView = new ItemEditView();
                        inputView.Init(null, item);
                        list.Add(inputView.GetControl());
                    }
                }
                else
                {
                    var values = new List<SaveProperty>(gs.Properties);
                    if (ReverseItem)
                    {
                        values.Reverse();
                    }
                    for (int i = 0; i < values.Count; i++)
                    {
                        var gv = values[i];
                        if (HideUnkown && gv.GetDisplayName() == gv.Name)
                        {
                            continue;
                        }
                        IInputView inputView = new InputView();
                        inputView.Init(gv, null);
                        list.Add(inputView.GetControl());
                    }
                }
                mWait = list.ToArray();
            }
        }

        public virtual void FillValues()
        {
            if (this.GameSave != null)
            {
                foreach (var c in panel1.Controls)
                {
                    IInputView view = c as IInputView;
                    if (view != null)
                    {
                        view.SaveValues();
                    }
                }
            }
        }

        public virtual void SetCheckShow(CheckShow checkShow)
        {
            CheckShow = checkShow;
        }
    }
}
