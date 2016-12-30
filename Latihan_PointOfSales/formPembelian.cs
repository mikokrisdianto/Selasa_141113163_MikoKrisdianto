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
    public partial class formPembelian : Form
    {
        Class.clsPembelian pembelian;
        Class.clsDetailPembelian detailPembelian;
        DataTable dtDetail;
        string status_pembelian = "", status_barang = "";
        public formPembelian()
        {
            InitializeComponent();
        }

        private void formPembelian_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtDetail = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = dtDetail;
            dgvDetail.DataSource = bsDetail;
        }

        private void lihatDetail(int id_pembelian)
        {
            try
            {
                dtDetail.Clear();
                Class.clsDetailPembelian.SelectAllByIdPembelian(id_pembelian).Fill(dtDetail);
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
            pembelian = Class.clsPembelian.cari_kode(txtKode.Text);
            reset_all();
            dtDetail.Clear();

            if (pembelian == null)
            {
                label2.Text = "Tambah Transaksi";
                status_pembelian = "insert";

                label10.Text = "Total : IDR 0";
            }
            else
            {
                label2.Text = "Edit Transaksi";
                txtIdSupplier.Text = pembelian.supplier.id.ToString();
                status_pembelian = "update";

                lihatDetail(pembelian.id);
            }

            panel1.Visible = true;
        }

        private void reset_all()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            txtIdSupplier.Text = ""; txtIdSupplier.ReadOnly = false;
            txtIdBarang.Text = ""; txtIdBarang.ReadOnly = false;
            label5.Visible = false; label6.Visible = false;
            txtKuantitas.Text = "";
            txtSubtotal.Text = "";
        }

        private void cekBarang_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            Class.clsBarang barang = Class.clsPembelian.cariBarangById(txtIdBarang.Text);
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
                    txtHargaHPP.Text = barang.harga_hpp.ToString();

                    if (pembelian != null)
                    {
                        detailPembelian = Class.clsDetailPembelian.cariDetailPembelian(pembelian.id.ToString(), barang.id.ToString());

                        if (detailPembelian != null)
                        {
                            txtKuantitas.Text = detailPembelian.kuantitas.ToString();
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

        private void cekSupplier_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            string nama_supplier = Class.clsPembelian.getSupplierNameById(txtIdSupplier.Text);
            if (nama_supplier != "")
            {
                label5.Text = "Nama Supplier : " + nama_supplier;
                label5.Visible = true;
                txtIdSupplier.ReadOnly = true;
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

        private void refresh_subtotal()
        {
            decimal hasil;
            try
            {
                hasil = Convert.ToDecimal(txtHargaHPP.Text) * Convert.ToDecimal(txtKuantitas.Text);
                txtSubtotal.Text = hasil.ToString();
            }

            catch (Exception ex) { txtSubtotal.Text = ""; }
        }

        private void txtKuantitas_KeyUp(object sender, KeyEventArgs e)
        {
            refresh_subtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKuantitas.Text != "")
            {
                int res = Class.clsDetailPembelian.kelola_pembelian(status_pembelian, pembelian == null ? 0 : pembelian.id, pembelian == null ? txtKode.Text : pembelian.kode, Convert.ToInt16(txtIdSupplier.Text));
                string pesan;
                if (status_pembelian == "insert")
                    pesan = res.ToString() + " Pembelian berhasil ditambah";
                else
                    pesan = res.ToString() + " Pembelian berhasil diupdate";
                MessageBox.Show(pesan);

                int id_pembelian;
                if (pembelian == null)
                    id_pembelian = Class.clsDetailPembelian.last_id_pembelian();
                else
                    id_pembelian = pembelian.id;

                int kuantitas_awal = 0;
                if (detailPembelian != null)
                {
                    kuantitas_awal = detailPembelian.kuantitas;
                }

                int kuantitas_akhir = Convert.ToInt16(txtKuantitas.Text) - kuantitas_awal;
                Class.clsDetailPembelian.update_stok(Convert.ToInt16(txtIdBarang.Text), kuantitas_akhir);


                res = Class.clsDetailPembelian.kelola_detail_pembelian(status_barang, detailPembelian == null ? 0 : detailPembelian.id, id_pembelian, Convert.ToInt16(txtIdBarang.Text), Convert.ToDecimal(txtHargaHPP.Text), Convert.ToInt16(txtKuantitas.Text));
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
