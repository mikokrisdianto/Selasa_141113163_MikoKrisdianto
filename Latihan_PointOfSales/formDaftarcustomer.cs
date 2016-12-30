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
    public partial class formDaftarcustomer : Form
    {
        DataTable dtCustomer;
        public formDaftarcustomer()
        {
            InitializeComponent();
        }
        private void formDaftarcustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtCustomer = new DataTable();
            BindingSource bsCustomer = new BindingSource();
            bsCustomer.DataSource = dtCustomer;
            dgvCustomer.DataSource = bsCustomer;
            lihatDaftarCustomer();
        }

        private void lihatDaftarCustomer()
        {

            try
            {
                dtCustomer.Clear();
                Class.clsCustomer.SelectAll().Fill(dtCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarCustomer();
        }
    }
}
