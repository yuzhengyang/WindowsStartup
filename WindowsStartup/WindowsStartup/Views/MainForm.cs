using System;
using System.IO;
using System.Windows.Forms;
using WindowsStartup.Utils;

namespace WindowsStartup.Views
{
    public partial class MainForm : Form
    {
        string AppName = "WindowsStartup";
        string AppFile = Application.ExecutablePath;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void UICmd(string s)
        {
            BeginInvoke(new Action(() =>
            {
                TbCmd.Text += s;
                TbCmd.Text += Environment.NewLine;
                TbCmd.Select(TbCmd.Text.Length, 0);
                TbCmd.ScrollToCaret();
            }));
        }

        #region 注册表的开机启动
        private void BtRegAdd_Click(object sender, EventArgs e)
        {
            string regAll = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            if (RegisterTool.SetValue(regAll, AppName, AppFile))
                UICmd("添加 注册表全局用户启动 成功");
            else
                UICmd("添加 注册表全局用户启动 失败");

            string regCurrent = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            if (RegisterTool.SetValue(regCurrent, AppName, AppFile))
                UICmd("添加 注册表当前用户启动 成功");
            else
                UICmd("添加 注册表当前用户启动 失败");
        }
        private void BtRegDel_Click(object sender, EventArgs e)
        {
            string regAll = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            if (RegisterTool.DeleteValue(regAll, AppName))
                UICmd("删除 注册表全局用户启动 成功");
            else
                UICmd("删除 注册表全局用户启动 失败");

            string regCurrent = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            if (RegisterTool.DeleteValue(regCurrent, AppName))
                UICmd("删除 注册表当前用户启动 成功");
            else
                UICmd("删除 注册表当前用户启动 失败");
        }
        #endregion

        #region 开始菜单启动项
        private void BtMenuAdd_Click(object sender, EventArgs e)
        {
            UICmd("正在读取 全局用户开始菜单启动文件夹");
            string commonStartup = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
            UICmd("CommonStartup：" + commonStartup);
            if (ShortcutTool.Create(commonStartup, AppName, AppFile))
                UICmd("添加 全局用户开始菜单启动 成功");
            else
                UICmd("添加 全局用户开始菜单启动 失败");

            UICmd("正在读取 当前用户开始菜单启动文件夹");
            string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            UICmd("Startup：" + startup);
            if (ShortcutTool.Create(startup, AppName, AppFile))
                UICmd("添加 当前用户开始菜单启动 成功");
            else
                UICmd("添加 当前用户开始菜单启动 失败");
        }
        private void BtMenuDel_Click(object sender, EventArgs e)
        {
            string commonStartup = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
            if (ShortcutTool.Delete(commonStartup, AppName))
                UICmd("删除 全局用户开始菜单启动 成功");
            else
                UICmd("删除 全局用户开始菜单启动 失败");

            string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            if (ShortcutTool.Delete(startup, AppName))
                UICmd("删除 当前用户开始菜单启动 成功");
            else
                UICmd("删除 当前用户开始菜单启动 失败");
        }

        #endregion

        private void BtTaskAdd_Click(object sender, EventArgs e)
        {
            UICmd("准备添加 计划任务 自启动");
            var task = TaskSchedulerTool.Create(AppName, AppFile, "Tom", "测试程序自启动计划任务");
            UICmd("添加 计划任务启动 成功");
        }

        private void BtTaskDel_Click(object sender, EventArgs e)
        {
            UICmd("准备删除 计划任务 自启动");
            TaskSchedulerTool.Delete(AppName);
            UICmd("删除 计划任务启动 成功");
        }
    }
}
