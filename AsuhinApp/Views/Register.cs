using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsuhinApp.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb.Text == "Nama lengkap" || tb.Text == "Email" || tb.Text == "Username" ||
                    tb.Text == "Password" || tb.Text == "Konfirmasi password")
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    if (tb.Name.Contains("Password"))
                        tb.UseSystemPasswordChar = true;
                }
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb == tbName)
                        tb.Text = "Nama lengkap";
                    else if (tb == tbEmail)
                        tb.Text = "Email";
                    else if (tb == tbUsername)
                        tb.Text = "Username";
                    else if (tb == tbPassword)
                        tb.Text = "Password";
                    else if (tb == tbConfirmPassword)
                        tb.Text = "Konfirmasi password";

                    tb.ForeColor = Color.SteelBlue;
                    tb.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password tidak sama!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
