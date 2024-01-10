using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using e_excel = Microsoft.Office.Interop.Excel;

namespace khuvuichoigiaitrinewest
{
    public partial class tt_danhgia : Form
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public tt_danhgia()
        {
            InitializeComponent();
        }

        private void Load_cbosdt()
        {
            try
            {
                string sql = "SELECT * FROM tt_khachhang";
                DataTable dt = Thuvien.Hienthi(sql);
                DataRow r = dt.NewRow();
                r["sodt"] = "--- Chọn số điện thoại ---";
                r["sodt"] = "--- Chọn số điện thoại ---";
                dt.Rows.InsertAt(r, 0);
                cbosdt.DataSource = dt;
                cbosdt.DisplayMember = "sodt";
                cbosdt.ValueMember = "sodt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu số điện thoại: " + ex.Message);
            }
        }


        private void load_dgv_danhgia()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From tt_danhgia";
            //b3 tao adadaptet lấy dư lieeun từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4 đổ dl từ DataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            //b5 hiển thi datatable lên datagridview
            dgv_danhgia.DataSource = dt;
            dgv_danhgia.Refresh();
        
        }

        private void tt_danhgia_Load(object sender, EventArgs e)
        {
                Load_cbosdt();
                load_dgv_danhgia();
        }

        private void cbosdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string p_cbosdt = cbosdt.Text.ToString();
                string sql = "SELECT tenkhachhang FROM tt_khachhang WHERE sodt='" + p_cbosdt + "'";
                DataTable dt = Thuvien.Hienthi(sql);
                if (dt.Rows.Count > 0)
                    txttenkh.Text = dt.Rows[0]["tenkhachhang"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn số điện thoại: " + ex.Message);
            }
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string p_sdt = cbosdt.SelectedValue.ToString();
                string p_hoten = txttenkh.Text.Trim();
                string p_mota = txtmota.Text.Trim();
                string p_vote = txtvote.Text.Trim();

                string sql = "INSERT INTO tt_danhgia (sodt, tenkhachhang,mota ,votesao) VALUES ( @sodt,@tenkhachhang, @mota, @votesao )";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@sodt", p_sdt);
                    cmd.Parameters.AddWithValue("@tenkhachhang", p_hoten);
                    cmd.Parameters.AddWithValue("@mota", p_mota);
                    cmd.Parameters.AddWithValue("@votesao", p_vote);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(" Đã thêm mới");
                load_dgv_danhgia(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string p_sdt = cbosdt.SelectedValue.ToString();
                string p_mota = txtmota.Text.Trim();
                string p_vote = txtvote.Text.Trim();

                string sql = "UPDATE tt_danhgia SET mota = @mota, votesao = @votesao WHERE sodt = @sodt";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@sodt", p_sdt);
                    cmd.Parameters.AddWithValue("@mota", p_mota);
                    cmd.Parameters.AddWithValue("@votesao", p_vote);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công!");
                load_dgv_danhgia();
                cbosdt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dgv_danhgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
           
            cbosdt.Text = dgv_danhgia.Rows[i].Cells[0].Value.ToString();
            txttenkh.Text = dgv_danhgia.Rows[i].Cells[1].Value.ToString();
            txtmota.Text = dgv_danhgia.Rows[i].Cells[2].Value.ToString();
            txtvote.Text = dgv_danhgia.Rows[i].Cells[3].Value.ToString();

            cbosdt.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string p_sdt = cbosdt.SelectedValue.ToString();

            //b2 kết nối DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tạo đối tượng command để thực hiện xóa dữ liệu trong bảng
            string sql = "Delete tt_danhgia where sodt='" + p_sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công >>>");
            load_dgv_danhgia();
            cbosdt.Enabled = true;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string p_sdt = cbosdt.SelectedValue.ToString();
            string p_hoten = txttenkh.Text.Trim();
            string p_mota = txtmota.Text.Trim();
            string p_vote = txtvote.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 tạo đối tượng command để lấy dữ liệu từ bảng nxb
            string sql = "Select * From tt_danhgia Where sodt like N'%" + p_sdt + "%' and tenkhachhang like N'%" + p_hoten + "%'and mota like N'%" + p_mota + "%' and votesao like N'%" + p_vote + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            //b4 tạo đối tượng dataAdapter để lấy kết quả từ command
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //5 lấy dữ liệu từ dataAdapter vào datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            //b6 hiển thị datatable lên Datagridview
            dgv_danhgia.DataSource = tb;
            dgv_danhgia.Refresh();
        }
        private void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN NHÂN SỤ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Số điện thoại";
            cl1.ColumnWidth = 25.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên khách hàng";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Mô tả";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Vote sao";
            cl4.ColumnWidth = 25.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "D3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            // string p_sdt = cbosdt.SelectedValue.ToString();
            // string p_hoten = txttenkh.Text.Trim();
            // string p_mota = txtmota.Text.Trim();
            // string p_vote = txtvote.Text.Trim();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT * FROM tt_danhgia";// WHERE sodt LIKE '%" + p_sdt + "%' AND tenkhachhang LIKE N'%" + p_hoten + "%' AND mota LIKE N'%" + p_mota + "%' AND votesao LIKE N'%" + p_vote + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmd.Dispose();
            con.Close();
            ExportExcel(dt, "ĐÁNH GIÁ KHÁCH HÀNG");
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            cbosdt.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
        }
    }
}