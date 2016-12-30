using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales.Class
{
    class clsPembelian
    {
        private static string tabel = "pembelian";
        
        public int id { private set; get; }
        public string kode { private set; get; }
        public clsSupplier supplier { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsPembelian(int id, string kode, clsSupplier supplier, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.kode = kode;
            this.supplier = supplier;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public static clsSupplier cariSupplierById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM supplier WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                clsSupplier supplier;
                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][1].ToString();
                    string alamat = dt.Rows[0][2].ToString();
                    string zip_code = dt.Rows[0][3].ToString();
                    string phone_number = dt.Rows[0][4].ToString();
                    string email = dt.Rows[0][5].ToString();
                    supplier = new clsSupplier(Convert.ToInt16(id),nama, alamat, zip_code, phone_number, email);

                    return supplier;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static clsPembelian cari_kode(string kode)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + tabel + " WHERE kode = @kode";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@kode", kode);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                clsPembelian pembelian;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    clsSupplier supplier = clsPembelian.cariSupplierById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    pembelian = new clsPembelian(id, kode, supplier, created_at, updated_at);

                    return pembelian;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static clsPembelian cari_id(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + tabel + " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                clsPembelian pembelian;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    clsSupplier supplier = clsPembelian.cariSupplierById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    pembelian = new clsPembelian(Convert.ToInt16(id), kode, supplier, created_at, updated_at);

                    return pembelian;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static string getSupplierNameById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT nama FROM supplier WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][0].ToString();

                    return nama;
                }
                return "";
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static clsBarang cariBarangById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM barang WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                clsBarang barang;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    string nama = dt.Rows[0][2].ToString();
                    int jumlah = Convert.ToInt16(dt.Rows[0][3]);
                    decimal hargahpp = Convert.ToDecimal(dt.Rows[0][4]);
                    decimal hargajual = Convert.ToDecimal(dt.Rows[0][5]);

                    barang = new clsBarang(Convert.ToInt16(id), kode, nama, jumlah, hargahpp, hargajual);
                    return barang;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }
    }
}
