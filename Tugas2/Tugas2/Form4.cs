using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private TextBox text;
        private double angka1;
        private double angka2;
        private double hasil;


        private void TextBox1_Enter(object sender, EventArgs e)
        {
            this.text = (TextBox)sender;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            if (text.Text == "")
            {
                text.Text = tombol.Text;
            }else
            {
                text.Text = text.Text + tombol.Text;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            angka1 = Convert.ToDouble(textBox1.Text);
            angka2 = Convert.ToDouble(textBox2.Text);
            if (tombol.Text == "+")
            {
                hasil = angka1 + angka2;
                label1.Text = Convert.ToString(hasil);
            } else if (tombol.Text == "-")
            {
                hasil = angka1 - angka2;
                label1.Text = Convert.ToString(hasil);
            } else if (tombol.Text == "*")
            {
                hasil = angka1 * angka2;
                label1.Text = Convert.ToString(hasil);
            } else
            {
                hasil = angka1 / angka2;
                label1.Text = Convert.ToString(hasil);
            }
        }
    }
}