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
using e_excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Collections.Specialized;
using System.Configuration;

namespace khuvuichoigiaitrinewest
{
    public partial class tt_nhansu : Form
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public tt_nhansu()
        {
            InitializeComponent();
        }
        private void load_dgv_thongtinnhansu()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From tt_nhansu";
            //b3 tao adadaptet lấy dư lieeun từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4 đổ dl từ DataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            //b5 hiển thi datatable lên datagridview
            dgv_thongtinnhansu.DataSource = dt;
            dgv_thongtinnhansu.Refresh();
        }
        private bool Checktrungma(string p_manv)
        {
            //b1 ket noi DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            //b2 tạo đối tượng command để thực hiện kiểm tra
            string sql = "select count(*) From tt_nhansu where manv='" + p_manv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;

        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string p_manv = txtmans.Text.Trim();
            string p_tennv = txttenns.Text.Trim();   
            string p_ns = datatimengaysinh.Text.Trim(); 
            string p_sdt = txtsodt.Text.Trim();
            string p_khuvuc = txtkhuvuclam.Text.Trim();
            string p_chucvu = txtchucvu.Text.Trim();
            int p_luong = int.Parse(txtluong.Text);

            if (p_manv == " ")
            {
                MessageBox.Show("Mã nhân viên  khôngđược bỏ trống");
                txtmans.Focus();
                return;
            }
            if (String.IsNullOrEmpty(p_sdt))
            {
                MessageBox.Show("Số điện thoại kh được để trống");
                txtsodt.Focus();
                return;
            }
            
            // kiểm tra trùng khóa chính
            if (Checktrungma(p_manv))
            {
                MessageBox.Show("Mã nhân sự đã tồn tại");
                txtmans.Focus();// trả  về con trỏ nhấp nháy

                return;
            }

            //b2 kết nối đến db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert into tt_nhansu Values('" + p_manv + "',N'" + p_tennv + "','" + p_ns + "','" + p_sdt + "',N'" + p_khuvuc + "',N'" + p_chucvu + "','" + p_luong + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công !");
            load_dgv_thongtinnhansu();
        }

        private void tt_nhansu_Load(object sender, EventArgs e)
        {
            load_dgv_thongtinnhansu();
        }

        

        private void btnsua_Click(object sender, EventArgs e)
        {
            //b1 lấy dl từ các control đưa vao biến
            string p_manv = txtmans.Text.Trim();
            string p_tennv = txttenns.Text.Trim();
            string p_ns = datatimengaysinh.Text.Trim();
            string p_sdt = txtsodt.Text.Trim();
            string p_khuvuc = txtkhuvuclam.Text.Trim();
            string p_chucvu = txtchucvu.Text.Trim();
            int p_luong = int.Parse(txtluong.Text);
            //b2 Kết nối đến DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "UPDATE tt_nhansu SET tennv = N'" + p_tennv + "', ngaysinh = '" + p_ns + "', sodt = '" + p_sdt + "', khuvuclam = N'" + p_khuvuc + "', chucvu = N'" + p_chucvu + "', luong = '" + p_luong + "' WHERE manv = '" + p_manv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công!");
            load_dgv_thongtinnhansu();
            txtmans.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            string p_sdt = txtsodt.Text.Trim();

            //b2 kết nối DB
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 Tạo đối tượng command để thực hiện xóa dữ liệu trong bảng
            string sql = "Delete tt_nhansu where sodt='" + p_sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công >>>");
            load_dgv_thongtinnhansu();
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

            e_excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN NHÂN SỤ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã NS";
            cl1.ColumnWidth = 25.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên NS";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số ĐT";
            cl4.ColumnWidth = 25.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Khu vực làm";
            cl5.ColumnWidth = 25.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Chức vụ";
            cl6.ColumnWidth = 25.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Lương";
            cl7.ColumnWidth = 25.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "G3");
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
          //  string p_manv = txtmans.Text.Trim();
          //  string p_tennv = txttenns.Text.Trim();
           // string p_ns = txtngaysinh.Text.Trim();
           // string p_sdt = txtsodt.Text.Trim();
           // string p_khuvuc = txtkhuvuclam.Text.Trim();
           // string p_chucvu = txtchucvu.Text.Trim();
           // int p_luong = int.Parse(txtluong.Text);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "Select * From tt_nhansu ";// Where manv like '%"+p_manv+"%', tennv like '%" + p_tennv + "%', ngaysinh like '%" + p_ns + "%', sodt like '%" + p_sdt + "%', khuvuclam like N'%" + p_khuvuc + "%', chucvu like N'%" + p_chucvu + "%', luong like '%" + p_luong + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmd.Dispose();
            con.Close();
            ExportExcel(dt, "Thông tin nhân sự");


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu từ các control đưa vao biến
            string p_manv = txtmans.Text.Trim();
            string p_tennv = txttenns.Text.Trim();
           // string p_ns = txtngaysinh.Text.Trim();
            string p_sdt = txtsodt.Text.Trim();
            string p_khuvuc = txtkhuvuclam.Text.Trim();
            string p_chucvu = txtchucvu.Text.Trim();
            //int p_luong=int.Parse(txtluong.Text);
            //b2 kết nối đến DB
            if (p_manv == " ")
            {
                MessageBox.Show("Mã nhân viên  khôngđược bỏ trống");
                txtmans.Focus();
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //b3 tạo đối tượng command để lấy dữ liệu từ bảng nxb
            string sql = "Select * From tt_nhansu Where manv like N'%" + p_manv + "%' and tennv like N'%" + p_tennv + "%'and sodt like N'%" + p_sdt + "%' and khuvuclam like N'%" + p_khuvuc + "%' and chucvu like N'%" + p_chucvu + "%'";
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
            dgv_thongtinnhansu.DataSource = tb;
            dgv_thongtinnhansu.Refresh();
        }


        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            txtmans.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
        }

        private void dgv_thongtinnhansu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmans.Text = dgv_thongtinnhansu.Rows[i].Cells[0].Value.ToString();
            txttenns.Text = dgv_thongtinnhansu.Rows[i].Cells[1].Value.ToString();
            datatimengaysinh.Text = dgv_thongtinnhansu.Rows[i].Cells[2].Value.ToString();
            txtsodt.Text = dgv_thongtinnhansu.Rows[i].Cells[3].Value.ToString();
            txtkhuvuclam.Text = dgv_thongtinnhansu.Rows[i].Cells[4].Value.ToString();
            txtchucvu.Text = dgv_thongtinnhansu.Rows[i].Cells[5].Value.ToString();
            txtluong.Text = dgv_thongtinnhansu.Rows[i].Cells[6].Value.ToString();
            txtmans.Enabled = false;

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }


    }
}