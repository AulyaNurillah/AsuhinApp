using System;
using System.Collections.Generic;
using Npgsql;
using AsuhinApp.Models;

namespace AsuhinApp.Controller
{
    internal class LaporanKeuanganController
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1098765432;Database=Asuhin";

        public List<LaporanKeuanganModel> GetLaporan()
        {
            List<LaporanKeuanganModel> laporan = new List<LaporanKeuanganModel>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT tanggal, 'Pemasukan' AS tipe, jumlah, catatan AS keterangan
                    FROM pemasukan
                    UNION ALL
                    SELECT tanggal, 'Pengeluaran' AS tipe, jumlah, keterangan
                    FROM pengeluaran
                    ORDER BY tanggal DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        laporan.Add(new LaporanKeuanganModel
                        {
                            Tanggal = reader.GetDateTime(0),
                            Tipe = reader.GetString(1),
                            Jumlah = reader.GetInt32(2),
                            Keterangan = reader.GetString(3)
                        });
                    }
                }
            }

            return laporan;
        }
    }
}
