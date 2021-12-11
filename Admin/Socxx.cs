using SocBLL;
using SocModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocSystem.Admin
{
    public partial class Socxx : Form
    {
        private int _socId;
        public Socxx(int i)
        {
            _socId = i;
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            try
            {
                SocInfo socInfo = new SocInfo();
                socInfo.SocId = _socId;
                AdminBLL adminBLL = new AdminBLL();
                DataSet ds = adminBLL.selectSoc(socInfo);
                dataGridView1.DataSource = ds.Tables[0];
                int res = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                SocID.Text = res.ToString();
                StuSoc stuSoc = new StuSoc();
                stuSoc.SocId = res;
                DataSet StuDs = adminBLL.SocIdReader(stuSoc);
                SocName.Text = StuDs.Tables[0].Rows[0][0].ToString();
                socCount.Text = ds.Tables[0].Rows.Count.ToString();
            }catch (Exception )
            {
              
            }
        }
    }
}
