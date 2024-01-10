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
using e_excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace khuvuichoigiaitrinewest
{
    public partial class Trochoi : Form

    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public Trochoi()
        {
            InitializeComponent();
        }
        private void Load_dgvdv_khutrochoi()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = " Select * From dv_khutrochoi";
            SqlCommand cmd = new SqlCommand(sql, con);
            // tao doi tuong DB de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //hienthi database len datagre
            dataGridView2.DataSource = tb;
            dataGridView2.Refresh();
        }
        private bool Checktrungma(string p_ma)
        {
            // ket noi DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            // tao doi tuong commmand de thuc hien kiem tra 
            string sql = "Select count(*) From dv_khutrochoi  where matrochoi='" + p_ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar(); // tra ve kq 0 and 1
            cmd.Dispose();
            con.Close();
            if (kq > 0) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string p_ma = textma.Text.Trim();
                string p_ten = textten.Text.Trim();
                string p_theloai = texttheloai.Text.Trim();
                string p_dateopen = dateTimeopen.Text.Trim();
                string p_dateclose = dateTimeclose.Text.Trim();
                int p_giavenl = int.Parse(textgiavenglon.Text);
                int p_giavetreem =int.Parse(textgiavetreem.Text);
                string p_tt = comboBoxtinhtrang.Text.Trim();
                if(textgiavenglon.Text=="") p_giavenl=0;
                if(textgiavetreem.Text=="") p_giavetreem=0;
                if (Checktrungma(p_ma))
                {
                    MessageBox.Show("Ma nha xuat ban da ton tai");
                    textma.Focus();
                    return;
                }
                textma.Enabled = true;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                string sql = "Insert dv_khutrochoi Values('" + p_ma + "',N'" + p_ten + "',N'" + p_theloai + "','" + p_dateopen + "','" + p_dateclose + "','" + p_giavenl + "','" + p_giavetreem + "','" + p_tt + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Them moi thanh cong!");
                Load_dgvdv_khutrochoi();
                UpdateSoLuongKhuBaoTri();
            }

            catch
            {
                MessageBox.Show("loi");
            }
        }

        private void dateTimeopen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // B1: Lay du lieu tu control dua vao
            string p_ma = textma.Text.Trim();
            // B2:Ket noi DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            // b3: Tao doi tuong command de thuc hien
            string sql = "Delete dv_khutrochoi where matrochoi='" + p_ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd; // lay du lieu tu cmd
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xoa thanh cong!");
            Load_dgvdv_khutrochoi();
            UpdateSoLuongKhuBaoTri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p_ma = textma.Text.Trim();
            string p_ten = textten.Text.Trim();
            string p_theloai = texttheloai.Text.Trim();
            string p_dateopen = dateTimeopen.Text.Trim();
            string p_dateclose = dateTimeclose.Text.Trim();
            int p_giavenl = int.Parse(textgiavenglon.Text);
            int p_giavetreem = int.Parse(textgiavetreem.Text);
            string p_tt = comboBoxtinhtrang.Text.Trim();
            if (textgiavenglon.Text == "") p_giavenl = 0;
            if (textgiavetreem.Text == "") p_giavetreem = 0;
            if (con.State == ConnectionState.Closed)
                con.Open();
            textma.Enabled = true;

            string sql = "Update dv_khutrochoi set tentrochoi=N'" + p_ten + "',theloai=N'" + p_theloai + "',tgmo='" + p_dateopen + "',tgdong='" + p_dateclose + "',giavenguoilon='" + p_giavenl + "',giavetreem='" + p_giavetreem + "',tinhtrang='" + p_tt + "' where matrochoi ='" + p_ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sua moi thanh cong!");
            Load_dgvdv_khutrochoi();
            UpdateSoLuongKhuBaoTri();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textma.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textten.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            texttheloai.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            dateTimeopen.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dateTimeclose.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            textgiavenglon.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            textgiavetreem.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
             comboBoxtinhtrang.Text= dataGridView2.Rows[i].Cells[7].Value.ToString();
            
            textma.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)

            
        {

            string p_ma = textma.Text.Trim();
            string p_ten = textten.Text.Trim();
            string p_theloai = texttheloai.Text.Trim();
            string p_dateopen = dateTimeopen.Text.Trim();
            string p_dateclose = dateTimeclose.Text.Trim();
            int p_giavenl = int.Parse(textgiavenglon.Text);
            int p_giavetreem = int.Parse(textgiavetreem.Text);
            string p_tt = comboBoxtinhtrang.Text.Trim();
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            textma.Enabled = true;
            // b3 tao doi tuong command de lay du lieu bang nxb
            string sql = "Select * from dv_khutrochoi  where matrochoi like '%" + p_ma + "%' and tentrochoi  like N'%" + p_ten + "%' and theloai like N'%" + p_theloai + "%' and tgmo like '%" + p_dateopen + "%' and tgdong like '%" + p_dateclose + "%' and tinhtrang like '%"+p_tt+"%'";
            // tao doi tuonf dataadapter de lay du lieu kq tu commmand
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //b5 do du lieu vao tu DataAdapter vafo Datable
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            //b6 Hien thi DataTable len datagridview
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void Trochoi_Load(object sender, EventArgs e)
        {
            Load_dgvdv_khutrochoi();
            int soLuongKhuBaoTri = DemSoLuongKhuBaoTri();
            txtsoluong.Text = soLuongKhuBaoTri.ToString();
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
            oBook = (e_excel.Workbook) (oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet) oSheets.get_Item(1);
        oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "H1");
        head.MergeCells = true;
            head.Value2 = "DANH SÁCH THÔNG TIN KHU VUI CHƠI";
            head.Font.Bold = true;// IN DAM
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
        cl1.Value2 = "MÃ TRÒ CHƠI";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
        cl2.Value2 = "TÊN TRÒ CHƠI";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
        cl3.Value2 = "THỂ LOẠI";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
        cl4.Value2 = "THỜI GIAN ĐÓNG";
            cl4.ColumnWidth = 15.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
        cl5.Value2 = "THỜI GIAN MỞ";
            cl5.ColumnWidth = 40.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
        cl6.Value2 = "GIÁ VÉ NGƯỜI LỚN";
            cl6.ColumnWidth = 40.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "GIÁ VÉ TRẺ EM";
            cl7.ColumnWidth = 40.0;
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "TINH TRẠNG";
            cl8.ColumnWidth = 40.0;
            
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "H3");
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
            for (int r = 0; r<tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c<tb.Columns.Count; c++)

                {
                    if (c == 2) arr[r, c] = "'" + dr[c];
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
           // e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            //e_excel.Range c4 = oSheet.get_Range(c1, c3);
            //oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textma.Enabled = true;
            string p_ma = textma.Text.Trim();
            string p_ten = textten.Text.Trim();
            string p_theloai = texttheloai.Text.Trim();
            string p_dateopen = dateTimeopen.Text.Trim();
            string p_dateclose = dateTimeclose.Text.Trim();
            int p_giavenl = int.Parse(textgiavenglon.Text);
            int p_giavetreem = int.Parse(textgiavetreem.Text);
            string p_tt = comboBoxtinhtrang.Text.Trim();
            if (textgiavenglon.Text == "") p_giavenl = 0;
            if (textgiavetreem.Text == "") p_giavetreem = 0;
            if (con.State == ConnectionState.Closed)
                con.Open();
            textma.Enabled = true;
            // b3 tao doi tuong command de lay du lieu bang nxb
            string sql = "Select * From dv_khutrochoi";
            //string sql = "Select * from dv_khutrochoi  where matrochoi like '%" + p_ma + "%' and tentrochoi  like N'%" + p_ten + "%' and theloai like N'%" + p_theloai + "%' and tgmo like '%" + p_dateopen + "%' and tgdong like '%" + p_dateclose + "%' and tinhtrang like N'%" + p_tt + "%'";
            // tao doi tuonf dataadapter de lay du lieu kq tu commmand
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //b5 do du lieu vao tu DataAdapter vafo Datable
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            ExportExcel(dt,"DSTTKVC");


        }
        private int DemSoLuongKhuBaoTri()
        {
            // Bước 1: Mở kết nối nếu nó chưa được mở
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // Bước 2: Tạo câu lệnh SQL để đếm số lượng khu bảo trì
            string sql = "SELECT COUNT(*) FROM dv_khutrochoi WHERE tinhtrang = N'Bảo trì'";
            SqlCommand cmd = new SqlCommand(sql, con);

            // Bước 3: Thực hiện câu lệnh và trả về kết quả
            int soLuongKhuBaoTri = (int)cmd.ExecuteScalar();

            // Bước 4: Đóng kết nối
            con.Close();

            return soLuongKhuBaoTri;
        }
        private void UpdateSoLuongKhuBaoTri()
        {
            int soLuongKhuBaoTri = DemSoLuongKhuBaoTri();
            txtsoluong.Text = soLuongKhuBaoTri.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
