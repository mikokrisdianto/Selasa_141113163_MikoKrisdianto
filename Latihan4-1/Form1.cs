using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public bool Menyimpan = true;
        public string Folder = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ukurannya.Items.Add("8");
            ukurannya.Items.Add("9");
            ukurannya.Items.Add("10");
            ukurannya.Items.Add("11");
            ukurannya.Items.Add("12");
            ukurannya.Items.Add("14");
            ukurannya.Items.Add("16");
            ukurannya.Items.Add("18");
            ukurannya.Items.Add("20");
            ukurannya.Items.Add("22");
            ukurannya.Items.Add("24");
            ukurannya.Items.Add("26");
            ukurannya.Items.Add("28");
            ukurannya.Items.Add("36");
            ukurannya.Items.Add("48");
            ukurannya.Items.Add("72");
            foreach (FontFamily font in FontFamily.Families)
            {
                jenisfont.Items.Add(font.Name.ToString());
            }
        }
        private void simpan()
        {
            DialogResult dr;
            if (Folder == "")
            {
                simpandialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                dr = simpandialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.SaveFile(simpandialog.FileName);
                    Folder = simpandialog.FileName;
                }
            }
            else
            {
                richTextBox1.SaveFile(Folder);
            }
            Menyimpan = true;
        }
        private void keluar()
        {
            if (!Menyimpan)
            {
                DialogResult dr;
                dr = MessageBox.Show("Apakah Anda ingin Simpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (dr == DialogResult.Yes)
                {
                    simpan();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                if (!Menyimpan)
                {
                    dr = MessageBox.Show("Apakah Anda ingin Simpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        simpan();
                    }
                }

                richTextBox1.Clear();
                Folder = "";
                Menyimpan = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                if (!Menyimpan)
                {
                    dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        simpan();
                    }
                }
                dr = bukadialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Folder = bukadialog.FileName;
                    Menyimpan = true;
                    richTextBox1.LoadFile(bukadialog.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                simpan();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            simpandialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            dr = simpandialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SaveFile(simpandialog.FileName);
                Folder = simpandialog.FileName;
            }
            Menyimpan = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                keluar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            keluar();
        }

        private void warna_Click_1(object sender, EventArgs e)
        {
            DialogResult color = warnadialog.ShowDialog();
            if (color == DialogResult.OK)
            {
                richTextBox1.ForeColor = warnadialog.Color;
            }
        }

        private void bolot_Click_1(object sender, EventArgs e)
        {
            if (bolot.FlatStyle == FlatStyle.Standard)
            {
                bolot.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                bolot.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (bolot.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void miring_Click_1(object sender, EventArgs e)
        {
            if (miring.FlatStyle == FlatStyle.Standard)
            {
                miring.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                miring.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (miring.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void bawahgaris_Click_1(object sender, EventArgs e)
        {

            if (bawahgaris.FlatStyle == FlatStyle.Standard)
            {
                bawahgaris.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                bawahgaris.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (bawahgaris.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void jenisfont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(jenisfont.Text, richTextBox1.Font.Size);
        }

        private void ukurannya_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(ukurannya.SelectedItem), richTextBox1.Font.Style);
        }
    }
}
