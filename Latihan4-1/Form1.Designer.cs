namespace Latihan_4_1
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ukurannya = new System.Windows.Forms.ComboBox();
            this.jenisfont = new System.Windows.Forms.ComboBox();
            this.warna = new System.Windows.Forms.Button();
            this.bawahgaris = new System.Windows.Forms.Button();
            this.miring = new System.Windows.Forms.Button();
            this.bolot = new System.Windows.Forms.Button();
            this.warnadialog = new System.Windows.Forms.ColorDialog();
            this.menuatas = new System.Windows.Forms.MenuStrip();
            this.simpandialog = new System.Windows.Forms.SaveFileDialog();
            this.bukadialog = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 351);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // ukurannya
            // 
            this.ukurannya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukurannya.FormattingEnabled = true;
            this.ukurannya.Location = new System.Drawing.Point(425, 44);
            this.ukurannya.Name = "ukurannya";
            this.ukurannya.Size = new System.Drawing.Size(52, 26);
            this.ukurannya.TabIndex = 7;
            this.ukurannya.SelectedIndexChanged += new System.EventHandler(this.ukurannya_SelectedIndexChanged_1);
            // 
            // jenisfont
            // 
            this.jenisfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisfont.FormattingEnabled = true;
            this.jenisfont.Location = new System.Drawing.Point(270, 44);
            this.jenisfont.Name = "jenisfont";
            this.jenisfont.Size = new System.Drawing.Size(140, 26);
            this.jenisfont.TabIndex = 8;
            this.jenisfont.SelectedIndexChanged += new System.EventHandler(this.jenisfont_SelectedIndexChanged_1);
            // 
            // warna
            // 
            this.warna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warna.Location = new System.Drawing.Point(171, 39);
            this.warna.Name = "warna";
            this.warna.Size = new System.Drawing.Size(82, 34);
            this.warna.TabIndex = 3;
            this.warna.Text = "Color";
            this.warna.UseVisualStyleBackColor = true;
            this.warna.Click += new System.EventHandler(this.warna_Click_1);
            // 
            // bawahgaris
            // 
            this.bawahgaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bawahgaris.Location = new System.Drawing.Point(118, 39);
            this.bawahgaris.Name = "bawahgaris";
            this.bawahgaris.Size = new System.Drawing.Size(47, 34);
            this.bawahgaris.TabIndex = 4;
            this.bawahgaris.Text = "U";
            this.bawahgaris.UseVisualStyleBackColor = true;
            this.bawahgaris.Click += new System.EventHandler(this.bawahgaris_Click_1);
            // 
            // miring
            // 
            this.miring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miring.Location = new System.Drawing.Point(65, 39);
            this.miring.Name = "miring";
            this.miring.Size = new System.Drawing.Size(47, 34);
            this.miring.TabIndex = 5;
            this.miring.Text = "/";
            this.miring.UseVisualStyleBackColor = true;
            this.miring.Click += new System.EventHandler(this.miring_Click_1);
            // 
            // bolot
            // 
            this.bolot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolot.Location = new System.Drawing.Point(12, 39);
            this.bolot.Name = "bolot";
            this.bolot.Size = new System.Drawing.Size(47, 34);
            this.bolot.TabIndex = 6;
            this.bolot.Text = "B";
            this.bolot.UseVisualStyleBackColor = true;
            this.bolot.Click += new System.EventHandler(this.bolot_Click_1);
            // 
            // menuatas
            // 
            this.menuatas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuatas.Location = new System.Drawing.Point(0, 0);
            this.menuatas.Name = "menuatas";
            this.menuatas.Size = new System.Drawing.Size(548, 24);
            this.menuatas.TabIndex = 10;
            this.menuatas.Text = "menuStrip1";
            // 
            // bukadialog
            // 
            this.bukadialog.FileName = "openFileDialog1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 457);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ukurannya);
            this.Controls.Add(this.jenisfont);
            this.Controls.Add(this.warna);
            this.Controls.Add(this.bawahgaris);
            this.Controls.Add(this.miring);
            this.Controls.Add(this.bolot);
            this.Controls.Add(this.menuatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuatas;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Latihan_4_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuatas.ResumeLayout(false);
            this.menuatas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox ukurannya;
        private System.Windows.Forms.ComboBox jenisfont;
        private System.Windows.Forms.Button warna;
        private System.Windows.Forms.Button bawahgaris;
        private System.Windows.Forms.Button miring;
        private System.Windows.Forms.Button bolot;
        private System.Windows.Forms.ColorDialog warnadialog;
        private System.Windows.Forms.MenuStrip menuatas;
        private System.Windows.Forms.SaveFileDialog simpandialog;
        private System.Windows.Forms.OpenFileDialog bukadialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

