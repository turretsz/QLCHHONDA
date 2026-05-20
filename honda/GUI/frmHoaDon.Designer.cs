namespace honda.GUI
{
    partial class frmHoaDon
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
            groupBoxHDInput = new GroupBox();
            btnDeleteHD = new Button();
            btnLapHD = new Button();
            lblTongTien = new Label();
            lblTongTienHeader = new Label();
            panelSeparator = new Panel();
            txtPhiTruocBa = new TextBox();
            lblPhiTruocBa = new Label();
            numVAT = new NumericUpDown();
            lblVAT = new Label();
            cboKH = new ComboBox();
            lblChonKH = new Label();
            lblGiaBanXe = new Label();
            cboXe = new ComboBox();
            lblChonXe = new Label();
            lblLichSuHD = new Label();
            dgvHoaDon = new DataGridView();
            groupBoxHDInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVAT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHDInput
            // 
            groupBoxHDInput.Controls.Add(btnDeleteHD);
            groupBoxHDInput.Controls.Add(btnLapHD);
            groupBoxHDInput.Controls.Add(lblTongTien);
            groupBoxHDInput.Controls.Add(lblTongTienHeader);
            groupBoxHDInput.Controls.Add(panelSeparator);
            groupBoxHDInput.Controls.Add(txtPhiTruocBa);
            groupBoxHDInput.Controls.Add(lblPhiTruocBa);
            groupBoxHDInput.Controls.Add(numVAT);
            groupBoxHDInput.Controls.Add(lblVAT);
            groupBoxHDInput.Controls.Add(cboKH);
            groupBoxHDInput.Controls.Add(lblChonKH);
            groupBoxHDInput.Controls.Add(lblGiaBanXe);
            groupBoxHDInput.Controls.Add(cboXe);
            groupBoxHDInput.Controls.Add(lblChonXe);
            groupBoxHDInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxHDInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxHDInput.Location = new Point(15, 10);
            groupBoxHDInput.Name = "groupBoxHDInput";
            groupBoxHDInput.Size = new Size(350, 691);
            groupBoxHDInput.TabIndex = 0;
            groupBoxHDInput.TabStop = false;
            groupBoxHDInput.Text = "Lập hóa đơn";
            groupBoxHDInput.Enter += groupBoxHDInput_Enter;
            // 
            // btnDeleteHD
            // 
            btnDeleteHD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteHD.BackColor = Color.White;
            btnDeleteHD.Cursor = Cursors.Hand;
            btnDeleteHD.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteHD.FlatStyle = FlatStyle.Flat;
            btnDeleteHD.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteHD.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteHD.Location = new Point(15, 627);
            btnDeleteHD.Name = "btnDeleteHD";
            btnDeleteHD.Size = new Size(310, 47);
            btnDeleteHD.TabIndex = 13;
            btnDeleteHD.Text = "Xóa hóa đơn";
            btnDeleteHD.UseVisualStyleBackColor = false;
            btnDeleteHD.Click += btnDeleteHD_Click;
            // 
            // btnLapHD
            // 
            btnLapHD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLapHD.BackColor = Color.FromArgb(41, 128, 185);
            btnLapHD.Cursor = Cursors.Hand;
            btnLapHD.FlatAppearance.BorderSize = 0;
            btnLapHD.FlatStyle = FlatStyle.Flat;
            btnLapHD.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLapHD.ForeColor = Color.White;
            btnLapHD.Location = new Point(15, 576);
            btnLapHD.Name = "btnLapHD";
            btnLapHD.Size = new Size(310, 45);
            btnLapHD.TabIndex = 12;
            btnLapHD.Text = "Lập hóa đơn";
            btnLapHD.UseVisualStyleBackColor = false;
            btnLapHD.Click += btnLapHD_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(41, 128, 185);
            lblTongTien.Location = new Point(18, 493);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(195, 72);
            lblTongTien.TabIndex = 11;
            lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienHeader
            // 
            lblTongTienHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongTienHeader.AutoSize = true;
            lblTongTienHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTienHeader.ForeColor = Color.FromArgb(100, 100, 100);
            lblTongTienHeader.Location = new Point(15, 452);
            lblTongTienHeader.Name = "lblTongTienHeader";
            lblTongTienHeader.Size = new Size(390, 41);
            lblTongTienHeader.TabIndex = 10;
            lblTongTienHeader.Text = "TỔNG TIỀN THANH TOÁN";
            // 
            // panelSeparator
            // 
            panelSeparator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparator.BackColor = Color.FromArgb(220, 220, 220);
            panelSeparator.Location = new Point(18, 568);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(310, 2);
            panelSeparator.TabIndex = 9;
            // 
            // txtPhiTruocBa
            // 
            txtPhiTruocBa.Font = new Font("Segoe UI", 11F);
            txtPhiTruocBa.Location = new Point(15, 402);
            txtPhiTruocBa.Name = "txtPhiTruocBa";
            txtPhiTruocBa.Size = new Size(310, 47);
            txtPhiTruocBa.TabIndex = 8;
            txtPhiTruocBa.TextChanged += txtPhiTruocBa_TextChanged;
            // 
            // lblPhiTruocBa
            // 
            lblPhiTruocBa.AutoSize = true;
            lblPhiTruocBa.Location = new Point(15, 358);
            lblPhiTruocBa.Name = "lblPhiTruocBa";
            lblPhiTruocBa.Size = new Size(295, 41);
            lblPhiTruocBa.TabIndex = 7;
            lblPhiTruocBa.Text = "Phí trước bạ (VNĐ):";
            // 
            // numVAT
            // 
            numVAT.DecimalPlaces = 1;
            numVAT.Font = new Font("Segoe UI", 11F);
            numVAT.Location = new Point(15, 308);
            numVAT.Name = "numVAT";
            numVAT.Size = new Size(310, 47);
            numVAT.TabIndex = 6;
            numVAT.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numVAT.ValueChanged += numVAT_ValueChanged;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Location = new Point(15, 264);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(215, 41);
            lblVAT.TabIndex = 5;
            lblVAT.Text = "Thuế VAT (%):";
            lblVAT.Click += lblVAT_Click;
            // 
            // cboKH
            // 
            cboKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKH.Font = new Font("Segoe UI", 11F);
            cboKH.FormattingEnabled = true;
            cboKH.Location = new Point(8, 213);
            cboKH.Name = "cboKH";
            cboKH.Size = new Size(310, 48);
            cboKH.TabIndex = 4;
            cboKH.SelectedIndexChanged += cboKH_SelectedIndexChanged;
            // 
            // lblChonKH
            // 
            lblChonKH.AutoSize = true;
            lblChonKH.Location = new Point(15, 172);
            lblChonKH.Name = "lblChonKH";
            lblChonKH.Size = new Size(269, 41);
            lblChonKH.TabIndex = 3;
            lblChonKH.Text = "Chọn khách hàng:";
            lblChonKH.Click += lblChonKH_Click;
            // 
            // lblGiaBanXe
            // 
            lblGiaBanXe.AutoSize = true;
            lblGiaBanXe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGiaBanXe.ForeColor = Color.FromArgb(100, 100, 100);
            lblGiaBanXe.Location = new Point(15, 135);
            lblGiaBanXe.Name = "lblGiaBanXe";
            lblGiaBanXe.Size = new Size(150, 37);
            lblGiaBanXe.TabIndex = 2;
            lblGiaBanXe.Text = "Giá bán: --";
            // 
            // cboXe
            // 
            cboXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboXe.Font = new Font("Segoe UI", 11F);
            cboXe.FormattingEnabled = true;
            cboXe.Location = new Point(15, 84);
            cboXe.Name = "cboXe";
            cboXe.Size = new Size(310, 48);
            cboXe.TabIndex = 1;
            cboXe.SelectedIndexChanged += cboXe_SelectedIndexChanged;
            // 
            // lblChonXe
            // 
            lblChonXe.AutoSize = true;
            lblChonXe.Location = new Point(15, 40);
            lblChonXe.Name = "lblChonXe";
            lblChonXe.Size = new Size(303, 41);
            lblChonXe.TabIndex = 0;
            lblChonXe.Text = "Chọn xe (Chưa bán):";
            // 
            // lblLichSuHD
            // 
            lblLichSuHD.AutoSize = true;
            lblLichSuHD.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLichSuHD.ForeColor = Color.FromArgb(44, 62, 80);
            lblLichSuHD.Location = new Point(380, 6);
            lblLichSuHD.Name = "lblLichSuHD";
            lblLichSuHD.Size = new Size(239, 41);
            lblLichSuHD.TabIndex = 1;
            lblLichSuHD.Text = "Lịch sử hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeight = 46;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Location = new Point(380, 50);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 82;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(897, 651);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1292, 715);
            Controls.Add(dgvHoaDon);
            Controls.Add(lblLichSuHD);
            Controls.Add(groupBoxHDInput);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            Text = "Lập Hóa Đơn Bán Xe";
            Load += frmHoaDon_Load;
            groupBoxHDInput.ResumeLayout(false);
            groupBoxHDInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVAT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHDInput;
        private System.Windows.Forms.Button btnDeleteHD;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienHeader;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.TextBox txtPhiTruocBa;
        private System.Windows.Forms.Label lblPhiTruocBa;
        private System.Windows.Forms.NumericUpDown numVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label lblChonKH;
        private System.Windows.Forms.Label lblGiaBanXe;
        private System.Windows.Forms.ComboBox cboXe;
        private System.Windows.Forms.Label lblChonXe;
        private System.Windows.Forms.Label lblLichSuHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}
