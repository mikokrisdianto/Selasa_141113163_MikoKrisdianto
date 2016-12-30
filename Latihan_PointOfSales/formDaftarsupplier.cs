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
    public partial class formDaftarsupplier : Form
    {
        DataTable dtSupplier;
        public formDaftarsupplier()
        {
            InitializeComponent();
        }

        private void formDaftarsupplier_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtSupplier = new DataTable();
            BindingSource bsSupplier = new BindingSource();
            bsSupplier.DataSource = dtSupplier;
            dgvSupplier.DataSource = bsSupplier;
            lihatDaftarSupplier();
        }

        private void lihatDaftarSupplier()
        {
            try
            {
                dtSupplier.Clear();
                Class.clsSupplier.SelectAll().Fill(dtSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, System.EventArgs e)
        {
            lihatDaftarSupplier();
        }

    }
}
