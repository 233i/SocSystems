using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocModel;
using SocBLL;
using SocSystem.StudentPage;

namespace SocSystem
{
    public partial class Students : Form
    {
        public static string _stuID;
        public Students()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置此窗体显示在屏幕正中间
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
          Form1 index = new Form1();
            index.Show();

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
       StuInfo stu = new StuInfo();
            stu.StuId = textBox1.Text.Trim();
               _stuID=  textBox1.Text.Trim();
            stu.StuPassword = textBox2.Text.Trim();
          
         StudentBLL studentBLL = new StudentBLL();
            if (studentBLL.StudenLogin(stu))
            {
                MessageBox.Show("登录成功！");
                ParentForm.Hide();
                StudentIndex index = new StudentIndex();
                index.Show();
                return;
            }
            else
            {
                MessageBox.Show("登录失败");

            }

        }
    }
}
