namespace SocSystem.Admin
{
    partial class SocManage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocJieshao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解散社团ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑社团信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SocAdd = new System.Windows.Forms.Button();
            this.SocDel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SocId,
            this.SocName,
            this.SocJieshao});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 584);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SocId
            // 
            this.SocId.DataPropertyName = "SocId";
            this.SocId.HeaderText = "社团编号";
            this.SocId.Name = "SocId";
            this.SocId.ReadOnly = true;
            this.SocId.Width = 200;
            // 
            // SocName
            // 
            this.SocName.DataPropertyName = "SocName";
            this.SocName.FillWeight = 500F;
            this.SocName.HeaderText = "社团名称";
            this.SocName.Name = "SocName";
            this.SocName.ReadOnly = true;
            this.SocName.Width = 200;
            // 
            // SocJieshao
            // 
            this.SocJieshao.DataPropertyName = "SocJieshao";
            this.SocJieshao.FillWeight = 1500F;
            this.SocJieshao.HeaderText = "社团介绍";
            this.SocJieshao.Name = "SocJieshao";
            this.SocJieshao.ReadOnly = true;
            this.SocJieshao.Width = 400;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看详情ToolStripMenuItem,
            this.解散社团ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.编辑社团信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            // 
            // 查看详情ToolStripMenuItem
            // 
            this.查看详情ToolStripMenuItem.Name = "查看详情ToolStripMenuItem";
            this.查看详情ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看详情ToolStripMenuItem.Text = "查看详情";
            // 
            // 解散社团ToolStripMenuItem
            // 
            this.解散社团ToolStripMenuItem.Name = "解散社团ToolStripMenuItem";
            this.解散社团ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.解散社团ToolStripMenuItem.Text = "解散社团";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 编辑社团信息ToolStripMenuItem
            // 
            this.编辑社团信息ToolStripMenuItem.Name = "编辑社团信息ToolStripMenuItem";
            this.编辑社团信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑社团信息ToolStripMenuItem.Text = "编辑社团信息";
            // 
            // SocAdd
            // 
            this.SocAdd.Location = new System.Drawing.Point(1018, 41);
            this.SocAdd.Name = "SocAdd";
            this.SocAdd.Size = new System.Drawing.Size(75, 23);
            this.SocAdd.TabIndex = 2;
            this.SocAdd.Text = "添加社团";
            this.SocAdd.UseVisualStyleBackColor = true;
            // 
            // SocDel
            // 
            this.SocDel.Location = new System.Drawing.Point(1018, 199);
            this.SocDel.Name = "SocDel";
            this.SocDel.Size = new System.Drawing.Size(75, 23);
            this.SocDel.TabIndex = 2;
            this.SocDel.Text = "删除该社团";
            this.SocDel.UseVisualStyleBackColor = true;
            this.SocDel.Click += new System.EventHandler(this.SocDel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1018, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "详细信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1009, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "修改社团信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SocManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1237, 608);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SocDel);
            this.Controls.Add(this.SocAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SocManage";
            this.Text = "SocManage";
            this.Load += new System.EventHandler(this.SocManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解散社团ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑社团信息ToolStripMenuItem;
        private System.Windows.Forms.Button SocAdd;
        private System.Windows.Forms.Button SocDel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocJieshao;
    }
}