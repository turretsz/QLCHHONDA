using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmHoaDon : Form
    {
        private int selectedHDId = -1;
        private decimal currentGiaBan = 0;
        private string role;
        private string username;

        public frmHoaDon(string role, string username = "admin")
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvHoaDon);
            LoadHoaDon();
            LoadXeComboBox();
            LoadKHComboBox();

            if (role == "Staff")
            {
                btnDeleteHD.Visible = false;
            }
        }

        private void LoadHoaDon()
        {
            DataTable dt = HoaDonBUS.Instance.GetAllHoaDon();
            dgvHoaDon.DataSource = dt;

            if (dgvHoaDon.Columns.Count >= 7)
            {
                dgvHoaDon.Columns[0].HeaderText = "Mã HD";
                dgvHoaDon.Columns[1].HeaderText = "Ngày lập";
                dgvHoaDon.Columns[2].HeaderText = "Tên xe";
                dgvHoaDon.Columns[3].HeaderText = "Khách hàng";
                dgvHoaDon.Columns[4].HeaderText = "VAT %";
                dgvHoaDon.Columns[5].HeaderText = "Phí trước bạ";
                dgvHoaDon.Columns[6].HeaderText = "Tổng tiền";

                dgvHoaDon.Columns[0].FillWeight = 7;
                dgvHoaDon.Columns[1].FillWeight = 15;
                dgvHoaDon.Columns[2].FillWeight = 25;
                dgvHoaDon.Columns[3].FillWeight = 20;
                dgvHoaDon.Columns[4].FillWeight = 8;
                dgvHoaDon.Columns[5].FillWeight = 15;
                dgvHoaDon.Columns[6].FillWeight = 15;

                dgvHoaDon.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvHoaDon.Columns[5].DefaultCellStyle.Format = "N0";
                dgvHoaDon.Columns[6].DefaultCellStyle.Format = "N0";
            }
        }

        private void LoadXeComboBox()
        {
            try
            {
                DataTable dt = CarBUS.Instance.GetAvailableCars();

                // Add a default select row
                DataRow dr = dt.NewRow();
                dr["MaXe"] = -1;
                dr["TenXe"] = "-- Chọn xe --";
                dr["LoaiXe"] = "";
                dr["GiaBan"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboXe.DataSource = dt;
                cboXe.DisplayMember = "TenXe";
                cboXe.ValueMember = "MaXe";
                cboXe.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục xe chưa bán: " + ex.Message);
            }
        }

        private void LoadKHComboBox()
        {
            try
            {
                DataTable dt = KhachHangBUS.Instance.GetAllKhachHang();

                // Add a default select row
                DataRow dr = dt.NewRow();
                dr["MaKH"] = -1;
                dr["TenKH"] = "-- Chọn khách hàng --";
                dr["SDT"] = "";
                dr["DiaChi"] = "";
                dr["CCCD"] = "";
                dt.Rows.InsertAt(dr, 0);

                cboKH.DataSource = dt;
                cboKH.DisplayMember = "TenKH";
                cboKH.ValueMember = "MaKH";
                cboKH.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục khách hàng: " + ex.Message);
            }
        }

        private void cboXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboXe.SelectedIndex <= 0 || cboXe.SelectedValue == null || Convert.ToInt32(cboXe.SelectedValue) == -1)
            {
                currentGiaBan = 0;
                lblGiaBanXe.Text = "Giá bán: --";
                txtPhiTruocBa.Text = "0";
                RecalcTotal();
                return;
            }

            if (cboXe.SelectedItem is DataRowView drv)
            {
                currentGiaBan = Convert.ToDecimal(drv["GiaBan"]);
                lblGiaBanXe.Text = "Giá bán: " + currentGiaBan.ToString("N0") + " VNĐ";
                // Default PhiTruocBa to 5% of GiaBan
                txtPhiTruocBa.Text = (currentGiaBan * 0.05m).ToString("F0");
                RecalcTotal();
            }
        }

        private void RecalcTotal()
        {
            decimal.TryParse(txtPhiTruocBa.Text, out decimal phi);
            decimal vat = numVAT.Value;

            decimal total = HoaDonBUS.Instance.TinhTongTien(currentGiaBan, vat, phi);
            lblTongTien.Text = total.ToString("N0") + " VNĐ";
        }

        private void numVAT_ValueChanged(object sender, EventArgs e)
        {
            RecalcTotal();
        }

        private void txtPhiTruocBa_TextChanged(object sender, EventArgs e)
        {
            RecalcTotal();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            int maXe = cboXe.SelectedValue != null ? Convert.ToInt32(cboXe.SelectedValue) : -1;
            int maKH = cboKH.SelectedValue != null ? Convert.ToInt32(cboKH.SelectedValue) : -1;

            if (maXe <= 0)
            {
                MessageBox.Show("Vui lòng chọn xe cần lập hóa đơn bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (maKH <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng mua xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtPhiTruocBa.Text, out decimal phi);
            if (phi < 0)
            {
                MessageBox.Show("Lệ phí trước bạ không được phép nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal vat = numVAT.Value;
            decimal total = HoaDonBUS.Instance.TinhTongTien(currentGiaBan, vat, phi);

            bool success = HoaDonBUS.Instance.AddHoaDon(maXe, maKH, username, vat, phi, total);
            if (success)
            {
                MessageBox.Show("Lập hóa đơn bán xe thành công! Trạng thái xe đã được đổi thành 'Đã bán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
                LoadXeComboBox(); // Reload available cars list
                ClearHDForm();
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thất bại! Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            if (selectedHDId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa từ danh sách lịch sử bên phải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không? Trạng thái xe liên kết sẽ được tự động trả về 'Chưa bán'.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = HoaDonBUS.Instance.DeleteHoaDon(selectedHDId);
                if (success)
                {
                    MessageBox.Show("Xóa hóa đơn thành công! Xe đã được khôi phục trạng thái 'Chưa bán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDon();
                    LoadXeComboBox(); // Reload available cars list
                    ClearHDForm();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                selectedHDId = Convert.ToInt32(row.Cells["MaHD"].Value);
            }
        }

        private void ClearHDForm()
        {
            selectedHDId = -1;
            cboXe.SelectedIndex = 0;
            cboKH.SelectedIndex = 0;
            numVAT.Value = 10;
            txtPhiTruocBa.Text = "0";
            currentGiaBan = 0;
            lblGiaBanXe.Text = "Giá bán: --";
            lblTongTien.Text = "0 VNĐ";
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

        private void groupBoxHDInput_Enter(object sender, EventArgs e)
        {

        }

        private void lblVAT_Click(object sender, EventArgs e)
        {

        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblChonKH_Click(object sender, EventArgs e)
        {

        }
    }
}
