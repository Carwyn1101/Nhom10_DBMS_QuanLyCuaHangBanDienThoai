using BusinessLogicLayer;
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
    public partial class Form_TaiKhoan : Form
    {
        bool Add = false;
        DBTaiKhoan tkbusiness = new DBTaiKhoan();

        public Form_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Add = true;

            // Xóa trống các đối tượng trong Panel 
            this.panel.ResetText();
            this.panel.Enabled = true;

            //this.dtp.ResetText();
            this.txtTenNguoiDung.ResetText();
            this.txtMatKhau.ResetText();
            this.txtLoaiNguoiDung.ResetText();

            // Cho thao tác trên các nút Lưu  
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtTenNguoiDung
            this.txtTenNguoiDung.Focus();
        }
        void LoadTaiKhoan()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                this.dgvTaiKhoan.DataSource = tkbusiness.LayTaiKhoan().Tables[0];

                // Xóa trống các đối tượng trong Panel
                this.txtTenNguoiDung.ResetText();
                this.txtMatKhau.ResetText();
                this.txtLoaiNguoiDung.ResetText();

                //this.dtp.ResetText();
                this.panel.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.panel.Enabled = false;
                // Đặt tên cột
                dgvTaiKhoan.Columns[0].HeaderText = "Tên người dùng";
                dgvTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
                dgvTaiKhoan.Columns[2].HeaderText = "Loại người dùng";

                // Sự kiện click chuột
                dgvTaiKhoan_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung tài khoản. Đã xảy ra lỗi!");
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtTenNguoiDung.Text = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
            this.txtMatKhau.Text = dgvTaiKhoan.Rows[r].Cells[1].Value.ToString();
            this.txtLoaiNguoiDung.Text = dgvTaiKhoan.Rows[r].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvTaiKhoan.CurrentCell.RowIndex;
                // Lấy TenNguoiDung của record hiện hành 
                string strTenNguoiDung =
                dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc muốn xoá tài khoản này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = tkbusiness.XoaTaiKhoan(ref err, strTenNguoiDung);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadTaiKhoan();
                        // Thông báo 
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    else
                        MessageBox.Show(txtTenNguoiDung.Text);
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Huỷ bỏ việc xoá tài khoản này!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được tài khoản này. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Add = false;
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvTaiKhoan_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnReLoad.Enabled = false;
            // Đưa con trỏ đến TextField txtMatKhau
            this.txtTenNguoiDung.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng 
            this.txtTenNguoiDung.ResetText();
            this.txtMatKhau.ResetText();
            this.txtLoaiNguoiDung.ResetText();
            this.panel.ResetText();

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnReLoad.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvTaiKhoan_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnReLoad.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;

            bool kq = false;
            string err = "";
            // Thêm dữ liệu 
            if (Add)
            {
                try
                {
                    kq = tkbusiness.ThemTaiKhoan(ref err, txtTenNguoiDung.Text, txtMatKhau.Text, txtLoaiNguoiDung.Text);
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadTaiKhoan();
                        // Thông báo 
                        MessageBox.Show("Đã thêm tài khoản thành công!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được tài khoản này. Lỗi rồi!";
                    MessageBox.Show(err);
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = dgvTaiKhoan.CurrentCell.RowIndex;
                // TenNguoiDung hiện hành 
                string strTenNguoiDung =
                dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL 
                kq = tkbusiness.CapNhatTaiKhoan(ref err, txtTenNguoiDung.Text, txtMatKhau.Text, txtLoaiNguoiDung.Text);
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadTaiKhoan();
                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }
    }
}
