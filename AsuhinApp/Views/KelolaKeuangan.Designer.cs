namespace AsuhinApp.Views
{
    partial class KelolaKeuangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnPemasukan;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Panel mainPanel;

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
            btnPemasukan = new Button();
            btnPengeluaran = new Button();
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(50, 50, 90);
            lblHeader.Location = new Point(20, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(400, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Kelola Keuangan";
            // 
            // btnPemasukan
            // 
            btnPemasukan.BackColor = Color.LightSkyBlue;
            btnPemasukan.FlatStyle = FlatStyle.Flat;
            btnPemasukan.Font = new Font("Sitka Display", 12F);
            btnPemasukan.Location = new Point(30, 80);
            btnPemasukan.Name = "btnPemasukan";
            btnPemasukan.Size = new Size(150, 40);
            btnPemasukan.TabIndex = 1;
            btnPemasukan.Text = "Pemasukan";
            btnPemasukan.UseVisualStyleBackColor = true;
            btnPemasukan.Click += btnPemasukan_Click;
            // 
            // btnPengeluaran
            // 
            btnPengeluaran.BackColor = Color.LightCoral;
            btnPengeluaran.FlatStyle = FlatStyle.Flat;
            btnPengeluaran.Font = new Font("Sitka Display", 12F);
            btnPengeluaran.Location = new Point(200, 80);
            btnPengeluaran.Name = "btnPengeluaran";
            btnPengeluaran.Size = new Size(150, 40);
            btnPengeluaran.TabIndex = 2;
            btnPengeluaran.Text = "Pengeluaran";
            btnPengeluaran.UseVisualStyleBackColor = true;
            btnPengeluaran.Click += btnPengeluaran_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(240, 248, 255);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Location = new Point(30, 140);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(750, 320);
            mainPanel.TabIndex = 3;
            // 
            // KelolaKeuangan
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 255);
            ClientSize = new Size(816, 489);
            Controls.Add(lblHeader);
            Controls.Add(btnPemasukan);
            Controls.Add(btnPengeluaran);
            Controls.Add(mainPanel);
            Font = new Font("Sitka Display", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KelolaKeuangan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Keuangan";
            ResumeLayout(false);
        }
    }
}
