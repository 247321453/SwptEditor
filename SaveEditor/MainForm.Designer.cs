namespace SaveEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hideUnknownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideManaHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.playerBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiraBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arishaBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kerilaBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanoraBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilianaBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirenaBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowenaBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.playerStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.k2StorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilianaStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirenaStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowenaStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bottom_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemFilterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.chooseSaveToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.resetToolStripMenuItem,
            this.resetAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.hideUnknownToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // chooseSaveToolStripMenuItem
            // 
            this.chooseSaveToolStripMenuItem.Name = "chooseSaveToolStripMenuItem";
            this.chooseSaveToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.chooseSaveToolStripMenuItem.Text = "存档列表";
            this.chooseSaveToolStripMenuItem.Click += new System.EventHandler(this.chooseSaveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveAsToolStripMenuItem.Text = "另存为";
            this.saveAsToolStripMenuItem.Visible = false;
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.resetToolStripMenuItem.Text = "重置当前角色技能和属性";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.resetAllToolStripMenuItem.Text = "重置全部角色技能和属性";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // hideUnknownToolStripMenuItem
            // 
            this.hideUnknownToolStripMenuItem.Checked = true;
            this.hideUnknownToolStripMenuItem.CheckOnClick = true;
            this.hideUnknownToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideUnknownToolStripMenuItem.Name = "hideUnknownToolStripMenuItem";
            this.hideUnknownToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hideUnknownToolStripMenuItem.Text = "隐藏没翻译的内容";
            this.hideUnknownToolStripMenuItem.Click += new System.EventHandler(this.hideUnknownToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.quitToolStripMenuItem.Text = "退出";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // itemFilterToolStripMenuItem
            // 
            this.itemFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideManaHPToolStripMenuItem,
            this.newItemListToolStripMenuItem,
            this.toolStripSeparator6,
            this.playerBodyToolStripMenuItem,
            this.kiraBodyToolStripMenuItem,
            this.arishaBodyToolStripMenuItem,
            this.kerilaBodyToolStripMenuItem,
            this.lanoraBodyToolStripMenuItem,
            this.dilianaBodyToolStripMenuItem,
            this.mirenaBodyToolStripMenuItem,
            this.rowenaBodyToolStripMenuItem,
            this.toolStripSeparator4,
            this.playerStorageToolStripMenuItem,
            this.kStorageToolStripMenuItem,
            this.aStorageToolStripMenuItem,
            this.k2StorageToolStripMenuItem,
            this.lStorageToolStripMenuItem,
            this.dilianaStorageToolStripMenuItem,
            this.mirenaStorageToolStripMenuItem,
            this.rowenaStorageToolStripMenuItem,
            this.toolStripSeparator5,
            this.allToolStripMenuItem});
            this.itemFilterToolStripMenuItem.Name = "itemFilterToolStripMenuItem";
            this.itemFilterToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.itemFilterToolStripMenuItem.Text = "物品";
            // 
            // hideManaHPToolStripMenuItem
            // 
            this.hideManaHPToolStripMenuItem.Checked = true;
            this.hideManaHPToolStripMenuItem.CheckOnClick = true;
            this.hideManaHPToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideManaHPToolStripMenuItem.Name = "hideManaHPToolStripMenuItem";
            this.hideManaHPToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hideManaHPToolStripMenuItem.Text = "隐藏非装备物品";
            this.hideManaHPToolStripMenuItem.Click += new System.EventHandler(this.hideManaHPToolStripMenuItem_Click);
            // 
            // newItemListToolStripMenuItem
            // 
            this.newItemListToolStripMenuItem.Checked = true;
            this.newItemListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newItemListToolStripMenuItem.Name = "newItemListToolStripMenuItem";
            this.newItemListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newItemListToolStripMenuItem.Text = "使用新的物品列表";
            this.newItemListToolStripMenuItem.Click += new System.EventHandler(this.newItemListToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // playerBodyToolStripMenuItem
            // 
            this.playerBodyToolStripMenuItem.Checked = true;
            this.playerBodyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playerBodyToolStripMenuItem.Name = "playerBodyToolStripMenuItem";
            this.playerBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.playerBodyToolStripMenuItem.Text = "Player身上装备";
            this.playerBodyToolStripMenuItem.Click += new System.EventHandler(this.playerBodyToolStripMenuItem_Click);
            // 
            // kiraBodyToolStripMenuItem
            // 
            this.kiraBodyToolStripMenuItem.Name = "kiraBodyToolStripMenuItem";
            this.kiraBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kiraBodyToolStripMenuItem.Text = "Kira身上装备";
            this.kiraBodyToolStripMenuItem.Click += new System.EventHandler(this.kiraBodyToolStripMenuItem_Click);
            // 
            // arishaBodyToolStripMenuItem
            // 
            this.arishaBodyToolStripMenuItem.Name = "arishaBodyToolStripMenuItem";
            this.arishaBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.arishaBodyToolStripMenuItem.Text = "Arisha身上装备";
            this.arishaBodyToolStripMenuItem.Click += new System.EventHandler(this.arishaBodyToolStripMenuItem_Click);
            // 
            // kerilaBodyToolStripMenuItem
            // 
            this.kerilaBodyToolStripMenuItem.Name = "kerilaBodyToolStripMenuItem";
            this.kerilaBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kerilaBodyToolStripMenuItem.Text = "Kerila身上装备";
            this.kerilaBodyToolStripMenuItem.Click += new System.EventHandler(this.kerilaBodyToolStripMenuItem_Click);
            // 
            // lanoraBodyToolStripMenuItem
            // 
            this.lanoraBodyToolStripMenuItem.Name = "lanoraBodyToolStripMenuItem";
            this.lanoraBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.lanoraBodyToolStripMenuItem.Text = "Lanora身上装备";
            this.lanoraBodyToolStripMenuItem.Click += new System.EventHandler(this.lanoraBodyToolStripMenuItem_Click);
            // 
            // dilianaBodyToolStripMenuItem
            // 
            this.dilianaBodyToolStripMenuItem.Name = "dilianaBodyToolStripMenuItem";
            this.dilianaBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dilianaBodyToolStripMenuItem.Text = "Diliana身上装备";
            this.dilianaBodyToolStripMenuItem.Click += new System.EventHandler(this.dilianaBodyToolStripMenuItem_Click);
            // 
            // mirenaBodyToolStripMenuItem
            // 
            this.mirenaBodyToolStripMenuItem.Name = "mirenaBodyToolStripMenuItem";
            this.mirenaBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mirenaBodyToolStripMenuItem.Text = "Mirena身上装备";
            this.mirenaBodyToolStripMenuItem.Click += new System.EventHandler(this.mirenaBodyToolStripMenuItem_Click);
            // 
            // rowenaBodyToolStripMenuItem
            // 
            this.rowenaBodyToolStripMenuItem.Name = "rowenaBodyToolStripMenuItem";
            this.rowenaBodyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rowenaBodyToolStripMenuItem.Text = "Rowena身上装备";
            this.rowenaBodyToolStripMenuItem.Click += new System.EventHandler(this.rowenaBodyToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // playerStorageToolStripMenuItem
            // 
            this.playerStorageToolStripMenuItem.Name = "playerStorageToolStripMenuItem";
            this.playerStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.playerStorageToolStripMenuItem.Text = "Player背包";
            this.playerStorageToolStripMenuItem.Click += new System.EventHandler(this.playerStorageToolStripMenuItem_Click);
            // 
            // kStorageToolStripMenuItem
            // 
            this.kStorageToolStripMenuItem.Name = "kStorageToolStripMenuItem";
            this.kStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kStorageToolStripMenuItem.Text = "Kira背包";
            this.kStorageToolStripMenuItem.Click += new System.EventHandler(this.kStorageToolStripMenuItem_Click);
            // 
            // aStorageToolStripMenuItem
            // 
            this.aStorageToolStripMenuItem.Name = "aStorageToolStripMenuItem";
            this.aStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aStorageToolStripMenuItem.Text = "Arisha背包";
            this.aStorageToolStripMenuItem.Click += new System.EventHandler(this.aStorageToolStripMenuItem_Click);
            // 
            // k2StorageToolStripMenuItem
            // 
            this.k2StorageToolStripMenuItem.Name = "k2StorageToolStripMenuItem";
            this.k2StorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.k2StorageToolStripMenuItem.Text = "Kerila背包";
            this.k2StorageToolStripMenuItem.Click += new System.EventHandler(this.k2StorageToolStripMenuItem_Click);
            // 
            // lStorageToolStripMenuItem
            // 
            this.lStorageToolStripMenuItem.Name = "lStorageToolStripMenuItem";
            this.lStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.lStorageToolStripMenuItem.Text = "Lanora背包";
            this.lStorageToolStripMenuItem.Click += new System.EventHandler(this.lStorageToolStripMenuItem_Click);
            // 
            // dilianaStorageToolStripMenuItem
            // 
            this.dilianaStorageToolStripMenuItem.Name = "dilianaStorageToolStripMenuItem";
            this.dilianaStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dilianaStorageToolStripMenuItem.Text = "Diliana背包";
            this.dilianaStorageToolStripMenuItem.Click += new System.EventHandler(this.dilianaStorageToolStripMenuItem_Click);
            // 
            // mirenaStorageToolStripMenuItem
            // 
            this.mirenaStorageToolStripMenuItem.Name = "mirenaStorageToolStripMenuItem";
            this.mirenaStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mirenaStorageToolStripMenuItem.Text = "Mirena背包";
            this.mirenaStorageToolStripMenuItem.Click += new System.EventHandler(this.mirenaStorageToolStripMenuItem_Click);
            // 
            // rowenaStorageToolStripMenuItem
            // 
            this.rowenaStorageToolStripMenuItem.Name = "rowenaStorageToolStripMenuItem";
            this.rowenaStorageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rowenaStorageToolStripMenuItem.Text = "Rowena背包";
            this.rowenaStorageToolStripMenuItem.Click += new System.EventHandler(this.rowenaStorageToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.allToolStripMenuItem.Text = "显示全部位置的物品";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottom_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bottom_label
            // 
            this.bottom_label.Name = "bottom_label";
            this.bottom_label.Size = new System.Drawing.Size(44, 17);
            this.bottom_label.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 682);
            this.tabControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWPT存档修改器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel bottom_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideUnknownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem hideManaHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem kiraBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arishaBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kerilaBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanoraBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem kStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem k2StorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilianaBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilianaStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirenaBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirenaStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowenaBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowenaStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemListToolStripMenuItem;
    }
}

