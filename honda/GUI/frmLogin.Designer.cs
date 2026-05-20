namespace honda.GUI
{
    partial class frmLogin
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
            lblTitle = new Label();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(90, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(640, 133);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng Nhập Hệ Thống";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(44, 62, 80);
            lblUser.Location = new Point(218, 162);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(140, 36);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tài khoản:";
            lblUser.Click += lblUser_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.5F);
            txtUsername.Location = new Point(364, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 41);
            txtUsername.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(44, 62, 80);
            lblPass.Location = new Point(218, 228);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(139, 36);
            lblPass.TabIndex = 3;
            lblPass.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(364, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 41);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(218, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(189, 195, 199);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(127, 140, 141);
            btnExit.Location = new Point(432, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 48);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmLogin
            // 
            BackColor = Color.White;
            ClientSize = new Size(812, 414);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(lblUser);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Cửa hàng Honda HEAD";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
