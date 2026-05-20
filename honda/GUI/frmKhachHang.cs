using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmKhachHang : Form
    {
        private int selectedKHId = -1;
        private string role;

        public frmKhachHang(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvKhachHang);
            LoadKhachHang();

            if (role == "Staff")
            {
                btnDeleteKH.Visible = false;
            }
        }

        private void LoadKhachHang()
        {
            DataTable dt = KhachHangBUS.Instance.GetAllKhachHang();
            dgvKhachHang.DataSource = dt;
            FormatGridColumns();
        }

        private void FormatGridColumns()
        {
            if (dgvKhachHang.Columns.Count >= 5)
            {
                dgvKhachHang.Columns[0].HeaderText = "Mã KH";
                dgvKhachHang.Columns[1].HeaderText = "Họ tên";
                dgvKhachHang.Columns[2].HeaderText = "Số điện thoại";
                dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns[4].HeaderText = "CCCD";

                dgvKhachHang.Columns[0].FillWeight = 8;
                dgvKhachHang.Columns[1].FillWeight = 25;
                dgvKhachHang.Columns[2].FillWeight = 15;
                dgvKhachHang.Columns[3].FillWeight = 35;
                dgvKhachHang.Columns[4].FillWeight = 17;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(kw))
            {
                LoadKhachHang();
            }
            else
            {
                dgvKhachHang.DataSource = KhachHangBUS.Instance.SearchKhachHang(kw);
                FormatGridColumns();
            }
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string cccd = txtCCCD.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenKH))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(cccd) && !System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{12}$"))
            {
                MessageBox.Show("Số CCCD phải gồm đúng 12 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check duplicate phone number
            if (KhachHangBUS.Instance.IsSDTExists(sdt, selectedKHId))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống cho một khách hàng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedKHId == -1)
            {
                bool success = KhachHangBUS.Instance.AddKhachHang(tenKH, sdt, diaChi, cccd);
                if (success)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                    ClearKHForm();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool success = KhachHangBUS.Instance.UpdateKhachHang(selectedKHId, tenKH, sdt, diaChi, cccd);
                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                    ClearKHForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            if (selectedKHId == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = KhachHangBUS.Instance.DeleteKhachHang(selectedKHId);
                if (success)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                    ClearKHForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng này! Khách hàng này có thể đã có hóa đơn mua hàng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                selectedKHId = Convert.ToInt32(row.Cells["MaKH"].Value);
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();

                btnSaveKH.Text = "Lưu cập nhật";
            }
        }

        private void ClearKHForm()
        {
            selectedKHId = -1;
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            btnSaveKH.Text = "Lưu";
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

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void lblCCCD_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
