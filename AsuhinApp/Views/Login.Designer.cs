namespace AsuhinApp.Views
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkRegister;

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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            panelLogin = new Panel();
            linkRegister = new LinkLabel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Display", 10F);
            lblUsername.Location = new Point(30, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Sitka Display", 10F);
            txtUsername.ForeColor = Color.SteelBlue;
            txtUsername.Location = new Point(30, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 24);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Masukkan username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 10F);
            lblPassword.Location = new Point(30, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Display", 10F);
            txtPassword.ForeColor = Color.SteelBlue;
            txtPassword.Location = new Point(30, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 24);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Masukkan password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumPurple;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Sitka Display", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MediumPurple;
            lblTitle.Location = new Point(50, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login Panti Asuhan";
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblTitle);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(linkRegister);
            panelLogin.Location = new Point(240, 80);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(320, 300);
            panelLogin.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Sitka Display", 9F, FontStyle.Italic);
            linkRegister.LinkColor = Color.MediumBlue;
            linkRegister.Location = new Point(77, 245);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(144, 18);
            linkRegister.TabIndex = 6;
            linkRegister.TabStop = true;
            linkRegister.Text = "Belum punya akun? Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistem Panti Asuhan";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}