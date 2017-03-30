using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsStartup.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UICmd(string s)
        {
            BeginInvoke(new Action(() =>
            {
                TbCmd.Text += s;
                TbCmd.Text += Environment.NewLine;
            }));
        }

        private void BtRegAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtRegDel_Click(object sender, EventArgs e)
        {

        }

        private void BtMenuAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtMenuDel_Click(object sender, EventArgs e)
        {

        }
    }
}
