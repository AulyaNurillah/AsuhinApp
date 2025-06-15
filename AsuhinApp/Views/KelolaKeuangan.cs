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
    public partial class KelolaKeuangan : Form
    {
        public KelolaKeuangan()
        {
            InitializeComponent();
            btnPemasukan.Click += btnPemasukan_Click;
            btnPengeluaran.Click += btnPengeluaran_Click;
        }

        private void btnPemasukan_Click(object sender, EventArgs e)
        {
            Pemasukan pemasukanForm = new Pemasukan();
            pemasukanForm.TopLevel = false;
            pemasukanForm.FormBorderStyle = FormBorderStyle.None;
            pemasukanForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pemasukanForm);
            pemasukanForm.Show();
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            Pengeluaran pengeluaranForm = new Pengeluaran();
            pengeluaranForm.TopLevel = false;
            pengeluaranForm.FormBorderStyle = FormBorderStyle.None;
            pengeluaranForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pengeluaranForm);
            pengeluaranForm.Show();
        }
    }
}
