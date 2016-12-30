using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_PointOfSales
{
    public partial class formEditbarang : Form
    {
        public formEditbarang()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Class.clsDatabase.tutup_koneksi();
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            string teks = txtId.Text;
            if (teks.Trim() != "")
            {
                try
                {
                    Dictionary<string, string> hasil = Class.clsBarang.cariBarang(teks);
                    if (hasil["tersedia"] == "tersedia")
                    {
                        txtIdInner.Text = teks;
                        txtKode.Text = hasil["kode"];
                        txtNama.Text = hasil["nama"];
                        txtJlhAwal.Text = hasil["jumlahawal"];
                        txtHrgHPP.Text = hasil["hargahpp"];
                        txtHargaJual.Text = hasil["hargajual"];
                        panel1.Visible = true;
                    }
                    else
                    {
                        panel1.Visible = false;
                        MessageBox.Show("ID tidak ditemukan");
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void formEditbarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            try
            {
                Class.clsBarang BarangEdit = new Class.clsBarang();
                int res = BarangEdit.UpdateBarang(Convert.ToInt16(txtIdInner.Text), txtKode.Text, txtNama.Text, Convert.ToInt32(txtJlhAwal.Text), Convert.ToDecimal(txtHrgHPP.Text), Convert.ToDecimal(txtHargaJual.Text));
                MessageBox.Show("Informasi Produk berhasil diubah", "Edited");
                panel1.Visible = false;
                txtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
