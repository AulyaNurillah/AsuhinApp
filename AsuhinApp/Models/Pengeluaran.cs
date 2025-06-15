using System;

namespace AsuhinApp.Models
{
    internal class PengeluaranModel
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public int Jumlah { get; set; }
        public string Catatan { get; set; }
    }
}
