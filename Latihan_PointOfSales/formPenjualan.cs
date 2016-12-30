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
    public partial class formPenjualan : Form
    {
        Class.clsPenjualan penjualan;
        Class.clsDetailPenjualan detailPenjualan;
        DataTable dtDetail;
        string status_penjualan = "", status_barang = "";
        public formPenjualan()
        {
            InitializeComponent();
        }

        private void formPenjualan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtDetail = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = dtDetail;
            dgvDetail.DataSource = bsDetail;
        }

        private void lihatDetail(int id_penjualan)
        {
            try
            {
                dtDetail.Clear();
                Class.clsDetailPenjualan.SelectAllByIdPenjualan(id_penjualan).Fill(dtDetail);
                refresh_total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refresh_total()
        {
            decimal hsl = 0;
            foreach (DataGridViewRow i in dgvDetail.Rows)
            {
                hsl += Convert.ToDecimal(i.Cells["harga_barang"].Value) * Convert.ToDecimal(i.Cells["kuantitas"].Value);
            }
            label10.Text = string.Format("Total : IDR {0:N}", hsl);
        }

        private void btnCekKode_Click(object sender, EventArgs e)
        {
            penjualan = Class.clsPenjualan.cari_kode(txtKode.Text);
            reset_all();
            dtDetail.Clear();

            if (penjualan == null)
            {
                label2.Text = "Tambah Transaksi";
                status_penjualan = "insert";

                label10.Text = "Total : IDR 0";
            }
            else
            {
                label2.Text = "Edit Transaksi";
                txtIdCustomer.Text = penjualan.customer.id.ToString();
                status_penjualan = "update";

                lihatDetail(penjualan.id);
            }

            panel1.Visible = true;
        }

        private void reset_all()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            txtIdCustomer.Text = ""; txtIdCustomer.ReadOnly = false;
            txtIdBarang.Text = ""; txtIdBarang.ReadOnly = false;
            label5.Visible = false; label6.Visible = false;
            txtKuantitas.Text = "";
            txtSubtotal.Text = "";
        }

        private void cekBarang_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            Class.clsBarang barang = Class.clsPenjualan.cariBarangById(txtIdBarang.Text);
            {
                if (barang == null)
                {
                    label6.Text = "Tidak ditemukan !";
                    label6.Visible = true;
                }
                else
                {
                    txtIdBarang.ReadOnly = true;
                    label6.Text = "Nama Barang : " + barang.nama;
                    label6.Visible = true;
                    txtHargaJual.Text = barang.harga_jual.ToString();

                    if (penjualan != null)
                    {
                        detailPenjualan = Class.clsDetailPenjualan.cariDetailPenjualan(penjualan.id.ToString(), barang.id.ToString());

                        if (detailPenjualan != null)
                        {
                            txtKuantitas.Text = detailPenjualan.kuantitas.ToString();
                            refresh_subtotal();
                            status_barang = "update";
                        }
                        else
                        {
                            status_barang = "insert";
                        }
                    }

                    panel2.Visible = true;
                }
            }
        }

        private void refresh_subtotal()
        {
            decimal hasil;
            try
            {
                hasil = Convert.ToDecimal(txtHargaJual.Text) * Convert.ToDecimal(txtKuantitas.Text);
                txtSubtotal.Text = hasil.ToString();
            }

            catch (Exception ex) { txtSubtotal.Text = ""; }
        }

        private void cekCustomer_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            string nama_customer = Class.clsPenjualan.getCustomerNameById(txtIdCustomer.Text);
            if (nama_customer != "")
            {
                label5.Text = "Nama Customer : " + nama_customer;
                label5.Visible = true;
                txtIdCustomer.ReadOnly = true;
            }
            else
            {
                label5.Text = "Tidak Ditemukan !";
                label5.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_all();
            txtKode.Text = "";
        }

        private void txtKuantitas_KeyUp(object sender, KeyEventArgs e)
        {
            refresh_subtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKuantitas.Text != "")
            {
                int res = Class.clsDetailPenjualan.kelola_penjualan(status_penjualan, penjualan == null ? 0 : penjualan.id, penjualan == null ? txtKode.Text : penjualan.kode, Convert.ToInt16(txtIdCustomer.Text));
                string pesan;
                if (status_penjualan == "insert")
                    pesan = res.ToString() + " Penjualan berhasil ditambah";
                else
                    pesan = res.ToString() + " Penjualan berhasil diupdate";
                MessageBox.Show(pesan);

                int id_penjualan;
                if (penjualan == null)
                    id_penjualan = Class.clsDetailPenjualan.last_id_penjualan();
                else
                    id_penjualan = penjualan.id;

                int kuantitas_awal = 0;
                if (detailPenjualan != null)
                {
                    kuantitas_awal = detailPenjualan.kuantitas;
                }

                int kuantitas_akhir = Convert.ToInt16(txtKuantitas.Text) - kuantitas_awal;
                Class.clsDetailPenjualan.update_stok(Convert.ToInt16(txtIdBarang.Text), kuantitas_akhir);


                res = Class.clsDetailPenjualan.kelola_detail_penjualan(status_barang, detailPenjualan == null ? 0 : detailPenjualan.id, id_penjualan, Convert.ToInt16(txtIdBarang.Text), Convert.ToDecimal(txtHargaJual.Text), Convert.ToInt16(txtKuantitas.Text));
                if (status_barang == "insert")
                    pesan = res.ToString() + " Barang berhasil ditambah";
                else
                    pesan = res.ToString() + " Barang berhasil diupdate";
                MessageBox.Show(pesan);

                reset_all();
            }
        }
    }
}
