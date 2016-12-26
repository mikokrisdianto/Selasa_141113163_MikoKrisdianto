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
    public partial class formRegistrasiBarang : Form
    {
        List<TextBox> listInput = new List<TextBox>();
        static MySqlConnection koneksi = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=pointofsales;Uid=root;password=;");
        public formRegistrasiBarang()
        {
            InitializeComponent();
            
        }

        private void formRegistrasiBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    listInput.Add((TextBox)ctrl);
            }

            try
            {
                koneksi.Open();
            }
            catch (MySqlException ec)
            {
                MessageBox.Show(ec.Message, "Error");
            }
        }

        private void formRegistrasiBarang_FormClosing(object sender, FormClosingEventArgs e)
        {
            koneksi.Close();
        }

        private void tmblKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool valid(List<TextBox> list)
        {
            bool v = true;
            foreach (TextBox item in list)
            {
                if (item.Text.Trim() == "")
                {
                    v = false;
                    break;
                }
            }
            return v;
        }

        private void tmblSimpan_Click(object sender, EventArgs e)
        {
            if (valid(listInput))
            {
                DateTime skrg = DateTime.Now;
                MySqlCommand cmd = koneksi.CreateCommand();
                string insert = "INSERT INTO barang (Kode,Nama,JumlahAwal,HargaHPP,HargaJual,created_at,updated_at)";
                insert += " VALUES (@kode,@nama,@jumlahAwal,@hargaHPP,@hargaJual,@createdAt,@updatedAt)";
                try
                {
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@kode", txtKode.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@jumlahAwal", Convert.ToInt32(txtJlhAwal.Text));
                    cmd.Parameters.AddWithValue("@hargaHPP", Convert.ToDecimal(txtHrgHPP.Text));
                    cmd.Parameters.AddWithValue("@hargaJual", Convert.ToDecimal(txtHargaJual.Text));
                    cmd.Parameters.AddWithValue("@createdAt", skrg);
                    cmd.Parameters.AddWithValue("@updatedAt", skrg);

                    reset();

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " Barang Berhasil Ditambahkan", "Sukses");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Mohon Masukkan Data dengan Lengkap");
            }
        }

        private void reset()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtJlhAwal.Clear();
            txtHrgHPP.Clear();
            txtHargaJual.Clear();
            txtKode.Focus();
        }

        private void tmblReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}