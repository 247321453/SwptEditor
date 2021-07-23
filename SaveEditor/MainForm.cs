using SaveEditor.Properties;
using SaveEditor.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SwptSaveLib;
using System.Linq;
using System.Threading.Tasks;

namespace SaveEditor
{
    public partial class MainForm : Form
    {
        private SaveGame mSave;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "saveeditor.conf");
            GameConstants.Init(path, Resources.saveeditor);
            this.Text = this.Text + " v" + Program.VERSION;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者:海豹\nQQ:2457774381", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "请选择存档的Player.txt文件";
                dlg.Filter = "玩家数据|Player.txt|All Files|*.*";
                dlg.InitialDirectory = GameConstants.SAVE_PATH;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadSave(Path.GetDirectoryName(dlg.FileName));
                }
            }
        }

        private bool IsOpened()
        {
            return mSave != null;
        }

        private void SetStatus(string msg)
        {
            bottom_label.Text = msg;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOpened() || tabControl1.SelectedTab == null)
            {
                return;
            }
            var view = (ISaveView)tabControl1.SelectedTab.Tag;
            view.FillValues();
            var gs = view.GetGameSave();
            if (gs.Name == "Global")
            {
                List<string> cpList = new List<string>(GameConstants.Companions);
                foreach (var name in gs.GetCompanionList())
                {
                    if (!cpList.Contains(name))
                    {
                        MessageBox.Show("存在无效的随从名字:" + name);
                        return;
                    }
                }
            }
            if (!gs.Save(true))
            {
                SetStatus("保存失败:" + gs.Name);
                MessageBox.Show("保存存档失败!");
                return;
            }
            SetStatus("保存成功:" + gs.Name);
            if (gs.Name == "Global.txt")
            {
                //Storages.txt
                var page = GetPage("Storages");
                if (page == null)
                {
                    MessageBox.Show("读取背包数据出错");
                    return;
                }
                var saveView = page.Tag as ISaveView;
                if (saveView == null)
                {
                    MessageBox.Show("读取背包数据出错");
                    return;
                }
                bool reload = false;
                var storage_save = saveView.GetGameSave();
                List<string> cpList = new List<string>(gs.GetCompanionList());
                foreach (var name in GameConstants.Companions)
                {
                    if (!cpList.Contains(name))
                    {
                        //delete
                        storage_save.DeleteStorage(name);
                        reload = true;
                    }
                }
                foreach (var name in cpList)
                {
                    if (storage_save.GetStorage(name) == null)
                    {
                        //添加背包
                        storage_save.CreateStorage(name);
                    }
                }
                string dir = Path.GetDirectoryName(storage_save.FilePath);
                var kira_save = GetGameSave(mSave, "Kira");
                if (kira_save != null)
                {
                    foreach (var name in cpList)
                    {
                        var cp_save = kira_save.Clone(name);
                        cp_save.SetCharacterName(name);
                        cp_save.ResetAttr();
                        cp_save.ResetSkill();
                        cp_save.ClearEquip();
                        cp_save.Save();
                        reload = true;
                    }
                }
                storage_save.Save(true);
                if (reload)
                {
                    LoadSave(dir);
                }
                else
                {
                    saveView.Init();
                    saveView.UpdateUI();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private TabPage GetPage(string name)
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                var saveView = page.Tag as ISaveView;
                if (saveView != null)
                {
                    var gs = saveView.GetGameSave();
                    if (gs.Name == name)
                    {
                        return page;
                    }
                }
            }
            return null;
        }

        private SaveFile GetGameSave(SaveGame save, string name)
        {
            foreach (var gs in save.Files)
            {
                if (gs.Name == name)
                {
                    return gs;
                }
            }
            return null;
        }

        private void LoadSave(string path)
        {
            ItemIds = null;
            var save = SaveGame.Load(path);
            if (save == null)
            {
                MessageBox.Show("读取存档出错！");
                return;
            }
            UnCheckAllFilter(playerBodyToolStripMenuItem, save, true);
            tabControl1.TabPages.Clear();
            SetStatus("开始读取:" + path);
            Task.Run(() =>
            {
                var pages = InitTabs(save);
                this.Invoke((Action)(() =>
                {
                    SetStatus("读取完成:" + path);
                    mSave = save;
                    tabControl1.TabPages.AddRange(pages.ToArray());
                    UpdateAllPages();
                }));
            });

        }

        private void InitView(ISaveView saveView)
        {
            saveView.Init(hideUnknownToolStripMenuItem.Checked, true);
        }

        private List<TabPage> InitTabs(SaveGame save)
        {
            var pages = new List<TabPage>();
            var list = new List<string>();
            list.Add("Player");
            list.Add("Global");
            list.Add("Storages");
            list.Add("Items");
            for (int i = 0; i < list.Count; i++)
            {
                var gs = GetGameSave(save, list[i]);
                if (gs != null)
                {
                    var page = new TabPage();
                    InitPage(page, gs);
                    pages.Add(page);
                }
            }
            foreach (var gs in save.Files)
            {
                if (gs.Name == gs.GetFileDisplayName())
                {
                    continue;
                }
                if (list.Contains(gs.Name))
                {
                    continue;
                }
                var page = new TabPage();
                InitPage(page, gs);
                pages.Add(page);
            }
            return pages;
        }

        private ISaveView InitPage(TabPage page, SaveFile gs)
        {
            string filename = gs.Name;
            ISaveView saveView;
            if (gs.IsItemMode() && newItemListToolStripMenuItem.Checked)
            {
                saveView = new ItemListView();
            }
            else
            {
                saveView = new SaveView();
            }
            page.Text = gs.GetFileDisplayName();
            page.Name = "tab_" + filename;
            saveView.GetControl().Dock = DockStyle.Fill;
            InitView(saveView);
            page.Controls.Add(saveView.GetControl());
            page.Tag = saveView;
            if (gs.IsItemMode())
            {
                saveView.SetCheckShow((SaveFile save, Item item) =>
                {
                    string name = item.Name.GetStringValue();
                    if (hideManaHPToolStripMenuItem.Checked)
                    {
                        if (name.IsConsumeables())
                        {
                            return false;
                        }
                    }
                    return IsShow(item);
                });
            }
            saveView.Init(gs);
            return saveView;
        }

        private bool IsShow(Item item)
        {
            if (ItemIds == null)
            {
                return true;
            }
            return ItemIds.Contains(item.Id);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideUnknownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAllPages();
        }

        private void UpdateAllPages()
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                var saveView = page.Tag as ISaveView;
                InitView(saveView);
                UpdateSaveView(saveView);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == null)
            {
                return;
            }
            var view = (ISaveView)tabControl1.SelectedTab.Tag;
            var gs = view.GetGameSave();
            if (MessageBox.Show("当前角色是 [" + gs.GetCharacterName() + ":" + gs.GetLevel() + "]", "重置技能和属性", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            if (gs.ResetSkill() < 0)
            {
                MessageBox.Show("重置技能出错");
                return;
            }
            if (gs.ResetAttr() < 0)
            {
                MessageBox.Show("重置属性出错");
                return;
            }
            view.UpdateUI();
            if (!gs.Save(true))
            {
                MessageBox.Show("保存存档失败");
            }
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("询问", "重置全部角色的技能和属性",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            foreach (TabPage page in tabControl1.TabPages)
            {
                var saveView = (ISaveView)page.Tag;
                var gs = saveView.GetGameSave();
                if (gs.GetCharacterName() == null)
                {
                    continue;
                }
                if (gs.ResetSkill() < 0)
                {
                    MessageBox.Show("重置技能出错");
                    return;
                }
                if (gs.ResetAttr() < 0)
                {
                    MessageBox.Show("重置属性出错");
                    return;
                }
                saveView.UpdateUI();
                if (!gs.Save(true))
                {
                    MessageBox.Show("保存存档出错!");
                }
            }
        }

        private void hideManaHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }
        private void RefreshItems()
        {
            var page = GetPage("Items");
            if (page != null)
            {
                var saveView = page.Tag as ISaveView;
                InitView(saveView);
                UpdateSaveView(saveView);
            }
        }


        private void UpdateSaveView(ISaveView saveView)
        {
#if DEBUG
            long time = DateTime.Now.Ticks / 1000;
#endif
            Task.Run(() =>
            {
                saveView.Init();
                this.Invoke((Action)(() =>
                {
#if DEBUG
                    long time2 = DateTime.Now.Ticks / 1000;
                    Console.WriteLine("init use time=" + (time2 - time));
#endif
                    saveView.UpdateUI();
#if DEBUG
                    long time3 = DateTime.Now.Ticks / 1000;
                    Console.WriteLine("update ui use time=" + (time3 - time2));
#endif
                }));
            });
        }

        private List<int> GetEquipItems(SaveGame save, string name)
        {
            var gs = GetGameSave(save, name);
            if (gs != null)
            {
                return gs.GetEquipItems();
            }
            return new List<int>();
        }

        private List<int> GetStorageItems(SaveGame save, string name)
        {
            var gs = GetGameSave(save, "Storages");
            if (gs != null)
            {
                var s = gs.GetStorage(name);
                if (s != null)
                {
                    return new List<int>(s.GetIntArray());
                }
            }
            return new List<int>();
        }

        #region fileter
        private List<int> ItemIds = null;
        private void UnCheckAllFilter(object sender, SaveGame save, bool updateId = true)
        {
            var arr = new ToolStripMenuItem[]{
            playerStorageToolStripMenuItem,
            kStorageToolStripMenuItem,
            aStorageToolStripMenuItem,
            k2StorageToolStripMenuItem,
            lStorageToolStripMenuItem,
            playerBodyToolStripMenuItem,
            kiraBodyToolStripMenuItem,
            arishaBodyToolStripMenuItem,
            kerilaBodyToolStripMenuItem,
            lanoraBodyToolStripMenuItem,

            dilianaBodyToolStripMenuItem,
            mirenaBodyToolStripMenuItem,
            rowenaBodyToolStripMenuItem,
            dilianaStorageToolStripMenuItem,
            mirenaStorageToolStripMenuItem,
            rowenaStorageToolStripMenuItem,

            allToolStripMenuItem,
        };
            foreach (var menu in arr)
            {
                if (menu == sender)
                {
                    menu.Checked = true;
                }
                else
                {
                    menu.Checked = false;
                }
            }
            if (!updateId || save == null)
            {
                return;
            }
            if (lanoraBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Lanora");
            }
            else if (kerilaBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Kerila");
            }
            else if (arishaBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Arisha");
            }
            else if (kiraBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Kira");
            }
            else if (playerBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Player");
            }
            else if (playerStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Player");
            }
            else if (kStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Kira");
            }
            else if (aStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Arisha");
            }
            else if (k2StorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Kerila");
            }
            else if (lStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Lanora");
            }
            else if (dilianaBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Diliana");
            }
            else if (dilianaStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Diliana");
            }
            else if (mirenaBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Mirena");
            }
            else if (mirenaStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Mirena");
            }
            else if (rowenaBodyToolStripMenuItem.Checked)
            {
                ItemIds = GetEquipItems(save, "Rowena");
            }
            else if (rowenaStorageToolStripMenuItem.Checked)
            {
                ItemIds = GetStorageItems(save, "Rowena");
            }
            else
            {
                ItemIds = null;
            }
            RefreshItems();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllFilter(sender, mSave, true);
        }

        private void lanoraBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void kerilaBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void arishaBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void kiraBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void playerBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void lStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void k2StorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void aStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void kStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void playerStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void dilianaBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void dilianaStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void mirenaBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void mirenaStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void rowenaBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        private void rowenaStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem_Click(sender, e);
        }

        #endregion

        private void chooseSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenSaveForm())
            {
                dlg.InitialDirectory = GameConstants.SAVE_PATH;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(dlg.FileName);
                    LoadSave(Path.GetDirectoryName(dlg.FileName));
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
#if !DEBUG
            chooseSaveToolStripMenuItem_Click(null, null);
#endif
        }

        private void newItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newItemListToolStripMenuItem.Checked = !newItemListToolStripMenuItem.Checked;
            var page = GetPage("Items");
            if (page != null)
            {
                var old = page.Tag as ISaveView;
                var gs = old.GetGameSave();
                page.Controls.Clear();
                var saveView = InitPage(page, gs);
                InitView(saveView);
                UpdateSaveView(saveView);
            }
        }
    }
}
