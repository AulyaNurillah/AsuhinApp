using System;
using System.Windows.Forms;
using System.Drawing;

namespace AsuhinApp.Views
{
    public partial class Pengeluaran : Form
    {
        private Label lblHeader, lblSubHeader;
        private Label lblTanggal, lblNominal, lblKategori, lblKeterangan;
        private DateTimePicker dtpTanggal;
        private TextBox txtNominal, txtKategori, txtKeterangan;
        private Button btnTambah, btnEdit, btnHapus, btnRefresh;
        private DataGridView dgvPengeluaran;

        public Pengeluaran()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            lblSubHeader = new Label();
            lblTanggal = new Label();
            lblNominal = new Label();
            lblKategori = new Label();
            lblKeterangan = new Label();
            dtpTanggal = new DateTimePicker();
            txtNominal = new TextBox();
            txtKategori = new TextBox();
            txtKeterangan = new TextBox();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            dgvPengeluaran = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPengeluaran).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(50, 50, 120);
            lblHeader.Location = new Point(20, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(400, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Manajemen Pengeluaran";
            // 
            // lblSubHeader
            // 
            lblSubHeader.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            lblSubHeader.ForeColor = Color.FromArgb(80, 80, 120);
            lblSubHeader.Location = new Point(20, 45);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(350, 30);
            lblSubHeader.TabIndex = 1;
            lblSubHeader.Text = "Catat dan kelola data pengeluaran panti";
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.White;
            lblTanggal.Location = new Point(54, 105);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(120, 25);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "Tanggal:";
            // 
            // lblNominal
            // 
            lblNominal.BackColor = Color.White;
            lblNominal.Location = new Point(54, 260);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(100, 23);
            lblNominal.TabIndex = 4;
            lblNominal.Text = "Nominal:";
            // 
            // lblKategori
            // 
            lblKategori.BackColor = Color.White;
            lblKategori.Location = new Point(54, 184);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(100, 23);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Kategori:";
            // 
            // lblKeterangan
            // 
            lblKeterangan.BackColor = Color.White;
            lblKeterangan.Location = new Point(54, 330);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(100, 23);
            lblKeterangan.TabIndex = 8;
            lblKeterangan.Text = "Keterangan:";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(220, 105);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(200, 26);
            dtpTanggal.TabIndex = 3;
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(220, 260);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(200, 26);
            txtNominal.TabIndex = 5;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(220, 181);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(200, 26);
            txtKategori.TabIndex = 7;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(220, 330);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(200, 26);
            txtKeterangan.TabIndex = 9;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(130, 200, 255);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Location = new Point(20, 401);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(90, 35);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 230, 150);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(116, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 150, 150);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Location = new Point(212, 401);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(90, 35);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(180, 255, 180);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(308, 401);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPengeluaran
            // 
            dgvPengeluaran.AllowUserToAddRows = false;
            dgvPengeluaran.AllowUserToDeleteRows = false;
            dgvPengeluaran.BackgroundColor = Color.White;
            dgvPengeluaran.Location = new Point(20, 78);
            dgvPengeluaran.Name = "dgvPengeluaran";
            dgvPengeluaran.ReadOnly = true;
            dgvPengeluaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengeluaran.Size = new Size(760, 308);
            dgvPengeluaran.TabIndex = 14;
            // 
            // Pengeluaran
            // 
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(816, 489);
            Controls.Add(lblHeader);
            Controls.Add(lblSubHeader);
            Controls.Add(lblTanggal);
            Controls.Add(dtpTanggal);
            Controls.Add(lblNominal);
            Controls.Add(txtNominal);
            Controls.Add(lblKategori);
            Controls.Add(txtKategori);
            Controls.Add(lblKeterangan);
            Controls.Add(txtKeterangan);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPengeluaran);
            Font = new Font("Sitka Display", 11F);
            Name = "Pengeluaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pengeluaran";
            ((System.ComponentModel.ISupportInitialize)dgvPengeluaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
