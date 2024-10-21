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
    public class DBNganKe
    {
        DAL db = null;

        public DBNganKe()
        {
            db = new DAL();
        }
        // Load danh sách ngăn kệ
        public DataSet LayNganKe()
        {
            return db.ExecuteQueryDataSet("USP_LayNganKe", CommandType.StoredProcedure);
        }
        // Load danh sách ngăn kệ, sức chứa, số lượng
        public DataSet NgankeSucchuaSoluong()
        {
            return db.ExecuteQueryDataSet("USP_TinhTrangNganKe", CommandType.StoredProcedure);
        }
        // Thêm ngăn kệ
        public bool ThemNganKe(ref string err,  string tennganke, int SucChua)
        {
            return db.MyExecuteNonQuery("USP_ThemNganKe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenNganKe", tennganke),
                new SqlParameter("@SucChua", SucChua));
        }
        // Xoá ngăn kệ
        public bool XoaNganKe(ref string err, string MaNganKe)
        {
            return db.MyExecuteNonQuery("USP_XoaNganKe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ma_ngan_ke", MaNganKe));
        }
        // Cập nhật ngăn kệ
        public bool CapNhatNganKe(ref string err, int MaNganKe, string tennganke, int SucChua)
        {
            return db.MyExecuteNonQuery("USP_CapNhatNganKe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@manganke", MaNganKe),
                new SqlParameter("@tennganke", tennganke),
                new SqlParameter("@succhua", SucChua));
        }
    }
}
