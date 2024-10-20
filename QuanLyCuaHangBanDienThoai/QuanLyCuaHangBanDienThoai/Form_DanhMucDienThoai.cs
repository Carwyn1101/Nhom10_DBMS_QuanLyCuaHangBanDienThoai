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
    public partial class Form_DanhMucDienThoai : Form
    {
        bool Them = false;
        DBDanhMucDienThoai dmdcbusiness = new DBDanhMucDienThoai();
        public Form_DanhMucDienThoai()
        {
            InitializeComponent();
        }

        private void form_DanhMucDienThoai_Load(object sender, EventArgs e)
        {
            LoadDanhMucDienThoai();
        }
        void LoadDanhMucDienThoai()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                this.dgvDanhMucDienThoai.DataSource = dmdcbusiness.LayDanhMucDienThoai().Tables[0];

                // Xóa trống các đối tượng trong Panel 
                this.txtMaLoaiDienThoai.ResetText();
                this.txtTenLoaiDienThoai.ResetText();

                //this.dtp.ResetText();
                this.panel.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnTroVe.Enabled = true;
                this.panel.Enabled = false;

                // Đặt tên cột
                dgvDanhMucDienThoai.Columns[0].HeaderText = "Mã loại đồ chơi";
                dgvDanhMucDienThoai.Columns[1].HeaderText = "Tên loại đồ chơi";

                // Sự kiện click chuột
                dgvDanhMucDienThoai_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung loại đồ chơi. Đã xảy ra lỗi!");
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

            // Xóa trống các đối tượng trong Panel 
            this.panel.ResetText();
            this.panel.Enabled = true;

            //this.dtp.ResetText();
            this.txtMaLoaiDienThoai.ResetText();
            this.txtTenLoaiDienThoai.ResetText();

            // Cho thao tác trên các nút Lưu  
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaLoaiDienThoai
            this.txtMaLoaiDienThoai.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvDanhMucDienThoai.CurrentCell.RowIndex;
                // Lấy MaLoaiDienThoai của record hiện hành 
                string strMaLoaiDienThoai =
                dgvDanhMucDienThoai.Rows[r].Cells[0].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc muốn xoá loại đồ chơi này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = dmdcbusiness.XoaDanhMucDienThoai(ref err, strMaLoaiDienThoai);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadDanhMucDienThoai();
                        // Thông báo 
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    else
                        MessageBox.Show(txtMaLoaiDienThoai.Text);
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Huỷ bỏ việc xoá loại đồ chơi này!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được loại đồ chơi này. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvDanhMucDienThoai_CellClick(null, null);

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
            this.txtMaLoaiDienThoai.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng 
            this.txtMaLoaiDienThoai.ResetText();
            this.txtTenLoaiDienThoai.ResetText();
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

            dgvDanhMucDienThoai_CellClick(null, null);
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
                    kq = dmdcbusiness.ThemDanhMucDienThoai(ref err, txtMaLoaiDienThoai.Text, txtTenLoaiDienThoai.Text);
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadDanhMucDienThoai();
                        // Thông báo 
                        MessageBox.Show("Đã thêm loại đồ chơi thành công!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được loại đồ chơi này. Lỗi rồi!";
                    MessageBox.Show(err);
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = dgvDanhMucDienThoai.CurrentCell.RowIndex;
                // MaLoaiDienThoai hiện hành 
                string strMaLoaiDienThoai =
                dgvDanhMucDienThoai.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL 
                kq = dmdcbusiness.CapNhatDanhMucDienThoai(ref err, txtMaLoaiDienThoai.Text, txtTenLoaiDienThoai.Text);
                if (kq)
                {
                    // Load lại dữ liệu trên DataGridView 
                    LoadDanhMucDienThoai();
                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDanhMucDienThoai();
        }

        private void dgvDanhMucDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDanhMucDienThoai.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaLoaiDienThoai.Text = dgvDanhMucDienThoai.Rows[r].Cells[0].Value.ToString();
            this.txtTenLoaiDienThoai.Text = dgvDanhMucDienThoai.Rows[r].Cells[1].Value.ToString();
        }
    }
}
