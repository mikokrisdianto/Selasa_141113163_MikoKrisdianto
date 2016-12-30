using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales.Class
{
    class clsPenjualan
    {
        private static string tabel = "penjualan";

        public int id { private set; get; }
        public string kode { private set; get; }
        public clsCustomer customer { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsPenjualan(int id, string kode, clsCustomer customer, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.kode = kode;
            this.customer = customer;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public static clsCustomer cariCustomerById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM customer WHERE id = @id";

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

                clsCustomer customer;
                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][1].ToString();
                    string alamat = dt.Rows[0][2].ToString();
                    string zip_code = dt.Rows[0][3].ToString();
                    string phone_number = dt.Rows[0][4].ToString();
                    string email = dt.Rows[0][5].ToString();
                    customer = new clsCustomer(Convert.ToInt16(id), nama, alamat, zip_code, phone_number, email);

                    return customer;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static clsPenjualan cari_kode(string kode)
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

                clsPenjualan penjualan;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    clsCustomer customer = clsPenjualan.cariCustomerById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    penjualan = new clsPenjualan(id, kode, customer, created_at, updated_at);

                    return penjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static clsPenjualan cari_id(string id)
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

                clsPenjualan penjualan;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    clsCustomer customer = clsPenjualan.cariCustomerById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    penjualan = new clsPenjualan(Convert.ToInt16(id), kode, customer, created_at, updated_at);

                    return penjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static string getCustomerNameById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT nama FROM customer WHERE id = @id";

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
