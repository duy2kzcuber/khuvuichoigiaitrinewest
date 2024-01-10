namespace khuvuichoigiaitrinewest
{
    partial class tt_nhansu
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
            this.dgv_thongtinnhansu = new System.Windows.Forms.DataGridView();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khuvuclam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtkhuvuclam = new System.Windows.Forms.TextBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.txttenns = new System.Windows.Forms.TextBox();
            this.txtmans = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.datatimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinnhansu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_thongtinnhansu
            // 
            this.dgv_thongtinnhansu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_thongtinnhansu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinnhansu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhanvien,
            this.tennhanvien,
            this.ngaysinh,
            this.sodt,
            this.Khuvuclam,
            this.chucvu,
            this.luong});
            this.dgv_thongtinnhansu.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_thongtinnhansu.Location = new System.Drawing.Point(13, 388);
            this.dgv_thongtinnhansu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_thongtinnhansu.Name = "dgv_thongtinnhansu";
            this.dgv_thongtinnhansu.RowHeadersWidth = 62;
            this.dgv_thongtinnhansu.RowTemplate.Height = 28;
            this.dgv_thongtinnhansu.Size = new System.Drawing.Size(1419, 304);
            this.dgv_thongtinnhansu.TabIndex = 25;
            this.dgv_thongtinnhansu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtinnhansu_CellClick);
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manv";
            this.manhanvien.HeaderText = "Mã Nhân viên";
            this.manhanvien.MinimumWidth = 8;
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Width = 150;
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "tennv";
            this.tennhanvien.HeaderText = "Tên nhân viên";
            this.tennhanvien.MinimumWidth = 8;
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 150;
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "sodt";
            this.sodt.HeaderText = "Số ĐT";
            this.sodt.MinimumWidth = 8;
            this.sodt.Name = "sodt";
            this.sodt.Width = 150;
            // 
            // Khuvuclam
            // 
            this.Khuvuclam.DataPropertyName = "khuvuclam";
            this.Khuvuclam.HeaderText = "Khu vực làm";
            this.Khuvuclam.MinimumWidth = 8;
            this.Khuvuclam.Name = "Khuvuclam";
            this.Khuvuclam.Width = 150;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.MinimumWidth = 8;
            this.chucvu.Name = "chucvu";
            this.chucvu.Width = 150;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 8;
            this.luong.Name = "luong";
            this.luong.Width = 150;
            // 
            // btnxuat
            // 
            this.btnxuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuat.ForeColor = System.Drawing.Color.Black;
            this.btnxuat.Location = new System.Drawing.Point(937, 31);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(110, 45);
            this.btnxuat.TabIndex = 24;
            this.btnxuat.Text = "Xuất file";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(440, 31);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 45);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(258, 31);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(110, 45);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(59, 30);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(111, 45);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(897, 173);
            this.txtluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(388, 31);
            this.txtluong.TabIndex = 19;
            this.txtluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluong_KeyPress);
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(897, 128);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(388, 31);
            this.txtchucvu.TabIndex = 18;
            // 
            // txtkhuvuclam
            // 
            this.txtkhuvuclam.Location = new System.Drawing.Point(897, 84);
            this.txtkhuvuclam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtkhuvuclam.Name = "txtkhuvuclam";
            this.txtkhuvuclam.Size = new System.Drawing.Size(388, 31);
            this.txtkhuvuclam.TabIndex = 17;
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(897, 44);
            this.txtsodt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(388, 31);
            this.txtsodt.TabIndex = 16;
            this.txtsodt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txttenns
            // 
            this.txttenns.Location = new System.Drawing.Point(161, 94);
            this.txttenns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttenns.Name = "txttenns";
            this.txttenns.Size = new System.Drawing.Size(388, 31);
            this.txttenns.TabIndex = 15;
            // 
            // txtmans
            // 
            this.txtmans.Location = new System.Drawing.Point(161, 46);
            this.txtmans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmans.Name = "txtmans";
            this.txtmans.Size = new System.Drawing.Size(388, 31);
            this.txtmans.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(709, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Lương";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(709, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(709, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Khu vực làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(709, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số đt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã nhân sự";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân sự";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.Black;
            this.btntimkiem.Location = new System.Drawing.Point(680, 31);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(126, 45);
            this.btntimkiem.TabIndex = 26;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(1159, 30);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(109, 45);
            this.btnlammoi.TabIndex = 27;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // datatimengaysinh
            // 
            this.datatimengaysinh.CustomFormat = "MM/dd/yyyy";
            this.datatimengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datatimengaysinh.Location = new System.Drawing.Point(161, 151);
            this.datatimengaysinh.Name = "datatimengaysinh";
            this.datatimengaysinh.Size = new System.Drawing.Size(388, 31);
            this.datatimengaysinh.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.btnxuat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1314, 82);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.datatimengaysinh);
            this.groupBox2.Controls.Add(this.txtluong);
            this.groupBox2.Controls.Add(this.txtchucvu);
            this.groupBox2.Controls.Add(this.txtkhuvuclam);
            this.groupBox2.Controls.Add(this.txtsodt);
            this.groupBox2.Controls.Add(this.txttenns);
            this.groupBox2.Controls.Add(this.txtmans);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1314, 208);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân sự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(587, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông tin nhân sự";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::khuvuichoigiaitrinewest.Properties.Resources.giphy__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(12, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(120, 76);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 32;
            this.guna2PictureBox2.TabStop = false;
            // 
            // tt_nhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 808);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_thongtinnhansu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tt_nhansu";
            this.Text = "Nhansu";
            this.Load += new System.EventHandler(this.tt_nhansu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinnhansu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongtinnhansu;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtkhuvuclam;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.TextBox txttenns;
        private System.Windows.Forms.TextBox txtmans;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DateTimePicker datatimengaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khuvuclam;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}