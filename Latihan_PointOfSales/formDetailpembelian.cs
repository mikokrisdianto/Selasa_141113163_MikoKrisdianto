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
    public partial class formDetailpembelian : Form
    {
        DataTable dtPembelian;
        DataTable dtDetailPembelian;
        public formDetailpembelian()
        {
            InitializeComponent();
        }

        private void formDetailpembelian_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtPembelian = new DataTable();
            BindingSource bsPembelian = new BindingSource();
            bsPembelian.DataSource = dtPembelian;
            dgvPembelian.DataSource = bsPembelian;

            dtDetailPembelian = new DataTable();
            BindingSource bsDetailPembelian = new BindingSource();
            bsDetailPembelian.DataSource = dtDetailPembelian;
            dgvDetailPembelian.DataSource = bsDetailPembelian;

            lihatDaftarPembelian();
            lihatDaftarDetailPembelian();
        }

        private void lihatDaftarPembelian()
        {
            try
            {
                dtPembelian.Clear();
                Class.clsDetailPembelian.SelectAllPembelian().Fill(dtPembelian);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lihatDaftarDetailPembelian()
        {
            try
            {
                dtDetailPembelian.Clear();
                Class.clsDetailPembelian.SelectAllDetailPembelian().Fill(dtDetailPembelian);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lihatDaftarPembelian();
            lihatDaftarDetailPembelian();
        }
    }
}
