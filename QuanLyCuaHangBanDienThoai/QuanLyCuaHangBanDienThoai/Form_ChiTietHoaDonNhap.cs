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
    public partial class Form_ChiTietHoaDonNhap : Form
    {
        bool Them = false;
        DBHoaDonNhap hdnbusiness = new DBHoaDonNhap();
        DBChiTietHoaDonNhap cthdnbusiness = new DBChiTietHoaDonNhap();
        public Form_ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;

            // Xóa trống các đối tượng trong Panel 
            this.panel.ResetText();
            this.panel.Enabled = true;


            //this.dtp.ResetText();
            this.txtMaNhanVien.ResetText();
            this.txtTongGiaTriNhap.ResetText();
            this.txtMaDienThoai.ResetText();
            this.txtMaHoaDonNhap.ResetText();
            this.txtNgayNhap.ResetText();
            this.txtSoLuongNhap.ResetText();
            this.txtGiaNhap.ResetText();

            // Cho thao tác trên các nút Lưu  
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaLoaiDoChoi
            this.txtSoLuongNhap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvDanhSachChiTietHoaDonNhap.CurrentCell.RowIndex;
                // Lấy MaDoChoi của record hiện hành 
                string strMaNhap =
                dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[0].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc muốn xoá chi tiết hóa đơn nhập này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = cthdnbusiness.XoaChiTietHoaDonNhap(ref err, txtMaHoaDonNhap.Text, txtMaDienThoai.Text);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadChiTietHoaDonNhap();
                        // Thông báo 
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Huỷ bỏ việc xoá chi tiết hóa đơn nhập này!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được chi tiết hóa đơn nhập này. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvDanhSachChiTietHoaDonNhap_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnReLoad.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNhap
            this.txtMaHoaDonNhap.Enabled = false;
            this.txtNgayNhap.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng 
            this.txtMaHoaDonNhap.ResetText();
            this.txtMaDienThoai.ResetText();
            this.txtTongGiaTriNhap.ResetText();
            this.txtMaNhanVien.ResetText();
            this.txtNgayNhap.ResetText();
            this.txtSoLuongNhap.ResetText();
            this.txtGiaNhap.ResetText();

            this.panel.ResetText();

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnReLoad.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
            dgvDanhSachChiTietHoaDonNhap_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnReLoad.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;

            bool kq = false;
            string err = "";
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    kq = cthdnbusiness.ThemChiTietHoaDonNhap(ref err, txtSoLuongNhap.Text, txtGiaNhap.Text, txtMaHoaDonNhap.Text, txtMaDienThoai.Text, txtTongGiaTriNhap.Text);
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadChiTietHoaDonNhap();
                        // Thông báo 
                        MessageBox.Show("Đã thêm chi tiết hóa đơn nhập thành công!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được chi tiết hóa đơn nhập. Lỗi rồi!";
                    MessageBox.Show(err);
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = dgvDanhSachChiTietHoaDonNhap.CurrentCell.RowIndex;
                // MaChiTietHoaDonNhap hiện hành 
                string strMaNhap =
                dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL 
                kq = cthdnbusiness.CapNhatChiTietHoaDonNhap(ref err, txtSoLuongNhap.Text, txtGiaNhap.Text, txtMaHoaDonNhap.Text, txtMaDienThoai.Text, txtTongGiaTriNhap.Text);
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadChiTietHoaDonNhap();
                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadChiTietHoaDonNhap();
            LoadHoaDonNhap();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Bạn có muốn trở về trang chủ?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void dgvDanhSachHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDanhSachHoaDonNhap.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaHoaDonNhap.Text = dgvDanhSachHoaDonNhap.Rows[r].Cells[0].Value.ToString();
            this.txtNgayNhap.Text = dgvDanhSachHoaDonNhap.Rows[r].Cells[1].Value.ToString();
            this.txtMaNhanVien.Text = dgvDanhSachHoaDonNhap.Rows[r].Cells[2].Value.ToString();
        }

        private void dgvDanhSachChiTietHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   //khi click record trong dgvCTDV thì thông tin sẽ đc đưa lên các textbox và combobox
                int r = dgvDanhSachChiTietHoaDonNhap.CurrentCell.RowIndex;
                //hiển thị 
                this.txtSoLuongNhap.Text = dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[2].Value.ToString();
                this.txtMaHoaDonNhap.Text = dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[0].Value.ToString();
                this.txtMaDienThoai.Text = dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[1].Value.ToString();
                this.txtGiaNhap.Text = dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[3].Value.ToString();
                this.txtTongGiaTriNhap.Text = dgvDanhSachChiTietHoaDonNhap.Rows[r].Cells[4].Value.ToString();
            }
            catch   //TH click row ko có data
            {
                this.txtSoLuongNhap.ResetText();
                this.txtMaHoaDonNhap.ResetText();
                this.txtMaDienThoai.ResetText();
                this.txtTongGiaTriNhap.ResetText();
            }
        }
        void LoadChiTietHoaDonNhap()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                this.dgvDanhSachChiTietHoaDonNhap.DataSource = cthdnbusiness.LayChiTietHoaDonNhap().Tables[0];

                // Thay đổi độ rộng cột 
                this.dgvDanhSachChiTietHoaDonNhap.AutoResizeColumns();
                // Đặt tên cột
                dgvDanhSachChiTietHoaDonNhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
                dgvDanhSachChiTietHoaDonNhap.Columns[1].HeaderText = "Mã điện thoại";
                dgvDanhSachChiTietHoaDonNhap.Columns[2].HeaderText = "Số lượng nhập";
                dgvDanhSachChiTietHoaDonNhap.Columns[3].HeaderText = "Giá nhập";
                dgvDanhSachChiTietHoaDonNhap.Columns[4].HeaderText = "Tổng giá trị nhập";

                // Xóa trống các đối tượng trong Panel 
                this.txtMaHoaDonNhap.ResetText();
                this.txtNgayNhap.ResetText();
                this.txtSoLuongNhap.ResetText();
                this.txtTongGiaTriNhap.ResetText();
                this.txtMaDienThoai.ResetText();
                this.txtMaNhanVien.ResetText();
                this.txtGiaNhap.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                //
                dgvDanhSachChiTietHoaDonNhap_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung đồ chơi. Đã xảy ra lỗi!");
            }
        }

        void LoadHoaDonNhap()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                dgvDanhSachHoaDonNhap.DataSource = hdnbusiness.LayHoaDonNhap().Tables[0];

                // Thay đổi độ rộng cột 
                dgvDanhSachHoaDonNhap.AutoResizeColumns();

                // Đặt tên cột
                dgvDanhSachHoaDonNhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
                dgvDanhSachHoaDonNhap.Columns[1].HeaderText = "Ngày nhập";
                dgvDanhSachHoaDonNhap.Columns[2].HeaderText = "Mã nhân viên";

                // Sự kiện click chuột
                dgvDanhSachHoaDonNhap_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung hóa đơn nhập. Đã xảy ra lỗi!");
            }
        }

        private void Form_ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadChiTietHoaDonNhap();
            LoadHoaDonNhap();
        }
    }
}
