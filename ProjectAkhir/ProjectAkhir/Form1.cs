using ProjectAkhir.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "NIM")
            {
                textBox1.Text = "";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar = true)
            {
                textBox2.UseSystemPasswordChar = false;
            } else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda sudah selesai?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
            }
        }
    }
}