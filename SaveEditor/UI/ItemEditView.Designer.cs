using SwptSaveLib;

namespace SaveEditor.UI
{
    partial class ItemEditView
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
            this.lb_display_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.tb_itemid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new SaveEditor.UI.ComboBoxPlus();
            this.tb_prefix = new SaveEditor.UI.ComboBoxPlus();
            this.tb_surfix = new SaveEditor.UI.ComboBoxPlus();
            this.SuspendLayout();
            // 
            // lb_display_name
            // 
            this.lb_display_name.AutoSize = true;
            this.lb_display_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_display_name.Location = new System.Drawing.Point(9, 39);
            this.lb_display_name.Name = "lb_display_name";
            this.lb_display_name.Size = new System.Drawing.Size(37, 20);
            this.lb_display_name.TabIndex = 0;
            this.lb_display_name.Text = "物品";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(1, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 1);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(203, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "位置";
            // 
            // tb_position
            // 
            this.tb_position.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_position.Location = new System.Drawing.Point(288, 2);
            this.tb_position.Name = "tb_position";
            this.tb_position.ReadOnly = true;
            this.tb_position.Size = new System.Drawing.Size(135, 26);
            this.tb_position.TabIndex = 5;
            // 
            // tb_itemid
            // 
            this.tb_itemid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_itemid.Location = new System.Drawing.Point(73, 3);
            this.tb_itemid.Name = "tb_itemid";
            this.tb_itemid.ReadOnly = true;
            this.tb_itemid.Size = new System.Drawing.Size(115, 26);
            this.tb_itemid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "物品ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "词条1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "词条2";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.FormattingEnabled = true;
            this.tb_name.Location = new System.Drawing.Point(73, 34);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(350, 28);
            this.tb_name.Items.AddRange(GameConstants.ITEMS);
            this.tb_name.TabIndex = 6;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_prefix.FormattingEnabled = true;
            this.tb_prefix.Location = new System.Drawing.Point(73, 68);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(350, 28);
            this.tb_prefix.Items.AddRange(GameConstants.PREFIXS);
            this.tb_prefix.TabIndex = 6;
            // 
            // tb_surfix
            // 
            this.tb_surfix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_surfix.FormattingEnabled = true;
            this.tb_surfix.Location = new System.Drawing.Point(73, 102);
            this.tb_surfix.Name = "tb_surfix";
            this.tb_surfix.Size = new System.Drawing.Size(350, 28);
            this.tb_surfix.Items.AddRange(GameConstants.SURFIXS);
            this.tb_surfix.TabIndex = 6;
            // 
            // ItemEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.tb_surfix);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_itemid);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_display_name);
            this.Name = "ItemEditView";
            this.Size = new System.Drawing.Size(480, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_display_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.TextBox tb_itemid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ComboBoxPlus tb_name;
        private ComboBoxPlus tb_prefix;
        private ComboBoxPlus tb_surfix;
    }
}
