namespace khuvuichoigiaitrinewest
{
    partial class ve_thamquan
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
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_vethamquan = new System.Windows.Forms.DataGridView();
            this.txt_giatreem = new System.Windows.Forms.TextBox();
            this.txt_sltreem = new System.Windows.Forms.TextBox();
            this.txt_slnglon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_tt = new System.Windows.Forms.ComboBox();
            this.dtp_tgdong = new System.Windows.Forms.DateTimePicker();
            this.dtp_tgban = new System.Windows.Forms.DateTimePicker();
            this.cbo_khu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tenkhu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_gianglon = new System.Windows.Forms.TextBox();
            this.mave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavenguoilon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavetreem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_nguoilon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_treem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vethamquan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(475, 276);
            this.btn_xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(97, 34);
            this.btn_xuat.TabIndex = 20;
            this.btn_xuat.Text = "Xuất file";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(325, 276);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(97, 34);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(190, 276);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 34);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_vethamquan
            // 
            this.dgv_vethamquan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vethamquan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mave,
            this.tenkhu,
            this.trangthai,
            this.tgban,
            this.tgdong,
            this.giavenguoilon,
            this.giavetreem,
            this.soluong_nguoilon,
            this.soluong_treem,
            this.tongtien});
            this.dgv_vethamquan.Location = new System.Drawing.Point(101, 329);
            this.dgv_vethamquan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_vethamquan.Name = "dgv_vethamquan";
            this.dgv_vethamquan.RowHeadersWidth = 51;
            this.dgv_vethamquan.Size = new System.Drawing.Size(973, 273);
            this.dgv_vethamquan.TabIndex = 21;
            this.dgv_vethamquan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vethamquan_CellContentClick);
            // 
            // txt_giatreem
            // 
            this.txt_giatreem.Location = new System.Drawing.Point(723, 209);
            this.txt_giatreem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_giatreem.Name = "txt_giatreem";
            this.txt_giatreem.ReadOnly = true;
            this.txt_giatreem.Size = new System.Drawing.Size(207, 22);
            this.txt_giatreem.TabIndex = 42;
            // 
            // txt_sltreem
            // 
            this.txt_sltreem.Location = new System.Drawing.Point(312, 209);
            this.txt_sltreem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sltreem.Name = "txt_sltreem";
            this.txt_sltreem.Size = new System.Drawing.Size(207, 22);
            this.txt_sltreem.TabIndex = 40;
            // 
            // txt_slnglon
            // 
            this.txt_slnglon.Location = new System.Drawing.Point(315, 165);
            this.txt_slnglon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_slnglon.Name = "txt_slnglon";
            this.txt_slnglon.Size = new System.Drawing.Size(207, 22);
            this.txt_slnglon.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Giá vé trẻ em";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Giá vé người lớn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số lượng trẻ em";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số lượng người lớn";
            // 
            // cbo_tt
            // 
            this.cbo_tt.FormattingEnabled = true;
            this.cbo_tt.Items.AddRange(new object[] {
            "CÒN",
            "HẾT"});
            this.cbo_tt.Location = new System.Drawing.Point(315, 115);
            this.cbo_tt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_tt.Name = "cbo_tt";
            this.cbo_tt.Size = new System.Drawing.Size(204, 24);
            this.cbo_tt.TabIndex = 34;
            this.cbo_tt.SelectedIndexChanged += new System.EventHandler(this.cbo_tt_SelectedIndexChanged);
            // 
            // dtp_tgdong
            // 
            this.dtp_tgdong.CustomFormat = "HH:mm:ss";
            this.dtp_tgdong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgdong.Location = new System.Drawing.Point(723, 109);
            this.dtp_tgdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_tgdong.Name = "dtp_tgdong";
            this.dtp_tgdong.Size = new System.Drawing.Size(201, 22);
            this.dtp_tgdong.TabIndex = 33;
            // 
            // dtp_tgban
            // 
            this.dtp_tgban.CustomFormat = "HH:mm:ss";
            this.dtp_tgban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgban.Location = new System.Drawing.Point(723, 54);
            this.dtp_tgban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_tgban.Name = "dtp_tgban";
            this.dtp_tgban.Size = new System.Drawing.Size(201, 22);
            this.dtp_tgban.TabIndex = 32;
            // 
            // cbo_khu
            // 
            this.cbo_khu.FormattingEnabled = true;
            this.cbo_khu.Location = new System.Drawing.Point(315, 58);
            this.cbo_khu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_khu.Name = "cbo_khu";
            this.cbo_khu.Size = new System.Drawing.Size(204, 24);
            this.cbo_khu.TabIndex = 31;
            this.cbo_khu.SelectedIndexChanged += new System.EventHandler(this.cbo_khu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thời gian đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Thời gian bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Trạng Thái";
            // 
            // cbo_tenkhu
            // 
            this.cbo_tenkhu.AutoSize = true;
            this.cbo_tenkhu.Location = new System.Drawing.Point(215, 67);
            this.cbo_tenkhu.Name = "cbo_tenkhu";
            this.cbo_tenkhu.Size = new System.Drawing.Size(55, 16);
            this.cbo_tenkhu.TabIndex = 27;
            this.cbo_tenkhu.Text = "Tên khu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã vé";
            // 
            // txt_mave
            // 
            this.txt_mave.Location = new System.Drawing.Point(317, 11);
            this.txt_mave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mave.Name = "txt_mave";
            this.txt_mave.Size = new System.Drawing.Size(612, 22);
            this.txt_mave.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tổng tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(723, 276);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(207, 22);
            this.txt_tongtien.TabIndex = 43;
            // 
            // txt_gianglon
            // 
            this.txt_gianglon.Location = new System.Drawing.Point(723, 165);
            this.txt_gianglon.Name = "txt_gianglon";
            this.txt_gianglon.ReadOnly = true;
            this.txt_gianglon.Size = new System.Drawing.Size(201, 22);
            this.txt_gianglon.TabIndex = 45;
            // 
            // mave
            // 
            this.mave.DataPropertyName = "mave";
            this.mave.HeaderText = "Mã vé";
            this.mave.MinimumWidth = 6;
            this.mave.Name = "mave";
            this.mave.Width = 125;
            // 
            // tenkhu
            // 
            this.tenkhu.DataPropertyName = "tenkhu";
            this.tenkhu.HeaderText = "Tên khu";
            this.tenkhu.MinimumWidth = 6;
            this.tenkhu.Name = "tenkhu";
            this.tenkhu.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // tgban
            // 
            this.tgban.DataPropertyName = "thoigianban";
            this.tgban.HeaderText = "Thời gian bán";
            this.tgban.MinimumWidth = 6;
            this.tgban.Name = "tgban";
            this.tgban.Width = 125;
            // 
            // tgdong
            // 
            this.tgdong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgdong.DataPropertyName = "thoigiandong";
            this.tgdong.HeaderText = "Thời gian đóng";
            this.tgdong.MinimumWidth = 6;
            this.tgdong.Name = "tgdong";
            this.tgdong.Width = 116;
            // 
            // giavenguoilon
            // 
            this.giavenguoilon.DataPropertyName = "giavenguoilon";
            this.giavenguoilon.HeaderText = "Giá vé người lớn";
            this.giavenguoilon.MinimumWidth = 6;
            this.giavenguoilon.Name = "giavenguoilon";
            this.giavenguoilon.Width = 125;
            // 
            // giavetreem
            // 
            this.giavetreem.DataPropertyName = "giavetreem";
            this.giavetreem.HeaderText = "Giá vé trẻ em";
            this.giavetreem.MinimumWidth = 6;
            this.giavetreem.Name = "giavetreem";
            this.giavetreem.Width = 125;
            // 
            // soluong_nguoilon
            // 
            this.soluong_nguoilon.DataPropertyName = "soluong_nguoilon";
            this.soluong_nguoilon.HeaderText = "Số lượng người lớn";
            this.soluong_nguoilon.MinimumWidth = 6;
            this.soluong_nguoilon.Name = "soluong_nguoilon";
            this.soluong_nguoilon.Width = 125;
            // 
            // soluong_treem
            // 
            this.soluong_treem.DataPropertyName = "soluong_treem";
            this.soluong_treem.HeaderText = "Số lượng trẻ em";
            this.soluong_treem.MinimumWidth = 6;
            this.soluong_treem.Name = "soluong_treem";
            this.soluong_treem.Width = 125;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 125;
            // 
            // ve_thamquan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 554);
            this.Controls.Add(this.txt_gianglon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_giatreem);
            this.Controls.Add(this.txt_sltreem);
            this.Controls.Add(this.txt_slnglon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_tt);
            this.Controls.Add(this.dtp_tgdong);
            this.Controls.Add(this.dtp_tgban);
            this.Controls.Add(this.cbo_khu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tenkhu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mave);
            this.Controls.Add(this.dgv_vethamquan);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ve_thamquan";
            this.Text = "ve_thamquan";
            this.Load += new System.EventHandler(this.ve_thamquan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vethamquan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_vethamquan;
        private System.Windows.Forms.TextBox txt_giatreem;
        private System.Windows.Forms.TextBox txt_sltreem;
        private System.Windows.Forms.TextBox txt_slnglon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_tt;
        private System.Windows.Forms.DateTimePicker dtp_tgdong;
        private System.Windows.Forms.DateTimePicker dtp_tgban;
        private System.Windows.Forms.ComboBox cbo_khu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cbo_tenkhu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_gianglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavenguoilon;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavetreem;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_nguoilon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_treem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}