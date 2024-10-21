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
using BusinessLogicLayer;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class Form_NhanVien : Form
    {
        bool Them = false;
        DBNhanVien nvbusiness = new DBNhanVien();
        public Form_NhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        void LoadNhanVien()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                dgvDanhSachNhanVien.DataSource = nvbusiness.LayNhanVien().Tables[0];
                //
                
                //dgvDanhSachNhanVien.Columns[7].Visible = false;
                // Thay đổi độ rộng cột 
                dgvDanhSachNhanVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                this.txtMaNhanVien.ResetText();
                this.txtSDT.ResetText();
                this.panel.ResetText();
                this.txtTenNhanVien.ResetText();
                this.txtNamSinh.ResetText();
                this.txtQueQuan.ResetText();
                this.txtLuong.ResetText();
                this.dtpNgayVaoLam.ResetText();
                this.cbbTrangThai.ResetText();
                this.cbbChucVu.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                // Radio button
                this.rdNam.Refresh();
                this.rdNu.Refresh();
                // Đặt tên cột
                dgvDanhSachNhanVien.Columns[0].HeaderText = "Mã nhân viên";
                dgvDanhSachNhanVien.Columns[1].HeaderText = "Họ tên";
                dgvDanhSachNhanVien.Columns[2].HeaderText = "Năm Sinh";
                dgvDanhSachNhanVien.Columns[3].HeaderText = "Giới Tính";
                dgvDanhSachNhanVien.Columns[4].HeaderText = "Quê Quán";
                dgvDanhSachNhanVien.Columns[5].HeaderText = "Lương";
                dgvDanhSachNhanVien.Columns[6].HeaderText = "Chức vụ";
                dgvDanhSachNhanVien.Columns[7].HeaderText = "Ngày Vào Làm";
                dgvDanhSachNhanVien.Columns[8].HeaderText = "Trạng Thái";
                dgvDanhSachNhanVien.Columns[9].HeaderText = "Số điện thoại";
                dgvDanhSachNhanVien.Columns[10].HeaderText = "Mã tài khoản";
                // Sự kiện click chuột
                dgvDanhSachNhanVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung nhân viên.Đã xảy ra lỗi!");
            }
        }
        // Nút trở về 
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            ///
            DataSet dsTaiKhoan = nvbusiness.LayTaiKhoanDangCo();
            if (dsTaiKhoan.Tables.Count > 0 && dsTaiKhoan.Tables[0].Rows.Count > 0)
            {
                cbbMaTK.DataSource = dsTaiKhoan.Tables[0]; // Gán DataTable vào DataSource của ComboBox
                cbbMaTK.DisplayMember = "TenDangNhap";     // Hiển thị tên tài khoản
                cbbMaTK.ValueMember = "MaTaiKhoan";         // Giá trị là mã tài khoản

                // Kiểm tra nếu ComboBox có mục thì chọn mục đầu tiên
                if (cbbMaTK.Items.Count > 0)
                {
                    cbbMaTK.SelectedIndex = 0; // Chọn mục đầu tiên
                }
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào để hiển thị.");
            }
            // Xóa trống các đối tượng trong Panel 
            this.txtMaNhanVien.ResetText();
            this.txtTenNhanVien.ResetText();
            this.panel.ResetText();
            this.dtpNgayVaoLam.ResetText();
            this.txtNamSinh.ResetText();
            this.txtQueQuan.ResetText(); ;
            this.txtSDT.ResetText();
            this.txtQueQuan.ResetText();
            this.txtLuong.ResetText();
            this.cbbTrangThai.ResetText();
            this.rdNam.Refresh();
            this.rdNu.Refresh();
            // Cho thao tác trên các nút Lưu
            this.txtMaNhanVien.Enabled = false;
            this.panel.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNhanVien
            this.txtMaNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvDanhSachNhanVien.CurrentCell.RowIndex;
                // Lấy MaNhanVien của record hiện hành 
                string strNhanVien = dgvDanhSachNhanVien.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc xóa nhân viên này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra có nhắp chọn nút Yes không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL
                    kq = nvbusiness.XoaNhanVien(ref err, strNhanVien);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadNhanVien();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        // Thông báo lỗi cụ thể nếu không xóa được
                        MessageBox.Show($"Không thể xóa nhân viên. Lỗi: {err}");
                    }
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException ex)
            {
                // Ghi lại thông báo lỗi chi tiết để biết nguyên nhân
                MessageBox.Show($"Không xóa được. Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác ngoài SqlException
                MessageBox.Show($"Không xóa được. Lỗi: {ex.Message}");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            //
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvDanhSachNhanVien_CellClick(null, null);
            int r = dgvDanhSachNhanVien.CurrentCell.RowIndex;

            // Lấy MaTaiKhoan của nhân viên hiện hành
            string maTaiKhoanHienTai = dgvDanhSachNhanVien.Rows[r].Cells["MaTaiKhoan"].Value.ToString();

            // Lấy danh sách tài khoản từ cơ sở dữ liệu
            DataSet dsTaiKhoan = nvbusiness.LayTaiKhoanDangCo();
            if (dsTaiKhoan.Tables.Count > 0 && dsTaiKhoan.Tables[0].Rows.Count > 0)
            {
                // Gán DataTable vào DataSource của ComboBox
                cbbMaTK.DataSource = dsTaiKhoan.Tables[0];
                cbbMaTK.DisplayMember = "TenDangNhap";   // Hiển thị tên tài khoản
                cbbMaTK.ValueMember = "MaTaiKhoan";      // Giá trị là mã tài khoản

                // Thiết lập giá trị ban đầu cho ComboBox là MaTaiKhoan của nhân viên hiện hành
                cbbMaTK.SelectedValue = maTaiKhoanHienTai;
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào để hiển thị.");
            }
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnReLoad.Enabled = false;

            // Đưa con trỏ đến TextField txtMaNV 
            this.txtMaNhanVien.Enabled = false;
            this.txtSDT.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtMaNhanVien.ResetText();
            this.txtTenNhanVien.ResetText();
            this.panel.ResetText();
            this.dtpNgayVaoLam.ResetText();
            this.txtNamSinh.ResetText();
            this.txtQueQuan.ResetText();
            this.txtSDT.ResetText();
            this.txtQueQuan.ResetText();
            this.txtLuong.ResetText();
            this.cbbTrangThai.ResetText();
            this.rdNam.Refresh();
            this.rdNu.Refresh();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnReLoad.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
            dgvDanhSachNhanVien_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            

            bool kq = false;
            string err = "";
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    int maTaiKhoan;

                    // Kiểm tra giá trị của ComboBox và lấy mã tài khoản
                    if (cbbMaTK.SelectedValue != null && int.TryParse(cbbMaTK.SelectedValue.ToString(), out maTaiKhoan))
                    {

                        // Kiểm tra các trường không được để trống
                        if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
                        {
                            MessageBox.Show("Tên nhân viên không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
                        {
                            MessageBox.Show("Năm sinh không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtSDT.Text))
                        {
                            MessageBox.Show("Số điện thoại không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtQueQuan.Text))
                        {
                            MessageBox.Show("Quê quán không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtLuong.Text))
                        {
                            MessageBox.Show("Lương không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(cbbChucVu.Text))
                        {
                            MessageBox.Show("Chức vụ không được để trống.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(cbbTrangThai.Text))
                        {
                            MessageBox.Show("Trạng thái không được để trống.");
                            return;
                        }

                        // kiểm tra số điện thoại
                        string sdt = txtSDT.Text.Trim();
                        if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
                        {
                            MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.");
                            return;
                        }

                        // Kiểm tra năm sinh
                        int namSinh;
                        if (!int.TryParse(txtNamSinh.Text, out namSinh))
                        {
                            MessageBox.Show("Năm sinh không hợp lệ. Vui lòng nhập lại.");
                            return;
                        }

                        int currentYear = DateTime.Now.Year;
                        if ((currentYear - namSinh) < 18)
                        {
                            MessageBox.Show("Nhân viên phải đủ 18 tuổi.");
                            return;
                        }

                        // Kiểm tra lương
                        int luong;
                        if (!int.TryParse(txtLuong.Text, out luong))
                        {
                            MessageBox.Show("Lương không hợp lệ. Vui lòng nhập lại.");
                            return;
                        }

                        if (luong < 0)
                        {
                            MessageBox.Show("Lương phải lớn hơn hoặc bằng 0.");
                            return;
                        }

                        // Kiểm tra ngày vào làm
                        DateTime ngayVaoLam;
                        if (!DateTime.TryParse(dtpNgayVaoLam.Text, out ngayVaoLam))
                        {
                            MessageBox.Show("Ngày vào làm không hợp lệ. Vui lòng nhập lại.");
                            return;
                        }
                        // Thực hiện thêm nhân viên
                        kq = nvbusiness.ThemNhanVien(
                            ref err,
                            txtTenNhanVien.Text,
                            (rdNam.Checked ? rdNam.Text : rdNu.Text),
                            int.Parse(txtNamSinh.Text),
                            txtQueQuan.Text,
                            int.Parse(txtLuong.Text),
                            DateTime.Parse(dtpNgayVaoLam.Text),
                            cbbTrangThai.Text,
                            cbbChucVu.Text,
                            txtSDT.Text,
                            maTaiKhoan
                        );

                        // Kiểm tra kết quả của ThemNhanVien và thông báo
                        if (kq)
                        {
                            // Load lại dữ liệu trên DataGridView
                            LoadNhanVien();
                            // Thông báo thành công
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            // Thông báo nếu có lỗi từ ThemNhanVien
                            MessageBox.Show($"Không thể thêm nhân viên. Lỗi: {err}");
                        }
                    }
                    else
                    {
                        // Thông báo nếu mã tài khoản không hợp lệ
                        MessageBox.Show("Vui lòng chọn mã tài khoản hợp lệ trước khi thêm nhân viên.");
                    }
                }
                catch (SqlException sqlEx)
                {
                    err = "Không thêm được nhân viên do lỗi SQL: " + sqlEx.Message;
                    MessageBox.Show(err);
                }
                catch (Exception ex)
                {
                    err = "Không thêm được. Lỗi: " + ex.Message;
                    MessageBox.Show(err);
                }
            }
            else
            {
                int maTaiKhoan;

                // Kiểm tra giá trị của ComboBox và lấy mã tài khoản
                if (cbbMaTK.SelectedValue != null && int.TryParse(cbbMaTK.SelectedValue.ToString(), out maTaiKhoan))
                {

                    // Kiểm tra các trường không được để trống
                    if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
                    {
                        MessageBox.Show("Tên nhân viên không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
                    {
                        MessageBox.Show("Năm sinh không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtSDT.Text))
                    {
                        MessageBox.Show("Số điện thoại không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtQueQuan.Text))
                    {
                        MessageBox.Show("Quê quán không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtLuong.Text))
                    {
                        MessageBox.Show("Lương không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cbbChucVu.Text))
                    {
                        MessageBox.Show("Chức vụ không được để trống.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cbbTrangThai.Text))
                    {
                        MessageBox.Show("Trạng thái không được để trống.");
                        return;
                    }

                    // kiểm tra số điện thoại
                    string sdt = txtSDT.Text.Trim();
                    if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
                    {
                        MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.");
                        return;
                    }

                    // Kiểm tra năm sinh
                    int namSinh;
                    if (!int.TryParse(txtNamSinh.Text, out namSinh))
                    {
                        MessageBox.Show("Năm sinh không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }

                    int currentYear = DateTime.Now.Year;
                    if ((currentYear - namSinh) < 18)
                    {
                        MessageBox.Show("Nhân viên phải đủ 18 tuổi.");
                        return;
                    }

                    // Kiểm tra lương
                    int luong;
                    if (!int.TryParse(txtLuong.Text, out luong))
                    {
                        MessageBox.Show("Lương không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }

                    if (luong < 0)
                    {
                        MessageBox.Show("Lương phải lớn hơn hoặc bằng 0.");
                        return;
                    }

                    // Kiểm tra ngày vào làm
                    DateTime ngayVaoLam;
                    if (!DateTime.TryParse(dtpNgayVaoLam.Text, out ngayVaoLam))
                    {
                        MessageBox.Show("Ngày vào làm không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }
                    // Thực hiện thêm nhân viên
                    kq = nvbusiness.CapNhatNhanVien(
                        ref err,
                        int.Parse(txtMaNhanVien.Text),
                        txtTenNhanVien.Text,
                        (rdNam.Checked ? rdNam.Text : rdNu.Text),
                        int.Parse(txtNamSinh.Text),
                        txtQueQuan.Text,
                        int.Parse(txtLuong.Text),
                        DateTime.Parse(dtpNgayVaoLam.Text),
                        cbbTrangThai.Text,
                        cbbChucVu.Text,
                        txtSDT.Text,
                        maTaiKhoan
                    );
                }
                else
                {
                    // Thông báo nếu mã tài khoản không hợp lệ
                    MessageBox.Show("Vui lòng chọn mã tài khoản hợp lệ trước khi thêm nhân viên.");
                }
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadNhanVien();
                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnReLoad.Enabled = true;
            this.btnLoc.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDanhSachNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNhanVien.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNhanVien.Text =
               dgvDanhSachNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtNamSinh.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[2].Value.ToString();
            if (dgvDanhSachNhanVien.Rows[r].Cells[3].Value.ToString() == "Nam")
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.txtQueQuan.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtLuong.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[5].Value.ToString();
            this.cbbChucVu.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[6].Value.ToString();
            this.dtpNgayVaoLam.Value = DateTime.Parse
                (dgvDanhSachNhanVien.Rows[r].Cells[7].Value.ToString());
            this.cbbTrangThai.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[8].Value.ToString();
            this.txtSDT.Text =
                 dgvDanhSachNhanVien.Rows[r].Cells[9].Value.ToString();
            this.cbbMaTK.Text =
                dgvDanhSachNhanVien.Rows[r].Cells[10].Value.ToString();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = nvbusiness.NhanVienDangLamViec().Tables[0];
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked == true)
            {
                rdNu.Checked = false;
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked == true)
            {
                rdNam.Checked = false;
            }
        }
    }
}
