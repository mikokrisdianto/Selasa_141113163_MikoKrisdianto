using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Latihan_PointOfSales.Class
{
    class clsBarang
    {
        private static string tabel = "barang";
        public int id { private set; get; }
        public string kode { private set; get; }
        public string nama { private set; get; }
        public int jumlah { private set; get; }
        public decimal harga_hpp { private set; get; }
        public decimal harga_jual { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsBarang()
        { 
            
        }

        public clsBarang(int id)
        {
            this.id = id;
        }

        public clsBarang(int id, string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = harga_hpp;
            this.harga_jual = harga_jual;
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
        
        public clsBarang(string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = harga_hpp;
            this.harga_jual = harga_jual;
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

        public static MySqlDataAdapter SelectAll()
        {
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM " + tabel;
            da = new MySqlDataAdapter(selectQuery, clsDatabase.koneksi);
            da.SelectCommand.ExecuteScalar();

            clsDatabase.tutup_koneksi();
            return da;
        }

        public int InsertBarang()
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insertQuery = "INSERT INTO " + tabel + " (Kode,Nama,JumlahAwal,HargaHPP,HargaJual,created_at,updated_at)";
            insertQuery += " VALUES (@kode,@nama,@jumlahAwal,@hargaHPP,@hargaJual,@createdAt,@updatedAt)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertQuery, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@createdAt", created_at);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.InsertCommand = cmd;
            res = da.InsertCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
            return res;
        }

        public static Dictionary<string,string> cariBarang(string id)
        {
            Dictionary<string, string> hasil = new Dictionary<string, string>();
            MySqlCommand cmd = clsDatabase.koneksi.CreateCommand();
            string query = "SELECT * from barang WHERE ID=" + id;
            cmd.CommandText = query;
            clsDatabase.buka_koneksi();
            MySqlDataReader reader = cmd.ExecuteReader();
            hasil["tersedia"] = "tidak tersedia";
            while (reader.Read())
            {
                hasil["tersedia"] = "tersedia";
                hasil["kode"] = reader.GetString("Kode");
                hasil["nama"] = reader.GetString("Nama");
                hasil["jumlahawal"] = reader.GetString("JumlahAwal");
                hasil["hargahpp"] = reader.GetString("HargaHPP");
                hasil["hargajual"] = reader.GetString("HargaJual");
            }
            clsDatabase.tutup_koneksi();

            return hasil;
        }

        public int UpdateBarang(int id, string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + tabel + " SET Kode = @kode, Nama = @nama, JumlahAwal = @jumlahAwal, HargaHPP = @hargaHPP, ";
            update += "HargaJual = @hargaJual, updated_at = @updatedAt WHERE ID = @id";
            updated_at = DateTime.Now;
            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.UpdateCommand = cmd;
            res = da.UpdateCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
            return res;
        }

        public int DeleteBarang()
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string delete = "DELETE FROM barang WHERE ID = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(delete, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);

            da.DeleteCommand = cmd;
            res = da.DeleteCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
            return res;
        }
    }
}
