using SocBLL;
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
using SocInfo = SocSystem.StudentPage.SoccInfo;

namespace SocSystem.StudentPage
{
    public partial class SoccInfo : UIForm
    {
        private static int _stuID;
        public SoccInfo(int stuID)
        {
            _stuID = stuID;
            InitializeComponent();
        }

        private void SoccInfo_Load(object sender, EventArgs e)
        {

            StudentBLL studentBLL = new StudentBLL();
            DataSet ds = studentBLL.SocInfoLoad(_stuID);

            socID.InputText = ds.Tables[0].Rows[0][1].ToString();
            socName.Text = ds.Tables[0].Rows[0][2].ToString();
            socjianj.Text = ds.Tables[0].Rows[0][3].ToString();
        }
    }
}
