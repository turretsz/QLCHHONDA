using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmCar : Form
    {
        private int selectedCarId = -1;
        private string role;

        public frmCar(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void frmCar_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvCars);
            cboLoaiXe.Items.AddRange(new string[] { "Vision", "SH", "Air Blade", "Winner X", "Lead", "Wave", "Vario", "PCX", "ADV", "Khác" });

            LoadCars();

            if (role == "Staff")
            {
                btnDeleteCar.Visible = false;
            }

            dgvCars.CellFormatting += dgvCars_CellFormatting;
        }

        private void LoadCars()
        {
            string filter = cboFilter.SelectedItem?.ToString() ?? "Tất cả";
            DataTable dt = CarBUS.Instance.GetAllCars(filter);
            dgvCars.DataSource = dt;

            if (dgvCars.Columns.Count >= 9)
            {
                dgvCars.Columns[0].HeaderText = "Mã";
                dgvCars.Columns[1].HeaderText = "Tên xe";
                dgvCars.Columns[2].HeaderText = "Dòng xe";
                dgvCars.Columns[3].HeaderText = "Số khung";
                dgvCars.Columns[4].HeaderText = "Số máy";
                dgvCars.Columns[5].HeaderText = "Giá nhập";
                dgvCars.Columns[6].HeaderText = "Giá bán";
                dgvCars.Columns[7].HeaderText = "Màu sắc";
                dgvCars.Columns[8].HeaderText = "Trạng thái";

                dgvCars.Columns[0].FillWeight = 5;
                dgvCars.Columns[1].FillWeight = 20;
                dgvCars.Columns[2].FillWeight = 10;
                dgvCars.Columns[3].FillWeight = 12;
                dgvCars.Columns[4].FillWeight = 12;
                dgvCars.Columns[5].FillWeight = 12;
                dgvCars.Columns[6].FillWeight = 12;
                dgvCars.Columns[7].FillWeight = 10;
                dgvCars.Columns[8].FillWeight = 9;

                dgvCars.Columns[5].DefaultCellStyle.Format = "N0";
                dgvCars.Columns[6].DefaultCellStyle.Format = "N0";
            }
        }

        private void dgvCars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvCars.Columns[e.ColumnIndex].HeaderText == "Trạng thái" && e.Value != null)
            {
                if (e.Value.ToString() == "Đã bán")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(231, 76, 60); // Red
                    e.CellStyle.SelectionForeColor = Color.FromArgb(231, 76, 60);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(39, 174, 96); // Green
                    e.CellStyle.SelectionForeColor = Color.FromArgb(39, 174, 96);
                }
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCars();
            ClearCarForm();
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            string tenXe = txtTenXe.Text.Trim();
            string loaiXe = cboLoaiXe.SelectedItem?.ToString() ?? "";
            string soKhung = txtSoKhung.Text.Trim();
            string soMay = txtSoMay.Text.Trim();
            string mauSac = txtMauSac.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenXe))
            {
                MessageBox.Show("Vui lòng nhập tên xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(loaiXe))
            {
                MessageBox.Show("Vui lòng chọn dòng xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(soKhung))
            {
                MessageBox.Show("Vui lòng nhập số khung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(soMay))
            {
                MessageBox.Show("Vui lòng nhập số máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(mauSac))
            {
                MessageBox.Show("Vui lòng nhập màu sắc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập phải là số lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán phải là số lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check unique SoKhung and SoMay
            if (CarBUS.Instance.IsSoKhungExists(soKhung, selectedCarId))
            {
                MessageBox.Show("Số khung đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CarBUS.Instance.IsSoMayExists(soMay, selectedCarId))
            {
                MessageBox.Show("Số máy đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedCarId == -1)
            {
                bool success = CarBUS.Instance.AddCar(tenXe, loaiXe, soKhung, soMay, giaNhap, giaBan, mauSac);
                if (success)
                {
                    MessageBox.Show("Thêm xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    ClearCarForm();
                }
                else
                {
                    MessageBox.Show("Thêm xe thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Double check if selected car is sold
                if (dgvCars.CurrentRow != null && dgvCars.CurrentRow.Cells["TrangThai"].Value.ToString() == "Đã bán")
                {
                    MessageBox.Show("Không thể sửa xe đã bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool success = CarBUS.Instance.UpdateCar(selectedCarId, tenXe, loaiXe, soKhung, soMay, giaNhap, giaBan, mauSac);
                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    ClearCarForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin xe thất bại! Xe có thể đã bán hoặc thông tin không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (selectedCarId == -1)
            {
                MessageBox.Show("Vui lòng chọn xe cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCars.CurrentRow != null && dgvCars.CurrentRow.Cells["TrangThai"].Value.ToString() == "Đã bán")
            {
                MessageBox.Show("Không thể xóa xe đã bán! Chỉ có thể xóa xe chưa bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = CarBUS.Instance.DeleteCar(selectedCarId);
                if (success)
                {
                    MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    ClearCarForm();
                }
                else
                {
                    MessageBox.Show("Xóa xe thất bại! Xe có thể đã bán hoặc không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];
                selectedCarId = Convert.ToInt32(row.Cells["MaXe"].Value);
                txtTenXe.Text = row.Cells["TenXe"].Value.ToString();

                string loaiXe = row.Cells["LoaiXe"].Value.ToString();
                cboLoaiXe.SelectedIndex = cboLoaiXe.Items.IndexOf(loaiXe);

                txtSoKhung.Text = row.Cells["SoKhung"].Value.ToString();
                txtSoMay.Text = row.Cells["SoMay"].Value.ToString();
                txtGiaNhap.Text = Convert.ToDecimal(row.Cells["GiaNhap"].Value).ToString("F0");
                txtGiaBan.Text = Convert.ToDecimal(row.Cells["GiaBan"].Value).ToString("F0");
                txtMauSac.Text = row.Cells["MauSac"].Value.ToString();

                btnSaveCar.Text = "Lưu cập nhật";
            }
        }

        private void ClearCarForm()
        {
            selectedCarId = -1;
            txtTenXe.Clear();
            cboLoaiXe.SelectedIndex = -1;
            txtSoKhung.Clear();
            txtSoMay.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtMauSac.Clear();
            btnSaveCar.Text = "Lưu";
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
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 251);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 249);
        }

        private void lblSoKhung_Click(object sender, EventArgs e)
        {

        }

        private void txtSoMay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGiaNhap_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
