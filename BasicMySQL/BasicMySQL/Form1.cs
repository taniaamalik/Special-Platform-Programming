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
    public partial class Form1 : Form
    {
        // Prepare the connection 
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        private string pilihBuku;
        private int jumlah;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Tambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id, @judul, @pengarang,@jumlah)";

            try
            {                 
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            } 


            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            } 

            finally {
                databaseConnection.Close();
                tampil_data();
            }
        }

        private void tampil_data()
        {
            listBuku.Items.Clear();

            string query = "SELECT * FROM data_buku";

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
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        

                        listBuku.Items.Add(listViewItem);

                    }

                    reader.Close();
                }
                else {
                    MessageBox.Show("No rows found.");
                }

            }

            catch (Exception ex)
            {
                // Show any error message.                 
                MessageBox.Show(ex.Message);
            } 


            finally {
                databaseConnection.Close();
            }
        }

        private void Button_Hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku WHERE id_buku = @id";

            try
            {
                // Open the database                     
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
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

        private void Button_Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang=@pengarang, jumlah=@jumlah WHERE id_buku= @id";

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil_data();
        }

        private void ListBuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBuku_MouseClick(object sender, MouseEventArgs e)
        {
            text_id.Text = listBuku.SelectedItems[0].SubItems[0].Text;
            text_judul.Text = listBuku.SelectedItems[0].SubItems[1].Text;
            text_pengarang.Text = listBuku.SelectedItems[0].SubItems[2].Text;
            text_jumlah.Text = listBuku.SelectedItems[0].SubItems[3].Text;

            pilihBuku = text_id.Text;
            jumlah = Int32.Parse(text_jumlah.Text);
        }

        Boolean pengarang, judul;

        private void Btn_CariPengarang_Click_1(object sender, EventArgs e)
        {
            pengarang = true;
            judul = false;
            cari_buku();
        }

        private void Btn_CariJudul_Click_1(object sender, EventArgs e)
        {
            pengarang = false;
            judul = true;
            cari_buku();
        }

        private void cari_buku()
            {
                listBuku.Items.Clear();
                try
                {
                String query = "";
                if (judul)
                {
                    query = "SELECT * FROM data_buku WHERE judul=@dicari";
                }
                if (pengarang)
                {
                    query = "SELECT * FROM data_buku WHERE pengarang=@dicari";
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
                            ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                            listViewItem.SubItems.Add(reader["judul"].ToString());
                            listViewItem.SubItems.Add(reader["pengarang"].ToString());
                            listViewItem.SubItems.Add(reader["jumlah"].ToString());

                            listBuku.Items.Add(listViewItem);
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


        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            tampil_data();
        }

        private void btn_pilihBuku_Click_1(object sender, EventArgs e)
        {
            if (pilihBuku != null)
            {
                if (jumlah > 0)
                {
                    tambahMahasiswa mhs = new tambahMahasiswa(pilihBuku, jumlah);
                    mhs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Buku sedang dipinjam!");
                }
            }
        }

        private void btn_riwayat_Click_1(object sender, EventArgs e)
        {
            RiwayatPinjaman history = new RiwayatPinjaman();
            history.Show();
            this.Hide();
        }

    }
}
