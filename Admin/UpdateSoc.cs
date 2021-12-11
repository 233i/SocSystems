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
using SocModel;

namespace SocSystem.Admin
{
    public partial class UpdateSoc : Form
    {
        private AdminBLL _adminBLL;
    private int _id;
       
        public UpdateSoc(int SocId )
        {
            _adminBLL = new AdminBLL(); ;
            InitializeComponent();
           _id = SocId; 
        }

        private void UpdateSoc_Load(object sender, EventArgs e)
        {

         DataSet set=   _adminBLL.SocInfoLoad(_id);
           socId.Text = _id.ToString();
            socName.Text = set.Tables[0].Rows[0][2].ToString();
            socjianshao.Text=set.Tables[0].Rows[0][3].ToString();
                }

        private void button1_Click(object sender, EventArgs e)
        {
            SocInfo socInfo = new SocInfo();
            socInfo.SocId = _id;
            socInfo.SocName=socName.Text.Trim();
            socInfo.SocJieshao= socjianshao.Text.Trim();
            if (_adminBLL.EditSoc(socInfo))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
