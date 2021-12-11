using SocBLL;
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

namespace SocSystem.Admin
{
    public partial class StuEdit : Form
    {
        public StuEdit(int id)
        {
            InitializeComponent();
            _id = id;
            LoadData();      
        }
     private static   int _id;
        public void LoadData()
        {
            AdminBLL adminBLL  = new AdminBLL();
            DataSet ds = adminBLL.StuFind(_id);
            textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            stuName.Text = ds.Tables[0].Rows [0][2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][5].ToString();
            if (ds.Tables[0].Rows[0][4].ToString().Equals("1"))
            {
                radman.Checked = true;
            }
            else
            {
                radnv.Checked = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
        string name =  stuName.Text.Trim();

            bool sex = false;
            if (radman.Checked == true)
            {
                sex = true;
            }
            else
            {
                sex = false;
            }
            int x;

            string Class= textBox3.Text.Trim();
            string  tel = textBox4.Text.Trim();
            StuInfo stuInfo = new StuInfo();    
            stuInfo.StuName = name;
            stuInfo.StuClass = Class;
            stuInfo.StuSex = sex;
            stuInfo.StuTel = tel;
            stuInfo.Id = _id;
            stuInfo.StuId = textBox1.Text;


            AdminBLL adminBLL=new AdminBLL();
            if (adminBLL.EditStudent(stuInfo))
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }



        }
    }
}
