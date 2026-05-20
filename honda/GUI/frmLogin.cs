using System;
using System.Windows.Forms;
using honda.BUS;

namespace honda.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (AccountBUS.Instance.Login(user, pass))
            {
                string role = AccountBUS.Instance.GetRole(user);
                MessageBox.Show("Đăng nhập thành công với quyền: " + role, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain main = new frmMain(role, user);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
