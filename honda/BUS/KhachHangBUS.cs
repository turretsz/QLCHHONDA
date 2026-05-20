using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS? instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            private set { instance = value; }
        }

        private KhachHangBUS() { }

        public DataTable GetAllKhachHang()
        {
            return KhachHangDAL.Instance.GetAllKhachHang();
        }

        public DataTable SearchKhachHang(string keyword)
        {
            return KhachHangDAL.Instance.SearchKhachHang(keyword);
        }

        public int GetTotalCustomers()
        {
            return KhachHangDAL.Instance.GetTotalCustomers();
        }

        public bool IsSDTExists(string sdt, int excludeId)
        {
            return KhachHangDAL.Instance.IsSDTExists(sdt, excludeId);
        }

        public bool AddKhachHang(string tenKH, string sdt, string diaChi, string cccd)
        {
            if (string.IsNullOrWhiteSpace(tenKH))
                return false;

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
                return false;

            if (!string.IsNullOrEmpty(cccd) && !System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{12}$"))
                return false;

            return KhachHangDAL.Instance.AddKhachHang(tenKH.Trim(), sdt.Trim(), diaChi.Trim(), cccd.Trim());
        }

        public bool UpdateKhachHang(int id, string tenKH, string sdt, string diaChi, string cccd)
        {
            if (string.IsNullOrWhiteSpace(tenKH))
                return false;

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
                return false;

            if (!string.IsNullOrEmpty(cccd) && !System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{12}$"))
                return false;

            return KhachHangDAL.Instance.UpdateKhachHang(id, tenKH.Trim(), sdt.Trim(), diaChi.Trim(), cccd.Trim());
        }

        public bool DeleteKhachHang(int id)
        {
            return KhachHangDAL.Instance.DeleteKhachHang(id);
        }
    }
}
