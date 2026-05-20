namespace honda.GUI
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxKHInput = new GroupBox();
            btnDeleteKH = new Button();
            btnSaveKH = new Button();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtTenKH = new TextBox();
            lblTenKH = new Label();
            lblDanhSachKH = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvKhachHang = new DataGridView();
            groupBoxKHInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBoxKHInput
            // 
            groupBoxKHInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxKHInput.Controls.Add(btnDeleteKH);
            groupBoxKHInput.Controls.Add(btnSaveKH);
            groupBoxKHInput.Controls.Add(txtCCCD);
            groupBoxKHInput.Controls.Add(lblCCCD);
            groupBoxKHInput.Controls.Add(txtDiaChi);
            groupBoxKHInput.Controls.Add(lblDiaChi);
            groupBoxKHInput.Controls.Add(txtSDT);
            groupBoxKHInput.Controls.Add(lblSDT);
            groupBoxKHInput.Controls.Add(txtTenKH);
            groupBoxKHInput.Controls.Add(lblTenKH);
            groupBoxKHInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxKHInput.Location = new Point(15, 10);
            groupBoxKHInput.Name = "groupBoxKHInput";
            groupBoxKHInput.Size = new Size(350, 560);
            groupBoxKHInput.TabIndex = 0;
            groupBoxKHInput.TabStop = false;
            groupBoxKHInput.Text = "Thông tin khách hàng";
            // 
            // btnDeleteKH
            // 
            btnDeleteKH.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteKH.BackColor = Color.White;
            btnDeleteKH.Cursor = Cursors.Hand;
            btnDeleteKH.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteKH.FlatStyle = FlatStyle.Flat;
            btnDeleteKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteKH.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteKH.Location = new Point(15, 495);
            btnDeleteKH.Name = "btnDeleteKH";
            btnDeleteKH.Size = new Size(310, 53);
            btnDeleteKH.TabIndex = 9;
            btnDeleteKH.Text = "Xóa khách hàng";
            btnDeleteKH.UseVisualStyleBackColor = false;
            btnDeleteKH.Click += btnDeleteKH_Click;
            // 
            // btnSaveKH
            // 
            btnSaveKH.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveKH.BackColor = Color.FromArgb(41, 128, 185);
            btnSaveKH.Cursor = Cursors.Hand;
            btnSaveKH.FlatAppearance.BorderSize = 0;
            btnSaveKH.FlatStyle = FlatStyle.Flat;
            btnSaveKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveKH.ForeColor = Color.White;
            btnSaveKH.Location = new Point(15, 446);
            btnSaveKH.Name = "btnSaveKH";
            btnSaveKH.Size = new Size(310, 43);
            btnSaveKH.TabIndex = 8;
            btnSaveKH.Text = "Lưu";
            btnSaveKH.UseVisualStyleBackColor = false;
            btnSaveKH.Click += btnSaveKH_Click;
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 11F);
            txtCCCD.Location = new Point(15, 393);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(310, 47);
            txtCCCD.TabIndex = 7;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(15, 349);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(103, 41);
            lblCCCD.TabIndex = 6;
            lblCCCD.Text = "CCCD:";
            lblCCCD.Click += lblCCCD_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 11F);
            txtDiaChi.Location = new Point(15, 276);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(310, 70);
            txtDiaChi.TabIndex = 5;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(15, 232);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(122, 41);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 11F);
            txtSDT.Location = new Point(15, 182);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(310, 47);
            txtSDT.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(15, 138);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(212, 41);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại:";
            lblSDT.Click += lblSDT_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 11F);
            txtTenKH.Location = new Point(15, 88);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(310, 47);
            txtTenKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(15, 40);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(171, 41);
            lblTenKH.TabIndex = 0;
            lblTenKH.Text = "Họ tên KH:";
            // 
            // lblDanhSachKH
            // 
            lblDanhSachKH.AutoSize = true;
            lblDanhSachKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDanhSachKH.ForeColor = Color.FromArgb(44, 62, 80);
            lblDanhSachKH.Location = new Point(380, 13);
            lblDanhSachKH.Name = "lblDanhSachKH";
            lblDanhSachKH.Size = new Size(331, 41);
            lblDanhSachKH.TabIndex = 1;
            lblDanhSachKH.Text = "Danh sách khách hàng";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(380, 54);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(303, 41);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm kiếm (tên/SĐT):";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(380, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(485, 47);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AllowUserToResizeRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeight = 46;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.Location = new Point(380, 151);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 82;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(674, 419);
            dgvKhachHang.TabIndex = 4;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1069, 579);
            Controls.Add(dgvKhachHang);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblDanhSachKH);
            Controls.Add(groupBoxKHInput);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKhachHang";
            Text = "Quản lý khách hàng";
            Load += frmKhachHang_Load;
            groupBoxKHInput.ResumeLayout(false);
            groupBoxKHInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKHInput;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnSaveKH;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblDanhSachKH;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvKhachHang;
    }
}
