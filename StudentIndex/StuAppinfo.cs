using HZH_Controls.Forms;
using SocBLL;
using SocModel;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocSystem.StudentPage
{
    public partial class StuAppinfo : UIForm
    {
        public int _SocID;
        private StudentBLL _studentBLL;


        public StuAppinfo(int socid)
        {
            _SocID = socid;
            _studentBLL = new StudentBLL();
            InitializeComponent();
        }
   
        private void tijiao_Click(object sender, EventArgs e)
        {
            SocAppInfo socApp = new SocAppInfo();
            socApp.Socid = int.Parse(socid.InputText.Trim());

            socApp.StuId = stuID.InputText.Trim();

            socApp.AppRea = liyou.Text.Trim();



            if (_studentBLL.socApp(socApp))
            {

                FrmDialog.ShowDialog(this, "提交成功", "提交提示");
            }
            else
            {
                FrmDialog.ShowDialog(this, "提交失败", "提交提示");
            }
        }

        private void StuAppinfo_Load(object sender, EventArgs e)
        {
            //Students students = new Students();
            stuID.InputText = Students._stuID;
            socid.InputText = _SocID.ToString();
        }
    }
}
