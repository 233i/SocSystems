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
    public partial class SocManage : Form
    {
        public SocManage()
        {
            InitializeComponent();
            Loaddata();
        }

        private void SocManage_Load(object sender, EventArgs e)
        {
           
        }
        private void Loaddata()
        {
            AdminBLL adminBLL = new AdminBLL();
            DataSet da = adminBLL.SocInfoLoad();
            dataGridView1.DataSource = da.Tables[0];
            i = int.Parse(da.Tables[0].Rows[0][1].ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


         public static int i = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//获取社团编号
           i = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            MessageBox.Show(i.ToString());

        }
        private void SocDel_Click(object sender, EventArgs e)
        {
            SocInfo soc = new SocInfo();
            soc.SocId = i;
            AdminBLL adminBLL = new AdminBLL();
            if (adminBLL.deleteSoc(soc))
            {
                MessageBox.Show("删除成功");
                Loaddata();
            }
            else
            {
                MessageBox.Show("删除失败");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Socxx socxx = new Socxx(i);
            socxx.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateSoc update = new UpdateSoc(i);
        
        update.ShowDialog();
           
        }
    }
}
