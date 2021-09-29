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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_EnabledChanged(object sender, EventArgs e)
        {
            label1.Text = "Enabled berhasil";
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "Enter berhasil";
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            label1.Text = "Leave berhasil";
        }

        private void TextBox1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = "Visible berhasil";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}
