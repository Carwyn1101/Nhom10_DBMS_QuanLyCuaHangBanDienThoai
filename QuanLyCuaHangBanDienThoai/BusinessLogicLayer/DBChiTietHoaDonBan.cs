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
    public class DBChiTietHoaDonBan
    {
        DAL db = null;
        public DBChiTietHoaDonBan()
        {
            db = new DAL();
        }
        //load ds chi tiết hóa đơn bán
        public DataSet LayChiTietHoaDonBan()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM UDF_LayChiTietHoaDonBan()", CommandType.Text);
        }
        //Thêm chi tiết hóa đơn bán
        public bool ThemChiTietHoaDonBan(ref string err, string soLuongBan, string mahoadonban, string madienthoai, string giaban)
        {
            return db.MyExecuteNonQuery("USP_ThemChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@SoLuongBan", Int32.Parse(soLuongBan)),
                new SqlParameter("@MaHoaDonBan", Int32.Parse(mahoadonban)),
                new SqlParameter("@MaDienThoai", Int32.Parse(madienthoai)),
                new SqlParameter("@TongGiaTriBan", Int32.Parse(giaban)));
        }
        //Cập nhật chi tiết hóa đơn bán
        public bool CapNhatChiTietHoaDonBan(ref string err, string soLuongBan, string mahoadonban, string madienthoai, string giaban)
        {
            return db.MyExecuteNonQuery("USP_CapNhatChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonBan", Int32.Parse(mahoadonban)),
                new SqlParameter("@MaDienThoai", Int32.Parse(madienthoai)),
                new SqlParameter("@SoLuongBan", Int32.Parse(soLuongBan)),
                new SqlParameter("@TongGiaTriBan", Int32.Parse(giaban)));
        }
        //Xoá chi tiết hóa đơn bán
        public bool XoaChiTietHoaDonBan(ref string err, string maban, string madienthoai)
        {
            return db.MyExecuteNonQuery("USP_XoaChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDienThoai", madienthoai),
                new SqlParameter("@MaHoaDonBan", maban));
        }
        //Thống kê chi tiết hoá đơn bán tháng vừa rồi
        public DataSet ThongKeCTHDBThangVuaQua()
        {
            return db.ExecuteQueryDataSet("UDF_ThongKeCTHDBThangVuaQua", CommandType.StoredProcedure);
        }
    }
}

