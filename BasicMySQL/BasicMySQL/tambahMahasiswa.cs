using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BasicMySQL
{
    public partial class tambahMahasiswa : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        private string id_buku;
        private int jumlah;
        private string pilihMhs;
        


        public tambahMahasiswa(string pilihBuku, int stok)
        {
            InitializeComponent();
            id_buku = pilihBuku;
            jumlah = stok;
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO mahasiswa (nim_user, nama) VALUES (@nim, @nama)";

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", text_nim.Text);
                cmd.Parameters.AddWithValue("@nama", text_nama.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }


            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            }

            finally
            {
                databaseConnection.Close();
                tampil_data();
            }
        }

        private void tampil_data()
        {
            listMhs.Items.Clear();

            string query = "SELECT * FROM mahasiswa";

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();

                // IMPORTANT :                  
                // If your query returns result, use the following processor : 

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nim_user"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());

                        listMhs.Items.Add(listViewItem);

                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }

            }

            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            }


            finally
            {
                databaseConnection.Close();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE mahasiswa SET nim_user = @nim, nama = @nama WHERE nim_user= @nim";

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", text_nim.Text);
                cmd.Parameters.AddWithValue("@nama", text_nama.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }

            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            }


            finally
            {
                databaseConnection.Close();
                tampil_data();
            }
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM mahasiswa WHERE nim_user = @nim";

            try
            {
                // Open the database                     
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", text_nim.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }

            catch (Exception ex)
            {
                // Show any error message.                     
                MessageBox.Show(ex.Message);
            }


            finally
            {
                databaseConnection.Close();
                tampil_data();
            }
        }

        private void listMhs_MouseClick(object sender, MouseEventArgs e)
        {
            text_nim.Text = listMhs.SelectedItems[0].SubItems[0].Text;
            text_nama.Text = listMhs.SelectedItems[0].SubItems[1].Text;

            pilihMhs = text_nim.Text;
        }


        private void tambahMahasiswa_Load(object sender, EventArgs e)
        {
            tampil_data();
        }

        Boolean nim, nama;
        private void btn_CariNIM_Click(object sender, EventArgs e)
        {
            nim = true;
            nama = false;
            cari_mahasiswa();
        }

        private void btn_CariNama_Click(object sender, EventArgs e)
        {
            nim = false;
            nama = true;
            cari_mahasiswa();
        }

        
        private void cari_mahasiswa()
        {
            listMhs.Items.Clear();
            try
            {
                String query = "";
                if (nim)
                {
                    query = "SELECT * FROM mahasiswa WHERE nim_user=@dicari";
                }
                if (nama)
                {
                    query = "SELECT * FROM mahasiswa WHERE nama=@dicari";
                }
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.Parameters.AddWithValue("@dicari", tb_Cari.Text);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nim_user"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());

                        listMhs.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void Text_nim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pilihAkun_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_pinjaman (nim_user, id_buku) VALUES (@nim_user, @id_buku)";
            string queryUpdate = "UPDATE data_buku SET jumlah=@jumlah-1 WHERE id_buku= @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim_user", pilihMhs);
                cmd.Parameters.AddWithValue("@id_buku", id_buku);
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand(queryUpdate, databaseConnection);
                cmd2.CommandTimeout = 60;
                cmd2.Parameters.AddWithValue("@jumlah", jumlah);
                cmd2.Parameters.AddWithValue("@id", id_buku);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Peminjaman Berhasil!");

                RiwayatPinjaman history = new RiwayatPinjaman();
                history.Show();
                this.Hide();
            }


            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            }

            finally
            {
                databaseConnection.Close();   
            }

        }


    }
}
