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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private int count;
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Tombol " + e.Button + " ditekan";
            count += e.Clicks;
            label2.Text = count + " kali ditekan";
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
              if (e.Control == true && e.KeyCode.ToString() == "A")
            {
                label3.Text = "Memilih Semua";
            } else if (e.Control == true && e.KeyCode.ToString() == "C")
            {
                label3.Text = "Melakukan Salin Data";
            } else if (e.Control == true && e.KeyCode.ToString() == "V")
            {
                label3.Text = "Melakukan Tempel Data";
            }
            else if (e.Control == true && e.KeyCode.ToString() == "P")
            {
                label3.Text = "Melakukan Cetak";
            }
        }
    }
}