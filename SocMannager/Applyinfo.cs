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
using SocBLL;
using SocModel;

namespace SocSystem.SocMannager
{
    public partial class Applyinfo : UIForm
    {
       
        private SocAdmininfoBLL _admininfoBLL;
        private SocAppInfo _socAppInfo;
        public Applyinfo(SocAppInfo socAppInfo)
        {
            
            InitializeComponent();
            _admininfoBLL = new SocAdmininfoBLL();
            _socAppInfo = socAppInfo;

        }

        private void Applyinfo_Load(object sender, EventArgs e)
        {

            loadApplyinfo();
        }

  public void      loadApplyinfo() {


            DataSet _DataSet = _admininfoBLL.OneApplyInfo(_socAppInfo);

            MessageBox.Show(_DataSet.Tables[0].Rows[0].ToString());



            stuName.Text = _DataSet.Tables[0].Rows[0]["StuName"].ToString().Trim();
            StuID.Text = _DataSet.Tables[0].Rows[0]["StuId"].ToString().Trim();
            Class.Text = _DataSet.Tables[0].Rows[0]["StuClass"].ToString().Trim();

            stuTel.Text = _DataSet.Tables[0].Rows[0]["StuTel"].ToString().Trim();



            if (bool.Parse(_DataSet.Tables[0].Rows[0]["StuSex"].ToString()))
            {
                sex.Text = "男";
            }
            else
            {
                sex.Text = "女";
            }

            if (_DataSet.Tables[0].Rows[0]["AppState"].ToString() == "")
            {
                state.Text = "待审核";
            }
            else if (bool.Parse(_DataSet.Tables[0].Rows[0]["AppState"].ToString()))
            {
                state.Text = "审核通过";
            }
            else
            {
                state.Text = "拒绝进入";
            }

            Rea.Text = _DataSet.Tables[0].Rows[0]["AppRea"].ToString();
        }


        private bool applyState;
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
      

            if (state.Text.Trim() == "待审核")
            {
                applyState = true;
            }
            else
            {
                applyState = false;
            }

            SocAppInfo socAppInfo = new SocAppInfo();
            socAppInfo.AppState = true;
            socAppInfo.StuId = StuID.Text.Trim();

            StuSoc stuSoc = new StuSoc {
                SocId = _socAppInfo.Socid,
                Stuid = StuID.Text

            };

            DialogResult dr = MessageBox.Show("确认此操作", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr== DialogResult.Yes)
            {
                if (_admininfoBLL.Applystate(socAppInfo, stuSoc))
                {
                    MessageBox.Show("加入成功");
                    loadApplyinfo();
                }
                else
                {
                    MessageBox.Show("加入失败");
                    loadApplyinfo();
                }

            }

           



        }
    }
}
