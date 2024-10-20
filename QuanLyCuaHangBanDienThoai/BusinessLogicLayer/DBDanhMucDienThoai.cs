using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ADO.NET
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBDanhMucDienThoai
    {
        DAL db = null;

        public DBDanhMucDienThoai()
        {
            db = new DAL();
        }
        // Load danh mục điện thoại
        public DataSet LayDanhMucDienThoai()
        {
            return db.ExecuteQueryDataSet("USP_LayDanhMucDienThoai", CommandType.StoredProcedure);
        }
        // Thêm danh mục điện thoại
        public bool ThemDanhMucDienThoai(ref string err, string MaLoaiDienThoai, string TenLoaiDienThoai)
        {
            return db.MyExecuteNonQuery("USP_ThemDanhMucDienThoai", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maloai", MaLoaiDienThoai),
                new SqlParameter("@tenloai", TenLoaiDienThoai));
        }
        // Xoá danh mục điện thoại
        public bool XoaDanhMucDienThoai(ref string err, string MaLoaiDienThoai)
        {
            return db.MyExecuteNonQuery("USP_XoaDanhMucDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maloai", MaLoaiDienThoai));
        }
        // Cập nhật danh mục điện thoại
        public bool CapNhatDanhMucDienThoai(ref string err, string MaLoaiDienThoai, string TenLoaiDienThoai)
        {
            return db.MyExecuteNonQuery("USP_CapNhatDanhMucDienThoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiDienThoai", MaLoaiDienThoai),
                new SqlParameter("@TenLoaiDienThoai", TenLoaiDienThoai));
        }
    }
}
