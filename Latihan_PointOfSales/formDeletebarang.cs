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
    public partial class formDeletebarang : Form
    {
        public formDeletebarang()
        {
            InitializeComponent();
        }

        private void formDeletebarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int res;
                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    Class.clsBarang BarangHapus = new Class.clsBarang(Convert.ToInt16(txtId.Text));
                    res = BarangHapus.DeleteBarang();
                    txtId.Text = "";
                    MessageBox.Show("Produk berhasil dihapus", "Deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
