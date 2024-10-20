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
    public class DBChiTietHoaDonNhap
    {
        DAL db = null;
        public DBChiTietHoaDonNhap()
        {
            db = new DAL();
        }
        //load ds chi tiết hóa đơn nhập 
        public DataSet LayChiTietHoaDonNhap()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM UDF_LayChiTietHoaDonNhap()", CommandType.Text);
        }
        //Thêm chi tiết hóa đơn nhập
        public bool ThemChiTietHoaDonNhap(ref string err, string soLuongNhap, string gianhap, string mahoadonnhap, string madienthoai, string tonggianhap)
        {
            return db.MyExecuteNonQuery("USP_ThemChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonNhap", Int32.Parse(mahoadonnhap)),
                new SqlParameter("@MaDienThoai", Int32.Parse(madienthoai)),
                new SqlParameter("@SoLuongNhap", Int32.Parse(soLuongNhap)),
                new SqlParameter("@GiaNhap", Int32.Parse(gianhap)),
                new SqlParameter("@TongGiaTriNhap", Int32.Parse(tonggianhap)));
        }
        //Cập nhật chi tiết hóa đơn nhập
        public bool CapNhatChiTietHoaDonNhap(ref string err, string soLuongNhap, string gianhap, string mahoadonnhap, string madienthoai, string tonggianhap)
        {
            return db.MyExecuteNonQuery("USP_CapNhatChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonNhap", Int32.Parse(mahoadonnhap)),
                new SqlParameter("@MaDienThoai", Int32.Parse(madienthoai)),
                new SqlParameter("@SoLuongNhap", Int32.Parse(soLuongNhap)),
                new SqlParameter("@GiaNhap", Int32.Parse(gianhap)),
                new SqlParameter("@TongGiaTriNhap", Int32.Parse(tonggianhap)));
        }
        //Xoá chi tiết hoá đơn nhập
        public bool XoaChiTietHoaDonNhap(ref string err, string manhap, string madienthoai)
        {
            return db.MyExecuteNonQuery("USP_XoaChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDienThoai", madienthoai),
                new SqlParameter("@MaHoaDonNhap", manhap));
        }
        //Thống kê chi tiết hoá đơn nhập tháng vừa rồi
        public DataSet ThongKeCTHDNThangVuaQua()
        {
            return db.ExecuteQueryDataSet("UDF_ThongKeCTHDNThangVuaQua", CommandType.StoredProcedure);
        }
    }
}
