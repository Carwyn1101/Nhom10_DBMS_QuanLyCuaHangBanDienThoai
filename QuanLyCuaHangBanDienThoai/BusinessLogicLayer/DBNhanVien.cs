using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class DBNhanVien
    {
        DAL db = null;

        public DBNhanVien()
        {
            db = new DAL();
        }
        // Load danh sách nhân viên
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("USP_LayNhanVien", CommandType.StoredProcedure);
        }
        // Load danh sách nhân viên đang làm việc
        public DataSet NhanVienDangLamViec()
        {
            return db.ExecuteQueryDataSet("USP_NhanVienDangLamViec", CommandType.StoredProcedure);
        }
        //load tài khoản 
        public DataSet LayTaiKhoanDangCo()
        {
            return db.ExecuteQueryDataSet("USP_LayTaiKhoan", CommandType.StoredProcedure);
        }
        // Thêm nhân viên
        public bool ThemNhanVien(ref string err, string TenNhanVien, string GioiTinh,
            int NamSinh, string QueQuan, int Luong, DateTime NgayVaoLam, string TrangThai, string ChucVu, string SDT, int MaTK)
        {
            return db.MyExecuteNonQuery("USP_ThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@hoten", TenNhanVien),
                new SqlParameter("@namsinh", NamSinh),
                new SqlParameter("@gioitinh", GioiTinh),
                new SqlParameter("@quequan", QueQuan),
                new SqlParameter("@luong", Luong),
                new SqlParameter("@chucvu", ChucVu),
                new SqlParameter("@ngayvaolam", NgayVaoLam),
                new SqlParameter("@trangthai", TrangThai),
                new SqlParameter("@sdt", SDT),
                new SqlParameter("@matk", MaTK)
                );
        }
        // Xoá nhân viên
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("USP_XoaNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@manhanvien", MaNhanVien));
        }
        // Cập nhật nhân viên
        public bool CapNhatNhanVien(ref string err, int MaNhanVien,string TenNhanVien, string GioiTinh,
            int NamSinh, string QueQuan, int Luong, DateTime NgayVaoLam, string TrangThai, string ChucVu, string SDT, int MaTK)
        {
            return db.MyExecuteNonQuery("USP_CapNhatNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@hoten", TenNhanVien),
                new SqlParameter("@namsinh", NamSinh),
                new SqlParameter("@gioitinh", GioiTinh),
                new SqlParameter("@quequan", QueQuan),
                new SqlParameter("@luong", Luong),
                new SqlParameter("@chucvu", ChucVu),
                new SqlParameter("@ngayvaolam", NgayVaoLam),
                new SqlParameter("@trangthai", TrangThai),
                new SqlParameter("@sdt", SDT),
                new SqlParameter("@matk", MaTK));
        }
    }
}
