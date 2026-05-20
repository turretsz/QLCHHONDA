using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class CarBUS
    {
        private static CarBUS? instance;
        public static CarBUS Instance
        {
            get { if (instance == null) instance = new CarBUS(); return instance; }
            private set { instance = value; }
        }

        private CarBUS() { }

        public DataTable GetAllCars(string filter)
        {
            return CarDAL.Instance.GetAllCars(filter);
        }

        public DataTable GetAvailableCars()
        {
            return CarDAL.Instance.GetAvailableCars();
        }

        public bool IsSoKhungExists(string soKhung, int excludeId)
        {
            return CarDAL.Instance.IsSoKhungExists(soKhung, excludeId);
        }

        public bool IsSoMayExists(string soMay, int excludeId)
        {
            return CarDAL.Instance.IsSoMayExists(soMay, excludeId);
        }

        public bool AddCar(string tenXe, string loaiXe, string soKhung, string soMay, decimal giaNhap, decimal giaBan, string mauSac)
        {
            if (string.IsNullOrWhiteSpace(tenXe) ||
                string.IsNullOrWhiteSpace(loaiXe) ||
                string.IsNullOrWhiteSpace(soKhung) ||
                string.IsNullOrWhiteSpace(soMay) ||
                string.IsNullOrWhiteSpace(mauSac))
                return false;

            if (giaNhap < 0 || giaBan < 0)
                return false;

            return CarDAL.Instance.AddCar(tenXe.Trim(), loaiXe.Trim(), soKhung.Trim(), soMay.Trim(), giaNhap, giaBan, mauSac.Trim());
        }

        public bool UpdateCar(int id, string tenXe, string loaiXe, string soKhung, string soMay, decimal giaNhap, decimal giaBan, string mauSac)
        {
            if (string.IsNullOrWhiteSpace(tenXe) ||
                string.IsNullOrWhiteSpace(loaiXe) ||
                string.IsNullOrWhiteSpace(soKhung) ||
                string.IsNullOrWhiteSpace(soMay) ||
                string.IsNullOrWhiteSpace(mauSac))
                return false;

            if (giaNhap < 0 || giaBan < 0)
                return false;

            return CarDAL.Instance.UpdateCar(id, tenXe.Trim(), loaiXe.Trim(), soKhung.Trim(), soMay.Trim(), giaNhap, giaBan, mauSac.Trim());
        }

        public bool DeleteCar(int id)
        {
            return CarDAL.Instance.DeleteCar(id);
        }
    }
}
