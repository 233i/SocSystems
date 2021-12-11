using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocBLL;
using SocSystem.Login;

namespace SocSystem
{
    public partial class Form1 : Form
    {
        private  AdminBLL _AdminBLL;
        public Form1()
        {
            _AdminBLL = new AdminBLL();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置此窗体显示在屏幕正中间
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();

        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
          Students index = new Students();
            index.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user=textBox1.Text.Trim();
            var pwd = textBox2.Text.Trim();
            if (user.Equals("") || pwd.Equals("")) 
            {
                MessageBox.Show("账号或者密码不能为空！");
                return;
            }
            //调用业务逻辑层
            if (_AdminBLL.Login(user, pwd))
            {
                MessageBox.Show("欢迎管理员登录");
                ParentForm.Hide();
                Mainfrom mainfrom = new Mainfrom(); 
                mainfrom.Show();
            }
            else
            {
                MessageBox.Show("抱歉请检查一下密码或者用户名！");
            }


        }
    }
}
