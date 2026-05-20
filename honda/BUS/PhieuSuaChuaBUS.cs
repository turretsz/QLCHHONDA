using System;
using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class PhieuSuaChuaBUS
    {
        private static PhieuSuaChuaBUS? instance;
        public static PhieuSuaChuaBUS Instance
        {
            get { if (instance == null) instance = new PhieuSuaChuaBUS(); return instance; }
            private set { instance = value; }
        }

        private PhieuSuaChuaBUS() { }

        public DataTable GetListPhieuSuaChua() => PhieuSuaChuaDAL.Instance.GetListPhieuSuaChua();

        public bool IsBienSoTodayExists(string bienSo) =>
            PhieuSuaChuaDAL.Instance.IsBienSoTodayExists(bienSo);

        public bool AddPhieuSuaChua(string bienSo, string noiDung, decimal tongTien, int maPhuTung)
        {
            if (string.IsNullOrWhiteSpace(bienSo)) return false;
            if (string.IsNullOrWhiteSpace(noiDung)) return false;
            if (tongTien < 0) return false;
            return PhieuSuaChuaDAL.Instance.AddPhieuSuaChua(bienSo, noiDung, tongTien, maPhuTung);
        }

        public bool DeletePhieuSuaChua(int id) => PhieuSuaChuaDAL.Instance.DeletePhieuSuaChua(id);

        public decimal GetTotalRevenueDichVu() => PhieuSuaChuaDAL.Instance.GetTotalRevenueDichVu();
    }
}
