namespace AsuhinApp.Views
{
    partial class Pemasukan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblHeader;

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
            lblHeader = new Label();
            label1 = new Label();
            lblTanggal = new Label();
            dtpTanggal = new DateTimePicker();
            lblNominal = new Label();
            txtNominal = new TextBox();
            lblKategori = new Label();
            txtKategori = new TextBox();
            lblKeterangan = new Label();
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
            lblHeader.BackColor = Color.FromArgb(240, 245, 255);
            lblHeader.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(50, 50, 120);
            lblHeader.Location = new Point(28, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(300, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Kelola Pemasukan";
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(80, 80, 120);
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(350, 30);
            label1.TabIndex = 15;
            label1.Text = "Catat dan kelola data pemasukan panti";
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = Color.White;
            lblTanggal.Location = new Point(62, 105);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(120, 25);
            lblTanggal.TabIndex = 16;
            lblTanggal.Text = "Tanggal:";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(228, 105);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(200, 28);
            dtpTanggal.TabIndex = 17;
            // 
            // lblNominal
            // 
            lblNominal.BackColor = Color.White;
            lblNominal.Location = new Point(62, 260);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(100, 23);
            lblNominal.TabIndex = 18;
            lblNominal.Text = "Nominal:";
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(228, 260);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(200, 28);
            txtNominal.TabIndex = 19;
            // 
            // lblKategori
            // 
            lblKategori.BackColor = Color.White;
            lblKategori.Location = new Point(62, 184);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(100, 23);
            lblKategori.TabIndex = 20;
            lblKategori.Text = "Kategori:";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(228, 181);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(200, 28);
            txtKategori.TabIndex = 21;
            // 
            // lblKeterangan
            // 
            lblKeterangan.BackColor = Color.White;
            lblKeterangan.Location = new Point(62, 330);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(100, 23);
            lblKeterangan.TabIndex = 22;
            lblKeterangan.Text = "Keterangan:";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(228, 330);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(200, 28);
            txtKeterangan.TabIndex = 23;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(130, 200, 255);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Location = new Point(28, 401);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(90, 35);
            btnTambah.TabIndex = 24;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 230, 150);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(124, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 150, 150);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Location = new Point(220, 401);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(90, 35);
            btnHapus.TabIndex = 26;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(180, 255, 180);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(316, 401);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPengeluaran
            // 
            dgvPengeluaran.AllowUserToAddRows = false;
            dgvPengeluaran.AllowUserToDeleteRows = false;
            dgvPengeluaran.BackgroundColor = Color.White;
            dgvPengeluaran.Location = new Point(28, 78);
            dgvPengeluaran.Name = "dgvPengeluaran";
            dgvPengeluaran.ReadOnly = true;
            dgvPengeluaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengeluaran.Size = new Size(760, 308);
            dgvPengeluaran.TabIndex = 28;
            // 
            // Pemasukan
            // 
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(850, 500);
            Controls.Add(label1);
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
            Controls.Add(lblHeader);
            Font = new Font("Sitka Display", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Pemasukan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Pemasukan";
            ((System.ComponentModel.ISupportInitialize)dgvPengeluaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label lblTanggal;
        private DateTimePicker dtpTanggal;
        private Label lblNominal;
        private TextBox txtNominal;
        private Label lblKategori;
        private TextBox txtKategori;
        private Label lblKeterangan;
        private TextBox txtKeterangan;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private DataGridView dgvPengeluaran;
    }
}
