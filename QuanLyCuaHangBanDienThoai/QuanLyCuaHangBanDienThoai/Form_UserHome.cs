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
    public partial class Form_UserHome : Form
    {
        public Form_UserHome()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            //Form_DanhMucDienThoai dmdc = new Form_DanhMucDienThoai();
            //dmdc.ShowDialog();
            //Bị hủy
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            Form_DienThoai dc = new Form_DienThoai();
            dc.ShowDialog();
        }

        private void btnNganKe_Click(object sender, EventArgs e)
        {
            //Form_NganKe nk = new Form_NganKe();
            //nk.ShowDialog();
            //Chưa có ngăn kệ.
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            Form_NhaSanXuat nsx = new Form_NhaSanXuat();
            nsx.ShowDialog();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            Form_Nhap n = new Form_Nhap();
            n.ShowDialog();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            Form_Ban b = new Form_Ban();
            b.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK)
                Environment.Exit(0);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Bạn có muốn đăng xuất?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Form_ThongTin tt = new Form_ThongTin();
            tt.ShowDialog();
        }
    }
}
