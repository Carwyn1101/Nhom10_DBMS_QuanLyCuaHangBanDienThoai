using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBDienThoai
    {
        DAL db = null;

        public DBDienThoai()
        {
            db = new DAL();
        }
        // Load danh sách điện thoại
        public DataSet LayDienThoai()
        {
            return db.ExecuteQueryDataSet("USP_LayDienThoai", CommandType.StoredProcedure);
        }
        // Load danh sách điện thoại
        public DataSet DienThoaiDaBan()
        {
            return db.ExecuteQueryDataSet("USP_DienThoaiDaBan", CommandType.StoredProcedure);
        }
        // Load danh sách điện thoại
        public DataSet DienThoaiChuaBan()
        {
            return db.ExecuteQueryDataSet("USP_DienThoaiChuaBan", CommandType.StoredProcedure);
        }
        // Thêm điện thoại
        public bool ThemDienThoai(ref string err, string TenDienThoai, string NamSanXuat, int GiaTien, int ViTriKho, int MaNganKe, int MaNSX)
        {
            // Chuyển đổi chuỗi năm sản xuất thành DateTime
            DateTime namSanXuat;
            if (!DateTime.TryParse(NamSanXuat, out namSanXuat))
            {
                err = "Năm sản xuất không hợp lệ.";
                return false;
            }
            return db.MyExecuteNonQuery("USP_ThemDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ten_dien_thoai", TenDienThoai),
                new SqlParameter("@nam_san_xuat", namSanXuat),
                new SqlParameter("@gia_tien", GiaTien),
                new SqlParameter("@vi_tri_kho", ViTriKho),
                new SqlParameter("@ma_ngan_ke", MaNganKe),
                new SqlParameter("@ma_nsx", MaNSX));
        }
        // Xoá điện thoại
        public bool XoaDienThoai(ref string err, int MaDienThoai)
        {
            return db.MyExecuteNonQuery("USP_XoaDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDienThoai", MaDienThoai));
        }
        // Cập nhật điện thoại
        public bool CapNhatDienThoai(ref string err, int MaDienThoai, string TenDienThoai, string NamSanXuat, int GiaTien, int ViTriKho, int MaNganKe, int MaNSX)
        {
            // Chuyển đổi chuỗi năm sản xuất thành DateTime
            DateTime namSanXuat;
            if (!DateTime.TryParse(NamSanXuat, out namSanXuat))
            {
                err = "Năm sản xuất không hợp lệ.";
                return false;
            }
            return db.MyExecuteNonQuery("USP_CapNhatDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@madienthoai", MaDienThoai),
                new SqlParameter("@tendienthoai", TenDienThoai),
                new SqlParameter("@namsanxuat", namSanXuat),
                new SqlParameter("@giatien", GiaTien),
                new SqlParameter("@vitrikho", ViTriKho),
                new SqlParameter("@manganke", MaNganKe),
                new SqlParameter("@maNSX", MaNSX));
        }

        // Tìm kiếm điện thoại theo mã: UDF_TimDienThoaiTheoMa
        public DataSet TimDienThoaiTheoMa(string maDienThoai)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM UDF_TimDienThoaiTheoMa({maDienThoai})", CommandType.Text);
        }

        // Tìm kiếm điện thoại theo tên: UDF_TimDienThoaiTheoTen 
        public DataSet TimDienThoaiTheoTen(string tenDienThoai)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM UDF_TimDienThoaiTheoTen(N'{tenDienThoai}')", CommandType.Text);
        }
    }
}
