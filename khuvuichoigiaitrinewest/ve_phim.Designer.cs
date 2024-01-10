namespace khuvuichoigiaitrinewest
{
    partial class ve_phim
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
            this.dgv_vephim = new System.Windows.Forms.DataGridView();
            this.mave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavenguoilon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giavetreem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_nglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_tree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtp_tgdong = new System.Windows.Forms.DateTimePicker();
            this.dtp_tgban = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tt = new System.Windows.Forms.ComboBox();
            this.cbo_phim = new System.Windows.Forms.ComboBox();
            this.txt_mave = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sonl = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gvtreem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gvnglon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vephim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vephim
            // 
            this.dgv_vephim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_vephim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vephim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mave,
            this.tenphim,
            this.trangthai,
            this.tgban,
            this.tgdong,
            this.giavenguoilon,
            this.giavetreem,
            this.soluong_nglon,
            this.soluong_tree,
            this.tongtien});
            this.dgv_vephim.Location = new System.Drawing.Point(628, 332);
            this.dgv_vephim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_vephim.Name = "dgv_vephim";
            this.dgv_vephim.RowHeadersWidth = 51;
            this.dgv_vephim.Size = new System.Drawing.Size(1368, 758);
            this.dgv_vephim.TabIndex = 37;
            this.dgv_vephim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vephim_CellContentClick);
            // 
            // mave
            // 
            this.mave.DataPropertyName = "mave";
            this.mave.HeaderText = "Mã vé";
            this.mave.MinimumWidth = 6;
            this.mave.Name = "mave";
            this.mave.Width = 200;
            // 
            // tenphim
            // 
            this.tenphim.DataPropertyName = "tenphim";
            this.tenphim.HeaderText = "Tên Phim";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            this.tenphim.Width = 200;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 200;
            // 
            // tgban
            // 
            this.tgban.DataPropertyName = "thoigianban";
            this.tgban.HeaderText = "Thời gian bán";
            this.tgban.MinimumWidth = 6;
            this.tgban.Name = "tgban";
            this.tgban.Width = 200;
            // 
            // tgdong
            // 
            this.tgdong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgdong.DataPropertyName = "thoigiandong";
            this.tgdong.HeaderText = "Thời gian đóng";
            this.tgdong.MinimumWidth = 6;
            this.tgdong.Name = "tgdong";
            this.tgdong.Width = 137;
            // 
            // giavenguoilon
            // 
            this.giavenguoilon.DataPropertyName = "giavenguoilon";
            this.giavenguoilon.HeaderText = "Giá vé người lớn";
            this.giavenguoilon.MinimumWidth = 8;
            this.giavenguoilon.Name = "giavenguoilon";
            this.giavenguoilon.Width = 150;
            // 
            // giavetreem
            // 
            this.giavetreem.DataPropertyName = "giavetreem";
            this.giavetreem.HeaderText = "Giá vé trẻ em";
            this.giavetreem.MinimumWidth = 8;
            this.giavetreem.Name = "giavetreem";
            this.giavetreem.Width = 150;
            // 
            // soluong_nglon
            // 
            this.soluong_nglon.DataPropertyName = "soluong_nglon";
            this.soluong_nglon.HeaderText = "Số lượng người lớn";
            this.soluong_nglon.MinimumWidth = 8;
            this.soluong_nglon.Name = "soluong_nglon";
            this.soluong_nglon.Width = 150;
            // 
            // soluong_tree
            // 
            this.soluong_tree.DataPropertyName = "soluong_tree";
            this.soluong_tree.HeaderText = "Số lượng trẻ em";
            this.soluong_tree.MinimumWidth = 8;
            this.soluong_tree.Name = "soluong_tree";
            this.soluong_tree.Width = 150;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 8;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 150;
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(498, 12);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(111, 78);
            this.btn_xuat.TabIndex = 36;
            this.btn_xuat.Text = "Xuất file";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(290, 12);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 78);
            this.btn_timkiem.TabIndex = 35;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(87, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 78);
            this.btn_them.TabIndex = 32;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtp_tgdong
            // 
            this.dtp_tgdong.CustomFormat = "HH:mm:ss";
            this.dtp_tgdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgdong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgdong.Location = new System.Drawing.Point(274, 346);
            this.dtp_tgdong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_tgdong.Name = "dtp_tgdong";
            this.dtp_tgdong.Size = new System.Drawing.Size(298, 44);
            this.dtp_tgdong.TabIndex = 31;
            // 
            // dtp_tgban
            // 
            this.dtp_tgban.CustomFormat = "HH:mm:ss";
            this.dtp_tgban.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgban.Location = new System.Drawing.Point(274, 258);
            this.dtp_tgban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_tgban.Name = "dtp_tgban";
            this.dtp_tgban.Size = new System.Drawing.Size(298, 44);
            this.dtp_tgban.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Thời gian đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thời gian bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã vé";
            // 
            // cbo_tt
            // 
            this.cbo_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tt.FormattingEnabled = true;
            this.cbo_tt.Items.AddRange(new object[] {
            "CÒN",
            "HẾT"});
            this.cbo_tt.Location = new System.Drawing.Point(274, 180);
            this.cbo_tt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_tt.Name = "cbo_tt";
            this.cbo_tt.Size = new System.Drawing.Size(298, 45);
            this.cbo_tt.TabIndex = 24;
            // 
            // cbo_phim
            // 
            this.cbo_phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phim.FormattingEnabled = true;
            this.cbo_phim.Location = new System.Drawing.Point(274, 102);
            this.cbo_phim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_phim.Name = "cbo_phim";
            this.cbo_phim.Size = new System.Drawing.Size(298, 45);
            this.cbo_phim.TabIndex = 23;
            this.cbo_phim.SelectedIndexChanged += new System.EventHandler(this.cbo_phim_SelectedIndexChanged);
            // 
            // txt_mave
            // 
            this.txt_mave.Location = new System.Drawing.Point(274, 26);
            this.txt_mave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mave.Multiline = true;
            this.txt_mave.Name = "txt_mave";
            this.txt_mave.Size = new System.Drawing.Size(298, 52);
            this.txt_mave.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_sote);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_sonl);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_gvtreem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_gvnglon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_tgdong);
            this.groupBox1.Controls.Add(this.dtp_tgban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_tt);
            this.groupBox1.Controls.Add(this.cbo_phim);
            this.groupBox1.Controls.Add(this.txt_mave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 880);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vé phim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 512);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 32);
            this.label11.TabIndex = 41;
            this.label11.Text = "Số trẻ em";
            // 
            // txt_sote
            // 
            this.txt_sote.Location = new System.Drawing.Point(274, 495);
            this.txt_sote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sote.Multiline = true;
            this.txt_sote.Name = "txt_sote";
            this.txt_sote.Size = new System.Drawing.Size(298, 52);
            this.txt_sote.TabIndex = 40;
            this.txt_sote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sote_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 431);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 32);
            this.label10.TabIndex = 39;
            this.label10.Text = "Số người lớn";
            // 
            // txt_sonl
            // 
            this.txt_sonl.Location = new System.Drawing.Point(274, 414);
            this.txt_sonl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sonl.Multiline = true;
            this.txt_sonl.Name = "txt_sonl";
            this.txt_sonl.Size = new System.Drawing.Size(298, 52);
            this.txt_sonl.TabIndex = 38;
            this.txt_sonl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sonl_KeyPress);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(274, 746);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(298, 52);
            this.txt_tongtien.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 763);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 32);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tổng tiền";
            // 
            // txt_gvtreem
            // 
            this.txt_gvtreem.Location = new System.Drawing.Point(274, 666);
            this.txt_gvtreem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gvtreem.Multiline = true;
            this.txt_gvtreem.Name = "txt_gvtreem";
            this.txt_gvtreem.ReadOnly = true;
            this.txt_gvtreem.Size = new System.Drawing.Size(298, 52);
            this.txt_gvtreem.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 666);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Giá vé trẻ em";
            // 
            // txt_gvnglon
            // 
            this.txt_gvnglon.Location = new System.Drawing.Point(274, 585);
            this.txt_gvnglon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gvnglon.Multiline = true;
            this.txt_gvnglon.Name = "txt_gvnglon";
            this.txt_gvnglon.ReadOnly = true;
            this.txt_gvnglon.Size = new System.Drawing.Size(298, 52);
            this.txt_gvnglon.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Giá vé người lớn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_xuat);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(741, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 134);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 59);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thông tin vé phim";
           
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1597, 70);
            this.textBox1.TabIndex = 40;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::khuvuichoigiaitrinewest.Properties.Resources.giphy__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 74);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(106, 123);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 41;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ve_phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_vephim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ve_phim";
            this.Text = "ve_phim";
            this.Load += new System.EventHandler(this.ve_phim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vephim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vephim;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtp_tgdong;
        private System.Windows.Forms.DateTimePicker dtp_tgban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_tt;
        private System.Windows.Forms.ComboBox cbo_phim;
        private System.Windows.Forms.TextBox txt_mave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gvtreem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gvnglon;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_sote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sonl;
        private System.Windows.Forms.DataGridViewTextBoxColumn mave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavenguoilon;
        private System.Windows.Forms.DataGridViewTextBoxColumn giavetreem;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_nglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_tree;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}