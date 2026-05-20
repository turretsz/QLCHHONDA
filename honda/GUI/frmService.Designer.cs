namespace honda.GUI
{
    partial class frmService
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
            tabControlService = new TabControl();
            tabTickets = new TabPage();
            groupBoxTicketInput = new GroupBox();
            btnDeleteTicket = new Button();
            btnSaveTicket = new Button();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            cboPhuTung = new ComboBox();
            lblPhuTung = new Label();
            txtNoiDung = new TextBox();
            lblNoiDung = new Label();
            txtBienSo = new TextBox();
            lblBienSo = new Label();
            lblTicketHistory = new Label();
            dgvTickets = new DataGridView();
            tabParts = new TabPage();
            groupBoxPartInput = new GroupBox();
            btnDeletePart = new Button();
            btnSavePart = new Button();
            txtPartStock = new TextBox();
            lblPartStock = new Label();
            txtPartPrice = new TextBox();
            lblPartPrice = new Label();
            txtPartName = new TextBox();
            lblPartName = new Label();
            lblPartsList = new Label();
            dgvParts = new DataGridView();
            tabControlService.SuspendLayout();
            tabTickets.SuspendLayout();
            groupBoxTicketInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            tabParts.SuspendLayout();
            groupBoxPartInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            SuspendLayout();
            // 
            // tabControlService
            // 
            tabControlService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlService.Controls.Add(tabTickets);
            tabControlService.Controls.Add(tabParts);
            tabControlService.Font = new Font("Segoe UI", 9.5F);
            tabControlService.Location = new Point(15, 15);
            tabControlService.Name = "tabControlService";
            tabControlService.SelectedIndex = 0;
            tabControlService.Size = new Size(1389, 696);
            tabControlService.TabIndex = 0;
            // 
            // tabTickets
            // 
            tabTickets.BackColor = Color.White;
            tabTickets.Controls.Add(groupBoxTicketInput);
            tabTickets.Controls.Add(lblTicketHistory);
            tabTickets.Controls.Add(dgvTickets);
            tabTickets.Location = new Point(8, 49);
            tabTickets.Name = "tabTickets";
            tabTickets.Padding = new Padding(3);
            tabTickets.Size = new Size(1373, 639);
            tabTickets.TabIndex = 0;
            tabTickets.Text = "1. Quản lý Phiếu sửa chữa";
            // 
            // groupBoxTicketInput
            // 
            groupBoxTicketInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTicketInput.Controls.Add(btnDeleteTicket);
            groupBoxTicketInput.Controls.Add(btnSaveTicket);
            groupBoxTicketInput.Controls.Add(txtTongTien);
            groupBoxTicketInput.Controls.Add(lblTongTien);
            groupBoxTicketInput.Controls.Add(cboPhuTung);
            groupBoxTicketInput.Controls.Add(lblPhuTung);
            groupBoxTicketInput.Controls.Add(txtNoiDung);
            groupBoxTicketInput.Controls.Add(lblNoiDung);
            groupBoxTicketInput.Controls.Add(txtBienSo);
            groupBoxTicketInput.Controls.Add(lblBienSo);
            groupBoxTicketInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxTicketInput.ForeColor = Color.FromArgb(44, 62, 80);
            groupBoxTicketInput.Location = new Point(15, 15);
            groupBoxTicketInput.Name = "groupBoxTicketInput";
            groupBoxTicketInput.Size = new Size(350, 609);
            groupBoxTicketInput.TabIndex = 0;
            groupBoxTicketInput.TabStop = false;
            groupBoxTicketInput.Text = "Thông tin bảo dưỡng";
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteTicket.BackColor = Color.White;
            btnDeleteTicket.Cursor = Cursors.Hand;
            btnDeleteTicket.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteTicket.FlatStyle = FlatStyle.Flat;
            btnDeleteTicket.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteTicket.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeleteTicket.Location = new Point(180, 544);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(145, 45);
            btnDeleteTicket.TabIndex = 9;
            btnDeleteTicket.Text = "Xóa phiếu";
            btnDeleteTicket.UseVisualStyleBackColor = false;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // btnSaveTicket
            // 
            btnSaveTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveTicket.BackColor = Color.FromArgb(41, 128, 185);
            btnSaveTicket.Cursor = Cursors.Hand;
            btnSaveTicket.FlatAppearance.BorderSize = 0;
            btnSaveTicket.FlatStyle = FlatStyle.Flat;
            btnSaveTicket.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveTicket.ForeColor = Color.White;
            btnSaveTicket.Location = new Point(15, 544);
            btnSaveTicket.Name = "btnSaveTicket";
            btnSaveTicket.Size = new Size(145, 45);
            btnSaveTicket.TabIndex = 8;
            btnSaveTicket.Text = "Lưu phiếu";
            btnSaveTicket.UseVisualStyleBackColor = false;
            btnSaveTicket.Click += btnSaveTicket_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 11F);
            txtTongTien.Location = new Point(15, 422);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(310, 47);
            txtTongTien.TabIndex = 7;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTien.Location = new Point(15, 378);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(298, 41);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng chi phí (VNĐ):";
            lblTongTien.Click += lblTongTien_Click;
            // 
            // cboPhuTung
            // 
            cboPhuTung.Font = new Font("Segoe UI", 11F);
            cboPhuTung.FormattingEnabled = true;
            cboPhuTung.Location = new Point(15, 327);
            cboPhuTung.Name = "cboPhuTung";
            cboPhuTung.Size = new Size(310, 48);
            cboPhuTung.TabIndex = 5;
            cboPhuTung.SelectedIndexChanged += cboPhuTung_SelectedIndexChanged;
            // 
            // lblPhuTung
            // 
            lblPhuTung.AutoSize = true;
            lblPhuTung.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPhuTung.Location = new Point(15, 280);
            lblPhuTung.Name = "lblPhuTung";
            lblPhuTung.Size = new Size(279, 41);
            lblPhuTung.TabIndex = 4;
            lblPhuTung.Text = "Phụ tùng thay thế:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Segoe UI", 11F);
            txtNoiDung.Location = new Point(15, 181);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(310, 95);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNoiDung.Location = new Point(15, 137);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(323, 41);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung bảo dưỡng:";
            // 
            // txtBienSo
            // 
            txtBienSo.Font = new Font("Segoe UI", 11F);
            txtBienSo.Location = new Point(15, 87);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(310, 47);
            txtBienSo.TabIndex = 1;
            txtBienSo.TextChanged += txtBienSo_TextChanged;
            // 
            // lblBienSo
            // 
            lblBienSo.AutoSize = true;
            lblBienSo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBienSo.Location = new Point(15, 43);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.Size = new Size(167, 41);
            lblBienSo.TabIndex = 0;
            lblBienSo.Text = "Biển số xe:";
            // 
            // lblTicketHistory
            // 
            lblTicketHistory.AutoSize = true;
            lblTicketHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTicketHistory.ForeColor = Color.FromArgb(44, 62, 80);
            lblTicketHistory.Location = new Point(380, 4);
            lblTicketHistory.Name = "lblTicketHistory";
            lblTicketHistory.Size = new Size(492, 45);
            lblTicketHistory.TabIndex = 1;
            lblTicketHistory.Text = "Lịch sử sửa chữa & bảo dưỡng xe";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.AllowUserToResizeRows = false;
            dgvTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.BorderStyle = BorderStyle.None;
            dgvTickets.ColumnHeadersHeight = 40;
            dgvTickets.Location = new Point(380, 52);
            dgvTickets.MultiSelect = false;
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersVisible = false;
            dgvTickets.RowHeadersWidth = 82;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(978, 569);
            dgvTickets.TabIndex = 2;
            dgvTickets.CellClick += dgvTickets_CellClick;
            // 
            // tabParts
            // 
            tabParts.BackColor = Color.White;
            tabParts.Controls.Add(groupBoxPartInput);
            tabParts.Controls.Add(lblPartsList);
            tabParts.Controls.Add(dgvParts);
            tabParts.Location = new Point(8, 49);
            tabParts.Name = "tabParts";
            tabParts.Padding = new Padding(3);
            tabParts.Size = new Size(1373, 639);
            tabParts.TabIndex = 1;
            tabParts.Text = "2. Quản lý Kho Phụ tùng";
            // 
            // groupBoxPartInput
            // 
            groupBoxPartInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxPartInput.Controls.Add(btnDeletePart);
            groupBoxPartInput.Controls.Add(btnSavePart);
            groupBoxPartInput.Controls.Add(txtPartStock);
            groupBoxPartInput.Controls.Add(lblPartStock);
            groupBoxPartInput.Controls.Add(txtPartPrice);
            groupBoxPartInput.Controls.Add(lblPartPrice);
            groupBoxPartInput.Controls.Add(txtPartName);
            groupBoxPartInput.Controls.Add(lblPartName);
            groupBoxPartInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxPartInput.ForeColor = Color.FromArgb(44, 62, 80);
            groupBoxPartInput.Location = new Point(15, 15);
            groupBoxPartInput.Name = "groupBoxPartInput";
            groupBoxPartInput.Size = new Size(350, 609);
            groupBoxPartInput.TabIndex = 0;
            groupBoxPartInput.TabStop = false;
            groupBoxPartInput.Text = "Thông tin phụ tùng";
            // 
            // btnDeletePart
            // 
            btnDeletePart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeletePart.BackColor = Color.White;
            btnDeletePart.Cursor = Cursors.Hand;
            btnDeletePart.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeletePart.FlatStyle = FlatStyle.Flat;
            btnDeletePart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeletePart.ForeColor = Color.FromArgb(231, 76, 60);
            btnDeletePart.Location = new Point(180, 544);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(145, 45);
            btnDeletePart.TabIndex = 7;
            btnDeletePart.Text = "Xóa";
            btnDeletePart.UseVisualStyleBackColor = false;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnSavePart
            // 
            btnSavePart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSavePart.BackColor = Color.FromArgb(41, 128, 185);
            btnSavePart.Cursor = Cursors.Hand;
            btnSavePart.FlatAppearance.BorderSize = 0;
            btnSavePart.FlatStyle = FlatStyle.Flat;
            btnSavePart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSavePart.ForeColor = Color.White;
            btnSavePart.Location = new Point(15, 544);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(145, 45);
            btnSavePart.TabIndex = 6;
            btnSavePart.Text = "Lưu";
            btnSavePart.UseVisualStyleBackColor = false;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // txtPartStock
            // 
            txtPartStock.Font = new Font("Segoe UI", 11F);
            txtPartStock.Location = new Point(15, 269);
            txtPartStock.Name = "txtPartStock";
            txtPartStock.Size = new Size(310, 47);
            txtPartStock.TabIndex = 5;
            // 
            // lblPartStock
            // 
            lblPartStock.AutoSize = true;
            lblPartStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPartStock.Location = new Point(15, 225);
            lblPartStock.Name = "lblPartStock";
            lblPartStock.Size = new Size(210, 41);
            lblPartStock.TabIndex = 4;
            lblPartStock.Text = "Số lượng tồn:";
            lblPartStock.Click += lblPartStock_Click;
            // 
            // txtPartPrice
            // 
            txtPartPrice.Font = new Font("Segoe UI", 11F);
            txtPartPrice.Location = new Point(15, 175);
            txtPartPrice.Name = "txtPartPrice";
            txtPartPrice.Size = new Size(310, 47);
            txtPartPrice.TabIndex = 3;
            // 
            // lblPartPrice
            // 
            lblPartPrice.AutoSize = true;
            lblPartPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPartPrice.Location = new Point(15, 131);
            lblPartPrice.Name = "lblPartPrice";
            lblPartPrice.Size = new Size(229, 41);
            lblPartPrice.TabIndex = 2;
            lblPartPrice.Text = "Giá bán (VNĐ):";
            lblPartPrice.Click += lblPartPrice_Click;
            // 
            // txtPartName
            // 
            txtPartName.Font = new Font("Segoe UI", 11F);
            txtPartName.Location = new Point(15, 81);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(310, 47);
            txtPartName.TabIndex = 1;
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPartName.Location = new Point(15, 37);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(213, 41);
            lblPartName.TabIndex = 0;
            lblPartName.Text = "Tên phụ tùng:";
            // 
            // lblPartsList
            // 
            lblPartsList.AutoSize = true;
            lblPartsList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPartsList.ForeColor = Color.FromArgb(44, 62, 80);
            lblPartsList.Location = new Point(380, 4);
            lblPartsList.Name = "lblPartsList";
            lblPartsList.Size = new Size(476, 45);
            lblPartsList.TabIndex = 1;
            lblPartsList.Text = "Danh mục phụ tùng trong kho";
            // 
            // dgvParts
            // 
            dgvParts.AllowUserToAddRows = false;
            dgvParts.AllowUserToDeleteRows = false;
            dgvParts.AllowUserToResizeRows = false;
            dgvParts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParts.BorderStyle = BorderStyle.None;
            dgvParts.ColumnHeadersHeight = 40;
            dgvParts.Location = new Point(380, 52);
            dgvParts.MultiSelect = false;
            dgvParts.Name = "dgvParts";
            dgvParts.ReadOnly = true;
            dgvParts.RowHeadersVisible = false;
            dgvParts.RowHeadersWidth = 82;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.Size = new Size(978, 569);
            dgvParts.TabIndex = 2;
            dgvParts.CellClick += dgvParts_CellClick;
            // 
            // frmService
            // 
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1419, 726);
            Controls.Add(tabControlService);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmService";
            Load += frmService_Load;
            tabControlService.ResumeLayout(false);
            tabTickets.ResumeLayout(false);
            tabTickets.PerformLayout();
            groupBoxTicketInput.ResumeLayout(false);
            groupBoxTicketInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            tabParts.ResumeLayout(false);
            tabParts.PerformLayout();
            groupBoxPartInput.ResumeLayout(false);
            groupBoxPartInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlService;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.GroupBox groupBoxTicketInput;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblPhuTung;
        private System.Windows.Forms.ComboBox cboPhuTung;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnSaveTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Label lblTicketHistory;
        private System.Windows.Forms.DataGridView dgvTickets;

        private System.Windows.Forms.TabPage tabParts;
        private System.Windows.Forms.GroupBox groupBoxPartInput;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.Label lblPartStock;
        private System.Windows.Forms.TextBox txtPartStock;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Label lblPartsList;
        private System.Windows.Forms.DataGridView dgvParts;
    }
}