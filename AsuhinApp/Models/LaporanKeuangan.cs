using System;

namespace AsuhinApp.Models
{
    internal class LaporanKeuanganModel
    {
        public DateTime Tanggal { get; set; }
        public string Tipe { get; set; } 
        public int Jumlah { get; set; }
        public string Keterangan { get; set; }
    }
}
