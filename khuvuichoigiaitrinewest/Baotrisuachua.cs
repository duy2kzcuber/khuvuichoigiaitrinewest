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
using System.Data.SqlClient;
using System.Configuration;
using e_excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace khuvuichoigiaitrinewest
{
    public partial class Baotrisuachua : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public Baotrisuachua()
        {
            InitializeComponent();
        }
        private void Load_dgvBAOTRI()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string spl = "select *from BAOTRI";
            SqlCommand cmd = new SqlCommand(spl, con);
            //Tao doi tuong adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //Do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //hienthi
            dataGridViewbaotri.DataSource = tb;
            dataGridViewbaotri.Refresh();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string p_manbt = txtmanbt.Text.Trim();
            string p_tennbt = txttennbt.Text.Trim();
            string p_sodienthoai = txtsodienthoai.Text.Trim();
            string p_khubaotri =cbkhubaotri.Text.Trim();
            string p_lichbaotri = lichbaotri.Text.Trim();
            string p_datestart = datestart.Text.Trim();
            string p_dateend=dateend.Text.Trim();
            int p_gia;
            if (txtgia.Text == "") p_gia = 0;
             else p_gia = int.Parse(txtgia.Text.ToString());
            string p_noidung=txtnoidung.Text.Trim();
            string p_anh=openFileDialog1.FileName.ToString().Trim();
            txtanh.Text = p_anh;
            if(txtgia.Text =="") p_gia=0;
            if (Checktrungma(p_manbt))
            {
                MessageBox.Show("Ma nha bao tri da ton tai");
                label.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "Insert BAOTRI Values(@manbt,@tennbt,@sodienthoai,@khubaotri,@lichbaotri,@datestart,@dateend,@gia,@noidung,@anh)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@manbt", SqlDbType.NVarChar, 50).Value = p_manbt;
            cmd.Parameters.Add("@tennbt", SqlDbType.NVarChar, 50).Value = p_tennbt;
            cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar, 50).Value = p_sodienthoai;
            cmd.Parameters.Add("@khubaotri", SqlDbType.NVarChar, 50).Value = p_khubaotri;
            cmd.Parameters.Add("@lichbaotri", SqlDbType.NVarChar, 50).Value = p_lichbaotri;
            cmd.Parameters.Add("@datestart", SqlDbType.NVarChar, 50).Value = p_datestart;
            cmd.Parameters.Add("@dateend", SqlDbType.NVarChar, 50).Value = p_dateend;
            cmd.Parameters.Add("@gia", SqlDbType.NVarChar, 50).Value = p_gia;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar, 50).Value = p_noidung;
            cmd.Parameters.Add("@anh", SqlDbType.NVarChar, 100).Value = p_anh;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Them moi thanh cong!");
            Load_dgvBAOTRI();
        }
        private bool Checktrungma(string p_manbt)
        {
            // ket noi DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            // tao doi tuong commmand de thuc hien kiem tra 
            string sql = "Select count(*) From BAOTRI  where manbt='" + p_manbt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar(); // tra ve kq 0 and 1
            cmd.Dispose();
            con.Close();
            if (kq > 0) return true;
            else return false;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btchonanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "mo file anh";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {

                PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                PictureBox1.Image = null;
            }
            txtanh.Text= openFileDialog1.FileName;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btsua_Click(object sender, EventArgs e)
        {

            string p_manbt = txtmanbt.Text.Trim();
            string p_tennbt = txttennbt.Text.Trim();
            string p_sodienthoai = txtsodienthoai.Text.Trim();
            string p_khubaotri = cbkhubaotri.Text.Trim();
            string p_lichbaotri = lichbaotri.Text.Trim();
            string p_datestart = datestart.Text.Trim();
            string p_dateend = dateend.Text.Trim();
            int p_gia = int.Parse(txtgia.Text);
            string p_noidung = txtnoidung.Text.Trim();
            string p_anh = txtanh.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //Tao doi tuong Command de thuc hien sua
            string sql = "Update BAOTRI set tennbt=N'" + p_tennbt + "',sodienthoai=N'" + p_sodienthoai + "',khubaotri= N'" + p_khubaotri + "',lichbaotri='" + p_lichbaotri + "',datestart='" + p_datestart + "',dateend='" + p_dateend + "',gia='" + p_gia + "',noidung='" + p_noidung + "',anh='"+p_anh+"' where manbt ='" + p_manbt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sua thanh cong");
            Load_dgvBAOTRI();
            txtmanbt.Enabled = true;
        }

        private void dataGridViewbaotri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanbt.Text = dataGridViewbaotri.Rows[i].Cells[0].Value.ToString();
            txttennbt.Text = dataGridViewbaotri.Rows[i].Cells[1].Value.ToString();
            txtsodienthoai.Text = dataGridViewbaotri.Rows[i].Cells[2].Value.ToString();
            cbkhubaotri.Text = dataGridViewbaotri.Rows[i].Cells[3].Value.ToString();
            lichbaotri.Text = dataGridViewbaotri.Rows[i].Cells[4].Value.ToString();
            datestart.Text = dataGridViewbaotri.Rows[i].Cells[5].Value.ToString();
            dateend.Text = dataGridViewbaotri.Rows[i].Cells[6].Value.ToString();
            txtgia.Text = dataGridViewbaotri.Rows[i].Cells[7].Value.ToString();
            txtnoidung.Text = dataGridViewbaotri.Rows[i].Cells[8].Value.ToString();
            
            openFileDialog1.FileName = dataGridViewbaotri.Rows[i].Cells[9].Value.ToString();
            txtanh.Text =openFileDialog1.FileName.ToString();
            if (openFileDialog1.FileName != "")
            {
                openFileDialog1.FileName = dataGridViewbaotri.Rows[i].Cells[9].Value.ToString();
                PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                PictureBox1.Image = null;
            }
            txtmanbt.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string p_manbt = txtmanbt.Text.Trim();
            //B2:Ket noi den db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            //B3:Tao doi tuong command de xoa
            string sql = "Delete BAOTRI where manbt='" + p_manbt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //Thuc thi no
            cmd.ExecuteNonQuery();
            cmd.Dispose();//Giai phong bo nho
            con.Close();//Ngat ket noi
            MessageBox.Show("Da xoa!");
            Load_dgvBAOTRI();
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
            head.Value2 = "DANH SÁCH BẢO TRÌ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ NHÀ BẢO TRÌ";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN NHÀ BẢO TRÌ";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "SỐ ĐIỆN THOẠI";
            cl3.ColumnWidth = 40.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "KHU BẢO TRÌ";
            cl4.ColumnWidth = 40.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "LỊCH BẢO TRÌ";
            cl5.ColumnWidth = 40.0;

            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "GIỜ BẮT ĐẦU";
            cl6.ColumnWidth = 40.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "GIỜ KÊT THÚC";
            cl7.ColumnWidth = 40.0;
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "GIÁ";
            cl8.ColumnWidth = 40.0;
            e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "NỘI DUNG";
            cl9.ColumnWidth = 40.0;
            e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "ẢNH";
            cl10.ColumnWidth = 40.0;



            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "K3");
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
                        arr[r, c] = "'" + dr[c];
                    else
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
        private void btexportfile_Click(object sender, EventArgs e)
        {

            string p_manbt = txtmanbt.Text.Trim();
            string p_tennbt = txttennbt.Text.Trim();
            string p_sodienthoai = txtsodienthoai.Text.Trim();
            string p_khubaotri = cbkhubaotri.Text.Trim();
            string p_lichbaotri = lichbaotri.Text.Trim();
            string p_datestart = datestart.Text.Trim();
            string p_dateend = dateend.Text.Trim();
            string p_gia = txtgia.Text.Trim();
            string p_noidung = txtnoidung.Text.Trim();
            string p_anh = txtanh.Text.Trim();

            if (con.State == ConnectionState.Closed) { con.Open(); }
            //string sql = " Select * From BAOTRI Where manbt like'%" + p_manbt + "%' and  tennbt like '%" + p_tennbt + "%' and sodienthoai like '%" + p_sodienthoai + "%' and  khubaotri like '%" + p_khubaotri + "%' and lichbaotri like'%"+p_lichbaotri+"%' and datestart like '%" + p_datestart + "%' and dateend like '%" + p_dateend + "%' and gia like'%"+p_gia+"%'and noidung like'%" + p_noidung + "%' and anh like'%"+p_anh+"%'";
            string sql = "Select * From BAOTRI";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            ExportExcel(dt, "BAOTRI");
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string p_manbt = txttimkiem.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //B3:Tao doi tuong command de lay du lieu tu bang
            string sql = "Select * From BAOTRI Where manbt like'%" + p_manbt + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //B4:Tao doi tuong Datadapter de lay du lieu kq tu command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b5:Do du lieu tu Datadapter vao database
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //b6:Hien thi Datatable len datagridview
            dataGridViewbaotri.DataSource = tb;
            dataGridViewbaotri.Refresh();
        }

        private void Baotrisuachua_Load(object sender, EventArgs e)
        {
            Load_dgvBAOTRI();
            openFileDialog1.FileName = null;
        }

        private void txtanh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
