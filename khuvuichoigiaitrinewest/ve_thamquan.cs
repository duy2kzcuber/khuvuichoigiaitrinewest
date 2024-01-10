using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

namespace khuvuichoigiaitrinewest
{
    public partial class ve_thamquan : Form
    {
        public ve_thamquan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        private bool checktrungma(string mave)
        {
            //b1 :ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tao doi tuong command
            string sql = "Select count(*) From ve_thamquan where mave= '" + mave + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void load_cbo_tenkhu()
        {
            string sql = " Select * From dv_khuthamquan";
            DataTable dt = new DataTable();
            dt = Thuvien.Hienthi(sql);
            DataRow r = dt.NewRow();
            r["tendiadiem"] = "Chọn tên khu";
            r["makhu"] = "";
            dt.Rows.InsertAt(r, 0);
            cbo_khu.DataSource = dt;
            cbo_khu.DisplayMember = "tendiadiem";
            cbo_khu.ValueMember = "tendiadiem";

        }
        private void Load_dgv()
        {
            string sql = "Select * From ve_thamquan";
            DataTable dt = new DataTable();
            dt = Thuvien.Hienthi(sql);
            dgv_vethamquan.DataSource = dt;
            dgv_vethamquan.Refresh();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                //b1: lay du lieu tu cac control
                string p_tenkhu = cbo_khu.SelectedValue.ToString();
                string p_mave = txt_mave.Text.ToString();
                string p_tt = cbo_tt.Text.Trim();
                string p_tgban = dtp_tgban.Text.Trim();
                string p_tgdong = dtp_tgdong.Text.Trim();
                //bat loi: 
                if (p_mave == "")
                {
                    MessageBox.Show("Bạn phải nhập mã vé");
                    txt_mave.Focus();
                    return;
                }
                if (p_tenkhu == "Chọn khu")
                {
                    MessageBox.Show("Bạn phải chọn khu");
                    cbo_khu.Focus();
                    return;
                }
                //bool check = Thuvien.checktrungma(p_mave, "ve_trochoi", "mave");
                if (checktrungma(p_mave))
                {
                    MessageBox.Show("Mã vé đã tồn tại");
                    txt_mave.Focus();
                    return;
                }
                //b2 : dung thu vien, doi tuong "thucthi" de ket noi den db va tao doi tuong cmd
                string sql = "insert ve_thamquan Values(N'" + p_tenkhu + "', N'" + p_mave + "', N'" + p_tt + "', '" + p_tgban + "', '" + p_tgdong + "') ";
                DataTable dt = new DataTable();
                Thuvien.Thucthi(sql);
                Load_dgv();
                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng liên hệ với quản trị viên");
            }
        }

        private void ve_thamquan_Load(object sender, EventArgs e)
        {
            Load_dgv();
            load_cbo_tenkhu();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control
            string p_tenkhu = cbo_khu.SelectedValue.ToString();
            string p_mave = txt_mave.Text.ToString();
            string p_tt = cbo_tt.Text.Trim();
            string p_tgban = dtp_tgban.Text.Trim();
            string p_tgdong = dtp_tgdong.Text.Trim(); 
            //b2 : dung thu vien, doi tuong "thucthi" de ket noi den db va tao doi tuong cmd
            string sql = "update ve_thamquan set tenkhu = N'" + p_tenkhu + "' , trangthai= N'" + p_tt + "', thoigianban= '" + p_tgban + "', thoigiandong= '" + p_tgdong + "' where mave = '" + p_mave + "'";

            Thuvien.Thucthi(sql);
            Load_dgv();
            txt_mave.Enabled = true;
            MessageBox.Show("Sửa thành công!");
        }

        private void dgv_vethamquan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_mave.Text = dgv_vethamquan.Rows[i].Cells[1].Value.ToString();
            cbo_khu.Text = dgv_vethamquan.Rows[i].Cells[0].Value.ToString();
            cbo_tt.Text = dgv_vethamquan.Rows[i].Cells[2].Value.ToString();
            dtp_tgban.Text = dgv_vethamquan.Rows[i].Cells[3].Value.ToString();
            dtp_tgdong.Text = dgv_vethamquan.Rows[i].Cells[4].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string p_mave = txt_mave.Text.Trim();
            string sql = "Delete ve_thamquan Where mave= '" + p_mave + "'";
            Thuvien.Thucthi(sql);
            Load_dgv();
            MessageBox.Show("Xóa thành công");
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control
            string p_tenkhu = cbo_khu.SelectedValue.ToString();
            string p_mave = txt_mave.Text.ToString();
            string p_tt = cbo_tt.Text.Trim();
            string p_tgban = dtp_tgban.Text.Trim();
            string p_tgdong = dtp_tgdong.Text.Trim();

            string sql = "Select * From ve_thamquan Where mave like '%" + p_mave + "%' and tenkhu like N'%" + p_tenkhu + "%' and trangthai like  N'%" + p_tt + "%'";
            DataTable dt = Thuvien.Hienthi(sql);
            dgv_vethamquan.DataSource = dt;
            dgv_vethamquan.Refresh();
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

            e_excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "THÔNG TIN VÉ TRÒ CHƠI";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ VÉ";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN KHU";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "TRẠNG THÁI";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "THỜI GIAN BÁN";
            cl4.ColumnWidth = 23.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "THỜI GIAN ĐÓNG";
            cl5.ColumnWidth = 40.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
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
                    if (c == 2)
                    {
                        arr[r, c] = "'" + dr[c];
                    }
                    else arr[r, c] = dr[c];
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
            //dua cac control vao bien
            string p_tenkhu = cbo_khu.SelectedValue.ToString();
            string p_mave = txt_mave.Text.ToString();
            string p_tt = cbo_tt.Text.Trim();
            string p_tgban = dtp_tgban.Text.Trim();
            string p_tgdong = dtp_tgdong.Text.Trim();

            //string sql = "Select * From ve_thamquan Where mave like '%" + p_mave + "%' and tenkhu like N'%" + p_tenkhu + "%' and trangthai like  N'%" + p_tt + "%'";
            string sql = "Select * from ve_thamquan"; 
            // DataTable dt = new DataTable();
            // dt=Thuvien.Hienthi(sql);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmd.Dispose();
            con.Close();

            ExportExcel(dt, "Ve tham quan");
        }
    }
}
