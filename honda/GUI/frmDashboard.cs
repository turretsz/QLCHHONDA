using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            // Thiết lập mặc định: Lọc dữ liệu trong 7 ngày gần nhất
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now.AddDays(-7);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvSales);
            StyleDataGridView(dgvRevenue);
            StyleDataGridView(dgvLowStock);
            LoadData();
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Header style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); // Xanh dương hiện đại
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            // Row style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 251); // Màu chọn nhẹ nhàng
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);

            // Alternating row color
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 249);

            dgv.RowHeadersVisible = false; // Ẩn cột thừa bên trái
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
        }

        private void LoadData()
        {
            try
            {
                // 1. Cập nhật các nhãn tổng quát dạng Card
                lblTotalRevenue.Text = DashboardBUS.Instance.GetTotalRevenueBanXe().ToString("N0") + " VNĐ";
                lblServiceRevenue.Text = DashboardBUS.Instance.GetTotalRevenueDichVu().ToString("N0") + " VNĐ";
                lblCustomersCount.Text = DashboardBUS.Instance.GetTotalCustomers().ToString() + " người";
                lblSalesCount.Text = DashboardBUS.Instance.GetMonthlySales(DateTime.Now.Month, DateTime.Now.Year).ToString() + " xe";
                lblInventoryCount.Text = DashboardBUS.Instance.GetInventory().ToString() + " xe";

                // 2. Nạp bảng Doanh số theo Dòng xe (Bảng 1)
                dgvSales.DataSource = DashboardBUS.Instance.GetSalesByModel();
                if (dgvSales.Columns.Count >= 3)
                {
                    dgvSales.Columns[0].HeaderText = "Dòng xe Honda";
                    dgvSales.Columns[1].HeaderText = "Số lượng bán";
                    dgvSales.Columns[2].HeaderText = "Doanh thu xe (VNĐ)";
                    dgvSales.Columns[2].DefaultCellStyle.Format = "N0";
                }

                // 3. Nạp bảng Doanh thu theo Thời gian (Bảng 2) - Đã lọc theo ngày
                dgvRevenue.DataSource = DashboardBUS.Instance.GetRevenueTrend(dtpFrom.Value, dtpTo.Value);
                if (dgvRevenue.Columns.Count >= 4)
                {
                    dgvRevenue.Columns[0].HeaderText = "Ngày";
                    dgvRevenue.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvRevenue.Columns[1].HeaderText = "Doanh thu Bán xe (VNĐ)";
                    dgvRevenue.Columns[1].DefaultCellStyle.Format = "N0";
                    dgvRevenue.Columns[2].HeaderText = "Doanh thu Dịch vụ (VNĐ)";
                    dgvRevenue.Columns[2].DefaultCellStyle.Format = "N0";
                    dgvRevenue.Columns[3].HeaderText = "Tổng doanh thu (VNĐ)";
                    dgvRevenue.Columns[3].DefaultCellStyle.Format = "N0";
                }

                // 4. Nạp bảng Cảnh báo phụ tùng sắp hết hàng (Bảng 3)
                dgvLowStock.DataSource = DashboardBUS.Instance.GetLowStockParts();
                if (dgvLowStock.Columns.Count >= 2)
                {
                    dgvLowStock.Columns[0].HeaderText = "Tên phụ tùng";
                    dgvLowStock.Columns[1].HeaderText = "Số lượng tồn";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tải lại dữ liệu khi nhấn nút Thống kê
            LoadData();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
