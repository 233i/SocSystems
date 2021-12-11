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

namespace SocSystem.Admin
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            StuReader();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void StuReader()
        {
            AdminBLL adminBLL = new AdminBLL();
            dataGridView1.DataSource = adminBLL.StuReader().Tables[0];
            i = int.Parse(adminBLL.StuReader().Tables[0].Rows[0][0].ToString());
            MessageBox.Show(i.ToString());
        }

        int i = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show(i.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminBLL adminBLL=new AdminBLL();
            if (adminBLL.deleStudent(i))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            StuReader();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StuEdit stuEdit = new StuEdit(i);

            stuEdit.ShowDialog();
        }
    }
}
