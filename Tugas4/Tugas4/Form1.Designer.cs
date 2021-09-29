namespace Tugas4
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
            this.button_Update = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.listBuku = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text_judul = new System.Windows.Forms.TextBox();
            this.label_judul = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.textBox_Cari = new System.Windows.Forms.TextBox();
            this.button_cariJudul = new System.Windows.Forms.Button();
            this.button_cariPengarang = new System.Windows.Forms.Button();
            this.button_pilihBuku = new System.Windows.Forms.Button();
            this.button_riwatanPinjaman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(110, 279);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 42;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(515, 231);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 23);
            this.button_refresh.TabIndex = 41;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(29, 279);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 23);
            this.button_Tambah.TabIndex = 40;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.Button_Tambah_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(191, 279);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 23);
            this.button_Hapus.TabIndex = 39;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.Button_Hapus_Click);
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBuku.HideSelection = false;
            this.listBuku.Location = new System.Drawing.Point(243, 74);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(363, 151);
            this.listBuku.TabIndex = 38;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBuku_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Buku";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul Buku";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pengarang";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            this.columnHeader4.Width = 50;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(110, 135);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(100, 20);
            this.text_judul.TabIndex = 37;
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(36, 138);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(60, 13);
            this.label_judul.TabIndex = 36;
            this.label_judul.Text = "Judul Buku";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(110, 100);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 35;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(36, 103);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 13);
            this.label_id.TabIndex = 34;
            this.label_id.Text = "Id Buku";
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(110, 203);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(100, 20);
            this.text_jumlah.TabIndex = 49;
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(36, 206);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(40, 13);
            this.label_jumlah.TabIndex = 48;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(110, 168);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(100, 20);
            this.text_pengarang.TabIndex = 47;
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(36, 171);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(59, 13);
            this.label_pengarang.TabIndex = 46;
            this.label_pengarang.Text = "Pengarang";
            // 
            // textBox_Cari
            // 
            this.textBox_Cari.Location = new System.Drawing.Point(243, 35);
            this.textBox_Cari.Name = "textBox_Cari";
            this.textBox_Cari.Size = new System.Drawing.Size(195, 20);
            this.textBox_Cari.TabIndex = 50;
            // 
            // button_cariJudul
            // 
            this.button_cariJudul.Location = new System.Drawing.Point(457, 33);
            this.button_cariJudul.Name = "button_cariJudul";
            this.button_cariJudul.Size = new System.Drawing.Size(91, 23);
            this.button_cariJudul.TabIndex = 51;
            this.button_cariJudul.Text = "Cari Judul";
            this.button_cariJudul.UseVisualStyleBackColor = true;
            this.button_cariJudul.Click += new System.EventHandler(this.Button_cariJudul_Click);
            // 
            // button_cariPengarang
            // 
            this.button_cariPengarang.Location = new System.Drawing.Point(554, 33);
            this.button_cariPengarang.Name = "button_cariPengarang";
            this.button_cariPengarang.Size = new System.Drawing.Size(91, 23);
            this.button_cariPengarang.TabIndex = 52;
            this.button_cariPengarang.Text = "Cari Pengarang";
            this.button_cariPengarang.UseVisualStyleBackColor = true;
            this.button_cariPengarang.Click += new System.EventHandler(this.Button_cariPengarang_Click);
            // 
            // button_pilihBuku
            // 
            this.button_pilihBuku.Location = new System.Drawing.Point(272, 231);
            this.button_pilihBuku.Name = "button_pilihBuku";
            this.button_pilihBuku.Size = new System.Drawing.Size(91, 23);
            this.button_pilihBuku.TabIndex = 53;
            this.button_pilihBuku.Text = "Pilih Buku";
            this.button_pilihBuku.UseVisualStyleBackColor = true;
            this.button_pilihBuku.Click += new System.EventHandler(this.Button_pilihBuku_Click);
            // 
            // button_riwatanPinjaman
            // 
            this.button_riwatanPinjaman.Location = new System.Drawing.Point(382, 231);
            this.button_riwatanPinjaman.Name = "button_riwatanPinjaman";
            this.button_riwatanPinjaman.Size = new System.Drawing.Size(114, 23);
            this.button_riwatanPinjaman.TabIndex = 54;
            this.button_riwatanPinjaman.Text = "Riwayat Pinjaman";
            this.button_riwatanPinjaman.UseVisualStyleBackColor = true;
            this.button_riwatanPinjaman.Click += new System.EventHandler(this.Button_riwatanPinjaman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 338);
            this.Controls.Add(this.button_riwatanPinjaman);
            this.Controls.Add(this.button_pilihBuku);
            this.Controls.Add(this.button_cariPengarang);
            this.Controls.Add(this.button_cariJudul);
            this.Controls.Add(this.textBox_Cari);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Tugas 4 PPK - 175150201111053";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.TextBox textBox_Cari;
        private System.Windows.Forms.Button button_cariJudul;
        private System.Windows.Forms.Button button_cariPengarang;
        private System.Windows.Forms.Button button_pilihBuku;
        private System.Windows.Forms.Button button_riwatanPinjaman;
    }
}

