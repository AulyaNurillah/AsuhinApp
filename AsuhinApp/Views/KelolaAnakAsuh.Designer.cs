using System;
using System.Drawing;
using System.Windows.Forms;

namespace AsuhinApp.Views
{
    partial class KelolaAnakAsuh : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel header;
        private Label lblTitle;
        private Label lblSubTitle;
        private TextBox txtCari;
        private Button btnCari;
        private DataGridView dgvAnakAsuh;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;

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
        /// the contents with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            dgvAnakAsuh = new DataGridView();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnakAsuh).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(90, 90, 210);
            header.Controls.Add(lblTitle);
            header.Controls.Add(lblSubTitle);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(816, 60);
            header.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kelola Data Anak Asuh";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Sitka Display", 10F, FontStyle.Italic);
            lblSubTitle.ForeColor = Color.WhiteSmoke;
            lblSubTitle.Location = new Point(10, 30);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(317, 20);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Pantau dan atur informasi anak asuh secara menyeluruh";
            // 
            // txtCari
            // 
            txtCari.BackColor = SystemColors.Window;
            txtCari.Font = new Font("Sitka Display", 12F);
            txtCari.Location = new Point(20, 80);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(200, 28);
            txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(180, 200, 250);
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Sitka Display", 10F);
            btnCari.Location = new Point(230, 80);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(80, 28);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // dgvAnakAsuh
            // 
            dgvAnakAsuh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnakAsuh.BackgroundColor = Color.White;
            dgvAnakAsuh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnakAsuh.Location = new Point(20, 115);
            dgvAnakAsuh.Name = "dgvAnakAsuh";
            dgvAnakAsuh.Size = new Size(770, 295);
            dgvAnakAsuh.TabIndex = 3;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(100, 200, 140);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Sitka Display", 12F);
            btnTambah.ForeColor = Color.Black;
            btnTambah.Location = new Point(20, 418);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 40);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(255, 200, 100);
            btnUbah.FlatStyle = FlatStyle.Flat;
            btnUbah.Font = new Font("Sitka Display", 12F);
            btnUbah.ForeColor = Color.Black;
            btnUbah.Location = new Point(126, 418);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(100, 40);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(240, 100, 100);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Sitka Display", 12F);
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(232, 418);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 40);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // KelolaAnakAsuh
            // 
            BackColor = Color.FromArgb(235, 235, 255);
            ClientSize = new Size(816, 489);
            Controls.Add(header);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Controls.Add(dgvAnakAsuh);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Font = new Font("Sitka Display", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KelolaAnakAsuh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Anak Asuh";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnakAsuh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
