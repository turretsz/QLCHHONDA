using System;
using System.Data;

namespace honda.DAL
{
    public class InvoiceDAL
    {
        private static InvoiceDAL? instance;
        public static InvoiceDAL Instance
        {
            get { if (instance == null) instance = new InvoiceDAL(); return instance; }
            private set { instance = value; }
        }

        private InvoiceDAL() { }

        public decimal GetTotalRevenue()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon";
            object? result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToDecimal(result) : 0;
        }

        public int GetMonthlySalesCount(int month, int year)
        {
            string query = "SELECT COUNT(*) FROM HoaDon WHERE MONTH(NgayLap) = @month AND YEAR(NgayLap) = @year";
            object? result = DataProvider.Instance.ExecuteScalar(query, new object[] { month, year });
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetRevenueByDay(DateTime fromDate, DateTime toDate)
        {
            string query = @"
SELECT 
    COALESCE(hd.Ngay, sc.Ngay) AS Ngay,
    CAST(ISNULL(hd.DoanhThuBanXe, 0) AS DECIMAL(18,2)) AS DoanhThuBanXe,
    CAST(ISNULL(sc.DoanhThuDichVu, 0) AS DECIMAL(18,2)) AS DoanhThuDichVu,
    CAST(ISNULL(hd.DoanhThuBanXe, 0) + ISNULL(sc.DoanhThuDichVu, 0) AS DECIMAL(18,2)) AS TongDoanhThu
FROM (
    SELECT CAST(NgayLap AS DATE) AS Ngay, SUM(TongTien) AS DoanhThuBanXe
    FROM HoaDon
    WHERE NgayLap >= @fromDate1 AND NgayLap <= @toDate1
    GROUP BY CAST(NgayLap AS DATE)
) hd
FULL OUTER JOIN (
    SELECT CAST(NgayLap AS DATE) AS Ngay, SUM(TongTien) AS DoanhThuDichVu
    FROM PhieuSuaChua
    WHERE NgayLap >= @fromDate2 AND NgayLap <= @toDate2
    GROUP BY CAST(NgayLap AS DATE)
) sc ON hd.Ngay = sc.Ngay
ORDER BY Ngay";
            DateTime start = fromDate.Date;
            DateTime end = toDate.Date.AddDays(1).AddTicks(-1);
            return DataProvider.Instance.ExecuteQuery(query, new object[] { start, end, start, end });
        }

        public DataTable GetAllHoaDon()
        {
            string query = "SELECT hd.MaHD, hd.NgayLap, x.TenXe, kh.TenKH, hd.VAT, hd.PhiTruocBa, hd.TongTien " +
                           "FROM HoaDon hd " +
                           "LEFT JOIN Xe x ON hd.MaXe = x.MaXe " +
                           "LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH " +
                           "ORDER BY hd.NgayLap DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddHoaDon(int maXe, int maKH, string username, decimal vat, decimal phiTruocBa, decimal tongTien)
        {
            string q1 = "INSERT INTO HoaDon (NgayLap, MaXe, MaKH, Username, VAT, PhiTruocBa, TongTien) VALUES ( GETDATE() , @maXe , @maKH , @username , @vat , @phiTruocBa , @tongTien )";
            int r1 = DataProvider.Instance.ExecuteNonQuery(q1, new object[] { maXe, maKH, username, vat, phiTruocBa, tongTien });

            string q2 = "UPDATE Xe SET TrangThai = N'Đã bán' WHERE MaXe = @maXe";
            int r2 = DataProvider.Instance.ExecuteNonQuery(q2, new object[] { maXe });

            return r1 > 0 && r2 > 0;
        }

        public bool DeleteHoaDon(int id)
        {
            object? maXeObj = DataProvider.Instance.ExecuteScalar("SELECT MaXe FROM HoaDon WHERE MaHD = @id", new object[] { id });
            if (maXeObj != null && maXeObj != DBNull.Value)
            {
                int maXe = Convert.ToInt32(maXeObj);
                DataProvider.Instance.ExecuteNonQuery("UPDATE Xe SET TrangThai = N'Chưa bán' WHERE MaXe = @maXe", new object[] { maXe });
            }

            string qDelete = "DELETE FROM HoaDon WHERE MaHD = @id";
            int rows = DataProvider.Instance.ExecuteNonQuery(qDelete, new object[] { id });
            return rows > 0;
        }

        public int GetTotalCustomers()
        {
            string query = "SELECT COUNT(*) FROM KhachHang";
            object? result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetLowStockParts()
        {
            string query = "SELECT TenPhuTung, SoLuongTon FROM PhuTung WHERE SoLuongTon <= 5 ORDER BY SoLuongTon ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
