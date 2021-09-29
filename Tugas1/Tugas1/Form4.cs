using System;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgWarna.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                this.BackColor = dlgWarna.Color;
            }
        }
    }
}