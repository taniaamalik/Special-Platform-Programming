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
    public partial class RiwayatPinjaman : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        private string id;


        public RiwayatPinjaman()
        {
            InitializeComponent();
        }

        Boolean nim, judul;
        private void btn_CariJudul_Click(object sender, EventArgs e)
        {
            nim = false;
            judul = true;
            cari_pinjaman();
        }

        private void btn_CariNIM_Click(object sender, EventArgs e)
        {
            nim = true;
            judul = false;
            cari_pinjaman();
        }

        private void cari_pinjaman()
        {
            listPinjaman.Items.Clear();
            try
            {
                String query = "";
                if (judul)
                {
                    query = "SELECT * FROM data_pinjaman WHERE judul=@dicari";
                }
                if (nim)
                {
                    query = "SELECT * FROM data_pinjaman WHERE nim_user=@dicari";
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
                        ListViewItem listViewItem = new ListViewItem(reader["id_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["nim_user"].ToString());
                        listPinjaman.Items.Add(listViewItem);
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
        private void button_refresh_Click(object sender, EventArgs e)
        {
            tampil_data();
        }

        private void RiwayatPinjaman_Load(object sender, EventArgs e)
        {
            tampil_data();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void btn_Hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_pinjaman WHERE id_pinjaman = @id";

            try
            {
                // Open the database                     
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", id);
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

        private void listPinjaman_MouseClick(object sender, MouseEventArgs e)
        {
            id = listPinjaman.SelectedItems[0].SubItems[0].Text;
        }

        private void tampil_data()
        {
            listPinjaman.Items.Clear();

            string query = "SELECT data_pinjaman.id_pinjaman, mahasiswa.nim_user, mahasiswa.nama, data_buku.judul, " +
                "data_buku.pengarang FROM data_pinjaman JOIN mahasiswa ON data_pinjaman.nim_user = " +
                "mahasiswa.nim_user JOIN data_buku ON data_pinjaman.id_buku = data_buku.id_buku";

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
                        ListViewItem listViewItem = new ListViewItem(reader["id_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["nim_user"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listPinjaman.Items.Add(listViewItem);

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
    }
}
