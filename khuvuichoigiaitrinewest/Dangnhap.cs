using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khuvuichoigiaitrinewest
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtTendn.Text=="hungpro" &&  txtMk.Text=="1111")
            {
                
                Trangchu trangch=new Trangchu();
                trangch.Show();
                this.Hide();

              
            }
        }
    }
}
