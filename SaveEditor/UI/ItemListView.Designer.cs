namespace SaveEditor.UI
{
    partial class ItemListView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.list_items = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.cb_surfix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_prefix = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_surfix = new System.Windows.Forms.TextBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_bottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.list_items.FullRowSelect = true;
            this.list_items.GridLines = true;
            this.list_items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_items.HideSelection = false;
            this.list_items.Location = new System.Drawing.Point(0, 0);
            this.list_items.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_items.MultiSelect = false;
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(720, 500);
            this.list_items.TabIndex = 0;
            this.list_items.UseCompatibleStateImageBehavior = false;
            this.list_items.View = System.Windows.Forms.View.Details;
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "位置";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "词条1";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "词条2";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "物品名";
            this.columnHeader2.Width = 220;
            // 
            // cb_name
            // 
            this.cb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(728, 149);
            this.cb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(260, 28);
            this.cb_name.TabIndex = 1;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            // 
            // cb_surfix
            // 
            this.cb_surfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_surfix.FormattingEnabled = true;
            this.cb_surfix.Location = new System.Drawing.Point(728, 274);
            this.cb_surfix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_surfix.Name = "cb_surfix";
            this.cb_surfix.Size = new System.Drawing.Size(260, 28);
            this.cb_surfix.TabIndex = 1;
            this.cb_surfix.SelectedIndexChanged += new System.EventHandler(this.cb_surfix_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "词条2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "词条1";
            // 
            // cb_prefix
            // 
            this.cb_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_prefix.FormattingEnabled = true;
            this.cb_prefix.Location = new System.Drawing.Point(728, 213);
            this.cb_prefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_prefix.Name = "cb_prefix";
            this.cb_prefix.Size = new System.Drawing.Size(260, 28);
            this.cb_prefix.TabIndex = 1;
            this.cb_prefix.SelectedIndexChanged += new System.EventHandler(this.cb_prefix_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "物品名";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "位置";
            // 
            // tb_position
            // 
            this.tb_position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_position.Location = new System.Drawing.Point(728, 90);
            this.tb_position.Name = "tb_position";
            this.tb_position.ReadOnly = true;
            this.tb_position.Size = new System.Drawing.Size(260, 26);
            this.tb_position.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "物品ID";
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_id.Location = new System.Drawing.Point(728, 33);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(260, 26);
            this.tb_id.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(752, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "修改并保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(885, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(901, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "立即保存";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_surfix
            // 
            this.tb_surfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_surfix.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_surfix.Location = new System.Drawing.Point(779, 248);
            this.tb_surfix.Name = "tb_surfix";
            this.tb_surfix.ReadOnly = true;
            this.tb_surfix.Size = new System.Drawing.Size(209, 23);
            this.tb_surfix.TabIndex = 6;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_prefix.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_prefix.Location = new System.Drawing.Point(778, 187);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.ReadOnly = true;
            this.tb_prefix.Size = new System.Drawing.Size(209, 23);
            this.tb_prefix.TabIndex = 6;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(778, 123);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(209, 23);
            this.tb_name.TabIndex = 6;
            // 
            // lb_bottom
            // 
            this.lb_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_bottom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_bottom.ForeColor = System.Drawing.Color.Red;
            this.lb_bottom.Location = new System.Drawing.Point(728, 479);
            this.lb_bottom.Name = "lb_bottom";
            this.lb_bottom.Size = new System.Drawing.Size(272, 21);
            this.lb_bottom.TabIndex = 7;
            this.lb_bottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_bottom);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.tb_surfix);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_prefix);
            this.Controls.Add(this.cb_surfix);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.list_items);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemListView";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.ComboBox cb_surfix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_prefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_surfix;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_bottom;
    }
}
