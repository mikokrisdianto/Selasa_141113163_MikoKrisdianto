using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales.Class
{
    class clsDetailPembelian
    {
        private static string tabel = "pembelian_detail";

        public int id { private set; get; }
        public clsPembelian pembelian { private set; get; }
        public clsBarang barang { private set; get; }
        public decimal harga_barang { private set; get; }
        public int kuantitas { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsDetailPembelian(int id, clsPembelian pembelian, clsBarang barang, decimal harga_barang, int kuantitas, DateTime create, DateTime update)
        {
            this.id = id;
            this.pembelian = pembelian;
            this.barang = barang;
            this.harga_barang = harga_barang;
            this.kuantitas = kuantitas;
            this.created_at = create;
            this.updated_at = update;
        }

        public static clsDetailPembelian cariDetailPembelian(string id_pembelian, string id_barang)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + tabel + " WHERE id_pembelian = @id_pembelian AND id_barang = @id_barang";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id_pembelian", id_pembelian);
            cmd.Parameters.AddWithValue("@id_barang", id_barang);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                clsDetailPembelian detailPembelian;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    clsPembelian pembelian = clsPembelian.cari_id(dt.Rows[0][1].ToString());
                    clsBarang barang = clsPembelian.cariBarangById(dt.Rows[0][2].ToString());
                    decimal harga_barang = Convert.ToDecimal(dt.Rows[0][3]);
                    int kuantitas = Convert.ToInt16(dt.Rows[0][4]);
                    DateTime create = Convert.ToDateTime(dt.Rows[0][5]);
                    DateTime update = Convert.ToDateTime(dt.Rows[0][6]);

                    detailPembelian = new clsDetailPembelian(id, pembelian, barang, harga_barang, kuantitas, create, update);

                    return detailPembelian;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static int last_id_pembelian()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT LAST id FROM pembelian";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.koneksi);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.buka_koneksi();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.tutup_koneksi();

                int hasil;
                if (dt.Rows.Count > 0)
                {
                    hasil = Convert.ToInt16(dt.Rows[0][0]);
                    return hasil;
                }
                return -1;
            }
            catch (Exception ex)
            {
                clsDatabase.tutup_koneksi();
                throw new Exception(ex.Message);
            }
        }

        public static int kelola_pembelian(string command, int id, string kode, int id_supplier)
        {
            int res = 0;
            if (command == "insert")
            {
                clsDatabase.buka_koneksi();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string insertQuery = "INSERT INTO pembelian (kode,id_supplier,created_at,updated_at)";
                insertQuery += " VALUES (@kode,@id_supplier,@createdAt,@updatedAt)";

                MySqlCommand cmd;
                DateTime created_at = DateTime.Now;
                DateTime updated_at = DateTime.Now;
                cmd = new MySqlCommand(insertQuery, clsDatabase.koneksi);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@id_supplier", id_supplier);
                cmd.Parameters.AddWithValue("@createdAt", created_at);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.InsertCommand = cmd;
                res = da.InsertCommand.ExecuteNonQuery();

                clsDatabase.tutup_koneksi();
                return res;
            }
            else {
                clsDatabase.buka_koneksi();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string update = "UPDATE pembelian SET kode = @kode, id_supplier = @id_supplier, ";
                update += "updated_at = @updatedAt WHERE ID = @id";
                DateTime updated_at = DateTime.Now;

                MySqlCommand cmd;
                cmd = new MySqlCommand(update, clsDatabase.koneksi);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@id_supplier", id_supplier);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.UpdateCommand = cmd;
                res = da.UpdateCommand.ExecuteNonQuery();

                clsDatabase.tutup_koneksi();
                return res;
            }
        }

        public static int kelola_detail_pembelian(string command, int id, int id_pembelian, int id_barang, decimal harga_barang, int kuantitas)
        {
            int res = 0;
            if (command == "insert")
            {
                clsDatabase.buka_koneksi();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string insertQuery = "INSERT INTO pembelian_detail (id_pembelian, id_barang, harga_barang, kuantitas ,created_at,updated_at)";
                insertQuery += " VALUES (@id_pembelian, @id_barang, @harga_barang, @kuantitas ,@createdAt,@updatedAt)";

                MySqlCommand cmd;
                DateTime created_at = DateTime.Now;
                DateTime updated_at = DateTime.Now;
                cmd = new MySqlCommand(insertQuery, clsDatabase.koneksi);
                cmd.Parameters.AddWithValue("@id_pembelian",id_pembelian);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@harga_barang", harga_barang);
                cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                cmd.Parameters.AddWithValue("@createdAt", created_at);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.InsertCommand = cmd;
                res = da.InsertCommand.ExecuteNonQuery();

                clsDatabase.tutup_koneksi();
                return res;
            }
            else
            {
                clsDatabase.buka_koneksi();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string update = "UPDATE pembelian_detail SET id_pembelian=@id_pembelian, id_barang=@id_barang, harga_barang=@harga_barang, kuantitas=@kuantitas, ";
                update += "updated_at = @updatedAt WHERE ID = @id";
                DateTime updated_at = DateTime.Now;

                MySqlCommand cmd;
                cmd = new MySqlCommand(update, clsDatabase.koneksi);
                cmd.Parameters.AddWithValue("@id_pembelian", id_pembelian);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@harga_barang", harga_barang);
                cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.UpdateCommand = cmd;
                res = da.UpdateCommand.ExecuteNonQuery();

                clsDatabase.tutup_koneksi();
                return res;
            }
        }

        public static void update_stok(int id_barang, int selisih_kuantitas)
        {
            clsDatabase.buka_koneksi();
            int res;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE barang SET JumlahAwal=JumlahAwal + @selisih_kuantitas, ";
            update += "updated_at = @updatedAt WHERE ID = @id";
            DateTime updated_at = DateTime.Now;

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@selisih_kuantitas", selisih_kuantitas);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);
            cmd.Parameters.AddWithValue("@id",id_barang);

            da.UpdateCommand = cmd;
            res = da.UpdateCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
        }

        public static MySqlDataAdapter SelectAllByIdPembelian(int id_pembelian)
        {
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM " + tabel + " WHERE id_pembelian= "+id_pembelian.ToString();
            da = new MySqlDataAdapter(selectQuery, clsDatabase.koneksi);
            da.SelectCommand.ExecuteScalar();

            clsDatabase.tutup_koneksi();
            return da;
        }

        public static MySqlDataAdapter SelectAllPembelian()
        {
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM pembelian";
            da = new MySqlDataAdapter(selectQuery, clsDatabase.koneksi);
            da.SelectCommand.ExecuteScalar();

            clsDatabase.tutup_koneksi();
            return da;
        }

        public static MySqlDataAdapter SelectAllDetailPembelian()
        {
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM pembelian_detail";
            da = new MySqlDataAdapter(selectQuery, clsDatabase.koneksi);
            da.SelectCommand.ExecuteScalar();

            clsDatabase.tutup_koneksi();
            return da;
        }
    }
}
