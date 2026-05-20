using System;
using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS? instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            private set { instance = value; }
        }

        private HoaDonBUS() { }

        public DataTable GetAllHoaDon()
        {
            return InvoiceDAL.Instance.GetAllHoaDon();
        }

        public decimal TinhTongTien(decimal giaBan, decimal vatPercent, decimal phiTruocBa)
        {
            return giaBan * (1m + vatPercent / 100m) + phiTruocBa;
        }

        public bool AddHoaDon(int maXe, int maKH, string username, decimal vat, decimal phiTruocBa, decimal tongTien)
        {
            if (maXe <= 0 || maKH <= 0)
                return false;

            return InvoiceDAL.Instance.AddHoaDon(maXe, maKH, username, vat, phiTruocBa, tongTien);
        }

        public bool DeleteHoaDon(int id)
        {
            return InvoiceDAL.Instance.DeleteHoaDon(id);
        }
    }
}
