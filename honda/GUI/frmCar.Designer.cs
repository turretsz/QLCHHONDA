namespace honda.GUI
{
    partial class frmCar
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
            groupBoxCarInput = new GroupBox();
            btnDeleteCar = new Button();
            btnSaveCar = new Button();
            txtMauSac = new TextBox();
            lblMauSac = new Label();
            txtGiaBan = new TextBox();
            lblGiaBan = new Label();
            txtGiaNhap = new TextBox();
            lblGiaNhap = new Label();
            txtSoMay = new TextBox();
            lblSoMay = new Label();
            txtSoKhung = new TextBox();
            lblSoKhung = new Label();
            cboLoaiXe = new ComboBox();
            lblLoaiXe = new Label();
            txtTenXe = new TextBox();
            lblTenXe = new Label();
            dgvCars = new DataGridView();
            cboFilter = new ComboBox();
            lblFilter = new Label();
            lblDanhSachXe = new Label();
            groupBoxCarInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCarInput
            // 
            groupBoxCarInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxCarInput.Controls.Add(btnDeleteCar);
            groupBoxCarInput.Controls.Add(btnSaveCar);
            groupBoxCarInput.Controls.Add(txtMauSac);
            groupBoxCarInput.Controls.Add(lblMauSac);
            groupBoxCarInput.Controls.Add(txtGiaBan);
            groupBoxCarInput.Controls.Add(lblGiaBan);
            groupBoxCarInput.Controls.Add(txtGiaNhap);
            groupBoxCarInput.Controls.Add(lblGiaNhap);
            groupBoxCarInput.Controls.Add(txtSoMay);
            groupBoxCarInput.Controls.Add(lblSoMay);
            groupBoxCarInput.Controls.Add(txtSoKhung);
            groupBoxCarInput.Controls.Add(lblSoKhung);
            groupBoxCarInput.Controls.Add(cboLoaiXe);
            groupBoxCarInput.Controls.Add(lblLoaiXe);
            groupBoxCarInput.Controls.Add(txtTenXe);
            groupBoxCarInput.Controls.Add(lblTenXe);
            groupBoxCarInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxCarInput.Location = new Point(28, 21);
            groupBoxCarInput.Margin = new Padding(6);
            groupBoxCarInput.Name = "groupBoxCarInput";
            groupBoxCarInput.Padding = new Padding(6);
            groupBoxCarInput.Size = new Size(650, 827);
            groupBoxCarInput.TabIndex = 0;
            groupBoxCarInput.TabStop = false;
            groupBoxCarInput.Text = "Thông tin xe";
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteCar.BackColor = Color.White;
            btnDeleteCar.Cursor = Cursors.Hand;
            btnDeleteCar.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteCar.FlatStyle = FlatStyle.Flat;
            btnDeleteCar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteCar.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteCar.Location = new Point(28, 734);
            btnDeleteCar.Margin = new Padding(6);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(572, 76);
            btnDeleteCar.TabIndex = 15;
            btnDeleteCar.Text = "Xóa xe";
            btnDeleteCar.UseVisualStyleBackColor = false;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnSaveCar
            // 
            btnSaveCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveCar.BackColor = Color.FromArgb(41, 128, 185);
            btnSaveCar.Cursor = Cursors.Hand;
            btnSaveCar.FlatAppearance.BorderSize = 0;
            btnSaveCar.FlatStyle = FlatStyle.Flat;
            btnSaveCar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveCar.ForeColor = Color.White;
            btnSaveCar.Location = new Point(28, 652);
            btnSaveCar.Margin = new Padding(6);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(572, 70);
            btnSaveCar.TabIndex = 14;
            btnSaveCar.Text = "Lưu";
            btnSaveCar.UseVisualStyleBackColor = false;
            btnSaveCar.Click += btnSaveCar_Click;
            // 
            // txtMauSac
            // 
            txtMauSac.Font = new Font("Segoe UI", 11F);
            txtMauSac.Location = new Point(28, 594);
            txtMauSac.Margin = new Padding(6);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(572, 47);
            txtMauSac.TabIndex = 13;
            // 
            // lblMauSac
            // 
            lblMauSac.AutoSize = true;
            lblMauSac.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMauSac.Location = new Point(28, 547);
            lblMauSac.Margin = new Padding(6, 0, 6, 0);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(140, 41);
            lblMauSac.TabIndex = 12;
            lblMauSac.Text = "Màu sắc:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 11F);
            txtGiaBan.Location = new Point(334, 494);
            txtGiaBan.Margin = new Padding(6);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(266, 47);
            txtGiaBan.TabIndex = 11;
            txtGiaBan.TextChanged += txtGiaBan_TextChanged;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGiaBan.Location = new Point(334, 447);
            lblGiaBan.Margin = new Padding(6, 0, 6, 0);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(133, 41);
            lblGiaBan.TabIndex = 10;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI", 11F);
            txtGiaNhap.Location = new Point(28, 494);
            txtGiaNhap.Margin = new Padding(6);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(266, 47);
            txtGiaNhap.TabIndex = 9;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.AutoSize = true;
            lblGiaNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGiaNhap.Location = new Point(28, 447);
            lblGiaNhap.Margin = new Padding(6, 0, 6, 0);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(151, 41);
            lblGiaNhap.TabIndex = 8;
            lblGiaNhap.Text = "Giá nhập:";
            lblGiaNhap.Click += lblGiaNhap_Click;
            // 
            // txtSoMay
            // 
            txtSoMay.Font = new Font("Segoe UI", 11F);
            txtSoMay.Location = new Point(28, 394);
            txtSoMay.Margin = new Padding(6);
            txtSoMay.Name = "txtSoMay";
            txtSoMay.Size = new Size(572, 47);
            txtSoMay.TabIndex = 7;
            txtSoMay.TextChanged += txtSoMay_TextChanged;
            // 
            // lblSoMay
            // 
            lblSoMay.AutoSize = true;
            lblSoMay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoMay.Location = new Point(28, 347);
            lblSoMay.Margin = new Padding(6, 0, 6, 0);
            lblSoMay.Name = "lblSoMay";
            lblSoMay.Size = new Size(128, 41);
            lblSoMay.TabIndex = 6;
            lblSoMay.Text = "Số máy:";
            // 
            // txtSoKhung
            // 
            txtSoKhung.Font = new Font("Segoe UI", 11F);
            txtSoKhung.Location = new Point(28, 294);
            txtSoKhung.Margin = new Padding(6);
            txtSoKhung.Name = "txtSoKhung";
            txtSoKhung.Size = new Size(572, 47);
            txtSoKhung.TabIndex = 5;
            // 
            // lblSoKhung
            // 
            lblSoKhung.AutoSize = true;
            lblSoKhung.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoKhung.Location = new Point(28, 247);
            lblSoKhung.Margin = new Padding(6, 0, 6, 0);
            lblSoKhung.Name = "lblSoKhung";
            lblSoKhung.Size = new Size(159, 41);
            lblSoKhung.TabIndex = 4;
            lblSoKhung.Text = "Số khung:";
            lblSoKhung.Click += lblSoKhung_Click;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiXe.Font = new Font("Segoe UI", 11F);
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Location = new Point(28, 193);
            cboLoaiXe.Margin = new Padding(6);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(572, 48);
            cboLoaiXe.TabIndex = 3;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLoaiXe.Location = new Point(28, 146);
            lblLoaiXe.Margin = new Padding(6, 0, 6, 0);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(143, 41);
            lblLoaiXe.TabIndex = 2;
            lblLoaiXe.Text = "Dòng xe:";
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 11F);
            txtTenXe.Location = new Point(28, 93);
            txtTenXe.Margin = new Padding(6);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(572, 47);
            txtTenXe.TabIndex = 1;
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTenXe.Location = new Point(32, 46);
            lblTenXe.Margin = new Padding(6, 0, 6, 0);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(115, 41);
            lblTenXe.TabIndex = 0;
            lblTenXe.Text = "Tên xe:";
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.ColumnHeadersHeight = 46;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCars.Location = new Point(706, 132);
            dgvCars.Margin = new Padding(6);
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidth = 82;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(901, 716);
            dgvCars.TabIndex = 4;
            dgvCars.CellClick += dgvCars_CellClick;
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.Font = new Font("Segoe UI", 11F);
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "Tất cả", "Chưa bán", "Đã bán" });
            cboFilter.Location = new Point(799, 72);
            cboFilter.Margin = new Padding(6);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(303, 48);
            cboFilter.TabIndex = 3;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFilter.Location = new Point(714, 67);
            lblFilter.Margin = new Padding(6, 0, 6, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(73, 41);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Lọc:";
            // 
            // lblDanhSachXe
            // 
            lblDanhSachXe.AutoSize = true;
            lblDanhSachXe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDanhSachXe.ForeColor = Color.FromArgb(44, 62, 80);
            lblDanhSachXe.Location = new Point(706, 21);
            lblDanhSachXe.Margin = new Padding(6, 0, 6, 0);
            lblDanhSachXe.Name = "lblDanhSachXe";
            lblDanhSachXe.Size = new Size(282, 45);
            lblDanhSachXe.TabIndex = 1;
            lblDanhSachXe.Text = "Danh sách kho xe";
            // 
            // frmCar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1634, 863);
            Controls.Add(dgvCars);
            Controls.Add(cboFilter);
            Controls.Add(lblFilter);
            Controls.Add(lblDanhSachXe);
            Controls.Add(groupBoxCarInput);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmCar";
            Text = "Quản lý kho xe";
            Load += frmCar_Load;
            groupBoxCarInput.ResumeLayout(false);
            groupBoxCarInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarInput;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtSoMay;
        private System.Windows.Forms.Label lblSoMay;
        private System.Windows.Forms.TextBox txtSoKhung;
        private System.Windows.Forms.Label lblSoKhung;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblDanhSachXe;
    }
}
