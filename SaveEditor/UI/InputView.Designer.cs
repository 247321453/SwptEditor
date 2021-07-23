namespace SaveEditor.UI
{
    partial class InputView
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_display_name
            // 
            this.lb_display_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_display_name.Location = new System.Drawing.Point(7, 3);
            this.lb_display_name.Name = "lb_display_name";
            this.lb_display_name.Size = new System.Drawing.Size(960, 20);
            this.lb_display_name.TabIndex = 0;
            this.lb_display_name.Text = "Name";
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_input.Location = new System.Drawing.Point(291, 22);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(672, 26);
            this.tb_input.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.Location = new System.Drawing.Point(10, 32);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(275, 15);
            this.lb_name.TabIndex = 2;
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 1);
            this.label1.TabIndex = 3;
            // 
            // InputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lb_display_name);
            this.Name = "InputView";
            this.Size = new System.Drawing.Size(970, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_display_name;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
    }
}
