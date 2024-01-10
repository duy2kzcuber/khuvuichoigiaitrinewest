using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khuvuichoigiaitrinewest
{
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Các bước để tìm kiếm .B1:Vui long an vao nut Import file Excel để import file len datagridview ,B2:Thực hiện chức năng tìm kiếm bằng các phần tử ở cột đó!!");
        }

        private void btimportfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet(*.xlsx|*.xlsx|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                con = string.Format(con, filepath, "yes");
                OleDbConnection excelconnection = new OleDbConnection(con);
                excelconnection.Open();
                DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand com = new OleDbCommand("Select * from[" + excelsheet + "]", excelconnection);
                OleDbDataAdapter oda = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                excelconnection.Close();
                dataGridViewtimkiem.DataSource = dt;
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            int n = dataGridViewtimkiem.RowCount;

            for (int i = n - 1; i >= 0; i--)
            {
                if (dataGridViewtimkiem.Rows[i].Cells[0].Value != null && (txttimkiem.Text != dataGridViewtimkiem.Rows[i].Cells[0].Value.ToString() && txttimkiem.Text != dataGridViewtimkiem.Rows[i].Cells[1].Value.ToString()))
                {
                    dataGridViewtimkiem.Rows.RemoveAt(i);
                }
            }
        }
    }
}

