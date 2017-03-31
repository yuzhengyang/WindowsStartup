namespace WindowsStartup.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtMenuAdd = new System.Windows.Forms.Button();
            this.BtMenuDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtRegAdd = new System.Windows.Forms.Button();
            this.BtRegDel = new System.Windows.Forms.Button();
            this.TbCmd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtTaskAdd = new System.Windows.Forms.Button();
            this.BtTaskDel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtMenuAdd);
            this.groupBox2.Controls.Add(this.BtMenuDel);
            this.groupBox2.Location = new System.Drawing.Point(256, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 62);
            this.groupBox2.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtRegAdd);
            this.groupBox1.Controls.Add(this.BtRegDel);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册表";
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
            // TbCmd
            // 
            this.TbCmd.Location = new System.Drawing.Point(12, 12);
            this.TbCmd.Multiline = true;
            this.TbCmd.Name = "TbCmd";
            this.TbCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbCmd.Size = new System.Drawing.Size(676, 341);
            this.TbCmd.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtTaskAdd);
            this.groupBox3.Controls.Add(this.BtTaskDel);
            this.groupBox3.Location = new System.Drawing.Point(500, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 62);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计划任务";
            // 
            // BtTaskAdd
            // 
            this.BtTaskAdd.Location = new System.Drawing.Point(13, 23);
            this.BtTaskAdd.Name = "BtTaskAdd";
            this.BtTaskAdd.Size = new System.Drawing.Size(75, 23);
            this.BtTaskAdd.TabIndex = 0;
            this.BtTaskAdd.Text = "添加";
            this.BtTaskAdd.UseVisualStyleBackColor = true;
            this.BtTaskAdd.Click += new System.EventHandler(this.BtTaskAdd_Click);
            // 
            // BtTaskDel
            // 
            this.BtTaskDel.Location = new System.Drawing.Point(97, 23);
            this.BtTaskDel.Name = "BtTaskDel";
            this.BtTaskDel.Size = new System.Drawing.Size(75, 23);
            this.BtTaskDel.TabIndex = 3;
            this.BtTaskDel.Text = "删除";
            this.BtTaskDel.UseVisualStyleBackColor = true;
            this.BtTaskDel.Click += new System.EventHandler(this.BtTaskDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 447);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbCmd);
            this.Name = "MainForm";
            this.Text = "设置程序自启动";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtMenuAdd;
        private System.Windows.Forms.Button BtMenuDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtRegAdd;
        private System.Windows.Forms.Button BtRegDel;
        private System.Windows.Forms.TextBox TbCmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtTaskAdd;
        private System.Windows.Forms.Button BtTaskDel;
    }
}