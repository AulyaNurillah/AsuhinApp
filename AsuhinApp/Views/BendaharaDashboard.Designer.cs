namespace AsuhinApp.Views
{
    partial class BendaharaDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel contentCard;
        private System.Windows.Forms.Button btnKelolaKeuangan;
        private System.Windows.Forms.Button btnLaporanKeuangan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTotalPemasukan;
        private System.Windows.Forms.Label lblDetailPemasukan;

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
            sidebar = new Panel();
            btnKelolaKeuangan = new Button();
            btnLaporanKeuangan = new Button();
            header = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnLogout = new Button();
            contentCard = new Panel();
            lblTotalPemasukan = new Label();
            lblDetailPemasukan = new Label();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            contentCard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(230, 230, 250);
            sidebar.Controls.Add(btnKelolaKeuangan);
            sidebar.Controls.Add(btnLaporanKeuangan);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 60);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(180, 429);
            sidebar.TabIndex = 0;
            // 
            // btnKelolaKeuangan
            // 
            btnKelolaKeuangan.BackColor = Color.White;
            btnKelolaKeuangan.Cursor = Cursors.Hand;
            btnKelolaKeuangan.FlatStyle = FlatStyle.Flat;
            btnKelolaKeuangan.Font = new Font("Sitka Display", 12F);
            btnKelolaKeuangan.Location = new Point(10, 14);
            btnKelolaKeuangan.Name = "btnKelolaKeuangan";
            btnKelolaKeuangan.Padding = new Padding(10, 0, 0, 0);
            btnKelolaKeuangan.Size = new Size(160, 40);
            btnKelolaKeuangan.TabIndex = 0;
            btnKelolaKeuangan.Text = "Kelola Keuangan";
            btnKelolaKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaKeuangan.UseVisualStyleBackColor = false;
            btnKelolaKeuangan.Click += btnKelolaKeuangan_Click;
            // 
            // btnLaporanKeuangan
            // 
            btnLaporanKeuangan.BackColor = Color.White;
            btnLaporanKeuangan.Cursor = Cursors.Hand;
            btnLaporanKeuangan.FlatStyle = FlatStyle.Flat;
            btnLaporanKeuangan.Font = new Font("Sitka Display", 12F);
            btnLaporanKeuangan.Location = new Point(10, 65);
            btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            btnLaporanKeuangan.Padding = new Padding(10, 0, 0, 0);
            btnLaporanKeuangan.Size = new Size(160, 40);
            btnLaporanKeuangan.TabIndex = 1;
            btnLaporanKeuangan.Text = "Laporan Keuangan";
            btnLaporanKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporanKeuangan.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(110, 110, 200);
            header.Controls.Add(lblTitle);
            header.Controls.Add(lblSubTitle);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(816, 60);
            header.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistem Manajemen Panti - Dashboard Bendahara";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Sitka Display", 11F, FontStyle.Italic);
            lblSubTitle.ForeColor = Color.WhiteSmoke;
            lblSubTitle.Location = new Point(10, 30);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(332, 21);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Kelola keuangan panti dengan transparan dan akurat";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 80, 80);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Sitka Display", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(10, 115);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 39);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // contentCard
            // 
            contentCard.BackColor = Color.FromArgb(50, 205, 120);
            contentCard.Controls.Add(lblTotalPemasukan);
            contentCard.Controls.Add(lblDetailPemasukan);
            contentCard.Location = new Point(200, 80);
            contentCard.Name = "contentCard";
            contentCard.Padding = new Padding(10);
            contentCard.Size = new Size(193, 100);
            contentCard.TabIndex = 2;
            // 
            // lblTotalPemasukan
            // 
            lblTotalPemasukan.AutoSize = true;
            lblTotalPemasukan.Font = new Font("Sitka Display", 14F, FontStyle.Bold);
            lblTotalPemasukan.ForeColor = Color.White;
            lblTotalPemasukan.Location = new Point(10, 10);
            lblTotalPemasukan.Name = "lblTotalPemasukan";
            lblTotalPemasukan.Size = new Size(129, 28);
            lblTotalPemasukan.TabIndex = 0;
            lblTotalPemasukan.Text = "Rp 15.500.000";
            // 
            // lblDetailPemasukan
            // 
            lblDetailPemasukan.AutoSize = true;
            lblDetailPemasukan.Font = new Font("Sitka Display", 12F);
            lblDetailPemasukan.ForeColor = Color.White;
            lblDetailPemasukan.Location = new Point(10, 40);
            lblDetailPemasukan.Name = "lblDetailPemasukan";
            lblDetailPemasukan.Size = new Size(144, 46);
            lblDetailPemasukan.TabIndex = 1;
            lblDetailPemasukan.Text = "Total Pemasukan\n+12% dari bulan lalu";
            // 
            // BendaharaDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(816, 489);
            Controls.Add(sidebar);
            Controls.Add(header);
            Controls.Add(contentCard);
            Font = new Font("Sitka Display", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BendaharaDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Bendahara";
            sidebar.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            contentCard.ResumeLayout(false);
            contentCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}