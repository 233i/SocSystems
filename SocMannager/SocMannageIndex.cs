using SocBLL;
using SocModel;
using Sunny.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace SocSystem.SocMannager
{
    public partial class SocMannageIndex : UIForm
    {
        private SocAdmininfoBLL _admininfoBLL;
        private SocAppInfo _SocAppInfo;
        private int _socid;
        private string _socadid;
        public static string i;
        public SocMannageIndex(int socid, string socAdid)
        {

            InitializeComponent();
            _SocAppInfo = new SocAppInfo();
            _admininfoBLL = new SocAdmininfoBLL();
            _socid = socid;
            _socadid = socAdid;
            uiMarkLabel2.Text = socid.ToString();
            SocAdmininfoBLL socAdmininfoBLL = new SocAdmininfoBLL();
            DataSet data = socAdmininfoBLL.ReaderSocName(socid.ToString());
            uiMarkLabel1.Text = data.Tables[0].Rows[0][0].ToString();
            uiDatetimePicker1.Value = DateTime.Now;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }



        public DataSet da;
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SocMannageIndex_Load(object sender, EventArgs e)
        {
            load();


        }

        public void load()
        {


            // TODO: 这行代码将数据加载到表“socDataSet1.SocAppInfo”中。您可以根据需要移动或删除它。
            this.socAppInfoTableAdapter.Fill(this.socDataSet1.SocAppInfo);
            // TODO: 这行代码将数据加载到表“socDataSet.StuInfo”中。您可以根据需要移动或删除它。
            SocInfo socInfo = new SocInfo()
            {
                SocId = _socid

            };

            //成员信息
            DataSet ds = _admininfoBLL.SocSelect(socInfo);

            uiDataGridView1.DataSource = ds.Tables[0];
            Preson.Text = ds.Tables[0].Rows.Count.ToString();

            //申请信息
            da = _admininfoBLL.ApplyInfo(_socid);

            uiDataGridView2.DataSource = da.Tables[0];
        }

        /// <summary>
        /// 活动申请按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            SocHdInfo socHdInfo = new SocHdInfo();
            socHdInfo.AcName = textBox1.Text.Trim();
            socHdInfo.IsSoc = _socid.ToString();
            socHdInfo.Acld = _socadid.ToString();
            socHdInfo.AcAdd = textBox2.Text.Trim();
            socHdInfo.AcDate = uiDatetimePicker1.ToString();
            socHdInfo.AcInfo = textBox5.Text;
            if (_admininfoBLL.SocAc(socHdInfo))
            {
                MessageBox.Show("申请成功");
            }
            else
            {
                MessageBox.Show("申请失败");
            }
        }
        /// <summary>
        /// 加载活动申请记录
        /// </summary>
        private void socHdLoad()
        {

        }

        private void uiDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _SocAppInfo.StuId = uiDataGridView2.SelectedRows[0].Cells[1].Value.ToString().Trim();
            MessageBox.Show(_SocAppInfo.StuId = uiDataGridView2.SelectedRows[0].Cells[1].Value.ToString().Trim());

        }


        private void uiButton1_Click(object sender, EventArgs e)
        {
            //SocAppInfo socAppInfo = new SocAppInfo
            //{
            //    Socid = _socid,
            //    StuId = i
            //};
            _SocAppInfo.Socid = _socid;

            Applyinfo applyinfo = new Applyinfo(_SocAppInfo);
            applyinfo.ShowDialog();
        }


    }
}
