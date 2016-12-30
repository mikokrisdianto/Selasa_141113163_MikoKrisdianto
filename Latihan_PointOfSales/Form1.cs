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
    public partial class Mainform : Form
    {
        formRegistrasiBarang formRegistrasiBarang;
        formDaftarbarang formDaftarbarang;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRegistrasiBarang == null || !formRegistrasiBarang.IsHandleCreated)
            {
                formRegistrasiBarang = new formRegistrasiBarang();
                formRegistrasiBarang.MdiParent = this;
            }
            formRegistrasiBarang.Show();
        }
        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formDaftarbarang == null || !formDaftarbarang.IsHandleCreated)
            {
                formDaftarbarang = new formDaftarbarang();
                formDaftarbarang.MdiParent = this;
            }
            formDaftarbarang.BringToFront();
            formDaftarbarang.Show();
        }

        formEditbarang formEditbarang;
        private void barangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formEditbarang == null || !formEditbarang.IsHandleCreated)
            {
                formEditbarang = new formEditbarang();
                formEditbarang.MdiParent = this;
            }
            formEditbarang.BringToFront();
            formEditbarang.Show();
        }

        formDeletebarang formDeletebarang;
        private void barangToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formDeletebarang == null || !formDeletebarang.IsHandleCreated)
            {
                formDeletebarang = new formDeletebarang();
                formDeletebarang.MdiParent = this;
            }
            formDeletebarang.BringToFront();
            formDeletebarang.Show();
        }

        formRegistrasicustomer formRegistrasicustomer;
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRegistrasicustomer == null || !formRegistrasicustomer.IsHandleCreated)
            {
                formRegistrasicustomer = new formRegistrasicustomer();
                formRegistrasicustomer.MdiParent = this;
            }
            formRegistrasicustomer.BringToFront();
            formRegistrasicustomer.Show();
        }

        formDaftarcustomer formDaftarcustomer;
        private void customerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formDaftarcustomer == null || !formDaftarcustomer.IsHandleCreated)
            {
                formDaftarcustomer = new formDaftarcustomer();
                formDaftarcustomer.MdiParent = this;
            }
            formDaftarcustomer.BringToFront();
            formDaftarcustomer.Show();
        }

        formEditcustomer formEditcustomer;
        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formEditcustomer == null || !formEditcustomer.IsHandleCreated)
            {
                formEditcustomer = new formEditcustomer();
                formEditcustomer.MdiParent = this;
            }
            formEditcustomer.BringToFront();
            formEditcustomer.Show();
        }

        formDeletecustomer formDeletecustomer;
        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formDeletecustomer == null || !formDeletecustomer.IsHandleCreated)
            {
                formDeletecustomer = new formDeletecustomer();
                formDeletecustomer.MdiParent = this;
            }
            formDeletecustomer.BringToFront();
            formDeletecustomer.Show();
        }

        formRegistrasisupplier formRegistrasisupplier;
        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRegistrasisupplier == null || !formRegistrasisupplier.IsHandleCreated)
            {
                formRegistrasisupplier = new formRegistrasisupplier();
                formRegistrasisupplier.MdiParent = this;
            }
            formRegistrasisupplier.BringToFront();
            formRegistrasisupplier.Show();
        }

        formDaftarsupplier formDaftarsupplier;
        private void supplierToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formDaftarsupplier == null || !formDaftarsupplier.IsHandleCreated)
            {
                formDaftarsupplier = new formDaftarsupplier();
                formDaftarsupplier.MdiParent = this;
            }
            formDaftarsupplier.BringToFront();
            formDaftarsupplier.Show();
        }

        formEditsupplier formEditsupplier;
        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formEditsupplier == null || !formEditsupplier.IsHandleCreated)
            {
                formEditsupplier = new formEditsupplier();
                formEditsupplier.MdiParent = this;
            }
            formEditsupplier.BringToFront();
            formEditsupplier.Show();
        }

        formDeletesupplier formDeletesupplier;
        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formDeletesupplier == null || !formDeletesupplier.IsHandleCreated)
            {
                formDeletesupplier = new formDeletesupplier();
                formDeletesupplier.MdiParent = this;
            }
            formDeletesupplier.BringToFront();
            formDeletesupplier.Show();
        }

        formPembelian formPembelian;
        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPembelian == null || !formPembelian.IsHandleCreated)
            {
                formPembelian = new formPembelian();
                formPembelian.MdiParent = this;
            }
            formPembelian.BringToFront();
            formPembelian.Show();
        }

        formPenjualan formPenjualan;
        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPenjualan == null || !formPenjualan.IsHandleCreated)
            {
                formPenjualan = new formPenjualan();
                formPenjualan.MdiParent = this;
            }
            formPenjualan.BringToFront();
            formPenjualan.Show();
        }

        formDetailpembelian formDetailpembelian;
        private void detailPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDetailpembelian == null || !formDetailpembelian.IsHandleCreated)
            {
                formDetailpembelian = new formDetailpembelian();
                formDetailpembelian.MdiParent = this;
            }
            formDetailpembelian.BringToFront();
            formDetailpembelian.Show();
        }

        formDetailpenjualan formDetailpenjualan;
        private void detailPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDetailpenjualan == null || !formDetailpenjualan.IsHandleCreated)
            {
                formDetailpenjualan = new formDetailpenjualan();
                formDetailpenjualan.MdiParent = this;
            }
            formDetailpenjualan.BringToFront();
            formDetailpenjualan.Show();
        }
    }
}
