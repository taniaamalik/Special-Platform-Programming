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
            this.text_judul = new System.Windows.Forms.TextBox();
            this.label_judul = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.listBuku = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(122, 239);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 42;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(527, 191);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 23);
            this.button_refresh.TabIndex = 41;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(41, 239);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 23);
            this.button_Tambah.TabIndex = 40;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.Button_Tambah_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(203, 239);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 23);
            this.button_Hapus.TabIndex = 39;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.Button_Hapus_Click);
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(122, 93);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(100, 20);
            this.text_judul.TabIndex = 37;
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(51, 96);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(60, 13);
            this.label_judul.TabIndex = 36;
            this.label_judul.Text = "Judul Buku";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(122, 60);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 35;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(51, 63);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(43, 13);
            this.label_id.TabIndex = 34;
            this.label_id.Text = "id Buku";
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(122, 159);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(100, 20);
            this.text_jumlah.TabIndex = 49;
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(51, 162);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(40, 13);
            this.label_jumlah.TabIndex = 48;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(122, 126);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(100, 20);
            this.text_pengarang.TabIndex = 47;
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(51, 129);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(59, 13);
            this.label_pengarang.TabIndex = 46;
            this.label_pengarang.Text = "Pengarang";
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBuku.HideSelection = false;
            this.listBuku.Location = new System.Drawing.Point(246, 21);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(372, 158);
            this.listBuku.TabIndex = 50;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.SelectedIndexChanged += new System.EventHandler(this.ListBuku_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id Buku";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul Buku";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pengarang";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 296);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.button_Hapus);
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
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

