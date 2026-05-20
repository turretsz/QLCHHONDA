using System;
using System.Data;

namespace honda.DAL
{
    public class PhieuSuaChuaDAL
    {
        private static PhieuSuaChuaDAL? instance;
        public static PhieuSuaChuaDAL Instance
        {
            get { if (instance == null) instance = new PhieuSuaChuaDAL(); return instance; }
            private set { instance = value; }
        }

        private PhieuSuaChuaDAL() { }

        public DataTable GetListPhieuSuaChua()
        {
            // Select MaPhuTung as well so we can bind it if needed, or know which part is used
            string query = "SELECT MaPhieu, BienSo, NgayLap, NoiDung, TongTien, MaPhuTung FROM PhieuSuaChua ORDER BY NgayLap DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool IsBienSoTodayExists(string bienSo)
        {
            string query = "SELECT COUNT(*) FROM PhieuSuaChua WHERE UPPER(BienSo) = UPPER( @bienSo ) AND CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
            object? result = DataProvider.Instance.ExecuteScalar(query, new object[] { bienSo });
            return result != null && Convert.ToInt32(result) > 0;
        }

        public bool AddPhieuSuaChua(string bienSo, string noiDung, decimal tongTien, int maPhuTung)
        {
            string query = "INSERT INTO PhieuSuaChua (BienSo, NgayLap, NoiDung, TongTien, MaPhuTung) VALUES ( @bienSo , GETDATE() , @noiDung , @tongTien , @maPhuTung )";
            object paramMaPhuTung = maPhuTung == -1 ? (object)DBNull.Value : maPhuTung;
            
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { bienSo, noiDung, tongTien, paramMaPhuTung });
            
            if (rows > 0 && maPhuTung > 0)
            {
                // Deduct SoLuongTon by 1
                string updateStockQuery = "UPDATE PhuTung SET SoLuongTon = SoLuongTon - 1 WHERE MaPhuTung = @maPhuTung AND SoLuongTon > 0";
                DataProvider.Instance.ExecuteNonQuery(updateStockQuery, new object[] { maPhuTung });
            }

            return rows > 0;
        }

        public bool DeletePhieuSuaChua(int id)
        {
            // Get MaPhuTung from ticket before deleting to restore inventory
            string selectQuery = "SELECT MaPhuTung FROM PhieuSuaChua WHERE MaPhieu = @id";
            object? result = DataProvider.Instance.ExecuteScalar(selectQuery, new object[] { id });

            string deleteQuery = "DELETE FROM PhieuSuaChua WHERE MaPhieu = @id";
            int rows = DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { id });

            if (rows > 0 && result != null && result != DBNull.Value)
            {
                int maPhuTung = Convert.ToInt32(result);
                // Restore stock
                string updateStockQuery = "UPDATE PhuTung SET SoLuongTon = SoLuongTon + 1 WHERE MaPhuTung = @maPhuTung";
                DataProvider.Instance.ExecuteNonQuery(updateStockQuery, new object[] { maPhuTung });
            }

            return rows > 0;
        }

        public decimal GetTotalRevenueDichVu()
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM PhieuSuaChua";
            object? result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToDecimal(result) : 0;
        }
    }
}
