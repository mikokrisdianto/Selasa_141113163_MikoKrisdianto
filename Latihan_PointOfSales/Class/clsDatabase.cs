using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales.Class
{
    class clsDatabase
    {
        public static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=pointofsales;Uid=root;password=;");

        public static void buka_koneksi()
        {
            if (koneksi.State != ConnectionState.Open)
                koneksi.Open();
        }

        public static void tutup_koneksi()
        {
            if (koneksi.State != ConnectionState.Closed)
                koneksi.Close();
        }
    }
}
