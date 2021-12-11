using SocSystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocSystem.StudentPage;

namespace SocSystem
{
    public partial class Mainfrom : Form
    {
        public Mainfrom()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 使用手册ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClosePreForm()
        {
            foreach (Control item in this.MainPln.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }

            }
        }
        private void SocBtn_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenFrm(new SocManage());
        }
        private void OpenFrm(Form objFrm)
        {
            objFrm.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            objFrm.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            objFrm.Parent = this.MainPln;//指定子窗体显示的容器
            objFrm.Show();
        }

        private void 暗色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void StuBtn_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenFrm(new Student());
            
        }
    }
}
