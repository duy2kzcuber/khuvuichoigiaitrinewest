using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using e_excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace khuvuichoigiaitrinewest
{
    public partial class tt_khachhang : Form
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public tt_khachhang()
        {
            InitializeComponent();
        }
        private void load_dgv_thongtinkh()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2 tao đối tượng command lấy dữ liệu từ DB
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From tt_khachhang";
            //b3 tao adadaptet lấy dư lieeun từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4 đổ dl từ DataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            //b5 hiển thi datatable lên datagridview
            dgv_thongtinkh.DataSource = dt;
            dgv_thongtinkh.Refresh();
        }
        private bool Checktrungma(string p_sdt)//tự viết
        {
            //b1 ket noi DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            //b2 tạo đối tượng command để thực hiện kiểm tra
            string sql = "select count(*) From tt_khachhang where sodt='" + p_sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;

        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            //b1 lấy dl từ các control đưa vao biến
            string p_hoten = txttenkh.Text.Trim();
            string p_sdt = txtsodt.Text.Trim();
            string p_ns = txtngaysinh.Text.Trim();
            string p_ttsk = txtttsk.Text.Trim();
            if (p_sdt == "") //cach1
            {
                MessageBox.Show("số điện thoại khôngđược bỏ trống");
                txtsodt.Focus();
                return;
            }
            if (String.IsNullOrEmpty(p_hoten))
            {
                MessageBox.Show("Tên xuất bản kh được để trống");
                txttenkh.Focus();
                return;
            }
            if (Checktrungma(p_sdt))
            {
                MessageBox.Show("Số điện thoại  đã tồn tại");
                txtsodt.Focus();// trả  về con trỏ nhấp nháy
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "Insert into tt_khachhang Values('" + p_hoten + "',N'" + p_ns + "','" + p_sdt + "',N'" + p_ttsk + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công !");
            load_dgv_thongtinkh();
        }

        private void tt_thongtinkh_Load(object sender, EventArgs e)
        {
            load_dgv_thongtinkh();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu từ các control đưa vào biến
            string p_hoten = txttenkh.Text.Trim();
            string p_sdt = txtsodt.Text.Trim();
            string p_ns=txtngaysinh.Text.Trim();
            string p_ttsk = txtttsk.Text.Trim();
            //b2 Kết nối đến DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update tt_khachhang set tenkhachhang=N'" + p_hoten + "',ngaysinh='" + p_ns + "',sodt='" + p_sdt + "', tinhtrangsk=N'" + p_ttsk + "' Where sodt='" + p_sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công!");
            load_dgv_thongtinkh();
            txtsodt.Enabled = true;
        }

        private void dgv_thongtinkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txttenkh.Text = dgv_thongtinkh.Rows[i].Cells[0].Value.ToString();
            txtngaysinh.Text = dgv_thongtinkh.Rows[i].Cells[1].Value.ToString();
            txtsodt.Text = dgv_thongtinkh.Rows[i].Cells[2].Value.ToString();
            txtttsk.Text = dgv_thongtinkh.Rows[i].Cells[3].Value.ToString();

            txtsodt.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu 
            //xóa theo khóa chính
            string p_sdt = txtsodt.Text.Trim();

            //b2 kết nối DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tạo đối tượng command để thực hiện xóa dữ liệu trong bảng
            string sql = "Delete tt_khachhang where sodt='" + p_sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công >>>");
            load_dgv_thongtinkh();
            txtsodt.Enabled = true;
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

            e_excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN KHÁCH HÀNG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên KH";
            cl1.ColumnWidth = 25.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Ngày sinh";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số ĐT";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "TÌNH TRẠNG SK";
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
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu từ control
           // string p_hoten = txttenkh.Text.Trim();
           // string p_ns=txtngaysinh.Text.Trim();
           // string p_sdt = txtsodt.Text.Trim();
           // string p_ttsk = txtttsk.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select * from tt_khachhang";// where tenkhachhang like N'%" + p_hoten + "%' and ngaysinh like N'" + p_ns + "' and sodt like N'%" + p_sdt + "%' and tinhtrangsk like N'%" + p_ttsk + "%'";
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
            ExportExcel(tb, "THÔNG TIN KHÁCH HÀNG");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu từ các control đưa vao biến
            string p_hoten = txttenkh.Text.Trim();
           string p_ns = txtngaysinh.Text.Trim();
            string p_sdt = txtsodt.Text.Trim();
            string p_ttsk = txtttsk.Text.Trim();
            //b2 kết nối đến DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            //b3 tạo đối tượng command để lấy dữ liệu từ bảng nxb
            string sql = "select * from tt_khachhang where tenkhachhang like N'%" + p_hoten + "%'and sodt like'%" + p_sdt + "%' and tinhtrangsk like '%" + p_ttsk + "%'";
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
            dgv_thongtinkh.DataSource = tb;
            dgv_thongtinkh.Refresh();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = true;
            txtsodt.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
