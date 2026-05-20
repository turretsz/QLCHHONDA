namespace honda.GUI
{
    partial class frmDashboard
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
            groupBoxFilter = new GroupBox();
            btnSearch = new Button();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            tableLayoutPanelCards = new TableLayoutPanel();
            panelRevenue = new Panel();
            lblRevenueHeader = new Label();
            lblTotalRevenue = new Label();
            panelSales = new Panel();
            lblSalesHeader = new Label();
            lblSalesCount = new Label();
            panelInventory = new Panel();
            lblInventoryHeader = new Label();
            lblInventoryCount = new Label();
            panelServiceRevenue = new Panel();
            lblServiceHeader = new Label();
            lblServiceRevenue = new Label();
            panelCustomers = new Panel();
            lblCustomersHeader = new Label();
            lblCustomersCount = new Label();
            tabControl1 = new TabControl();
            tabModels = new TabPage();
            dgvSales = new DataGridView();
            tabTime = new TabPage();
            dgvRevenue = new DataGridView();
            tabLowStock = new TabPage();
            dgvLowStock = new DataGridView();
            groupBoxFilter.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            panelRevenue.SuspendLayout();
            panelSales.SuspendLayout();
            panelInventory.SuspendLayout();
            panelServiceRevenue.SuspendLayout();
            panelCustomers.SuspendLayout();
            tabControl1.SuspendLayout();
            tabModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            tabTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            tabLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(btnSearch);
            groupBoxFilter.Controls.Add(dtpTo);
            groupBoxFilter.Controls.Add(lblTo);
            groupBoxFilter.Controls.Add(dtpFrom);
            groupBoxFilter.Controls.Add(lblFrom);
            groupBoxFilter.Font = new Font("Segoe UI", 11F);
            groupBoxFilter.ForeColor = Color.FromArgb(44, 62, 80);
            groupBoxFilter.Location = new Point(20, 15);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(1031, 120);
            groupBoxFilter.TabIndex = 2;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Bộ lọc thời gian";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(796, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(215, 47);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Lọc thống kê";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(541, 49);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(188, 47);
            dtpTo.TabIndex = 1;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTo.Location = new Point(376, 49);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(159, 41);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(172, 49);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(198, 47);
            dtpFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFrom.Location = new Point(25, 49);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(141, 41);
            lblFrom.TabIndex = 4;
            lblFrom.Text = "Từ ngày:";
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCards.ColumnCount = 5;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelCards.Controls.Add(panelRevenue, 0, 0);
            tableLayoutPanelCards.Controls.Add(panelSales, 1, 0);
            tableLayoutPanelCards.Controls.Add(panelInventory, 2, 0);
            tableLayoutPanelCards.Controls.Add(panelServiceRevenue, 3, 0);
            tableLayoutPanelCards.Controls.Add(panelCustomers, 4, 0);
            tableLayoutPanelCards.Location = new Point(20, 141);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowCount = 1;
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCards.Size = new Size(1031, 130);
            tableLayoutPanelCards.TabIndex = 3;
            // 
            // panelRevenue
            // 
            panelRevenue.BackColor = Color.FromArgb(235, 245, 251);
            panelRevenue.Controls.Add(lblRevenueHeader);
            panelRevenue.Controls.Add(lblTotalRevenue);
            panelRevenue.Dock = DockStyle.Fill;
            panelRevenue.Location = new Point(3, 3);
            panelRevenue.Margin = new Padding(3, 3, 10, 3);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.Size = new Size(193, 124);
            panelRevenue.TabIndex = 0;
            // 
            // lblRevenueHeader
            // 
            lblRevenueHeader.AutoSize = true;
            lblRevenueHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRevenueHeader.ForeColor = Color.FromArgb(127, 140, 141);
            lblRevenueHeader.Location = new Point(12, 16);
            lblRevenueHeader.Name = "lblRevenueHeader";
            lblRevenueHeader.Size = new Size(287, 37);
            lblRevenueHeader.TabIndex = 0;
            lblRevenueHeader.Text = "DOANH THU XE MÁY";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalRevenue.Location = new Point(12, 50);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(174, 65);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "0 VNĐ";
            // 
            // panelSales
            // 
            panelSales.BackColor = Color.FromArgb(254, 249, 231);
            panelSales.Controls.Add(lblSalesHeader);
            panelSales.Controls.Add(lblSalesCount);
            panelSales.Dock = DockStyle.Fill;
            panelSales.Location = new Point(209, 3);
            panelSales.Margin = new Padding(3, 3, 10, 3);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(193, 124);
            panelSales.TabIndex = 1;
            // 
            // lblSalesHeader
            // 
            lblSalesHeader.AutoSize = true;
            lblSalesHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalesHeader.ForeColor = Color.FromArgb(127, 140, 141);
            lblSalesHeader.Location = new Point(12, 16);
            lblSalesHeader.Name = "lblSalesHeader";
            lblSalesHeader.Size = new Size(282, 37);
            lblSalesHeader.TabIndex = 0;
            lblSalesHeader.Text = "XE ĐÃ BÁN (THÁNG)";
            // 
            // lblSalesCount
            // 
            lblSalesCount.AutoSize = true;
            lblSalesCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSalesCount.ForeColor = Color.FromArgb(230, 126, 34);
            lblSalesCount.Location = new Point(12, 50);
            lblSalesCount.Name = "lblSalesCount";
            lblSalesCount.Size = new Size(56, 65);
            lblSalesCount.TabIndex = 1;
            lblSalesCount.Text = "0";
            // 
            // panelInventory
            // 
            panelInventory.BackColor = Color.FromArgb(234, 250, 241);
            panelInventory.Controls.Add(lblInventoryHeader);
            panelInventory.Controls.Add(lblInventoryCount);
            panelInventory.Dock = DockStyle.Fill;
            panelInventory.Location = new Point(415, 3);
            panelInventory.Margin = new Padding(3, 3, 10, 3);
            panelInventory.Name = "panelInventory";
            panelInventory.Size = new Size(193, 124);
            panelInventory.TabIndex = 2;
            // 
            // lblInventoryHeader
            // 
            lblInventoryHeader.AutoSize = true;
            lblInventoryHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInventoryHeader.ForeColor = Color.FromArgb(127, 140, 141);
            lblInventoryHeader.Location = new Point(12, 16);
            lblInventoryHeader.Name = "lblInventoryHeader";
            lblInventoryHeader.Size = new Size(179, 37);
            lblInventoryHeader.TabIndex = 0;
            lblInventoryHeader.Text = "XE TỒN KHO";
            // 
            // lblInventoryCount
            // 
            lblInventoryCount.AutoSize = true;
            lblInventoryCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInventoryCount.ForeColor = Color.FromArgb(39, 174, 96);
            lblInventoryCount.Location = new Point(12, 50);
            lblInventoryCount.Name = "lblInventoryCount";
            lblInventoryCount.Size = new Size(56, 65);
            lblInventoryCount.TabIndex = 1;
            lblInventoryCount.Text = "0";
            // 
            // panelServiceRevenue
            // 
            panelServiceRevenue.BackColor = Color.FromArgb(244, 236, 247);
            panelServiceRevenue.Controls.Add(lblServiceHeader);
            panelServiceRevenue.Controls.Add(lblServiceRevenue);
            panelServiceRevenue.Dock = DockStyle.Fill;
            panelServiceRevenue.Location = new Point(621, 3);
            panelServiceRevenue.Margin = new Padding(3, 3, 10, 3);
            panelServiceRevenue.Name = "panelServiceRevenue";
            panelServiceRevenue.Size = new Size(193, 124);
            panelServiceRevenue.TabIndex = 3;
            // 
            // lblServiceHeader
            // 
            lblServiceHeader.AutoSize = true;
            lblServiceHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblServiceHeader.ForeColor = Color.FromArgb(127, 140, 141);
            lblServiceHeader.Location = new Point(12, 16);
            lblServiceHeader.Name = "lblServiceHeader";
            lblServiceHeader.Size = new Size(301, 37);
            lblServiceHeader.TabIndex = 0;
            lblServiceHeader.Text = "DOANH THU DỊCH VỤ";
            // 
            // lblServiceRevenue
            // 
            lblServiceRevenue.AutoSize = true;
            lblServiceRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblServiceRevenue.ForeColor = Color.FromArgb(155, 89, 182);
            lblServiceRevenue.Location = new Point(12, 50);
            lblServiceRevenue.Name = "lblServiceRevenue";
            lblServiceRevenue.Size = new Size(174, 65);
            lblServiceRevenue.TabIndex = 1;
            lblServiceRevenue.Text = "0 VNĐ";
            // 
            // panelCustomers
            // 
            panelCustomers.BackColor = Color.FromArgb(253, 242, 233);
            panelCustomers.Controls.Add(lblCustomersHeader);
            panelCustomers.Controls.Add(lblCustomersCount);
            panelCustomers.Dock = DockStyle.Fill;
            panelCustomers.Location = new Point(827, 3);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(201, 124);
            panelCustomers.TabIndex = 4;
            // 
            // lblCustomersHeader
            // 
            lblCustomersHeader.AutoSize = true;
            lblCustomersHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomersHeader.ForeColor = Color.FromArgb(127, 140, 141);
            lblCustomersHeader.Location = new Point(12, 16);
            lblCustomersHeader.Name = "lblCustomersHeader";
            lblCustomersHeader.Size = new Size(200, 37);
            lblCustomersHeader.TabIndex = 0;
            lblCustomersHeader.Text = "KHÁCH HÀNG";
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCustomersCount.ForeColor = Color.FromArgb(211, 84, 0);
            lblCustomersCount.Location = new Point(12, 50);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new Size(56, 65);
            lblCustomersCount.TabIndex = 1;
            lblCustomersCount.Text = "0";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabModels);
            tabControl1.Controls.Add(tabTime);
            tabControl1.Controls.Add(tabLowStock);
            tabControl1.Font = new Font("Segoe UI", 11F);
            tabControl1.Location = new Point(20, 277);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1031, 398);
            tabControl1.TabIndex = 0;
            // 
            // tabModels
            // 
            tabModels.BackColor = Color.White;
            tabModels.Controls.Add(dgvSales);
            tabModels.Location = new Point(8, 54);
            tabModels.Name = "tabModels";
            tabModels.Size = new Size(1015, 336);
            tabModels.TabIndex = 0;
            tabModels.Text = "1. Thống kê theo dòng xe";
            // 
            // dgvSales
            // 
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.ColumnHeadersHeight = 35;
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(0, 0);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 82;
            dgvSales.Size = new Size(1015, 336);
            dgvSales.TabIndex = 0;
            // 
            // tabTime
            // 
            tabTime.BackColor = Color.White;
            tabTime.Controls.Add(dgvRevenue);
            tabTime.Location = new Point(8, 54);
            tabTime.Name = "tabTime";
            tabTime.Size = new Size(1015, 312);
            tabTime.TabIndex = 1;
            tabTime.Text = "2. Thống kê theo thời gian";
            // 
            // dgvRevenue
            // 
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.BorderStyle = BorderStyle.None;
            dgvRevenue.ColumnHeadersHeight = 35;
            dgvRevenue.Dock = DockStyle.Fill;
            dgvRevenue.Location = new Point(0, 0);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.RowHeadersWidth = 82;
            dgvRevenue.Size = new Size(1015, 312);
            dgvRevenue.TabIndex = 0;
            // 
            // tabLowStock
            // 
            tabLowStock.BackColor = Color.White;
            tabLowStock.Controls.Add(dgvLowStock);
            tabLowStock.Location = new Point(8, 54);
            tabLowStock.Name = "tabLowStock";
            tabLowStock.Size = new Size(1015, 312);
            tabLowStock.TabIndex = 2;
            tabLowStock.Text = "3. Cảnh báo phụ tùng sắp hết";
            // 
            // dgvLowStock
            // 
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.BorderStyle = BorderStyle.None;
            dgvLowStock.ColumnHeadersHeight = 35;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(0, 0);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersWidth = 82;
            dgvLowStock.Size = new Size(1015, 312);
            dgvLowStock.TabIndex = 0;
            // 
            // frmDashboard
            // 
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1071, 690);
            Controls.Add(tabControl1);
            Controls.Add(tableLayoutPanelCards);
            Controls.Add(groupBoxFilter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Load += frmDashboard_Load;
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            tableLayoutPanelCards.ResumeLayout(false);
            panelRevenue.ResumeLayout(false);
            panelRevenue.PerformLayout();
            panelSales.ResumeLayout(false);
            panelSales.PerformLayout();
            panelInventory.ResumeLayout(false);
            panelInventory.PerformLayout();
            panelServiceRevenue.ResumeLayout(false);
            panelServiceRevenue.PerformLayout();
            panelCustomers.ResumeLayout(false);
            panelCustomers.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabModels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            tabTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            tabLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private System.Windows.Forms.Panel panelRevenue;
        private System.Windows.Forms.Label lblRevenueHeader;
        private System.Windows.Forms.Label lblTotalRevenue;
        
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Label lblSalesHeader;
        private System.Windows.Forms.Label lblSalesCount;
        
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Label lblInventoryHeader;
        private System.Windows.Forms.Label lblInventoryCount;

        private System.Windows.Forms.Panel panelServiceRevenue;
        private System.Windows.Forms.Label lblServiceHeader;
        private System.Windows.Forms.Label lblServiceRevenue;

        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label lblCustomersHeader;
        private System.Windows.Forms.Label lblCustomersCount;
        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabModels;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TabPage tabTime;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.TabPage tabLowStock;
        private System.Windows.Forms.DataGridView dgvLowStock;
    }
}
