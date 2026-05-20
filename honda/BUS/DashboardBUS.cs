using System;
using System.Data;
using honda.DAL;

namespace honda.BUS
{
    public class DashboardBUS
    {
        private static DashboardBUS? instance;
        public static DashboardBUS Instance
        {
            get { if (instance == null) instance = new DashboardBUS(); return instance; }
            private set { instance = value; }
        }

        private DashboardBUS() { }

        public decimal GetTotalRevenue() => InvoiceDAL.Instance.GetTotalRevenue();
        public int GetMonthlySales(int m, int y) => InvoiceDAL.Instance.GetMonthlySalesCount(m, y);
        public int GetInventory() => CarDAL.Instance.GetInventoryCount();
        
        public DataTable GetSalesByModel() => CarDAL.Instance.GetSalesByModel();
        
        public DataTable GetRevenueTrend(DateTime from, DateTime to) 
        {
            return InvoiceDAL.Instance.GetRevenueByDay(from, to);
        }

        public decimal GetTotalRevenueBanXe() => InvoiceDAL.Instance.GetTotalRevenue();
        
        public decimal GetTotalRevenueDichVu() => PhieuSuaChuaDAL.Instance.GetTotalRevenueDichVu();

        public int GetTotalCustomers() => InvoiceDAL.Instance.GetTotalCustomers();

        public DataTable GetLowStockParts() => InvoiceDAL.Instance.GetLowStockParts();
    }
}
