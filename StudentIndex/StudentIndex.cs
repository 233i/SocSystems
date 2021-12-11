using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Forms;
using SocBLL;
using SocModel;
using SocSystem.StudentPage;
using Sunny;
using Sunny.UI;
namespace SocSystem.StudentPage
{
    public partial class StudentIndex : UIForm
    {
        public DataSet ds;
        public StudentBLL _studentBLL;
        public StudentIndex()
        {
            InitializeComponent();
            _studentBLL = new StudentBLL();
       
        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int y = 135;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y<535)
            {
                y = y + 10;
                uiPanel1.Location = new Point(1145, y);

            }
            else
            {
                y = 135;
            }

         

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void StudentIndex_Load(object sender, EventArgs e)
        {
            SocAdmininfoBLL socAdmininfoBLL = new SocAdmininfoBLL();
            ds = socAdmininfoBLL.SocInfoLoad();

           uiDataGridView1.DataSource = ds.Tables[0];


            DataSet da = _studentBLL.getStudentinfo(Students._stuID);

            StuName.Text = da.Tables[0].Rows[0][2].ToString();
            stutel.InputText = da.Tables[0].Rows[0][5].ToString();
            textstuid.Text = Students._stuID.ToString();
            if (da.Tables[0].Rows[0][3].ToString() == "0")
            {
                radman.Checked = true;
            }
            else
            {
                radnv.Checked = true;
            }

            textClass1.InputText = da.Tables[0].Rows[0][4].ToString();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            StuInfo stuInfo = new StuInfo();
            stuInfo.StuName = StuName.Text.Trim();
            stuInfo.StuTel = stutel.InputText.Trim();
            stuInfo.StuId = textstuid.Text.Trim();
            stuInfo.StuSex = true;
            if (radman.Checked == true)
            {
                stuInfo.StuSex = true;



            }
            else
            {
                stuInfo.StuSex = false;
            }

            stuInfo.StuClass = textClass1.InputText.Trim();
            if (_studentBLL.updateStudentinfo(stuInfo))
            {
                FrmDialog.ShowDialog(this, "保存信息成功", "信息提示");
            }
            else
            {
                FrmDialog.ShowDialog(this, "保存信息失败", "信息提示");
            }
        }

        int i = 0;
        private void uiButton5_Click(object sender, EventArgs e)
        {
            SoccInfo socInfo = new SoccInfo(i);
            socInfo.ShowDialog();
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           i =  int.Parse(uiDataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            //获取社团编号
            
            MessageBox.Show(i.ToString());
        }

        private void ucBtnImg1_BtnClick(object sender, EventArgs e)
        {
            StuAppinfo socAppinfo = new StuAppinfo(i);
            socAppinfo.Show();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        { 
         
        }
    }
}
