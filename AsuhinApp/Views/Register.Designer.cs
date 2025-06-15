namespace AsuhinApp.Views
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRegister = new Panel();
            lblTitle = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegister
            // 
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(lblTitle);
            panelRegister.Controls.Add(tbName);
            panelRegister.Controls.Add(tbEmail);
            panelRegister.Controls.Add(tbUsername);
            panelRegister.Controls.Add(tbPassword);
            panelRegister.Controls.Add(tbConfirmPassword);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(linkLogin);
            panelRegister.Location = new Point(240, 25);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(320, 400);
            panelRegister.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Sitka Display", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MediumPurple;
            lblTitle.Location = new Point(45, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Daftar Akun Baru";
            // 
            // tbName
            // 
            tbName.Font = new Font("Sitka Display", 10F);
            tbName.ForeColor = Color.SteelBlue;
            tbName.Location = new Point(30, 60);
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 24);
            tbName.TabIndex = 1;
            tbName.Text = "Nama lengkap";
            tbName.Enter += txt_Enter;
            tbName.Leave += txt_Leave;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Sitka Display", 10F);
            tbEmail.ForeColor = Color.SteelBlue;
            tbEmail.Location = new Point(30, 100);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(250, 24);
            tbEmail.TabIndex = 2;
            tbEmail.Text = "Email";
            tbEmail.Enter += txt_Enter;
            tbEmail.Leave += txt_Leave;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Sitka Display", 10F);
            tbUsername.ForeColor = Color.SteelBlue;
            tbUsername.Location = new Point(30, 140);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(250, 24);
            tbUsername.TabIndex = 3;
            tbUsername.Text = "Username";
            tbUsername.Enter += txt_Enter;
            tbUsername.Leave += txt_Leave;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Sitka Display", 10F);
            tbPassword.ForeColor = Color.SteelBlue;
            tbPassword.Location = new Point(30, 180);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(250, 24);
            tbPassword.TabIndex = 4;
            tbPassword.Text = "Password";
            tbPassword.Enter += txt_Enter;
            tbPassword.Leave += txt_Leave;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Sitka Display", 10F);
            tbConfirmPassword.ForeColor = Color.SteelBlue;
            tbConfirmPassword.Location = new Point(30, 220);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(250, 24);
            tbConfirmPassword.TabIndex = 5;
            tbConfirmPassword.Text = "Konfirmasi password";
            tbConfirmPassword.Enter += txt_Enter;
            tbConfirmPassword.Leave += txt_Leave;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumPurple;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Sitka Display", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(30, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLogin
            // 
            linkLogin.Font = new Font("Sitka Display", 9F, FontStyle.Italic);
            linkLogin.LinkColor = Color.MediumBlue;
            linkLogin.Location = new Point(56, 303);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(200, 30);
            linkLogin.TabIndex = 7;
            linkLogin.TabStop = true;
            linkLogin.Text = "Sudah punya akun? Login";
            linkLogin.TextAlign = ContentAlignment.MiddleCenter;
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegister);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }
    }
}
