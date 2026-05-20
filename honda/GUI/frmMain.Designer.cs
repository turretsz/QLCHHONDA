namespace honda.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            btnDashboardMenu = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoXeToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            bảoDưỡngDịchVụToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2346, 40);
            menuStrip1.TabIndex = 2;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(135, 36);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(256, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += btnLogout_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(256, 44);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += btnExitMenu_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnDashboardMenu, bánHàngToolStripMenuItem, quảnLýKhoXeToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, bảoDưỡngDịchVụToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(146, 36);
            quảnLýToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // btnDashboardMenu
            // 
            btnDashboardMenu.Name = "btnDashboardMenu";
            btnDashboardMenu.Size = new Size(384, 44);
            btnDashboardMenu.Text = "Thống kê (Dashboard)";
            btnDashboardMenu.Click += btnDashboard_Click;
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(384, 44);
            bánHàngToolStripMenuItem.Text = "Quản lý bán hàng";
            bánHàngToolStripMenuItem.Click += btnBanHang_Click;
            // 
            // quảnLýKhoXeToolStripMenuItem
            // 
            quảnLýKhoXeToolStripMenuItem.Name = "quảnLýKhoXeToolStripMenuItem";
            quảnLýKhoXeToolStripMenuItem.Size = new Size(384, 44);
            quảnLýKhoXeToolStripMenuItem.Text = "Quản lý kho xe";
            quảnLýKhoXeToolStripMenuItem.Click += btnKhoXe_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(384, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += btnKhachHang_Click;
            // 
            // bảoDưỡngDịchVụToolStripMenuItem
            // 
            bảoDưỡngDịchVụToolStripMenuItem.Name = "bảoDưỡngDịchVụToolStripMenuItem";
            bảoDưỡngDịchVụToolStripMenuItem.Size = new Size(384, 44);
            bảoDưỡngDịchVụToolStripMenuItem.Text = "Bảo dưỡng & Dịch vụ";
            bảoDưỡngDịchVụToolStripMenuItem.Click += btnDichVu_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(20, 36);
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 40);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(2346, 902);
            pnlContent.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 942);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2346, 42);
            statusStrip1.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 32);
            lblStatus.Text = "Sẵn sàng";
            // 
            // frmMain
            // 
            ClientSize = new Size(2346, 984);
            Controls.Add(pnlContent);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý Honda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoDưỡngDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
