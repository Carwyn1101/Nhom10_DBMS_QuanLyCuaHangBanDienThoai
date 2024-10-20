using BusinessLogicLayer;
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
    public partial class Form_DangNhap : Form
    {
        DBTaiKhoan tk = new DBTaiKhoan();

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";
            // Thông tin đăng nhập (Tên người dùng/ Mật khẩu)
            int check = tk.DangNhap(txtTenNguoiDung.Text.Trim(), txtMatKhau.Text.Trim());
            if (check == 1)
            {
                Form_AdminHome ad = new Form_AdminHome();
                ad.ShowDialog();
                txtTenNguoiDung.ResetText();
                txtMatKhau.ResetText();
                txtMatKhau.Focus();
            }
            else if (check == 2)
            {
                //Form_UserHome usr = new Form_UserHome();
                //usr.ShowDialog();
                //txtTenNguoiDung.ResetText();
                //txtMatKhau.ResetText();
                //txtTenNguoiDung.Focus();
            }
            else // không đúng thì xuất ra thông báo!
            {
                lblThongBao.Text = err;
                txtTenNguoiDung.Focus();
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Clear();
            txtTenNguoiDung.Focus();
            txtMatKhau.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenNguoiDung.Clear();
            this.txtMatKhau.Clear();
            this.txtTenNguoiDung.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát khỏi FormDangNhap
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
