using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAutorun
{
    public partial class Form1 : Form
    {
        string ProgramName = "测试自启动";
        string ProgramFile = Application.ExecutablePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UICmd(string s)
        {
            BeginInvoke(new Action(() =>
            {
                TbCmd.Text += s;
                TbCmd.Text += Environment.NewLine;
            }));
        }

        #region 注册表实现开机启动
        private void BtRegAdd_Click(object sender, EventArgs e)
        {
            RegOpe();
        }
        private void BtRegDel_Click(object sender, EventArgs e)
        {
            RegOpe(false);
        }
        private void RegOpe(bool add = true)
        {
            RegistryKey HKLM = Registry.LocalMachine;
            RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE/Microsoft/Windows/CurrentVersion/Run");
            if (add)
            {
                try
                {
                    Run.SetValue(ProgramName, ProgramFile);
                    HKLM.Close();
                    UICmd("注册表 开机启动 添加 成功");
                }
                catch//没有权限会异常            
                {
                    UICmd("注册表 开机启动 添加 失败");
                }
            }
            else
            {
                try
                {
                    Run.DeleteValue(ProgramName);
                    HKLM.Close();
                    UICmd("注册表 开机启动 删除 成功");
                }
                catch//没有权限会异常 
                {
                    UICmd("注册表 开机启动 删除 失败");
                }
            }
        }
        #endregion

        #region 启动菜单实现开机启动
        private void BtMenuAdd_Click(object sender, EventArgs e)
        {
            string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            CreateShortcut(startup, ProgramName, ProgramFile);
            UICmd("添加 启动菜单 成功");
        }
        private void BtMenuDel_Click(object sender, EventArgs e)
        {
            string startup = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + ProgramName + ".lnk";
            if (System.IO.File.Exists(startup))
            {
                System.IO.File.Delete(startup);
                UICmd("删除 启动菜单 成功");
            }
        }
        public static void CreateShortcut(string directory, string shortcutName, string targetPath,
            string description = null, string iconLocation = null)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            //添加引用 Com 中搜索 Windows Script Host Object Model
            string shortcutPath = Path.Combine(directory, string.Format("{0}.lnk", shortcutName));
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);//创建快捷方式对象
            shortcut.TargetPath = targetPath;//指定目标路径
            shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);//设置起始位置
            shortcut.WindowStyle = 1;//设置运行方式，默认为常规窗口
            shortcut.Description = description;//设置备注
            shortcut.IconLocation = string.IsNullOrWhiteSpace(iconLocation) ? targetPath : iconLocation;//设置图标路径
            shortcut.Save();//保存快捷方式
        }
        #endregion
    }
}
