using System.Data;

namespace honda.DAL
{
    public class CarDAL
    {
        private static CarDAL? instance;
        public static CarDAL Instance
        {
            get { if (instance == null) instance = new CarDAL(); return instance; }
            private set { instance = value; }
        }

        private CarDAL() { }

        public int GetInventoryCount()
        {
            string query = "SELECT COUNT(*) FROM Xe WHERE TrangThai = N'Chưa bán'";
            object? result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetSalesByModel()
        {
            string query = "SELECT x.LoaiXe, COUNT(hd.MaHD) AS SalesCount, CAST(ISNULL(SUM(hd.TongTien), 0) AS DECIMAL(18,2)) AS Revenue FROM Xe x JOIN HoaDon hd ON x.MaXe = hd.MaXe GROUP BY x.LoaiXe";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllCars(string filter)
        {
            if (filter == "Tất cả")
            {
                string query = "SELECT MaXe,TenXe,LoaiXe,SoKhung,SoMay,GiaNhap,GiaBan,MauSac,TrangThai FROM Xe ORDER BY MaXe DESC";
                return DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                string query = "SELECT MaXe,TenXe,LoaiXe,SoKhung,SoMay,GiaNhap,GiaBan,MauSac,TrangThai FROM Xe WHERE TrangThai = @filter ORDER BY MaXe DESC";
                return DataProvider.Instance.ExecuteQuery(query, new object[] { filter });
            }
        }

        public DataTable GetAvailableCars()
        {
            string query = "SELECT MaXe, TenXe, LoaiXe, GiaBan FROM Xe WHERE TrangThai = N'Chưa bán' ORDER BY TenXe";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddCar(string tenXe, string loaiXe, string soKhung, string soMay, decimal giaNhap, decimal giaBan, string mauSac)
        {
            string query = "INSERT INTO Xe (TenXe,LoaiXe,SoKhung,SoMay,GiaNhap,GiaBan,MauSac,TrangThai) VALUES ( @tenXe , @loaiXe , @soKhung , @soMay , @giaNhap , @giaBan , @mauSac , N'Chưa bán' )";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenXe, loaiXe, soKhung, soMay, giaNhap, giaBan, mauSac });
            return rows > 0;
        }

        public bool UpdateCar(int id, string tenXe, string loaiXe, string soKhung, string soMay, decimal giaNhap, decimal giaBan, string mauSac)
        {
            string query = "UPDATE Xe SET TenXe = @tenXe , LoaiXe = @loaiXe , SoKhung = @soKhung , SoMay = @soMay , GiaNhap = @giaNhap , GiaBan = @giaBan , MauSac = @mauSac WHERE MaXe = @id AND TrangThai = N'Chưa bán'";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenXe, loaiXe, soKhung, soMay, giaNhap, giaBan, mauSac, id });
            return rows > 0;
        }

        public bool DeleteCar(int id)
        {
            string query = "DELETE FROM Xe WHERE MaXe = @id AND TrangThai = N'Chưa bán'";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return rows > 0;
        }

        public bool IsSoKhungExists(string soKhung, int excludeId)
        {
            string query;
            object? result;
            if (excludeId == -1)
            {
                query = "SELECT COUNT(*) FROM Xe WHERE SoKhung = @soKhung";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { soKhung });
            }
            else
            {
                query = "SELECT COUNT(*) FROM Xe WHERE SoKhung = @soKhung AND MaXe <> @excludeId";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { soKhung, excludeId });
            }
            return result != null && Convert.ToInt32(result) > 0;
        }

        public bool IsSoMayExists(string soMay, int excludeId)
        {
            string query;
            object? result;
            if (excludeId == -1)
            {
                query = "SELECT COUNT(*) FROM Xe WHERE SoMay = @soMay";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { soMay });
            }
            else
            {
                query = "SELECT COUNT(*) FROM Xe WHERE SoMay = @soMay AND MaXe <> @excludeId";
                result = DataProvider.Instance.ExecuteScalar(query, new object[] { soMay, excludeId });
            }
            return result != null && Convert.ToInt32(result) > 0;
        }
    }
}
