using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using AsuhinApp.Models;

namespace AsuhinApp.Controller
{
    internal class PemasukanController
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1098765432;Database=Asuhin";

        public List<PemasukanModel> GetAll()
        {
            List<PemasukanModel> list = new List<PemasukanModel>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pemasukan ORDER BY tanggal DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PemasukanModel
                        {
                            Id = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Jumlah = reader.GetInt32(2),
                            Catatan = reader.GetString(3),
                            UserId = reader.GetInt32(4)
                        });
                    }
                }
            }

            return list;
        }

        public void Insert(PemasukanModel pemasukan)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO pemasukan (tanggal, jumlah, catatan, user_id_user) VALUES (@tanggal, @jumlah, @catatan, @user_id_user)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggal", pemasukan.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", pemasukan.Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", pemasukan.Catatan ?? "");
                    cmd.Parameters.AddWithValue("@user_id_user", pemasukan.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM pemasukan WHERE id_pemasukan = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
