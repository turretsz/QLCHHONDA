using System;
using System.Windows.Forms;

namespace honda.GUI
{
    public partial class frmMain : Form
    {
        private string userRole;
        private string username;
        private System.Windows.Forms.Timer timerClock;

        public frmMain(string role, string username = "admin")
        {
            InitializeComponent();
            this.userRole = role;
            this.username = username;
            
            // Tự động phóng to toàn màn hình và bật thanh cuộn nếu màn hình quá nhỏ
            // this.WindowState = FormWindowState.Maximized;
            this.pnlContent.AutoScroll = true;
            
            // Đăng ký sự kiện Load để hiển thị form mặc định
            this.Load += frmMain_Load;
            
            // Khởi tạo đồng hồ
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000; // 1 giây
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        private void frmMain_Load(object? sender, EventArgs e)
        {
            ApplyPermissions();

            // Load màn hình mặc định
            if (userRole == "Admin")
            {
                btnDashboard_Click(this, EventArgs.Empty);
            }
            else
            {
                btnBanHang_Click(this, EventArgs.Empty); // Nhân viên mặc định vào form lập hóa đơn bán hàng
            }
        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblStatus.Text = "Hệ thống: Sẵn sàng | Nhân viên: " + username + " | Quyền: " + userRole + " | Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ApplyPermissions()
        {
            if (userRole == "Staff")
            {
                // Ẩn hoàn toàn menu Thống kê & Quản lý kho xe
                btnDashboardMenu.Visible = false;
                quảnLýKhoXeToolStripMenuItem.Visible = false;
                
                MessageBox.Show("Chào " + username + ". Bạn đang đăng nhập với quyền Nhân viên bán hàng. Chức năng Thống kê & Quản lý kho xe đã được ẩn theo quyền truy cập.", "Thông báo phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDashboard_Click(object? sender, EventArgs e)
        {
            if (userRole != "Admin") return;

            frmDashboard dash = new frmDashboard();
            dash.TopLevel = false;
            dash.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(dash);
            dash.Show();
        }

        private void btnKhoXe_Click(object? sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmCar car = new frmCar(userRole);
            car.TopLevel = false;
            car.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(car);
            car.Show();
        }

        private void btnKhachHang_Click(object? sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang(userRole);
            kh.TopLevel = false;
            kh.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(kh);
            kh.Show();
        }

        private void btnBanHang_Click(object? sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon(userRole, username);
            hd.TopLevel = false;
            hd.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hd);
            hd.Show();
        }

        private void btnDichVu_Click(object? sender, EventArgs e)
        {
            frmService service = new frmService(userRole);
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(service);
            service.Show();
        }

        private void btnExitMenu_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
