using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SwptSaveLib;

namespace SaveEditor.UI
{
    public partial class ItemEditView : UserControl, IInputView
    {
        private Item Value;
        private SynchronizationContext syncContext = null;
        public ItemEditView()
        {
            InitializeComponent();
            syncContext = SynchronizationContext.Current;
        }

        private void Init(ComboBox comboBox, List<KeyValue> list)
        {
            comboBox.BeginUpdate();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(list.ToArray());
            comboBox.EndUpdate();
        }

        public virtual Control GetControl()
        {
            return this;
        }
        public virtual void Init(SaveProperty value = null, Item item = null)
        {
            if (item != null)
            {
                this.Value = item;
            }
        }

        public virtual void UpdateUI()
        {
            var gv = this.Value;
            if (gv != null)
            {
                tb_itemid.Text = gv.ID;
                string name = gv.Name.GetStringValue();
                tb_name.Text = GameConstants.GetItemText(name, name);

                Vector2 size = gv.Position.GetVector2Value();
                tb_position.Text = (int)size.X + ", " + (int)size.Y;
                var v = gv.GetPrefix(false);
                if (v == null)
                {
                    tb_prefix.Text = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    tb_prefix.Text = GameConstants.GetPrefixText(name, name);
                }
                v = gv.GetSurfix(false);
                if (v == null)
                {
                    tb_surfix.Text = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    tb_surfix.Text = GameConstants.GetPrefixText(name, name);
                }
            }
        }

        public virtual void SaveValues()
        {
            try
            {
                var gv = this.Value;
                if (gv != null)
                {
                    string val = tb_name.Text.Trim();
                    int index = tb_name.SelectedIndex;
                    if (index >= 0)
                    {
                        //   MessageBox.Show(""+ ((KeyValue)tb_name.Items[index]).Key);
                        //     Application.Exit();
                        gv.Name.SetStringValue(((KeyValue)tb_name.Items[index]).Key);
                    }
                    else
                    {
                        //   MessageBox.Show("" + val);
                        //  Application.Exit();
                        //TODO may be chinese?
                        gv.Name.SetStringValue(val);
                    }
                    string[] arr = tb_position.Text.Split(',');
                    float[] i_arr = new float[2];
                    for (int i = 0; i < 2; i++)
                    {
                        i_arr[i] = float.Parse(arr[i]);
                    }
                    gv.Position.SetVector2Value(new Vector2(i_arr[0], i_arr[1]));
                    //prefix
                    val = tb_prefix.Text.Trim();
                    index = tb_prefix.SelectedIndex;
                    if (index >= 0)
                    {
                        val = ((KeyValue)tb_prefix.Items[index]).Key;
                    }
                    if (!string.IsNullOrEmpty(val))
                    {
                        gv.GetPrefix(true).SetStringValue(val);
                    }
                    else
                    {
                        gv.DeletePrefix();
                    }
                    //surfix
                    val = tb_surfix.Text.Trim();
                    index = tb_surfix.SelectedIndex;
                    if (index >= 0)
                    {
                        val = ((KeyValue)tb_surfix.Items[index]).Key;
                    }
                    if (!string.IsNullOrEmpty(val))
                    {
                        gv.GetSurfix(true).SetStringValue(val);
                    }
                    else
                    {
                        gv.DeleteSurfix();
                    }
                }
            }
            catch { }
        }
    }
}
