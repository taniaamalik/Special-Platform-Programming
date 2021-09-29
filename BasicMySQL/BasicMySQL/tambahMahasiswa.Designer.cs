namespace BasicMySQL
{
    partial class tambahMahasiswa
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
            this.btn_CariNIM = new System.Windows.Forms.Button();
            this.btn_CariNama = new System.Windows.Forms.Button();
            this.tb_Cari = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.listMhs = new System.Windows.Forms.ListView();
            this.NIM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text_nama = new System.Windows.Forms.TextBox();
            this.label_nama = new System.Windows.Forms.Label();
            this.text_nim = new System.Windows.Forms.TextBox();
            this.label_nim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pilihAkun = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CariNIM
            // 
            this.btn_CariNIM.Location = new System.Drawing.Point(288, 76);
            this.btn_CariNIM.Name = "btn_CariNIM";
            this.btn_CariNIM.Size = new System.Drawing.Size(94, 26);
            this.btn_CariNIM.TabIndex = 33;
            this.btn_CariNIM.Text = "Cari NIM";
            this.btn_CariNIM.UseVisualStyleBackColor = true;
            this.btn_CariNIM.Click += new System.EventHandler(this.btn_CariNIM_Click);
            // 
            // btn_CariNama
            // 
            this.btn_CariNama.Location = new System.Drawing.Point(424, 76);
            this.btn_CariNama.Name = "btn_CariNama";
            this.btn_CariNama.Size = new System.Drawing.Size(94, 26);
            this.btn_CariNama.TabIndex = 32;
            this.btn_CariNama.Text = "Cari Nama";
            this.btn_CariNama.UseVisualStyleBackColor = true;
            this.btn_CariNama.Click += new System.EventHandler(this.btn_CariNama_Click);
            // 
            // tb_Cari
            // 
            this.tb_Cari.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_Cari.Location = new System.Drawing.Point(288, 43);
            this.tb_Cari.Name = "tb_Cari";
            this.tb_Cari.Size = new System.Drawing.Size(230, 20);
            this.tb_Cari.TabIndex = 31;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(100, 117);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(74, 23);
            this.button_Update.TabIndex = 30;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(19, 117);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(74, 23);
            this.button_Tambah.TabIndex = 28;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(181, 117);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(74, 23);
            this.button_Hapus.TabIndex = 27;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // listMhs
            // 
            this.listMhs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NIM,
            this.Nama});
            this.listMhs.HideSelection = false;
            this.listMhs.Location = new System.Drawing.Point(288, 117);
            this.listMhs.Name = "listMhs";
            this.listMhs.Size = new System.Drawing.Size(372, 163);
            this.listMhs.TabIndex = 26;
            this.listMhs.UseCompatibleStateImageBehavior = false;
            this.listMhs.View = System.Windows.Forms.View.Details;
            this.listMhs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listMhs_MouseClick);
            // 
            // NIM
            // 
            this.NIM.Text = "NIM";
            this.NIM.Width = 171;
            // 
            // Nama
            // 
            this.Nama.Text = "Nama";
            this.Nama.Width = 196;
            // 
            // text_nama
            // 
            this.text_nama.Location = new System.Drawing.Point(100, 71);
            this.text_nama.Name = "text_nama";
            this.text_nama.Size = new System.Drawing.Size(155, 20);
            this.text_nama.TabIndex = 21;
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(26, 74);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(35, 13);
            this.label_nama.TabIndex = 20;
            this.label_nama.Text = "Nama";
            // 
            // text_nim
            // 
            this.text_nim.Location = new System.Drawing.Point(100, 36);
            this.text_nim.Name = "text_nim";
            this.text_nim.Size = new System.Drawing.Size(155, 20);
            this.text_nim.TabIndex = 19;
            this.text_nim.TextChanged += new System.EventHandler(this.Text_nim_TextChanged);
            // 
            // label_nim
            // 
            this.label_nim.AutoSize = true;
            this.label_nim.Location = new System.Drawing.Point(26, 39);
            this.label_nim.Name = "label_nim";
            this.label_nim.Size = new System.Drawing.Size(27, 13);
            this.label_nim.TabIndex = 18;
            this.label_nim.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pilih akun untuk melakukan peminjaman buku";
            // 
            // btn_pilihAkun
            // 
            this.btn_pilihAkun.Location = new System.Drawing.Point(288, 286);
            this.btn_pilihAkun.Name = "btn_pilihAkun";
            this.btn_pilihAkun.Size = new System.Drawing.Size(94, 26);
            this.btn_pilihAkun.TabIndex = 35;
            this.btn_pilihAkun.Text = "Pilih Akun";
            this.btn_pilihAkun.UseVisualStyleBackColor = true;
            this.btn_pilihAkun.Click += new System.EventHandler(this.btn_pilihAkun_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(12, 284);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(81, 26);
            this.btn_kembali.TabIndex = 36;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Daftar Akun";
            // 
            // tambahMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.btn_pilihAkun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CariNIM);
            this.Controls.Add(this.btn_CariNama);
            this.Controls.Add(this.tb_Cari);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.listMhs);
            this.Controls.Add(this.text_nama);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.text_nim);
            this.Controls.Add(this.label_nim);
            this.Name = "tambahMahasiswa";
            this.Text = "Tugas 4 PPK - 175150201111053";
            this.Load += new System.EventHandler(this.tambahMahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CariNIM;
        private System.Windows.Forms.Button btn_CariNama;
        private System.Windows.Forms.TextBox tb_Cari;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.ListView listMhs;
        private System.Windows.Forms.ColumnHeader NIM;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.TextBox text_nama;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox text_nim;
        private System.Windows.Forms.Label label_nim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pilihAkun;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Label label2;
    }
}