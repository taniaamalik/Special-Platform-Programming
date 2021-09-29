using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3
{
    public partial class FormPict : Form
    {
        int deg, n;
        int zoom;
        Image gbrAsli;
        Form1 FrmParent;
        public FormPict(Form1 F1)
        {
            InitializeComponent();
            FrmParent = F1;
        }
        public void setpic(Image img)
        {
            pictureBox1.Image = img;
            gbrAsli = pictureBox1.Image;
        }
        public void Putarkanan()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            deg += 90;
            if (deg > 360) { deg = deg - 360; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmParent.AllDegree1 = deg;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a1, a2;
            //untuk ambil deg dari parent dibagi 90
            a1 = FrmParent.AllDegree1 / 90;
            a2 = deg / 90;
            //jika rotasi gbr kurang dari induk, maka putar kanan
            if (a2 < a1)
            {
                for (int i = a2; i < a1; i++)
                {
                    Putarkanan();
                }
            }
            else if (a2 > a1)
            {
                for (int i = a1; i < a2; i++)
                {
                    Putarkiri();
                }
            }
        }
        public void Putarkiri()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = flipImage;
            deg -= 90;
            if (deg < 0) { deg = 270; }
            textBox1.Text = deg.ToString();
        }
        public void Zoomin()
        {
            pictureBox1.Height += 50;
            pictureBox1.Width += 50;
            zoom += 50;
            textBox1.Text = zoom.ToString() + " x zoom in";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmParent.AllZoom1 = zoom;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int z1, z2;
            z1 = FrmParent.AllZoom1 / 50;
            z2 = zoom / 50;
            if (z2 < z1)
            {
                for (int i = z2; i < z1; i++)
                {
                    Zoomin();
                }
            }
            else if (z2 > z1)
            {
                for (int i = z1; i < z2; i++)
                {
                    Zoomout();
                }
            }
        }
        public void Zoomout()
        {
            pictureBox1.Height -= 50;
            pictureBox1.Width -= 50;
            zoom -= 50;
            textBox1.Text = zoom.ToString() + " x zoom out";
        }
    }
}