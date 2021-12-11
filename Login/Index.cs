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
using SocSystem.Login;
using SocSystem.SocMannager;

namespace SocSystem
{

    public partial class Index : Form
    {
        private SocAdmininfoBLL _SocAdmininfoBLL;
        public Index()
        {
            _SocAdmininfoBLL = new SocAdmininfoBLL();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//设置此窗体显示在屏幕正中间
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students index = new Students();
            index.Show();

        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 index = new Form1();
            index.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SocAdmininfo admininfo = new SocAdmininfo();
            admininfo.Stuid = textBox1.Text.Trim();
            admininfo.Password=textBox2.Text.Trim();
          SocAdmininfoBLL socAdmininfoBLL = new SocAdmininfoBLL();

            SocAdmininfo socAdmininfo = new SocAdmininfo();
        socAdmininfo.Stuid = admininfo.Stuid;

           //获取社团Id的传值
        int SocID =      int.Parse(_SocAdmininfoBLL.ReaderSocID(socAdmininfo));

            if (socAdmininfoBLL.SocAdmininfoBLLLogin(admininfo))
            {
                
                MessageBox.Show("登陆成功！");
                ParentForm.Hide();
          

                SocMannageIndex socMannageIndex = new SocMannageIndex(SocID,admininfo.Stuid);
                socMannageIndex.Show();

            }
            else
            {
                MessageBox.Show("登陆失败！");


            }



        }
    }
}
