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
    public partial class Form_DienThoai : Form
    {
        bool Them = false;
        DBNhaSanXuat nsxbusiness = new DBNhaSanXuat();
        DBNganKe nkbusiness = new DBNganKe();
        DBDienThoai dcbusiness = new DBDienThoai();
        public Form_DienThoai()
        {
            InitializeComponent();
        }

        private void Form_DienThoai_Load(object sender, EventArgs e)
        {
            LoadDienThoai();
            LoadNhaSanXuat();
            LoadNganKe();
        }
        void LoadDienThoai()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                this.dgvDienThoai.DataSource = dcbusiness.LayDienThoai().Tables[0];
                //this.dgvDienThoai.Columns[3].Visible = false;
                //this.dgvDienThoai.Columns[4].Visible = false;
                //this.dgvDienThoai.Columns[5].Visible = false;
                // Thay đổi độ rộng cột 
                this.dgvDienThoai.AutoResizeColumns();
                // Đặt tên cột
                dgvDienThoai.Columns[0].HeaderText = "Mã điện thoại ";
                dgvDienThoai.Columns[1].HeaderText = "Tên điện thoại";
                dgvDienThoai.Columns[2].HeaderText = "NSX";
                dgvDienThoai.Columns[3].HeaderText = "Giá";
                dgvDienThoai.Columns[4].HeaderText = "Vị trí kho";
                dgvDienThoai.Columns[5].HeaderText = "Mã ngăn kệ";
                dgvDienThoai.Columns[6].HeaderText = "Mã NSX";

                // Xóa trống các đối tượng trong Panel 
                this.txtNamSanXuat.ResetText();
                this.txtTenDienThoai.ResetText();
                this.txtGiaTien.ResetText();
                //this.cbxMaLoaiDienThoai.ResetText();
                this.txtNhaSanXuat.ResetText();
                this.txtMaNganKe.ResetText();

                this.panel.Enabled = false;


                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                //this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                //
                dgvDienThoai_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung điện thoại. Đã xảy ra lỗi!");
            }
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;

            // Xóa trống các đối tượng trong Panel 
            this.panel.ResetText();
            this.panel.Enabled = true;

            //this.dtp.ResetText();
            this.txtMaNganKe.ResetText();
            this.txtViTriKho.ResetText();
            this.txtNamSanXuat.ResetText();
            this.txtTenDienThoai.ResetText();
            this.txtGiaTien.ResetText();
            this.txtNhaSanXuat.ResetText();
            this.txtMaDienThoai.ResetText();
            txtMaDienThoai.Enabled = false;

            // Cho thao tác trên các nút Lưu  
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaLoaiDienThoai
            this.txtNamSanXuat.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvDienThoai.CurrentCell.RowIndex;
                // Lấy MaDienThoai của record hiện hành 
                string strMaDienThoai =
                dgvDienThoai.Rows[r].Cells[0].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc muốn xoá điện thoại này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = dcbusiness.XoaDienThoai(ref err,int.Parse(txtMaDienThoai.Text));
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadDienThoai();
                        // Thông báo 
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Huỷ bỏ việc xoá điện thoại này!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được điện thoại này. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvDienThoai_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnReLoad.Enabled = false;
            // Đưa con trỏ đến TextField txtMaDienThoai
            this.txtNamSanXuat.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng 
            this.txtMaNganKe.ResetText();
            this.txtViTriKho.ResetText();
            this.txtNamSanXuat.ResetText();
            this.txtTenDienThoai.ResetText();
            this.txtGiaTien.ResetText();
            this.txtNhaSanXuat.ResetText();

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
            dgvDienThoai_CellClick(null, null);
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
                    kq = dcbusiness.ThemDienThoai(ref err, txtTenDienThoai.Text, txtNamSanXuat.Text, int.Parse(txtGiaTien.Text),
                        int.Parse(txtViTriKho.Text), int.Parse(txtMaNganKe.Text), int.Parse(txtNhaSanXuat.Text));
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadDienThoai();
                        // Thông báo 
                        MessageBox.Show("Đã thêm điện thoại thành công!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được điện thoại. Lỗi rồi!";
                    MessageBox.Show(err);
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = dgvDienThoai.CurrentCell.RowIndex;
                // MaDienThoai hiện hành 
                string strMaDienThoai =
                dgvDienThoai.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL 
                kq = dcbusiness.CapNhatDienThoai(ref err, int.Parse(txtMaDienThoai.Text), txtTenDienThoai.Text, txtNamSanXuat.Text, int.Parse(txtGiaTien.Text),
                        int.Parse(txtViTriKho.Text), int.Parse(txtMaNganKe.Text), int.Parse(txtNhaSanXuat.Text));
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadDienThoai();
                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDienThoai();
            LoadNhaSanXuat();
            LoadNganKe();
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   //khi click record trong dgvDanhSachDienThoai thì thông tin sẽ đc đưa lên các textbox và combobox
                int r = dgvDienThoai.CurrentCell.RowIndex;
                //hiển thị 
                this.txtMaDienThoai.Text = dgvDienThoai.Rows[r].Cells[0].Value.ToString();
                this.txtTenDienThoai.Text = dgvDienThoai.Rows[r].Cells[1].Value.ToString();
                this.txtNamSanXuat.Text = dgvDienThoai.Rows[r].Cells[2].Value.ToString();
                this.txtGiaTien.Text = dgvDienThoai.Rows[r].Cells[3].Value.ToString();
                this.txtViTriKho.Text = dgvDienThoai.Rows[r].Cells[4].Value.ToString();
                this.txtNhaSanXuat.Text = dgvDienThoai.Rows[r].Cells[5].Value.ToString();
                this.txtMaNganKe.Text = dgvDienThoai.Rows[r].Cells[6].Value.ToString();
            }
            catch   //TH click row ko có data
            {
                this.txtNamSanXuat.ResetText();
                this.txtTenDienThoai.ResetText();
                this.txtGiaTien.ResetText();
                this.txtViTriKho.ResetText();
                //this.cbxMaLoaiDienThoai.ResetText();
                this.txtMaNganKe.ResetText();
                this.txtNhaSanXuat.ResetText();
            }
        }
        void LoadNhaSanXuat()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                this.dgvNhaSanXuat.DataSource = nsxbusiness.LayNhaSanXuat().Tables[0];

                // Thay đổi độ rộng cột 
                this.dgvLoaiDienThoai.AutoResizeColumns();

                // Đặt tên cột
                dgvNhaSanXuat.Columns[0].HeaderText = "Mã nhà sản xuất";
                dgvNhaSanXuat.Columns[1].HeaderText = "Tên nhà sản xuất";
                dgvNhaSanXuat.Columns[2].HeaderText = "Tên quốc gia";

                // Sự kiện click chuột
                dgvNhaSanXuat_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung nhà sản xuất. Đã xảy ra lỗi!");
            }
        }

        private void dgvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNhaSanXuat.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtNhaSanXuat.Text = dgvNhaSanXuat.Rows[r].Cells[0].Value.ToString();
        }
        void LoadNganKe()
        {
            try
            {
                // đưa dữ liệu lên datagridview  
                this.dgvNganKe.DataSource = nkbusiness.NgankeSucchuaSoluong().Tables[0];
                // đặt tên cột
                dgvNganKe.Columns[0].HeaderText = "mã ngăn kệ ";
                dgvNganKe.Columns[1].HeaderText = "sức chứa";
                dgvNganKe.Columns[2].HeaderText = "đang chứa";
                //
                dgvNganKe_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("không lấy được nội dung ngăn kệ. đã xảy ra lỗi!");
            }
        }

        private void dgvNganKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNganKe.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNganKe.Text = dgvNganKe.Rows[r].Cells[0].Value.ToString();
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            dgvThongTin.Refresh();
            this.dgvThongTin.DataSource = dcbusiness.TimDienThoaiTheoTen(txtThongTin.Text).Tables[0];
        }

        private void btnTimMa_Click(object sender, EventArgs e)
        {
            dgvThongTin.Refresh();
            this.dgvThongTin.DataSource = dcbusiness.TimDienThoaiTheoMa(txtThongTin.Text).Tables[0];
        }

        private void btnDaBan_Click(object sender, EventArgs e)
        {
            dgvDienThoai.DataSource = dcbusiness.DienThoaiDaBan().Tables[0];
        }

        private void btnChuaBan_Click(object sender, EventArgs e)
        {
            dgvDienThoai.DataSource = dcbusiness.DienThoaiChuaBan().Tables[0];
        }

    }
}
