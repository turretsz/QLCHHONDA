using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmService : Form
    {
        private int selectedPartId = -1;
        private int selectedTicketId = -1;
        private string role;

        public frmService(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvTickets);
            StyleDataGridView(dgvParts);
            LoadTickets();
            LoadParts();
            LoadPartsComboBox();

            if (role == "Staff")
            {
                btnDeleteTicket.Visible = false;
                btnDeletePart.Visible = false;
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 251);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 249);
        }

        // ==========================================
        // 1. NGHIỆP VỤ PHIẾU BẢO DƯỠNG
        // ==========================================

        private void LoadTickets()
        {
            try
            {
                dgvTickets.DataSource = PhieuSuaChuaBUS.Instance.GetListPhieuSuaChua();
                if (dgvTickets.Columns.Count >= 5)
                {
                    dgvTickets.Columns[0].HeaderText = "Mã phiếu";
                    dgvTickets.Columns[0].FillWeight = 10;
                    dgvTickets.Columns[1].HeaderText = "Biển số xe";
                    dgvTickets.Columns[1].FillWeight = 15;
                    dgvTickets.Columns[2].HeaderText = "Ngày lập";
                    dgvTickets.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvTickets.Columns[2].FillWeight = 22;
                    dgvTickets.Columns[3].HeaderText = "Nội dung bảo dưỡng";
                    dgvTickets.Columns[3].FillWeight = 35;
                    dgvTickets.Columns[4].HeaderText = "Tổng tiền";
                    dgvTickets.Columns[4].DefaultCellStyle.Format = "N0";
                    dgvTickets.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTickets.Columns[4].FillWeight = 18;

                    // Hide MaPhuTung column if present in dataSource
                    if (dgvTickets.Columns.Count >= 6)
                    {
                        dgvTickets.Columns[5].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu sửa chữa: " + ex.Message, "Lỗi");
            }
        }

        private void LoadPartsComboBox()
        {
            try
            {
                DataTable dt = PhuTungBUS.Instance.GetListPhuTung();
                DataRow dr = dt.NewRow();
                dr["MaPhuTung"] = -1;
                dr["TenPhuTung"] = "-- Không thay phụ tùng --";
                dr["GiaBan"] = 0;
                dr["SoLuongTon"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboPhuTung.DataSource = dt;
                cboPhuTung.DisplayMember = "TenPhuTung";
                cboPhuTung.ValueMember = "MaPhuTung";
                cboPhuTung.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phụ tùng: " + ex.Message);
            }
        }

        private void cboPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhuTung.SelectedIndex > 0 && cboPhuTung.SelectedItem is DataRowView drv)
            {
                decimal price = Convert.ToDecimal(drv["GiaBan"]);
                txtTongTien.Text = price.ToString("F0");
                txtNoiDung.Text = "Thay thế phụ tùng: " + drv["TenPhuTung"].ToString();
            }
            else
            {
                txtTongTien.Text = "0";
                txtNoiDung.Text = "";
            }
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSo.Text.Trim().ToUpper();
            string noiDung = txtNoiDung.Text.Trim();

            if (string.IsNullOrWhiteSpace(bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe!", "Cảnh báo");
                txtBienSo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng điền nội dung sửa chữa!", "Cảnh báo");
                txtNoiDung.Focus();
                return;
            }

            // ✅ Kiểm tra trùng biển số: cùng biển số không được lập 2 phiếu trong 1 ngày
            if (selectedTicketId == -1 && PhieuSuaChuaBUS.Instance.IsBienSoTodayExists(bienSo))
            {
                MessageBox.Show(
                    $"Biển số '{bienSo}' đã có phiếu sửa chữa hôm nay!\nMột xe chỉ được lập 1 phiếu mỗi ngày.",
                    "Trùng biển số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtTongTien.Text, out decimal price);
            int maPhuTung = cboPhuTung.SelectedValue != null ? Convert.ToInt32(cboPhuTung.SelectedValue) : -1;

            if (maPhuTung > 0)
            {
                DataRowView drv = (DataRowView)cboPhuTung.SelectedItem;
                int stock = Convert.ToInt32(drv["SoLuongTon"]);
                if (stock <= 0)
                {
                    MessageBox.Show("Phụ tùng này đã hết hàng trong kho! Không thể lập phiếu sửa chữa với phụ tùng này.", "Hết hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (PhieuSuaChuaBUS.Instance.AddPhieuSuaChua(bienSo, noiDung, price, maPhuTung))
            {
                MessageBox.Show("Lưu phiếu bảo dưỡng thành công!", "Thông báo");
                LoadTickets();
                LoadParts();
                LoadPartsComboBox();
                ClearTicketForm();
            }
            else
            {
                MessageBox.Show("Không thể lưu phiếu. Vui lòng kiểm tra lại!", "Lỗi");
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (selectedTicketId == -1)
            {
                MessageBox.Show("Vui lòng chọn phiếu sửa chữa muốn xóa từ danh sách bên phải!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu này không? Tồn kho phụ tùng liên kết sẽ được hoàn lại.", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PhieuSuaChuaBUS.Instance.DeletePhieuSuaChua(selectedTicketId))
                {
                    MessageBox.Show("Xóa phiếu thành công!", "Thông báo");
                    LoadTickets();
                    LoadParts();
                    LoadPartsComboBox();
                    ClearTicketForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTickets.Rows[e.RowIndex];
                selectedTicketId = Convert.ToInt32(row.Cells["MaPhieu"].Value);
                txtBienSo.Text = row.Cells["BienSo"].Value?.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();
                txtTongTien.Text = Convert.ToDecimal(row.Cells["TongTien"].Value).ToString("F0");

                object maPhuTungVal = row.Cells["MaPhuTung"].Value;
                if (maPhuTungVal != null && maPhuTungVal != DBNull.Value)
                {
                    int maPhuTung = Convert.ToInt32(maPhuTungVal);
                    cboPhuTung.SelectedValue = maPhuTung;
                }
                else
                {
                    cboPhuTung.SelectedIndex = 0;
                }
            }
        }

        private void ClearTicketForm()
        {
            selectedTicketId = -1;
            txtBienSo.Clear();
            txtNoiDung.Clear();
            txtTongTien.Clear();
            cboPhuTung.SelectedIndex = 0;
        }

        // ==========================================
        // 2. NGHIỆP VỤ DANH MỤC PHỤ TÙNG
        // ==========================================

        private void LoadParts()
        {
            try
            {
                dgvParts.DataSource = PhuTungBUS.Instance.GetListPhuTung();
                if (dgvParts.Columns.Count >= 4)
                {
                    dgvParts.Columns[0].HeaderText = "Mã";
                    dgvParts.Columns[0].FillWeight = 10;
                    dgvParts.Columns[1].HeaderText = "Tên phụ tùng";
                    dgvParts.Columns[1].FillWeight = 50;
                    dgvParts.Columns[2].HeaderText = "Giá bán (VNĐ)";
                    dgvParts.Columns[2].DefaultCellStyle.Format = "N0";
                    dgvParts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvParts.Columns[2].FillWeight = 25;
                    dgvParts.Columns[3].HeaderText = "Tồn kho";
                    dgvParts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvParts.Columns[3].FillWeight = 15;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục phụ tùng: " + ex.Message, "Lỗi");
            }
        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            string name = txtPartName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên phụ tùng không được để trống!", "Cảnh báo");
                txtPartName.Focus();
                return;
            }
            if (!decimal.TryParse(txtPartPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ! Chỉ nhập số không âm.", "Cảnh báo");
                txtPartPrice.Focus();
                return;
            }
            if (!int.TryParse(txtPartStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ! Chỉ nhập số nguyên không âm.", "Cảnh báo");
                txtPartStock.Focus();
                return;
            }

            if (selectedPartId == -1)
            {
                // ===== THÊM MỚI =====
                if (PhuTungBUS.Instance.IsTenPhuTungExists(name, -1))
                {
                    MessageBox.Show(
                        $"Phụ tùng '{name}' đã tồn tại trong danh mục!\nVui lòng đặt tên khác.",
                        "Trùng tên phụ tùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPartName.Focus();
                    return;
                }

                if (PhuTungBUS.Instance.AddPhuTung(name, price, stock))
                {
                    MessageBox.Show("Thêm phụ tùng mới thành công!", "Thông báo");
                    LoadParts();
                    LoadPartsComboBox();
                    ClearPartForm();
                }
                else
                {
                    MessageBox.Show("Thêm phụ tùng thất bại!", "Lỗi");
                }
            }
            else
            {
                // ===== CẬP NHẬT =====
                if (PhuTungBUS.Instance.IsTenPhuTungExists(name, selectedPartId))
                {
                    MessageBox.Show(
                        $"Tên '{name}' đã được dùng bởi phụ tùng khác!\nVui lòng đặt tên khác.",
                        "Trùng tên phụ tùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPartName.Focus();
                    return;
                }

                if (PhuTungBUS.Instance.UpdatePhuTung(selectedPartId, name, price, stock))
                {
                    MessageBox.Show("Cập nhật phụ tùng thành công!", "Thông báo");
                    LoadParts();
                    LoadPartsComboBox();
                    ClearPartForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi");
                }
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (selectedPartId == -1)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng từ danh sách bên phải để xóa!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa phụ tùng '{txtPartName.Text.Trim()}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (PhuTungBUS.Instance.DeletePhuTung(selectedPartId))
                {
                    MessageBox.Show("Xóa phụ tùng thành công!", "Thông báo");
                    LoadParts();
                    LoadPartsComboBox();
                    ClearPartForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvParts.Rows[e.RowIndex];
                selectedPartId = Convert.ToInt32(row.Cells["MaPhuTung"].Value);
                txtPartName.Text = row.Cells["TenPhuTung"].Value?.ToString();
                txtPartPrice.Text = Convert.ToDecimal(row.Cells["GiaBan"].Value).ToString("F0");
                txtPartStock.Text = row.Cells["SoLuongTon"].Value?.ToString();
                btnSavePart.Text = "Lưu cập nhật";
            }
        }

        private void ClearPartForm()
        {
            selectedPartId = -1;
            txtPartName.Clear();
            txtPartPrice.Clear();
            txtPartStock.Clear();
            btnSavePart.Text = "Lưu";
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPartStock_Click(object sender, EventArgs e)
        {

        }

        private void lblPartPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
