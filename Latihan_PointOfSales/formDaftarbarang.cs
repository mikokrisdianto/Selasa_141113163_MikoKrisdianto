using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_PointOfSales
{
    public partial class formDaftarbarang : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=pointofsales;Uid=root;password=;");
        DataTable dtBarang;
        public formDaftarbarang()
        {
            InitializeComponent();
        }

        private void formDaftarbarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtBarang = new DataTable();
            BindingSource bsBarang = new BindingSource();
            bsBarang.DataSource = dtBarang;
            dgvBarang.DataSource = bsBarang;
            lihatDaftarBarang();
        }

        private void lihatDaftarBarang()
        {
            try
            {
                dtBarang.Clear();
                Class.clsBarang.SelectAll().Fill(dtBarang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarBarang();
        }
    }
}
