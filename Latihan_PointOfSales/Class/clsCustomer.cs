using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales.Class
{
    class clsCustomer
    {
        private static string tabel = "customer";
        public int id { private set; get; }
        public string nama { private set; get; }
        public string alamat { private set; get; }
        public string zip_code { private set; get; }
        public string phone_number { private set; get; }
        public string email { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsCustomer()
        { }

        public clsCustomer(int id)
        {
            this.id = id;
        }

        public clsCustomer(int id, string nama, string alamat, string zip_code, string phone_number, string email)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.zip_code = zip_code;
            this.phone_number = phone_number;
            this.email = email;
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

        public clsCustomer(string nama, string alamat, string zip_code, string phone_number, string email)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.zip_code = zip_code;
            this.phone_number = phone_number;
            this.email = email;
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

        public int InsertCustomer()
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insertQuery = "INSERT INTO " + tabel + " (Nama,Alamat,Zip_code,Phone_number,Email,created_at,updated_at)";
            insertQuery += " VALUES (@nama,@alamat,@zip_code,@phone_number,@email,@createdAt,@updatedAt)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertQuery, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@zip_code", zip_code);
            cmd.Parameters.AddWithValue("@phone_number", phone_number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@createdAt", created_at);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.InsertCommand = cmd;
            res = da.InsertCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
            return res;
        }

        public static Dictionary<string, string> cariCustomer(string id)
        {
            Dictionary<string, string> hasil = new Dictionary<string, string>();
            MySqlCommand cmd = clsDatabase.koneksi.CreateCommand();
            string query = "SELECT * from customer WHERE ID=" + id;
            cmd.CommandText = query;
            clsDatabase.buka_koneksi();
            MySqlDataReader reader = cmd.ExecuteReader();
            hasil["tersedia"] = "tidak tersedia";
            while (reader.Read())
            {
                hasil["tersedia"] = "tersedia";
                hasil["nama"] = reader.GetString("Nama");
                hasil["alamat"] = reader.GetString("Alamat");
                hasil["zipcode"] = reader.GetString("Zip_code");
                hasil["phonenumber"] = reader.GetString("Phone_number");
                hasil["email"] = reader.GetString("Email");
            }
            clsDatabase.tutup_koneksi();

            return hasil;
        }

        public int UpdateCustomer(int id, string nama, string alamat, string zip_code, string phone_number, string email)
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + tabel + " SET Nama = @nama, Alamat = @alamat, Zip_code = @zip_code, Phone_number = @phone_number, ";
            update += "Email = @email, updated_at = @updatedAt WHERE ID = @id";
            updated_at = DateTime.Now;
            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@zip_code", zip_code);
            cmd.Parameters.AddWithValue("@phone_number", phone_number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@createdAt", created_at);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.UpdateCommand = cmd;
            res = da.UpdateCommand.ExecuteNonQuery();

            clsDatabase.tutup_koneksi();
            return res;
        }

        public int DeleteCustomer()
        {
            int res;
            clsDatabase.buka_koneksi();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string delete = "DELETE FROM customer WHERE ID = @id";

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
