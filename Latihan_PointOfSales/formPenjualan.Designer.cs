namespace Latihan_PointOfSales
{
    partial class formPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtKuantitas = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cekBarang = new System.Windows.Forms.Button();
            this.cekCustomer = new System.Windows.Forms.Button();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCekKode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cekBarang);
            this.panel1.Controls.Add(this.cekCustomer);
            this.panel1.Controls.Add(this.txtIdBarang);
            this.panel1.Controls.Add(this.txtIdCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 357);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(29, 187);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(479, 133);
            this.dgvDetail.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtSubtotal);
            this.panel2.Controls.Add(this.txtKuantitas);
            this.panel2.Controls.Add(this.txtHargaJual);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 96);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(91, 61);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(139, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.Location = new System.Drawing.Point(91, 34);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.Size = new System.Drawing.Size(139, 20);
            this.txtKuantitas.TabIndex = 6;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(91, 8);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.ReadOnly = true;
            this.txtHargaJual.Size = new System.Drawing.Size(139, 20);
            this.txtHargaJual.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sub-total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kuantitas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harga Jual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // cekBarang
            // 
            this.cekBarang.Location = new System.Drawing.Point(196, 56);
            this.cekBarang.Name = "cekBarang";
            this.cekBarang.Size = new System.Drawing.Size(46, 23);
            this.cekBarang.TabIndex = 6;
            this.cekBarang.Text = "Cek";
            this.cekBarang.UseVisualStyleBackColor = true;
            this.cekBarang.Click += new System.EventHandler(this.cekBarang_Click);
            // 
            // cekCustomer
            // 
            this.cekCustomer.Location = new System.Drawing.Point(196, 29);
            this.cekCustomer.Name = "cekCustomer";
            this.cekCustomer.Size = new System.Drawing.Size(46, 23);
            this.cekCustomer.TabIndex = 5;
            this.cekCustomer.Text = "Cek";
            this.cekCustomer.UseVisualStyleBackColor = true;
            this.cekCustomer.Click += new System.EventHandler(this.cekCustomer_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(77, 58);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(100, 20);
            this.txtIdBarang.TabIndex = 4;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(77, 31);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Id Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // btnCekKode
            // 
            this.btnCekKode.Location = new System.Drawing.Point(287, 17);
            this.btnCekKode.Name = "btnCekKode";
            this.btnCekKode.Size = new System.Drawing.Size(75, 23);
            this.btnCekKode.TabIndex = 16;
            this.btnCekKode.Text = "Cek";
            this.btnCekKode.UseVisualStyleBackColor = true;
            this.btnCekKode.Click += new System.EventHandler(this.btnCekKode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(91, 19);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(177, 20);
            this.txtKode.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(377, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // formPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCekKode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.btnReset);
            this.Name = "formPenjualan";
            this.Text = "formPenjualan";
            this.Load += new System.EventHandler(this.formPenjualan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtKuantitas;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cekBarang;
        private System.Windows.Forms.Button cekCustomer;
        private System.Windows.Forms.TextBox txtIdBarang;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCekKode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnReset;
    }
}