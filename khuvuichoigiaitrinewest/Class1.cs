using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khuvuichoigiaitrinewest
{
    internal class Class1
    {
        public static SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=DTDVH;Integrated Security=True");
        public static DataTable Hienthi(string sql)
        {
            //b1 kết nối đến DB
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b2b3
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand = cmd;
            //b4 đổ dữ liệu từ dataadapter vào bảng
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            return dt;
        }
        public static void Thucthi(string sql)
        {
            //b1 kết nối đến DB
            if (con.State != ConnectionState.Open)
            {
                con.Open();

            }
            //b2 tạo đối tượng command ddweerbthucjw hieenjt hêm/sửa /xóa dl vào bảng
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public static bool Check(string Ma, string Maloai, string Table)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "select count(*) from " + Table + " where " + Maloai + "='" + Ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }

    }
}
