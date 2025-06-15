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
    public partial class BendaharaDashboard : Form
    {
        public BendaharaDashboard()
        {
            InitializeComponent();
            btnKelolaKeuangan.Click += new EventHandler(btnKelolaKeuangan_Click);
        }

        private void btnKelolaKeuangan_Click(object sender, EventArgs e)
        {
            KelolaKeuangan formKelola = new KelolaKeuangan();
            formKelola.Show();
        }
    }
}
