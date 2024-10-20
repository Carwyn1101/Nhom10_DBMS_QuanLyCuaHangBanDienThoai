using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class Form_Nhap : Form
    {
        public Form_Nhap()
        {
            InitializeComponent();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonNhap hdn = new frmHoaDonNhap();
            hdn.ShowDialog();
            this.Close();
        }

        private void btnChiTietHDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ChiTietHoaDonNhap cthdn = new Form_ChiTietHoaDonNhap();
            cthdn.ShowDialog();
            this.Close();
        }
    }
}
