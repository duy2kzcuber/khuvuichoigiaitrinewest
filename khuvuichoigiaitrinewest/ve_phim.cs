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
    public partial class ve_phim : Form
    {
        public ve_phim()
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
            string sql = "Select count(*) From ve_phim where mave= '" + mave + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void load_cbo_phim()
        {
            string sql = " Select * From dv_rapchieuphim";
            DataTable dt = new DataTable();
            dt = Thuvien.Hienthi(sql);
            DataRow r = dt.NewRow();
            r["tenphim"] = "Chọn phim";
            r["maphim"] = "";
            dt.Rows.InsertAt(r, 0);
            cbo_phim.DataSource = dt;
            cbo_phim.DisplayMember = "tenphim";
            cbo_phim.ValueMember = "tenphim";

        }
        private void Load_dgv()
        {
            string sql = "Select * From ve_phim";
            DataTable dt = new DataTable();
            dt = Thuvien.Hienthi(sql);
            dgv_vephim.DataSource = dt;
            dgv_vephim.Refresh();
        }
        private void ve_phim_Load(object sender, EventArgs e)
        {
            load_cbo_phim();
            Load_dgv();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                //b1: lay du lieu tu cac control
                string p_tenphim = cbo_phim.SelectedValue.ToString();
                string p_mave = txt_mave.Text.ToString();
                string p_tt = cbo_tt.Text.Trim();
                string p_tgban = dtp_tgban.Text.Trim();
                string p_tgdong = dtp_tgdong.Text.Trim();
                string p_gianl = txt_gvnglon.Text.Trim();
                string p_giate = txt_gvtreem.Text.Trim();
                string p_sonl = txt_sonl.Text.Trim(); // so nguoi lon
                string p_sote = txt_sote.Text.Trim(); // so tre em
                if(p_sonl == "") p_sonl = "0";
                if(p_sote == "") p_sote = "0";
                //bat loi: 
                if (p_mave == "")
                {
                    MessageBox.Show("Bạn phải nhập mã vé");
                    txt_mave.Focus();
                    return;
                }
                if (p_tenphim == "Chọn phim")
                {
                    MessageBox.Show("Bạn phải chọn phim");
                    cbo_phim.Focus();
                    return;
                }
                int a = (int)int.Parse(p_gianl) * int.Parse(p_sonl) + int.Parse(p_giate) * int.Parse(p_sote) ;
                string p_tongtien = a.ToString();
                if (checktrungma(p_mave))
                {
                    MessageBox.Show("Mã vé đã tồn tại");
                    txt_mave.Focus();
                    return;
                }
                //b2 : dung thu vien, doi tuong "thucthi" de ket noi den db va tao doi tuong cmd
                string sql1 = "insert ve_phim Values(N'" + p_tenphim + "', N'" + p_mave + "', N'" + p_tt + "', '" + p_tgban + "', '" + p_tgdong + "', ";
                string sql2 = "'"+p_gianl+"', '"+p_giate+"', '"+p_sonl+"', '"+p_sote+"', '"+p_tongtien+"' )";
                string sql = sql1 + sql2;
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control
            string p_tenphim = cbo_phim.SelectedValue.ToString();
            string p_mave = txt_mave.Text.ToString();
            string p_tt = cbo_tt.Text.Trim();
            string p_tgban = dtp_tgban.Text.Trim();
            string p_tgdong = dtp_tgdong.Text.Trim();

            string sql = "Select * From ve_phim Where mave like '%" + p_mave + "%' and tenphim like N'%" + p_tenphim + "%' and trangthai like  N'%" + p_tt + "%'";
            DataTable dt = Thuvien.Hienthi(sql);
            dgv_vephim.DataSource = dt;
            dgv_vephim.Refresh();
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
            head.Value2 = "THÔNG TIN VÉ PHIM";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ VÉ";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN PHIM";

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
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "GIÁ VÉ NGƯỜI LỚN";
            cl6.ColumnWidth = 25.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "GIÁ VÉ TRẺ EM";
            cl7.ColumnWidth = 25.0;
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "SỐ LƯỢNG NGƯỜI LỚN";
            cl8.ColumnWidth = 25.0;
            e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "SỐ LƯỢNG TRẺ EM";
            cl9.ColumnWidth = 25.0;
            e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "TỔNG TIỀN";
            cl10.ColumnWidth = 25.0;

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
            string p_tenphim = cbo_phim.SelectedValue.ToString();
            string p_mave = txt_mave.Text.ToString();
            string p_tt = cbo_tt.Text.Trim();
            string p_tgban = dtp_tgban.Text.Trim();
            string p_tgdong = dtp_tgdong.Text.Trim();

            string sql = "Select * From ve_phim Where mave like '%" + p_mave + "%' and tenphim like N'%" + p_tenphim+ "%' and trangthai like  N'%" + p_tt + "%'";
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

            ExportExcel(dt, "Ve phim");
        }

        private void dgv_vephim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_mave.Text = dgv_vephim.Rows[i].Cells[1].Value.ToString();
            cbo_phim.Text = dgv_vephim.Rows[i].Cells[0].Value.ToString();
            cbo_tt.Text = dgv_vephim.Rows[i].Cells[2].Value.ToString();
            dtp_tgban.Text = dgv_vephim.Rows[i].Cells[3].Value.ToString();
            dtp_tgdong.Text = dgv_vephim.Rows[i].Cells[4].Value.ToString();
            txt_gvnglon.Text = dgv_vephim.Rows[i].Cells[5].Value.ToString();
            txt_gvtreem.Text = dgv_vephim.Rows[i].Cells[6].Value.ToString();
            txt_sonl.Text = dgv_vephim.Rows[i].Cells[7].Value.ToString();
            txt_sote.Text = dgv_vephim.Rows[i].Cells[8].Value.ToString();   
            txt_tongtien.Text = dgv_vephim.Rows[i].Cells[9].Value.ToString();
        }

        private void cbo_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p_tenphim = cbo_phim.Text.ToString();
            string sql = " Select * From dv_rapchieuphim where tenphim= N'" + p_tenphim + "'";
            DataTable dt = Thuvien.Hienthi(sql);
            if (dt.Rows.Count > 0)
            {
                txt_gvnglon.Text = dt.Rows[0]["giavenguoilon"].ToString();
                txt_gvtreem.Text = dt.Rows[0]["giavetreem"].ToString();
            }
        }

        private void txt_sonl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chi cho phep nhap cac chu so va phim backspace
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_sote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
