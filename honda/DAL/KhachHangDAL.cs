using System.Data;

namespace honda.DAL
{
    public class KhachHangDAL
    {
        private static KhachHangDAL? instance;
        public static KhachHangDAL Instance
        {
            get { if (instance == null) instance = new KhachHangDAL(); return instance; }
            private set { instance = value; }
        }

        private KhachHangDAL() { }

        public DataTable GetAllKhachHang()
        {
            string query = "SELECT MaKH,TenKH,SDT,DiaChi,CCCD FROM KhachHang ORDER BY TenKH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchKhachHang(string keyword)
        {
            string kw = "%" + keyword + "%";
            string query = "SELECT MaKH,TenKH,SDT,DiaChi,CCCD FROM KhachHang WHERE TenKH LIKE @kw OR SDT LIKE @kw ORDER BY TenKH";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { kw, kw });
        }

        public bool AddKhachHang(string tenKH, string sdt, string diaChi, string cccd)
        {
            string query = "INSERT INTO KhachHang (TenKH,SDT,DiaChi,CCCD) VALUES ( @tenKH , @sdt , @diaChi , @cccd )";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKH, sdt, diaChi, cccd });
            return rows > 0;
        }

        public bool UpdateKhachHang(int id, string tenKH, string sdt, string diaChi, string cccd)
        {
            string query = "UPDATE KhachHang SET TenKH = @tenKH , SDT = @sdt , DiaChi = @diaChi , CCCD = @cccd WHERE MaKH = @id";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKH, sdt, diaChi, cccd, id });
            return rows > 0;
        }

        public bool DeleteKhachHang(int id)
        {
            // Check if customer has any invoices
            string checkQuery = "SELECT COUNT(*) FROM HoaDon WHERE MaKH = @id";
            object? checkResult = DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { id });
            if (checkResult != null && Convert.ToInt32(checkResult) > 0)
                return false;

            string query = "DELETE FROM KhachHang WHERE MaKH = @id";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return rows > 0;
        }

        public bool IsSDTExists(string sdt, int excludeId)
        {
            string query;
            object? result;
            if (excludeId == -1)
            {
                query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @sdt";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt });
            }
            else
            {
                query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @sdt AND MaKH <> @excludeId";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, excludeId });
            }
            return result != null && Convert.ToInt32(result) > 0;
        }

        public int GetTotalCustomers()
        {
            string query = "SELECT COUNT(*) FROM KhachHang";
            object? result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}
