using System;
using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class PhuTungBUS
    {
        private static PhuTungBUS? instance;
        public static PhuTungBUS Instance
        {
            get { if (instance == null) instance = new PhuTungBUS(); return instance; }
            private set { instance = value; }
        }

        private PhuTungBUS() { }

        public DataTable GetListPhuTung() => PhuTungDAL.Instance.GetListPhuTung();

        /// <summary>
        /// Kiểm tra tên phụ tùng đã tồn tại chưa.
        /// excludeId = -1 khi thêm mới, = MaPhuTung khi cập nhật.
        /// </summary>
        public bool IsTenPhuTungExists(string name, int excludeId) =>
            PhuTungDAL.Instance.IsTenPhuTungExists(name, excludeId);

        public bool AddPhuTung(string name, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name) || price < 0 || stock < 0) return false;
            return PhuTungDAL.Instance.AddPhuTung(name, price, stock);
        }

        public bool UpdatePhuTung(int id, string name, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name) || price < 0 || stock < 0) return false;
            return PhuTungDAL.Instance.UpdatePhuTung(id, name, price, stock);
        }

        public bool DeletePhuTung(int id) => PhuTungDAL.Instance.DeletePhuTung(id);
    }
}
