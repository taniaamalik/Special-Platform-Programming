namespace BasicMySQL
{
    partial class RiwayatPinjaman
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
            this.btn_CariJudul = new System.Windows.Forms.Button();
            this.btn_CariNIM = new System.Windows.Forms.Button();
            this.tb_Cari = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.listPinjaman = new System.Windows.Forms.ListView();
            this.id_pinjaman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaPeminjam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Judul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pengarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Hapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CariJudul
            // 
            this.btn_CariJudul.Location = new System.Drawing.Point(12, 49);
            this.btn_CariJudul.Name = "btn_CariJudul";
            this.btn_CariJudul.Size = new System.Drawing.Size(94, 26);
            this.btn_CariJudul.TabIndex = 34;
            this.btn_CariJudul.Text = "Cari Judul";
            this.btn_CariJudul.UseVisualStyleBackColor = true;
            this.btn_CariJudul.Click += new System.EventHandler(this.btn_CariJudul_Click);
            // 
            // btn_CariNIM
            // 
            this.btn_CariNIM.Location = new System.Drawing.Point(131, 49);
            this.btn_CariNIM.Name = "btn_CariNIM";
            this.btn_CariNIM.Size = new System.Drawing.Size(94, 26);
            this.btn_CariNIM.TabIndex = 33;
            this.btn_CariNIM.Text = "Cari NIM";
            this.btn_CariNIM.UseVisualStyleBackColor = true;
            this.btn_CariNIM.Click += new System.EventHandler(this.btn_CariNIM_Click);
            // 
            // tb_Cari
            // 
            this.tb_Cari.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_Cari.Location = new System.Drawing.Point(12, 12);
            this.tb_Cari.Name = "tb_Cari";
            this.tb_Cari.Size = new System.Drawing.Size(414, 20);
            this.tb_Cari.TabIndex = 32;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(575, 280);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 23);
            this.button_refresh.TabIndex = 30;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listPinjaman
            // 
            this.listPinjaman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_pinjaman,
            this.NIM,
            this.NamaPeminjam,
            this.Judul,
            this.Pengarang});
            this.listPinjaman.HideSelection = false;
            this.listPinjaman.Location = new System.Drawing.Point(12, 98);
            this.listPinjaman.Name = "listPinjaman";
            this.listPinjaman.Size = new System.Drawing.Size(654, 176);
            this.listPinjaman.TabIndex = 27;
            this.listPinjaman.UseCompatibleStateImageBehavior = false;
            this.listPinjaman.View = System.Windows.Forms.View.Details;
            this.listPinjaman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listPinjaman_MouseClick);
            // 
            // id_pinjaman
            // 
            this.id_pinjaman.Text = "id_pinjaman";
            this.id_pinjaman.Width = 68;
            // 
            // NIM
            // 
            this.NIM.Text = "NIM";
            this.NIM.Width = 127;
            // 
            // NamaPeminjam
            // 
            this.NamaPeminjam.Text = "NamaPeminjam";
            this.NamaPeminjam.Width = 143;
            // 
            // Judul
            // 
            this.Judul.Text = "Judul";
            this.Judul.Width = 158;
            // 
            // Pengarang
            // 
            this.Pengarang.Text = "Pengarang";
            this.Pengarang.Width = 154;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(611, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(55, 33);
            this.btn_home.TabIndex = 35;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Location = new System.Drawing.Point(12, 280);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(74, 23);
            this.btn_Hapus.TabIndex = 36;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = true;
            this.btn_Hapus.Click += new System.EventHandler(this.btn_Hapus_Click);
            // 
            // RiwayatPinjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 325);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_CariJudul);
            this.Controls.Add(this.btn_CariNIM);
            this.Controls.Add(this.tb_Cari);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.listPinjaman);
            this.Name = "RiwayatPinjaman";
            this.Text = "Tugas 4 PPK - 175150201111053";
            this.Load += new System.EventHandler(this.RiwayatPinjaman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CariJudul;
        private System.Windows.Forms.Button btn_CariNIM;
        private System.Windows.Forms.TextBox tb_Cari;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListView listPinjaman;
        private System.Windows.Forms.ColumnHeader id_pinjaman;
        private System.Windows.Forms.ColumnHeader NIM;
        private System.Windows.Forms.ColumnHeader NamaPeminjam;
        private System.Windows.Forms.ColumnHeader Judul;
        private System.Windows.Forms.ColumnHeader Pengarang;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Hapus;
    }
}