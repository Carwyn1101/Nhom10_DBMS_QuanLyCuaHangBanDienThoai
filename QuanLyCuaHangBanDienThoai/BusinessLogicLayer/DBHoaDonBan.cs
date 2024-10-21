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
    public class DBHoaDonBan
    {
        DAL db = null;
        public DBHoaDonBan()
        {
            db = new DAL();
        }
        //load ds hóa đơn bán 
        public DataSet LayHoaDonBan()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM UDF_LayHoaDonBan()", CommandType.Text);
        }
        //Thêm hóa đơn bán 
        public bool ThemHoaDonBan(ref string err, DateTime ngayBan, int manhanvien,int makh)
        {
            return db.MyExecuteNonQuery("USP_ThemHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ngayban", ngayBan),
                new SqlParameter("@manv", manhanvien),
                new SqlParameter("@makh", makh)
                );
        }
        //Cập nhật hoá đơn bán
        public bool CapNhatHoaDonBan(ref string err, int mahoadonban, DateTime ngayBan, int manhanvien, int makh)
        {
            return db.MyExecuteNonQuery("USP_CapNhatHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@mahoadonban", mahoadonban),
                new SqlParameter("@ngaylaphd", ngayBan),
                new SqlParameter("@manv", manhanvien),
                new SqlParameter("@makh", makh)
                );
        }
        //Xoá hoá đơn bán
        public bool XoaHoaDonBan(ref string err, string mahoadonban)
        {
            return db.MyExecuteNonQuery("USP_XoaHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@mahoadonban", mahoadonban));
        }
    }
}
