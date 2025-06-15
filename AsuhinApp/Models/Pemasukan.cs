using System;

namespace AsuhinApp.Models
{
    public class PemasukanModel
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public int Jumlah { get; set; }
        public string Catatan { get; set; }
        public int UserId { get; set; }
    }
}
