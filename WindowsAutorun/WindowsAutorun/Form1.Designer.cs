namespace WindowsAutorun
{
    partial class Form1
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
            this.BtRegAdd = new System.Windows.Forms.Button();
            this.TbCmd = new System.Windows.Forms.TextBox();
            this.BtRegDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtMenuAdd = new System.Windows.Forms.Button();
            this.BtMenuDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtRegAdd
            // 
            this.BtRegAdd.Location = new System.Drawing.Point(13, 23);
            this.BtRegAdd.Name = "BtRegAdd";
            this.BtRegAdd.Size = new System.Drawing.Size(75, 23);
            this.BtRegAdd.TabIndex = 0;
            this.BtRegAdd.Text = "添加";
            this.BtRegAdd.UseVisualStyleBackColor = true;
            this.BtRegAdd.Click += new System.EventHandler(this.BtRegAdd_Click);
            // 
            // TbCmd
            // 
            this.TbCmd.Location = new System.Drawing.Point(12, 12);
            this.TbCmd.Multiline = true;
            this.TbCmd.Name = "TbCmd";
            this.TbCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbCmd.Size = new System.Drawing.Size(378, 237);
            this.TbCmd.TabIndex = 1;
            // 
            // BtRegDel
            // 
            this.BtRegDel.Location = new System.Drawing.Point(97, 23);
            this.BtRegDel.Name = "BtRegDel";
            this.BtRegDel.Size = new System.Drawing.Size(75, 23);
            this.BtRegDel.TabIndex = 3;
            this.BtRegDel.Text = "删除";
            this.BtRegDel.UseVisualStyleBackColor = true;
            this.BtRegDel.Click += new System.EventHandler(this.BtRegDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtRegAdd);
            this.groupBox1.Controls.Add(this.BtRegDel);
            this.groupBox1.Location = new System.Drawing.Point(401, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtMenuAdd);
            this.groupBox2.Controls.Add(this.BtMenuDel);
            this.groupBox2.Location = new System.Drawing.Point(401, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "启动菜单";
            // 
            // BtMenuAdd
            // 
            this.BtMenuAdd.Location = new System.Drawing.Point(13, 23);
            this.BtMenuAdd.Name = "BtMenuAdd";
            this.BtMenuAdd.Size = new System.Drawing.Size(75, 23);
            this.BtMenuAdd.TabIndex = 0;
            this.BtMenuAdd.Text = "添加";
            this.BtMenuAdd.UseVisualStyleBackColor = true;
            this.BtMenuAdd.Click += new System.EventHandler(this.BtMenuAdd_Click);
            // 
            // BtMenuDel
            // 
            this.BtMenuDel.Location = new System.Drawing.Point(97, 23);
            this.BtMenuDel.Name = "BtMenuDel";
            this.BtMenuDel.Size = new System.Drawing.Size(75, 23);
            this.BtMenuDel.TabIndex = 3;
            this.BtMenuDel.Text = "删除";
            this.BtMenuDel.UseVisualStyleBackColor = true;
            this.BtMenuDel.Click += new System.EventHandler(this.BtMenuDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbCmd);
            this.Name = "Form1";
            this.Text = "设置程序自启动";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRegAdd;
        private System.Windows.Forms.TextBox TbCmd;
        private System.Windows.Forms.Button BtRegDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtMenuAdd;
        private System.Windows.Forms.Button BtMenuDel;
    }
}

