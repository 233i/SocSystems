
namespace SocSystem.StudentPage
{
    partial class StuAppinfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tijiao = new Sunny.UI.UIButton();
            this.liyou = new System.Windows.Forms.TextBox();
            this.socid = new HZH_Controls.Controls.UCTextBoxEx();
            this.stuID = new HZH_Controls.Controls.UCTextBoxEx();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ucBtnImg1 = new HZH_Controls.Controls.UCBtnImg();
            this.SuspendLayout();
            // 
            // tijiao
            // 
            this.tijiao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tijiao.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tijiao.IsScaled = false;
            this.tijiao.Location = new System.Drawing.Point(459, 580);
            this.tijiao.MinimumSize = new System.Drawing.Size(1, 1);
            this.tijiao.Name = "tijiao";
            this.tijiao.Size = new System.Drawing.Size(100, 35);
            this.tijiao.TabIndex = 13;
            this.tijiao.Text = "提交申请";
            this.tijiao.Click += new System.EventHandler(this.tijiao_Click);
            // 
            // liyou
            // 
            this.liyou.Location = new System.Drawing.Point(402, 322);
            this.liyou.Multiline = true;
            this.liyou.Name = "liyou";
            this.liyou.Size = new System.Drawing.Size(527, 228);
            this.liyou.TabIndex = 12;
            // 
            // socid
            // 
            this.socid.BackColor = System.Drawing.Color.Transparent;
            this.socid.ConerRadius = 5;
            this.socid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.socid.DecLength = 2;
            this.socid.FillColor = System.Drawing.Color.Empty;
            this.socid.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.socid.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.socid.InputText = "";
            this.socid.InputType = HZH_Controls.TextInputType.NotControl;
            this.socid.IsFocusColor = true;
            this.socid.IsRadius = true;
            this.socid.IsShowClearBtn = true;
            this.socid.IsShowKeyboard = false;
            this.socid.IsShowRect = true;
            this.socid.IsShowSearchBtn = false;
            this.socid.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.socid.Location = new System.Drawing.Point(402, 216);
            this.socid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.socid.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.socid.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.socid.Name = "socid";
            this.socid.Padding = new System.Windows.Forms.Padding(5);
            this.socid.PasswordChar = '\0';
            this.socid.PromptColor = System.Drawing.Color.Gray;
            this.socid.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.socid.PromptText = "";
            this.socid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.socid.RectWidth = 1;
            this.socid.RegexPattern = "";
            this.socid.Size = new System.Drawing.Size(322, 42);
            this.socid.TabIndex = 11;
            // 
            // stuID
            // 
            this.stuID.BackColor = System.Drawing.Color.Transparent;
            this.stuID.ConerRadius = 5;
            this.stuID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stuID.DecLength = 2;
            this.stuID.FillColor = System.Drawing.Color.Empty;
            this.stuID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.stuID.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stuID.InputText = "";
            this.stuID.InputType = HZH_Controls.TextInputType.NotControl;
            this.stuID.IsFocusColor = true;
            this.stuID.IsRadius = true;
            this.stuID.IsShowClearBtn = true;
            this.stuID.IsShowKeyboard = false;
            this.stuID.IsShowRect = true;
            this.stuID.IsShowSearchBtn = false;
            this.stuID.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.stuID.Location = new System.Drawing.Point(402, 111);
            this.stuID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stuID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stuID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.stuID.Name = "stuID";
            this.stuID.Padding = new System.Windows.Forms.Padding(5);
            this.stuID.PasswordChar = '\0';
            this.stuID.PromptColor = System.Drawing.Color.Gray;
            this.stuID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stuID.PromptText = "";
            this.stuID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stuID.RectWidth = 1;
            this.stuID.RegexPattern = "";
            this.stuID.Size = new System.Drawing.Size(322, 42);
            this.stuID.TabIndex = 10;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(245, 324);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(126, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "个人申请理由：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(241, 216);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(142, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "申请的社团编号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(271, 111);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "学号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucBtnImg1
            // 
            this.ucBtnImg1.BackColor = System.Drawing.Color.White;
            this.ucBtnImg1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImg1.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.ucBtnImg1.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucBtnImg1.BtnText = "填写信息";
            this.ucBtnImg1.ConerRadius = 5;
            this.ucBtnImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImg1.EnabledMouseEffect = false;
            this.ucBtnImg1.FillColor = System.Drawing.Color.Teal;
            this.ucBtnImg1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg1.Image = null;
            this.ucBtnImg1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImg1.ImageFontIcons = null;
            this.ucBtnImg1.IsRadius = true;
            this.ucBtnImg1.IsShowRect = true;
            this.ucBtnImg1.IsShowTips = false;
            this.ucBtnImg1.Location = new System.Drawing.Point(258, 35);
            this.ucBtnImg1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg1.Name = "ucBtnImg1";
            this.ucBtnImg1.RectColor = System.Drawing.Color.White;
            this.ucBtnImg1.RectWidth = 1;
            this.ucBtnImg1.Size = new System.Drawing.Size(601, 58);
            this.ucBtnImg1.TabIndex = 6;
            this.ucBtnImg1.TabStop = false;
            this.ucBtnImg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg1.TipsColor = System.Drawing.Color.White;
            this.ucBtnImg1.TipsText = "";
            // 
            // StuAppinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 643);
            this.Controls.Add(this.tijiao);
            this.Controls.Add(this.liyou);
            this.Controls.Add(this.socid);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ucBtnImg1);
            this.Name = "StuAppinfo";
            this.Text = "StuAppinfo";
            this.Load += new System.EventHandler(this.StuAppinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton tijiao;
        private System.Windows.Forms.TextBox liyou;
        private HZH_Controls.Controls.UCTextBoxEx socid;
        private HZH_Controls.Controls.UCTextBoxEx stuID;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private HZH_Controls.Controls.UCBtnImg ucBtnImg1;
    }
}