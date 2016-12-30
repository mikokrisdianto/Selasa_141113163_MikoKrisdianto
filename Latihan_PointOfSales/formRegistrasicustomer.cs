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
    public partial class formRegistrasicustomer : Form
    {
        List<TextBox> listInput = new List<TextBox>();
        public formRegistrasicustomer()
        {
            InitializeComponent();
        }

        private void formRegistrasicustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    listInput.Add((TextBox)ctrl);
            }

            try
            {
                Class.clsDatabase.buka_koneksi();
            }
            catch (MySqlException ec)
            {
                MessageBox.Show(ec.Message, "Error");
            }
        }

        private void reset()
        {
            txtZipcode.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Class.clsDatabase.tutup_koneksi();
            this.Close();
        }

        private bool validasi(List<TextBox> list)
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasi(listInput))
            {

                try
                {
                    Class.clsCustomer CustomerBaru = new Class.clsCustomer(txtNama.Text, txtAlamat.Text, txtZipcode.Text, txtPhoneNumber.Text, txtEmail.Text);
                    int res = CustomerBaru.InsertCustomer();
                    reset();
                    MessageBox.Show(res + " Customer berhasil ditambahkan", "Tersimpan");
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
    }
}
