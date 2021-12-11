using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocSystem.Login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置此窗体显示在屏幕正中间
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        private void ClosePreForm()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }

            }
        }
        private void OpenFrm(Form objFrm)
        {
            objFrm.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            objFrm.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            objFrm.Parent = this.panel1;//指定子窗体显示的容器
            objFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenFrm(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenFrm(new Index());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenFrm(new Students());
        }
    }
}
