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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();
        }
        private void CustomizeDesign()
        {
            panelDichvuSubMenu.Visible = false;
            panelThongtinSubMenu.Visible = false;
        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HideSubMenu()
        {
            if (panelDichvuSubMenu.Visible == true) { panelDichvuSubMenu.Visible = false; }

        }

        private void Setcolor()
        {
            btnTrochoi.BackColor = Color.DodgerBlue;
            btnTrochoi.ForeColor = Color.White;
            btnThamquan.BackColor = Color.DodgerBlue;
            btnThamquan.ForeColor = Color.White;
            btnPhim.BackColor = Color.DodgerBlue;
            btnPhim.ForeColor = Color.White;
            btnKhachhang.BackColor = Color.DodgerBlue;
            btnKhachhang.ForeColor = Color.White;
            btnNhansu.BackColor = Color.DodgerBlue;
            btnNhansu.ForeColor = Color.White;
            btnDanhgia.BackColor = Color.DodgerBlue;
            btnDanhgia.ForeColor = Color.White;
            btnSukien.BackColor = Color.DodgerBlue;
            btnSukien.ForeColor = Color.White;
            btnVe.BackColor = Color.DodgerBlue;
            btnVe.ForeColor = Color.White;
            btnBaotrisuachua.BackColor = Color.DodgerBlue;
            btnBaotrisuachua.ForeColor = Color.White;
            btnVetrochoi.BackColor = Color.DodgerBlue;
            btnVetrochoi.ForeColor = Color.White;
            btnVethamquan.BackColor = Color.DodgerBlue;
            btnVethamquan.ForeColor = Color.White;
            btnVexemphim.BackColor = Color.DodgerBlue;
            btnVexemphim.ForeColor = Color.White;
            btnDichvukhac.BackColor = Color.DodgerBlue;
            btnDichvukhac.ForeColor = Color.White;
            btnVesukien.BackColor = Color.DodgerBlue;
            btnVesukien.ForeColor = Color.White;
            btnVedichvukhac.BackColor= Color.DodgerBlue;
            btnVedichvukhac.ForeColor= Color.White;
            btnThongke.BackColor = Color.DodgerBlue;
            btnThongke.ForeColor = Color.White;
            btnDoanhthu.BackColor = Color.DodgerBlue;
            btnDoanhthu.ForeColor = Color.White;


        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDichvuSubMenu);
        }

        private void btnTrochoi_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnTrochoi.BackColor = Color.MidnightBlue; btnTrochoi.ForeColor = Color.White;
            OpenChildForm(new Trochoi());
        }

        private void btnThamquan_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnThamquan.BackColor = Color.MidnightBlue; btnThamquan.ForeColor = Color.White;
            OpenChildForm(new Thamquan());
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnPhim.BackColor = Color.MidnightBlue; btnPhim.ForeColor = Color.White;
            OpenChildForm(new Phim());
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThongtinSubMenu);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnKhachhang.BackColor = Color.MidnightBlue; btnKhachhang.ForeColor = Color.White;
            OpenChildForm(new tt_khachhang());
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnNhansu.BackColor = Color.MidnightBlue; btnNhansu.ForeColor = Color.White;
            OpenChildForm(new tt_nhansu());
        }

        private void btnDanhgia_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnDanhgia.BackColor = Color.MidnightBlue; btnDanhgia.ForeColor = Color.White;
            OpenChildForm(new tt_danhgia());
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVeSubMenu);
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild == null) return;
            currentFormChild.Close();
            Setcolor();
        }

        

        private void btnVetrochoi_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnVetrochoi.BackColor = Color.MidnightBlue; btnVetrochoi.ForeColor = Color.White;
            OpenChildForm(new Ve_trochoi());
        }

        private void btnVethamquan_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnVethamquan.BackColor = Color.MidnightBlue; btnVethamquan.ForeColor = Color.White;
            OpenChildForm(new ve_thamquan());
        }

        private void btnVexemphim_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnVexemphim.BackColor = Color.MidnightBlue; btnVexemphim.ForeColor = Color.White;
            OpenChildForm(new ve_phim());
        }

        private void btnDichvukhac_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnDichvukhac.BackColor = Color.MidnightBlue; btnDichvukhac.ForeColor = Color.White;
            OpenChildForm(new Dichvukhac());
        }

        private void btnVedichvukhac_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnVedichvukhac.BackColor = Color.MidnightBlue; btnVedichvukhac.ForeColor = Color.White;
            OpenChildForm(new Ve_dichvukhac());
        }
        private void btnVesukien_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnVesukien.BackColor = Color.MidnightBlue; btnVesukien.ForeColor = Color.White;
            OpenChildForm(new Ve_sukien());
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnDoanhthu.BackColor = Color.MidnightBlue; btnDoanhthu.ForeColor = Color.White;
            OpenChildForm(new Doanhthu());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnThongke.BackColor = Color.MidnightBlue; btnThongke.ForeColor = Color.White;
            OpenChildForm(new Thongke());
        }

        private void btnBaotrisuachua_Click(object sender, EventArgs e)
        {
            Setcolor();
            btnBaotrisuachua.BackColor = Color.MidnightBlue; btnBaotrisuachua.ForeColor = Color.White;
            OpenChildForm(new Baotrisuachua());
        }































        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void panelThongtinSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDichvuSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelVeSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            if(button1.Text=="<<")
            {
                button1.Text = ">>";

            }
            else { button1.Text = "<<"; }
        }
    }
}
