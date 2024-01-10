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
            this.txt_mave = new System.Windows.Forms.TextBox();
            this.cbo_khu = new System.Windows.Forms.ComboBox();
            this.cbo_tt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_tgban = new System.Windows.Forms.DateTimePicker();
            this.dtp_tgdong = new System.Windows.Forms.DateTimePicker();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_vethamquan = new System.Windows.Forms.DataGridView();
            this.mave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vethamquan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mave
            // 
            this.txt_mave.Location = new System.Drawing.Point(115, 24);
            this.txt_mave.Name = "txt_mave";
            this.txt_mave.Size = new System.Drawing.Size(208, 20);
            this.txt_mave.TabIndex = 0;
            // 
            // cbo_khu
            // 
            this.cbo_khu.FormattingEnabled = true;
            this.cbo_khu.Location = new System.Drawing.Point(115, 67);
            this.cbo_khu.Name = "cbo_khu";
            this.cbo_khu.Size = new System.Drawing.Size(207, 21);
            this.cbo_khu.TabIndex = 1;
            // 
            // cbo_tt
            // 
            this.cbo_tt.FormattingEnabled = true;
            this.cbo_tt.Items.AddRange(new object[] {
            "CÒN",
            "HẾT"});
            this.cbo_tt.Location = new System.Drawing.Point(115, 111);
            this.cbo_tt.Name = "cbo_tt";
            this.cbo_tt.Size = new System.Drawing.Size(207, 21);
            this.cbo_tt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời gian bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thời gian đóng";
            // 
            // dtp_tgban
            // 
            this.dtp_tgban.CustomFormat = "HH:mm:ss";
            this.dtp_tgban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgban.Location = new System.Drawing.Point(495, 27);
            this.dtp_tgban.Name = "dtp_tgban";
            this.dtp_tgban.Size = new System.Drawing.Size(200, 20);
            this.dtp_tgban.TabIndex = 10;
            // 
            // dtp_tgdong
            // 
            this.dtp_tgdong.CustomFormat = "HH:mm:ss";
            this.dtp_tgdong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tgdong.Location = new System.Drawing.Point(495, 74);
            this.dtp_tgdong.Name = "dtp_tgdong";
            this.dtp_tgdong.Size = new System.Drawing.Size(200, 20);
            this.dtp_tgdong.TabIndex = 11;
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(249, 161);
            this.btn_xuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(73, 28);
            this.btn_xuat.TabIndex = 20;
            this.btn_xuat.Text = "Xuất file";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(135, 161);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(73, 28);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(34, 161);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(73, 28);
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
            this.tgdong});
            this.dgv_vethamquan.Location = new System.Drawing.Point(37, 213);
            this.dgv_vethamquan.Name = "dgv_vethamquan";
            this.dgv_vethamquan.Size = new System.Drawing.Size(730, 222);
            this.dgv_vethamquan.TabIndex = 21;
            this.dgv_vethamquan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vethamquan_CellContentClick);
            // 
            // mave
            // 
            this.mave.DataPropertyName = "mave";
            this.mave.HeaderText = "Mã vé";
            this.mave.Name = "mave";
            // 
            // tenkhu
            // 
            this.tenkhu.DataPropertyName = "tenkhu";
            this.tenkhu.HeaderText = "Tên khu";
            this.tenkhu.Name = "tenkhu";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // tgban
            // 
            this.tgban.DataPropertyName = "thoigianban";
            this.tgban.HeaderText = "Thời gian bán";
            this.tgban.Name = "tgban";
            // 
            // tgdong
            // 
            this.tgdong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgdong.DataPropertyName = "thoigiandong";
            this.tgdong.HeaderText = "Thời gian đóng";
            this.tgdong.Name = "tgdong";
            this.tgdong.Width = 96;
            // 
            // ve_thamquan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_vethamquan);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_tgdong);
            this.Controls.Add(this.dtp_tgban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_tt);
            this.Controls.Add(this.cbo_khu);
            this.Controls.Add(this.txt_mave);
            this.Name = "ve_thamquan";
            this.Text = "ve_thamquan";
            this.Load += new System.EventHandler(this.ve_thamquan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vethamquan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mave;
        private System.Windows.Forms.ComboBox cbo_khu;
        private System.Windows.Forms.ComboBox cbo_tt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_tgban;
        private System.Windows.Forms.DateTimePicker dtp_tgdong;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_vethamquan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgdong;
    }
}