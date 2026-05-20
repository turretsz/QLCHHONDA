using System;
using System.Data;

namespace honda.DAL
{
    public class PhuTungDAL
    {
        private static PhuTungDAL? instance;
        public static PhuTungDAL Instance
        {
            get { if (instance == null) instance = new PhuTungDAL(); return instance; }
            private set { instance = value; }
        }

        private PhuTungDAL() { }

        public DataTable GetListPhuTung()
        {
            string query = "SELECT MaPhuTung, TenPhuTung, GiaBan, SoLuongTon FROM PhuTung ORDER BY TenPhuTung";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Kiểm tra tên phụ tùng đã tồn tại chưa.
        /// excludeId: truyền -1 khi thêm mới, truyền MaPhuTung khi cập nhật (bỏ qua chính nó).
        /// </summary>
        public bool IsTenPhuTungExists(string name, int excludeId)
        {
            string query = excludeId == -1
                ? "SELECT COUNT(*) FROM PhuTung WHERE LOWER(TenPhuTung) = LOWER( @name )"
                : "SELECT COUNT(*) FROM PhuTung WHERE LOWER(TenPhuTung) = LOWER( @name ) AND MaPhuTung <> @excludeId";

            object[]? parameters = excludeId == -1
                ? new object[] { name }
                : new object[] { name, excludeId };

            object? result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }

        public bool AddPhuTung(string name, decimal price, int stock)
        {
            string query = "INSERT INTO PhuTung (TenPhuTung, GiaBan, SoLuongTon) VALUES ( @name , @price , @stock )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, stock }) > 0;
        }

        public bool UpdatePhuTung(int id, string name, decimal price, int stock)
        {
            string query = "UPDATE PhuTung SET TenPhuTung = @name , GiaBan = @price , SoLuongTon = @stock WHERE MaPhuTung = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, stock, id }) > 0;
        }

        public bool DeletePhuTung(int id)
        {
            string query = "DELETE FROM PhuTung WHERE MaPhuTung = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }
    }
}
