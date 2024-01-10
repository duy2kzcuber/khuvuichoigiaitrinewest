namespace khuvuichoigiaitrinewest
{
    partial class tt_danhgia
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtvote = new System.Windows.Forms.TextBox();
            this.cbosdt = new System.Windows.Forms.ComboBox();
            this.dgv_danhgia = new System.Windows.Forms.DataGridView();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhgia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đánh giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(852, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vote sao";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(1032, 37);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(340, 39);
            this.txtmota.TabIndex = 2;
            // 
            // txtvote
            // 
            this.txtvote.Location = new System.Drawing.Point(1032, 101);
            this.txtvote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvote.Multiline = true;
            this.txtvote.Name = "txtvote";
            this.txtvote.Size = new System.Drawing.Size(340, 40);
            this.txtvote.TabIndex = 2;
            // 
            // cbosdt
            // 
            this.cbosdt.FormattingEnabled = true;
            this.cbosdt.Location = new System.Drawing.Point(263, 44);
            this.cbosdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbosdt.Name = "cbosdt";
            this.cbosdt.Size = new System.Drawing.Size(343, 28);
            this.cbosdt.TabIndex = 3;
            this.cbosdt.SelectedIndexChanged += new System.EventHandler(this.cbosdt_SelectedIndexChanged);
            // 
            // dgv_danhgia
            // 
            this.dgv_danhgia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_danhgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sodt,
            this.tenkh,
            this.Mota,
            this.votesao});
            this.dgv_danhgia.Location = new System.Drawing.Point(152, 371);
            this.dgv_danhgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhgia.Name = "dgv_danhgia";
            this.dgv_danhgia.RowHeadersWidth = 62;
            this.dgv_danhgia.RowTemplate.Height = 28;
            this.dgv_danhgia.Size = new System.Drawing.Size(1203, 462);
            this.dgv_danhgia.TabIndex = 5;
            this.dgv_danhgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhgia_CellContentClick);
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "sodt";
            this.sodt.HeaderText = "Số điện thoại";
            this.sodt.MinimumWidth = 8;
            this.sodt.Name = "sodt";
            this.sodt.Width = 200;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkhachhang";
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.MinimumWidth = 8;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 200;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "mota";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.MinimumWidth = 8;
            this.Mota.Name = "Mota";
            this.Mota.Width = 200;
            // 
            // votesao
            // 
            this.votesao.DataPropertyName = "votesao";
            this.votesao.HeaderText = "Vote sao";
            this.votesao.MinimumWidth = 8;
            this.votesao.Name = "votesao";
            this.votesao.Width = 150;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(263, 92);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkh.Multiline = true;
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(340, 41);
            this.txttenkh.TabIndex = 6;
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(59, 28);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(124, 54);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(292, 28);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(124, 54);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(537, 28);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(135, 54);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(1063, 28);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(124, 54);
            this.btntimkiem.TabIndex = 8;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuat.Location = new System.Drawing.Point(821, 28);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(124, 54);
            this.btnxuat.TabIndex = 8;
            this.btnxuat.Text = "Xuất file";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(1290, 28);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(135, 54);
            this.btnlammoi.TabIndex = 9;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnxuat);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1453, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txttenkh);
            this.groupBox2.Controls.Add(this.cbosdt);
            this.groupBox2.Controls.Add(this.txtvote);
            this.groupBox2.Controls.Add(this.txtmota);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1480, 158);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đánh giá";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::khuvuichoigiaitrinewest.Properties.Resources.giphy__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-2, 2);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(107, 103);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 25;
            this.guna2PictureBox2.TabStop = false;
            // 
            // tt_danhgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1728, 971);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_danhgia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "tt_danhgia";
            this.Text = "Danhgia";
            this.Load += new System.EventHandler(this.tt_danhgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhgia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtvote;
        private System.Windows.Forms.ComboBox cbosdt;
        private System.Windows.Forms.DataGridView dgv_danhgia;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}