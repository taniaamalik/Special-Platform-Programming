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

namespace Tugas4
{
    public partial class Form1 : Form
    {
        // Prepare the connection 
        private static string connectionString = "server=localhost;port=3306;username=root;password=Iryana1512;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

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


            finally
            {
                databaseConnection.Close();
            }
            Button_refresh_Click(sender, e);
        }

        private void Button_refresh_Click(object sender, EventArgs e)
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
            }
            Button_refresh_Click(sender, e);
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
            }
            Button_refresh_Click(sender, e);
        }

        private void ListBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_id.Text = listBuku.SelectedItems[0].SubItems[0].Text;
            text_judul.Text = listBuku.SelectedItems[0].SubItems[1].Text;
            text_pengarang.Text = listBuku.SelectedItems[0].SubItems[2].Text;
            text_jumlah.Text = listBuku.SelectedItems[0].SubItems[3].Text;
        }
    }
}