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

namespace Latihan_5_1
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
            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    toolStripComboBox3.Items.Add(property.Name);
                    toolStripComboBox4.Items.Add(property.Name);
                }
            }

            toolStripComboBox3.SelectedIndex = 8;
            toolStripComboBox3.ComboBox.LostFocus += new EventHandler(toolStripComboBox3_LostFocus);
            toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox3.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            toolStripComboBox4.Text = "White";
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            toolStripComboBox4.ComboBox.LostFocus += new EventHandler(toolStripComboBox4_LostFocus);
            toolStripComboBox4.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox4.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
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
        public string AmbilBackground()
        {
            return richTextBox1.BackColor.Name;
        }
        public void GantiWarnaBackground(string color)
        {
            richTextBox1.BackColor = Color.FromName(color);
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
        }
        private void toolStripComboBox3_LostFocus(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
            richTextBox1.Select(start, length);
        }

        private void toolStripComboBox4_LostFocus(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            richTextBox1.Select(start, length);
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
        public void koala()
        {
            richTextBox1.BringToFront();
            richTextBox1.Focus();
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
        private void bolot_Click(object sender, EventArgs e)
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
        TukangEdit formEditor;
        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formEditor == null || !formEditor.IsHandleCreated)
            {
                formEditor = new TukangEdit();
                formEditor.MdiParent = this;
                formEditor.BringToFront();
                richTextBox1.SendToBack();
                formEditor.Show();
            }
            else
            {
                formEditor.Show();
            }
        }


        private void jenisfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(jenisfont.Text, richTextBox1.Font.Size);
        }

        private void miring_Click(object sender, EventArgs e)
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

        private void bawahgaris_Click(object sender, EventArgs e)
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

        private void ukurannya_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(ukurannya.SelectedItem), richTextBox1.Font.Style);
        }
        private void toolStripComboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.toolStripComboBox3.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                return;
            }

            richTextBox1.SelectedText = "";
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}