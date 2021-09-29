namespace BasicMySQL
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
            this.components = new System.ComponentModel.Container();
            this.label_id = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.label_judul = new System.Windows.Forms.Label();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.listBuku = new System.Windows.Forms.ListView();
            this.id_buku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Judul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pengarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jumlah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_CariJudul = new System.Windows.Forms.Button();
            this.Btn_CariPengarang = new System.Windows.Forms.Button();
            this.tb_Cari = new System.Windows.Forms.TextBox();
            this.btn_pilihBuku = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(27, 41);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id Buku";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(101, 38);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(137, 20);
            this.text_id.TabIndex = 2;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(101, 73);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(137, 20);
            this.text_judul.TabIndex = 4;
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(27, 76);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(60, 13);
            this.label_judul.TabIndex = 3;
            this.label_judul.Text = "Judul Buku";
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(101, 109);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(137, 20);
            this.text_pengarang.TabIndex = 6;
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(27, 112);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(59, 13);
            this.label_pengarang.TabIndex = 5;
            this.label_pengarang.Text = "Pengarang";
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(101, 146);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(137, 20);
            this.text_jumlah.TabIndex = 8;
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(27, 149);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(40, 13);
            this.label_jumlah.TabIndex = 7;
            this.label_jumlah.Text = "Jumlah";
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_buku,
            this.Judul,
            this.Pengarang,
            this.Jumlah});
            this.listBuku.HideSelection = false;
            this.listBuku.Location = new System.Drawing.Point(298, 91);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(363, 151);
            this.listBuku.TabIndex = 9;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.SelectedIndexChanged += new System.EventHandler(this.ListBuku_SelectedIndexChanged);
            this.listBuku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBuku_MouseClick);
            // 
            // id_buku
            // 
            this.id_buku.Text = "id_buku";
            // 
            // Judul
            // 
            this.Judul.Text = "Judul";
            this.Judul.Width = 127;
            // 
            // Pengarang
            // 
            this.Pengarang.Text = "Pengarang";
            this.Pengarang.Width = 112;
            // 
            // Jumlah
            // 
            this.Jumlah.Text = "Jumlah";
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(182, 195);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 23);
            this.button_Hapus.TabIndex = 10;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.Button_Hapus_Click);
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(20, 195);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 23);
            this.button_Tambah.TabIndex = 11;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.Button_Tambah_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(101, 195);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(570, 248);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 23);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_CariJudul
            // 
            this.Btn_CariJudul.Location = new System.Drawing.Point(438, 59);
            this.Btn_CariJudul.Name = "Btn_CariJudul";
            this.Btn_CariJudul.Size = new System.Drawing.Size(94, 26);
            this.Btn_CariJudul.TabIndex = 37;
            this.Btn_CariJudul.Text = "Cari Judul";
            this.Btn_CariJudul.UseVisualStyleBackColor = true;
            this.Btn_CariJudul.Click += new System.EventHandler(this.Btn_CariJudul_Click_1);
            // 
            // Btn_CariPengarang
            // 
            this.Btn_CariPengarang.Location = new System.Drawing.Point(298, 59);
            this.Btn_CariPengarang.Name = "Btn_CariPengarang";
            this.Btn_CariPengarang.Size = new System.Drawing.Size(94, 26);
            this.Btn_CariPengarang.TabIndex = 36;
            this.Btn_CariPengarang.Text = "Cari Pengarang";
            this.Btn_CariPengarang.UseVisualStyleBackColor = true;
            this.Btn_CariPengarang.Click += new System.EventHandler(this.Btn_CariPengarang_Click_1);
            // 
            // tb_Cari
            // 
            this.tb_Cari.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_Cari.Location = new System.Drawing.Point(298, 33);
            this.tb_Cari.Name = "tb_Cari";
            this.tb_Cari.Size = new System.Drawing.Size(234, 20);
            this.tb_Cari.TabIndex = 35;
            // 
            // btn_pilihBuku
            // 
            this.btn_pilihBuku.Location = new System.Drawing.Point(298, 246);
            this.btn_pilihBuku.Name = "btn_pilihBuku";
            this.btn_pilihBuku.Size = new System.Drawing.Size(94, 26);
            this.btn_pilihBuku.TabIndex = 38;
            this.btn_pilihBuku.Text = "Pilih Buku";
            this.btn_pilihBuku.UseVisualStyleBackColor = true;
            this.btn_pilihBuku.Click += new System.EventHandler(this.btn_pilihBuku_Click_1);
            // 
            // btn_riwayat
            // 
            this.btn_riwayat.Location = new System.Drawing.Point(429, 246);
            this.btn_riwayat.Name = "btn_riwayat";
            this.btn_riwayat.Size = new System.Drawing.Size(103, 26);
            this.btn_riwayat.TabIndex = 39;
            this.btn_riwayat.Text = "Riwayat Pinjaman";
            this.btn_riwayat.UseVisualStyleBackColor = true;
            this.btn_riwayat.Click += new System.EventHandler(this.btn_riwayat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Petunjuk : Pilih buku untuk melakukan transaksi peminjaman buku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_riwayat);
            this.Controls.Add(this.btn_pilihBuku);
            this.Controls.Add(this.Btn_CariJudul);
            this.Controls.Add(this.Btn_CariPengarang);
            this.Controls.Add(this.tb_Cari);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Tugas 4 PPK - 175150201111053";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.ColumnHeader id_buku;
        private System.Windows.Forms.ColumnHeader Judul;
        private System.Windows.Forms.ColumnHeader Pengarang;
        private System.Windows.Forms.ColumnHeader Jumlah;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_CariJudul;
        private System.Windows.Forms.Button Btn_CariPengarang;
        private System.Windows.Forms.TextBox tb_Cari;
        private System.Windows.Forms.Button btn_pilihBuku;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Label label1;
    }
}

