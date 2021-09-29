using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir.Properties
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
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

        private void Button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProjectAkhir.Form5 form3 = new ProjectAkhir.Form5();
            form3.Show();
            Hide();
        }
    }
}
