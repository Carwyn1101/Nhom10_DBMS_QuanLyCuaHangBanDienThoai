using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.ShowDialog();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
         /*   Form_TaiKhoan tk = new Form_TaiKhoan();
            tk.ShowDialog();*/
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
          /*  Form_DanhMucDoChoi dmdc = new Form_DanhMucDoChoi();
            dmdc.ShowDialog();*/
        }

        private void btnDoChoi_Click(object sender, EventArgs e)
        {
            /*Form_DoChoi dc = new Form_DoChoi();
            dc.ShowDialog();*/
        }

        private void btnNganKe_Click(object sender, EventArgs e)
        {
            Form_NganKe nk = new Form_NganKe();
            nk.ShowDialog();
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
         /*   Form_NhaSanXuat nsx = new Form_NhaSanXuat();
            nsx.ShowDialog();*/
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            /*Form_Nhap n = new Form_Nhap();
            n.ShowDialog();*/
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            Form_Ban b = new Form_Ban();
            b.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            /*Form_ThongKe tk = new Form_ThongKe();
            tk.ShowDialog();*/
        }

    }
}
