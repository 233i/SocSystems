namespace SocSystem.Admin
{
    partial class UpdateSoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.socId = new System.Windows.Forms.TextBox();
            this.socName = new System.Windows.Forms.TextBox();
            this.socjianshao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "社团编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "社团名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "社团介绍";
            // 
            // socId
            // 
            this.socId.Location = new System.Drawing.Point(144, 60);
            this.socId.Name = "socId";
            this.socId.ReadOnly = true;
            this.socId.Size = new System.Drawing.Size(100, 21);
            this.socId.TabIndex = 1;
            // 
            // socName
            // 
            this.socName.Location = new System.Drawing.Point(144, 129);
            this.socName.Name = "socName";
            this.socName.Size = new System.Drawing.Size(100, 21);
            this.socName.TabIndex = 1;
            // 
            // socjianshao
            // 
            this.socjianshao.Location = new System.Drawing.Point(144, 199);
            this.socjianshao.Multiline = true;
            this.socjianshao.Name = "socjianshao";
            this.socjianshao.Size = new System.Drawing.Size(583, 205);
            this.socjianshao.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.socjianshao);
            this.Controls.Add(this.socName);
            this.Controls.Add(this.socId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSoc";
            this.Text = "编辑社团的信息";
            this.Load += new System.EventHandler(this.UpdateSoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox socId;
        private System.Windows.Forms.TextBox socName;
        private System.Windows.Forms.TextBox socjianshao;
        private System.Windows.Forms.Button button1;
    }
}