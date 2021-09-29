using System;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGantiFont_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgFont.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                lblInfo.Font = dlgFont.Font;
                lblInfo.ForeColor = dlgFont.Color;
            }
        }
    }
}