using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwptSaveLib;

namespace SaveEditor.UI
{
    public partial class ItemListView : UserControl, ISaveView
    {
        private SaveFile GameSave;
        private bool HideUnkown;
        private bool ReverseItem = true;
        private CheckShow CheckShow;
        private ListViewItem[] mWait = null;
        private ListViewItem mSelected = null;
        private int INDEX_ID = 0;
        private int INDEX_POS = 1;
        private int INDEX_SURFIX = 2;
        private int INDEX_PREFIX = 3;
        private int INDEX_NAME = 4;

        public ItemListView()
        {
            InitializeComponent();
            this.cb_name.Items.AddRange(SwptSaveLib.GameConstants.ITEMS);
            this.cb_surfix.Items.AddRange(SwptSaveLib.GameConstants.SURFIXS);
            this.cb_prefix.Items.AddRange(SwptSaveLib.GameConstants.PREFIXS);
        }

        public Control GetControl()
        {
            return this;
        }

        public SaveFile GetGameSave()
        {
            return this.GameSave;
        }

        public void Init(bool hideUnkown, bool reverseItem)
        {
            HideUnkown = hideUnkown;
            ReverseItem = reverseItem;
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
                var list = new List<ListViewItem>();
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
                        var listItem = new ListViewItem();
                        Fill(listItem, item);
                        list.Add(listItem);
                    }
                }
                mWait = list.ToArray();
            }
        }

        private void Fill(ListViewItem row, Item gv)
        {
            if (row.Tag == null)
            {
                row.Tag = gv;
                row.Text = gv.ID;
                string name = gv.Name.GetStringValue();
                Vector2 size = gv.Position.GetVector2Value();
                string str_v = (int)size.X + ", " + (int)size.Y;
                row.SubItems.Add(str_v);
                var v = gv.GetSurfix(false);
                if (v == null)
                {
                    str_v = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    str_v = GameConstants.GetSurfixText(name, name);
                }
                row.SubItems.Add(str_v);

                v = gv.GetPrefix(false);
                if (v == null)
                {
                    str_v = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    str_v = GameConstants.GetPrefixText(name, name);
                }
                row.SubItems.Add(str_v);
                row.SubItems.Add(GameConstants.GetItemText(name, name));
            }
            else
            {
                //row.Tag = gv;
                //row.Text = gv.ID;
                if (gv == null) {
                    gv = row.Tag as Item;
                }
                if (gv == null) {
                    return;
                }

                string str_v;
                //Vector2 size = gv.Position.GetVector2Value();
                //str_v = (int)size.X + ", " + (int)size.Y;
                //row.SubItems[INDEX_POS].Text = str_v;

                string name;
                var v = gv.GetSurfix(false);
                if (v == null)
                {
                    str_v = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    str_v = GameConstants.GetSurfixText(name, name);
                }
                row.SubItems[INDEX_SURFIX].Text = str_v;

                v = gv.GetPrefix(false);
                if (v == null)
                {
                    str_v = string.Empty;
                }
                else
                {
                    name = v.GetStringValue();
                    str_v = GameConstants.GetPrefixText(name, name);
                }
                row.SubItems[INDEX_PREFIX].Text = str_v;
                name = gv.Name.GetStringValue();
                row.SubItems[INDEX_NAME].Text = GameConstants.GetItemText(name, name);
            }
        }

        public void SetCheckShow(CheckShow checkShow)
        {
            CheckShow = checkShow;
        }

        public void UpdateUI()
        {
#if DEBUG
            long time1 = DateTime.Now.Ticks / 1000;
#endif
            if (mWait != null)
            {
                list_items.BeginUpdate();
                list_items.Items.Clear();
                list_items.Items.AddRange(mWait);
                list_items.EndUpdate();
                mWait = null;
            }
#if DEBUG
            long time2 = DateTime.Now.Ticks / 1000;
            Console.WriteLine("add views time=" + (time2 - time1));
#endif
            foreach (ListViewItem row in list_items.Items)
            {
                var item = row.Tag as Item;
                if (item != null)
                {
                    Fill(row, item);
                }
            }

#if DEBUG
            long time3 = DateTime.Now.Ticks / 1000;
            Console.WriteLine("update views time=" + (time3 - time2));
#endif
        }

        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = list_items.SelectedItems;
            if (selected != null && selected.Count > 0)
            {
                mSelected = selected[0];
                Read(mSelected);
            }
        }

        private void Read(ListViewItem row)
        {
            if (row != null)
            {
                var item = row.Tag as Item;
                if (item != null)
                {
                    tb_id.Text = row.SubItems[INDEX_ID].Text;
                    tb_position.Text = row.SubItems[INDEX_POS].Text;
                    cb_name.Text = row.SubItems[INDEX_NAME].Text;
                    cb_prefix.Text = row.SubItems[INDEX_PREFIX].Text;
                    cb_surfix.Text = row.SubItems[INDEX_SURFIX].Text;

                    tb_name.Text = item.Name.GetStringValue();
                    if (tb_name.Text.EndsWith(" "))
                    {
                        lb_bottom.Text = "注意物品名后面带有空格";
                    }
                    else {
                        lb_bottom.Text = "";
                    }
                    var p = item.GetPrefix(false);
                    tb_prefix.Text = p == null ? string.Empty : p.GetStringValue();
                    p = item.GetSurfix(false);
                    tb_surfix.Text = p == null ? string.Empty : p.GetStringValue();
                }
            }
        }
        private bool Save(ListViewItem row)
        {
            if (row == null)
            {
                return false;
            }
            var gv = row.Tag as Item;
            if (gv != null)
            {
                try
                {
                    string val = cb_name.Text;
                    int index = cb_name.SelectedIndex;
                    if (index >= 0)
                    {
                        val = ((KeyValue)cb_name.Items[index]).Key;
                    }
                    gv.Name.SetStringValue(val);

                    string[] arr = tb_position.Text.Split(',');
                    float[] i_arr = new float[2];
                    for (int i = 0; i < 2; i++)
                    {
                        i_arr[i] = float.Parse(arr[i]);
                    }
                    gv.Position.SetVector2Value(new Vector2(i_arr[0], i_arr[1]));
                    //prefix
                    val = cb_prefix.Text;
                    index = cb_prefix.SelectedIndex;
                    if (index >= 0)
                    {
                        val = ((KeyValue)cb_prefix.Items[index]).Key;
                    }
                    if (!string.IsNullOrEmpty(val))
                    {
                        Console.WriteLine("prefix="+val);
                        gv.GetPrefix(true).SetStringValue(val);
                    }
                    else
                    {
                        Console.WriteLine("delete prefix");
                        gv.DeletePrefix();
                    }
                    //surfix
                    val = cb_surfix.Text;
                    index = cb_surfix.SelectedIndex;
                    if (index >= 0)
                    {
                        val = ((KeyValue)cb_surfix.Items[index]).Key;
                    }
                    if (!string.IsNullOrEmpty(val))
                    {
                        Console.WriteLine("surfix=" + val);
                        gv.GetSurfix(true).SetStringValue(val);
                    }
                    else
                    {
                        Console.WriteLine("delete surfix");
                        gv.DeleteSurfix();
                    }
                    return true;
                }
#if DEBUG
                catch(Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace);
#else 
                catch
                {
#endif
                }
            }
            return false;
        }
        public void FillValues()
        {
            //nothing
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mSelected != null)
            {
                Read(mSelected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mSelected != null)
            {
                if (Save(mSelected)) {
                    Fill(mSelected, null);
                    Read(mSelected);
                    if (checkBox1.Checked) {
                        GameSave.Save(true);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "修改并保存";
            }
            else {
                button1.Text = "修改并保存";
            }
        }

        private void cb_surfix_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_surfix.SelectedIndex;
            if (index >= 0)
            {
                tb_name.Text = ((KeyValue)cb_surfix.Items[index]).Key;
            }
        }

        private void cb_prefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_prefix.SelectedIndex;
            if (index >= 0)
            {
                tb_name.Text = ((KeyValue)cb_prefix.Items[index]).Key;
            }
        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_name.SelectedIndex;
            if (index >= 0)
            {
                tb_name.Text = ((KeyValue)cb_name.Items[index]).Key;
            }
        }
    }
}
