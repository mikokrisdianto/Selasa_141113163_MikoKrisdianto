using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calender.ScrollChange = 11;

            int n = 2025;
            while (n>=1996)
            {
                DateTime awal = new DateTime(n, 1, 1);
                DateTime akhir = new DateTime(n, 12, 31);
                for (int i = 0; i < akhir.DayOfYear; i++)
                {
                    if (awal.DayOfWeek.ToString()=="Monday"||awal.DayOfWeek.ToString()=="Sunday")
                    {
                        Calender.AddBoldedDate(awal);
                    }
                    awal = awal.AddDays(1);
                }

                Calender.AddBoldedDate(new DateTime(n, 9, 1));
                n--;
            }

            Calender.UpdateBoldedDates();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = 2025;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] semuaBulan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (z>=1996)
            {
                Calender.AddBoldedDate(new DateTime(z, semuaBulan[bulan], tanggal));
                z--;
            }

            Calender.UpdateBoldedDates();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z = 2025;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] semuaBulan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (z >= 1996)
            {
                Calender.RemoveBoldedDate(new DateTime(z, semuaBulan[bulan], tanggal));
                z--;
            }

            Calender.UpdateBoldedDates();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
