using System;
using System.Collections.Generic;
using Npgsql;
using AsuhinApp.Models;

namespace AsuhinApp.Controller
{
    internal class PengeluaranController
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1098765432;Database=Asuhin";

        public List<PengeluaranModel> GetAll()
        {
            List<PengeluaranModel> list = new List<PengeluaranModel>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pengeluaran ORDER BY tanggal DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PengeluaranModel
                        {
                            Id = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Jumlah = reader.GetInt32(2),
                            Catatan = reader.GetString(3)
                        });
                    }
                }
            }

            return list;
        }

        public void Insert(PengeluaranModel pengeluaran)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO pengeluaran (tanggal, jumlah, catatan) VALUES (@tanggal, @jumlah, @catatan)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggal", pengeluaran.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", pengeluaran.Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", pengeluaran.Catatan ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM pengeluaran WHERE id_pengeluaran = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
